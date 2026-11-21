CREATE OR ALTER PROCEDURE dbo.spSaleGetItems @SaleId INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ProductId, SKU, ProductName, Quantity, UnitPrice, DiscountAmount, LineTotal, VatAmount
    FROM dbo.SaleItems WHERE SaleId = @SaleId ORDER BY SaleItemId;
END
GO
