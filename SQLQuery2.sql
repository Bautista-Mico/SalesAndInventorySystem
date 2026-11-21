EXEC sp_MSforeachdb 'SELECT ''?'' AS DbName, COUNT(*) AS HasProducts FROM [?].sys.tables WHERE name = ''Products''';

USE SalesInventoryDB;
GO

BEGIN TRAN;
EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL';
DELETE dbo.Receipts;
DELETE dbo.Payments;
DELETE dbo.SaleItems;
DELETE dbo.Sales;
DELETE dbo.StockMovements;
DELETE dbo.Products;
EXEC sp_MSforeachtable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL';
COMMIT;

SELECT COUNT(*) AS ProductsLeft FROM dbo.Products;