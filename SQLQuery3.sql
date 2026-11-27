USE SalesInventoryDB;
GO

BEGIN TRAN;
DELETE dbo.SaleItems;        -- sale lines point to products
DELETE dbo.StockMovements;   -- stock history points to products
DELETE dbo.Products;
COMMIT;

SELECT COUNT(*) AS ProductsLeft FROM dbo.Products;   -- should show 0