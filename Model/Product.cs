namespace SalesInventory.Model;

public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public override string ToString() => Name;
}

public class Supplier
{
    public int SupplierId { get; set; }
    public string Name { get; set; }
    public string ContactInfo { get; set; }
    public override string ToString() => Name;
}

public class Product
{
    public int ProductId { get; set; }
    public string SKU { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Specification { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public int? SupplierId { get; set; }
    public string SupplierName { get; set; }
    public string UnitOfMeasure { get; set; } = "Piece";
    public decimal UnitCost { get; set; }
    public decimal SellingPrice { get; set; }
    public string TaxGroup { get; set; } = "VAT";
    public bool DiscountEligible { get; set; }
    public string ImagePath { get; set; }
    public string StorageLocation { get; set; }
    public int QtyOnHand { get; set; }
    public int ReorderPoint { get; set; } = 5;
    public bool IsActive { get; set; } = true;

    public decimal InventoryValue => QtyOnHand * UnitCost;
    public bool IsLowStock => QtyOnHand <= ReorderPoint;
    public string StatusText => !IsActive ? "Inactive" : IsLowStock ? "Low stock" : "OK";
    public string DiscountText => DiscountEligible ? "Yes" : "No";
}
