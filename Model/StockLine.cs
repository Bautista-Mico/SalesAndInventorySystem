namespace SalesInventory.Model;

/// <summary>One row of a stock update batch (replenishment, write-off or discrepancy adjustment).</summary>
public class StockLine
{
    public int ProductId { get; set; }
    public string SKU { get; set; }
    public string ProductName { get; set; }
    public string ActionType { get; set; }
    public int Quantity { get; set; }          // as entered by the user
    public string Location { get; set; }
    public string Reference { get; set; }
    public string Reason { get; set; }
    public int CurrentQty { get; set; }
    public decimal UnitCost { get; set; }

    /// <summary>Signed change applied to stock-on-hand.</summary>
    public int Delta => ActionType switch
    {
        "Replenishment" => Math.Abs(Quantity),
        "Damage Writeoff" => -Math.Abs(Quantity),
        _ => Quantity
    };
}

public class DashboardSummary
{
    public decimal TodaySales { get; set; }
    public int TodayTransactions { get; set; }
    public int ActiveProducts { get; set; }
    public int LowStockItems { get; set; }
    public decimal InventoryValue { get; set; }
}
