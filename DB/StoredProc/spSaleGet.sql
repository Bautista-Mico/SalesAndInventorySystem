CREATE OR ALTER PROCEDURE dbo.spSaleGet @SaleId INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM dbo.vwSaleSummary WHERE SaleId = @SaleId;
END
GO
