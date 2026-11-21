CREATE OR ALTER PROCEDURE dbo.spSaleSearch
    @Search NVARCHAR(100) = NULL, @From DATE = NULL, @To DATE = NULL, @Status NVARCHAR(10) = NULL, @CashierId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP (500) *
    FROM dbo.vwSaleSummary
    WHERE (@Search IS NULL OR @Search = '' OR InvoiceNo LIKE '%' + @Search + '%' OR CustomerRef LIKE '%' + @Search + '%')
      AND (@From IS NULL OR SaleDate >= @From)
      AND (@To IS NULL OR SaleDate < DATEADD(DAY, 1, @To))
      AND (@Status IS NULL OR Status = @Status)
      AND (@CashierId IS NULL OR CashierId = @CashierId)
    ORDER BY SaleDate DESC;
END
GO
