namespace SalesInventory.BusinessLogic.Controller;

/// <summary>
/// Cart maths. Selling prices are VAT-inclusive (VAT items contain 12% VAT). This mirrors spSaleComplete,
/// which recomputes everything on the server when the sale is finalized.
/// </summary>
public static class PricingService
{
    public const decimal VatRate = 0.12m;

    public static readonly Dictionary<string, decimal> DiscountCodes = new(StringComparer.OrdinalIgnoreCase)
    {
        ["STUDENT10"] = 10m,
        ["STAFF15"] = 15m,
        ["PROMO5"] = 5m
    };

    public static decimal PercentFor(string customerType, string code)
    {
        if (!string.IsNullOrWhiteSpace(code))
        {
            if (DiscountCodes.TryGetValue(code.Trim(), out var pct)) return pct;
            throw new BusinessRuleException("That discount code is not valid.");
        }
        return customerType switch { "Student" => 10m, "Staff" => 15m, _ => 0m };
    }

    private static decimal R(decimal v) => Math.Round(v, 2, MidpointRounding.AwayFromZero);

    public static CartTotals Calculate(IEnumerable<CartLine> lines, decimal discountPercent)
    {
        var t = new CartTotals();
        foreach (var l in lines)
        {
            l.Gross = R(l.UnitPrice * l.Quantity);
            l.Discount = l.DiscountEligible ? R(l.Gross * discountPercent / 100m) : 0m;
            l.LineTotal = l.Gross - l.Discount;
            l.Vat = l.TaxGroup == "VAT" ? R(l.LineTotal / (1 + VatRate) * VatRate) : 0m;
            t.ItemCount += l.Quantity;
            t.Subtotal += l.Gross;
            t.Discount += l.Discount;
            t.Vat += l.Vat;
            t.Total += l.LineTotal;
        }
        return t;
    }
}
