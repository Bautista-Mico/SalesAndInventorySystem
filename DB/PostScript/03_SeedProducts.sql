USE SalesInventoryDB;
GO

BEGIN TRAN;
DELETE dbo.SaleItems;       
DELETE dbo.StockMovements;   
DELETE dbo.Products;
COMMIT;

SELECT COUNT(*) AS ProductsLeft FROM dbo.Products;  