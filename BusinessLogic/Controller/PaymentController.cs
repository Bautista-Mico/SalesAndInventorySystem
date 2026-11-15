using static System.Collections.Specialized.BitVector32;

namespace SalesInventory.BusinessLogic.Controller;

public class GatewayResult
{
    public bool Success { get; set; }
    public string Reference { get; set; }
    public string Message { get; set; }
}

public class PaymentController
{
    public static readonly string[] Modes = { "Cash", "Card", "Mobile Wallet" };

    private static readonly Random Rng = new();

    public decimal ComputeChange(decimal totalDue, decimal tendered)
    {
        if (tendered < totalDue) throw new BusinessRuleException("Cash tendered is less than the total amount due.");
        return Math.Round(tendered - totalDue, 2);
    }

    /// <summary>
    /// Simulated card terminal / e-wallet handshake. Replace the body with the real gateway SDK call;
    /// the rest of the system only needs a Success flag and a transaction token.
    /// </summary>
    public GatewayResult Handshake(string mode, decimal amount)
    {
        if (mode == "Cash") throw new BusinessRuleException("Cash payments do not need a terminal handshake.");
        if (amount <= 0) throw new BusinessRuleException("There is nothing to charge.");
        var prefix = mode == "Card" ? "CARD" : "WALLET";
        return new GatewayResult
        {
            Success = true,
            Reference = $"{prefix}-{DateTime.Now:yyyyMMddHHmmss}-{Rng.Next(1000, 9999)}",
            Message = "Approved"
        };
    }

    /// <summary>Validates the payment and finalizes the sale atomically (sale + stock + payment succeed or nothing does).</summary>
    public Sale Finalize(SalesController sales, string mode, decimal? tendered, string gatewayReference)
    {
        if (sales.Cart.Count == 0) throw new BusinessRuleException("The cart cannot be checked out because it contains zero items.");
        sales.Recalculate();

        if (mode == "Cash")
        {
            if (tendered == null) throw new BusinessRuleException("Enter the cash tendered amount.");
            ComputeChange(sales.Totals.Total, tendered.Value);
        }
        else if (string.IsNullOrWhiteSpace(gatewayReference))
            throw new BusinessRuleException("A successful gateway response is required before card / wallet payments can be finalized.");

        try
        {
            var (saleId, _) = SalesRepository.Complete(Session.Current.UserId, sales.CustomerType, sales.CustomerRef, sales.DiscountPercent,
                mode, mode == "Cash" ? null : gatewayReference, mode == "Cash" ? tendered : null, sales.OverrideApprovedBy, sales.Cart);
            var sale = SalesRepository.GetSale(saleId);
            sales.ClearAfterSale();
            return sale;
        }
        catch (BusinessRuleException) { throw; }
        catch (Exception ex)
        {
            throw new BusinessRuleException("The payment could not be completed (network or gateway timeout). The transaction was rolled back " +
                                            "to a pending state and no duplicate charge was recorded. Please try again.", ex);
        }
    }
}
