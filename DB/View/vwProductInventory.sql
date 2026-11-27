CREATE OR ALTER VIEW dbo.vwProductInventory
AS
SELECT p.ProductId, p.SKU, p.Name, p.Description, p.Specification,
       p.CategoryId, c.Name AS CategoryName,
       p.SupplierId, s.Name AS SupplierName,
       p.UnitOfMeasure, p.UnitCost, p.SellingPrice, p.TaxGroup, p.DiscountEligible,
       p.ImagePath, p.StorageLocation, p.QtyOnHand, p.ReorderPoint, p.IsActive,
       CAST(p.QtyOnHand * p.UnitCost AS DECIMAL(18,2)) AS InventoryValue,
       CAST(CASE WHEN p.QtyOnHand <= p.ReorderPoint THEN 1 ELSE 0 END AS BIT) AS IsLowStock
FROM dbo.Products p
JOIN dbo.Categories c ON c.CategoryId = p.CategoryId
LEFT JOIN dbo.Suppliers s ON s.SupplierId = p.SupplierId;
GO
