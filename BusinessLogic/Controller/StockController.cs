using System.Data;
using System.Text.Json;

namespace SalesInventory.BusinessLogic.Controller;

public class StockController
{
    /// <summary>Negative adjustments worth more than this need a manager / administrator credential.</summary>
    public const decimal WriteOffApprovalLimit = 5000m;

    public static readonly string[] ActionTypes = { "Replenishment", "Damage Writeoff", "Discrepancy Adjustment" };
    public static readonly string[] ReasonCodes =
        { "Supplier Intake", "Damaged Cargo", "Expired Goods", "Discrepancy Audit", "Supplier Miscount Overlap", "Correction" };

    private static string SuspendedPath
    {
        get
        {
            var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SalesInventory");
            Directory.CreateDirectory(dir);
            return Path.Combine(dir, "suspended_inventory.json");
        }
    }

    public StockLine BuildLine(Product p, string action, int quantity, string location, string reference, string reason)
    {
        if (p == null) throw new BusinessRuleException("Select a product first (scan the barcode or search by SKU / name).");
        if (!ActionTypes.Contains(action)) throw new BusinessRuleException("Choose a stock action type.");
        if (quantity == 0) throw new BusinessRuleException("Adjustment quantity cannot be zero.");
        if (string.IsNullOrWhiteSpace(reason)) throw new BusinessRuleException("An inventory reason code is required.");
        return new StockLine
        {
            ProductId = p.ProductId,
            SKU = p.SKU,
            ProductName = p.Name,
            ActionType = action,
            Quantity = quantity,
            Location = string.IsNullOrWhiteSpace(location) ? p.StorageLocation : location.Trim(),
            Reference = reference?.Trim(),
            Reason = reason,
            CurrentQty = p.QtyOnHand,
            UnitCost = p.UnitCost
        };
    }

    public bool NeedsApproval(IEnumerable<StockLine> lines) =>
        lines.Any(l => l.Delta < 0 && Math.Abs(l.Delta) * l.UnitCost > WriteOffApprovalLimit);

    public void Post(IList<StockLine> lines, int? approvedBy)
    {
        if (!Permissions.CanEditInventory) throw new BusinessRuleException("You do not have permission to update stock.");
        if (lines == null || lines.Count == 0) throw new BusinessRuleException("The inventory update has no SKU entries.");
        try
        {
            StockRepository.AdjustBatch(lines, Session.Current.UserId, approvedBy, WriteOffApprovalLimit);
            ClearSuspended();
        }
        catch (BusinessRuleException) { throw; }
        catch (Exception ex)
        {
            File.WriteAllText(SuspendedPath, JsonSerializer.Serialize(lines.ToList()));
            throw new BusinessRuleException("The connection was lost while saving. Nothing was posted. Your lines were kept as a " +
                                            "\"Suspended Inventory Session\" - use Recover Session to continue.", ex);
        }
    }

    public bool HasSuspended => File.Exists(SuspendedPath);

    public List<StockLine> RecoverSuspended() =>
        HasSuspended ? JsonSerializer.Deserialize<List<StockLine>>(File.ReadAllText(SuspendedPath)) : new List<StockLine>();

    public void ClearSuspended() { if (HasSuspended) File.Delete(SuspendedPath); }

    public DataTable Ledger(DateTime? from, DateTime? to, string search, string action) => StockRepository.Ledger(from, to, search, action);
}
