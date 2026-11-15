using Model;
using System.ComponentModel;
using System.Data;
using System.Text.Json;
using static System.Collections.Specialized.BitVector32;

namespace SalesInventory.BusinessLogic.Controller;

/// <summary>Holds the active POS cart and everything the cashier does before payment.</summary>
public class SalesController
{
    public static readonly string[] CustomerTypes = { "Walk-in", "Guest", "Student", "Staff" };

    public BindingList<CartLine> Cart { get; } = new();
    public string CustomerType { get; private set; } = "Walk-in";
    public string CustomerRef { get; private set; }
    public decimal DiscountPercent { get; private set; }
    public CartTotals Totals { get; private set; } = new();
    public int? OverrideApprovedBy { get; private set; }

    public List<Product> Find(string text) => ProductRepository.Search(text, null, false, false);

    public void AddProduct(Product p, int qty = 1)
    {
        if (qty <= 0) throw new BusinessRuleException("Quantities must be positive whole numbers.");
        if (!p.IsActive) throw new BusinessRuleException("This product is inactive and cannot be sold.");
        var existing = Cart.FirstOrDefault(c => c.ProductId == p.ProductId);
        var newQty = (existing?.Quantity ?? 0) + qty;
        if (newQty > p.QtyOnHand)
            throw new BusinessRuleException($"Only {p.QtyOnHand} unit(s) of \"{p.Name}\" are in stock.");

        if (existing != null) { existing.Quantity = newQty; existing.StockOnHand = p.QtyOnHand; }
        else Cart.Add(new CartLine
        {
            ProductId = p.ProductId,
            SKU = p.SKU,
            ProductName = p.Name,
            Quantity = qty,
            ListPrice = p.SellingPrice,
            DiscountEligible = p.DiscountEligible,
            TaxGroup = p.TaxGroup,
            StockOnHand = p.QtyOnHand
        });
        Recalculate();
    }

    /// <summary>Keeps quantities valid after the cashier edits the grid. Returns a warning message or null.</summary>
    public string ClampQuantities()
    {
        string warning = null;
        foreach (var l in Cart)
        {
            if (l.Quantity < 1) { l.Quantity = 1; warning = "Quantities must be positive whole numbers."; }
            if (l.Quantity > l.StockOnHand) { l.Quantity = l.StockOnHand; warning = $"Only {l.StockOnHand} unit(s) of \"{l.ProductName}\" are in stock."; }
        }
        Recalculate();
        return warning;
    }

    public void Remove(CartLine line) { Cart.Remove(line); Recalculate(); }

    public void Clear() { ClearAfterSale(); }

    public void SetCustomer(string type, string reference, string code)
    {
        if ((type == "Student" || type == "Staff") && string.IsNullOrWhiteSpace(reference))
            throw new BusinessRuleException("A Student / Staff ID is required for this customer type.");
        DiscountPercent = PricingService.PercentFor(type, code);
        CustomerType = type;
        CustomerRef = string.IsNullOrWhiteSpace(reference) ? null : reference.Trim();
        Recalculate();
    }

    public void SetOverride(CartLine line, decimal newPrice, User approver)
    {
        if (newPrice < 0) throw new BusinessRuleException("A price cannot be lower than 0.00.");
        line.OverridePrice = newPrice;
        OverrideApprovedBy = approver.UserId;
        Recalculate();
    }

    public void Recalculate()
    {
        Totals = PricingService.Calculate(Cart, DiscountPercent);
        Cart.ResetBindings();
    }

    public void ClearAfterSale()
    {
        Cart.Clear();
        CustomerType = "Walk-in"; CustomerRef = null; DiscountPercent = 0; OverrideApprovedBy = null;
        Recalculate();
    }

    // ----- Suspended transactions -----
    public int Suspend()
    {
        if (Cart.Count == 0) throw new BusinessRuleException("There is nothing to hold - the cart is empty.");
        var json = JsonSerializer.Serialize(Cart.Select(c => new SuspendedItem { ProductId = c.ProductId, Quantity = c.Quantity }).ToList());
        var id = SalesRepository.Suspend(Session.Current.UserId, CustomerType, CustomerRef, json);
        ClearAfterSale();
        return id;
    }

    /// <summary>Held carts of the signed-in cashier as (Id, Held at, Customer, Lines).</summary>
    public DataTable SuspendedList()
    {
        var raw = SalesRepository.Suspended(Session.Current.UserId);
        var t = new DataTable();
        t.Columns.Add("Id", typeof(int)); t.Columns.Add("Held at", typeof(string));
        t.Columns.Add("Customer", typeof(string)); t.Columns.Add("Lines", typeof(int));
        foreach (DataRow r in raw.Rows)
        {
            var items = JsonSerializer.Deserialize<List<SuspendedItem>>(Db.Val<string>(r, "CartJson"));
            t.Rows.Add(Db.Val<int>(r, "SuspendedId"), Db.Val<DateTime>(r, "CreatedAt").ToString("g"),
                       Db.Val<string>(r, "CustomerType") + " " + Db.Val<string>(r, "CustomerRef"), items.Count);
        }
        return t;
    }

    /// <summary>Restores a held cart using today's prices and stock. Returns a warning if anything had to be adjusted.</summary>
    public string Recall(int suspendedId)
    {
        if (Cart.Count > 0) throw new BusinessRuleException("Finish or hold the current cart before recalling another transaction.");
        var row = SalesRepository.Suspended(Session.Current.UserId).Rows.Cast<DataRow>()
                    .FirstOrDefault(r => Db.Val<int>(r, "SuspendedId") == suspendedId)
                  ?? throw new BusinessRuleException("That held transaction no longer exists.");

        var items = JsonSerializer.Deserialize<List<SuspendedItem>>(Db.Val<string>(row, "CartJson"));
        var warnings = new List<string>();
        foreach (var it in items)
        {
            var p = ProductRepository.Get(it.ProductId);
            if (p == null || !p.IsActive || p.QtyOnHand <= 0) { warnings.Add($"{p?.Name ?? "An item"} is no longer available."); continue; }
            var qty = Math.Min(it.Quantity, p.QtyOnHand);
            if (qty < it.Quantity) warnings.Add($"{p.Name}: quantity reduced to {qty} (stock).");
            AddProduct(p, qty);
        }
        var type = Db.Val<string>(row, "CustomerType");
        var cref = Db.Val<string>(row, "CustomerRef");
        try { SetCustomer(type, cref, null); } catch (BusinessRuleException) { SetCustomer("Walk-in", null, null); }
        SalesRepository.DeleteSuspended(suspendedId);
        return warnings.Count == 0 ? null : string.Join(Environment.NewLine, warnings);
    }

    // ----- Post-sale actions -----
    public void VoidSale(int saleId, User approver, string reason)
    {
        if (approver.Role != Roles.Administrator) throw new BusinessRuleException("Voiding a finalized sale requires an administrator.");
        if (string.IsNullOrWhiteSpace(reason)) throw new BusinessRuleException("An explicit reason is required.");
        SalesRepository.Void(saleId, approver.UserId, reason.Trim());
    }

    public DataTable Search(string text, DateTime? from, DateTime? to, string status)
    {
        // Cashiers only see their own sales; managers and admins see all.
        int? cashier = Session.InRole(Roles.Cashier) ? Session.Current.UserId : null;
        return SalesRepository.Search(text, from, to, status, cashier);
    }

    public Sale GetSale(int saleId) => SalesRepository.GetSale(saleId);
}
