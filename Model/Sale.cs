namespace SalesInventory.Model;

/// <summary>A line in the POS cart. Money fields are filled in by PricingService.</summary>
public class CartLine
{
    public int ProductId { get; set; }
    public string SKU { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal ListPrice { get; set; }
    public decimal? OverridePrice { get; set; }
    public bool DiscountEligible { get; set; }
    public string TaxGroup { get; set; }
    public int StockOnHand { get; set; }

    public decimal UnitPrice => OverridePrice ?? ListPrice;
    public decimal Gross { get; set; }
    public decimal Discount { get; set; }
    public decimal LineTotal { get; set; }
    public decimal Vat { get; set; }
}

public class CartTotals
{
    public int ItemCount { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Discount { get; set; }
    public decimal Vat { get; set; }
    public decimal Total { get; set; }
}

public class SuspendedItem
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}

public class SaleItem
{
    public int ProductId { get; set; }
    public string SKU { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal LineTotal { get; set; }
    public decimal VatAmount { get; set; }
}

public class Sale
{
    public int SaleId { get; set; }
    public string InvoiceNo { get; set; }
    public DateTime SaleDate { get; set; }
    public int CashierId { get; set; }
    public string CashierName { get; set; }
    public string CustomerType { get; set; }
    public string CustomerRef { get; set; }
    public decimal Subtotal { get; set; }
    public decimal DiscountPercent { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal VatAmount { get; set; }
    public decimal TotalAmount { get; set; }
    public string PaymentMode { get; set; }
    public string PaymentRef { get; set; }
    public decimal? CashTendered { get; set; }
    public decimal? ChangeDue { get; set; }
    public string Status { get; set; }
    public string VoidReason { get; set; }
    public List<SaleItem> Items { get; set; } = new();
}
