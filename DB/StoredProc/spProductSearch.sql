CREATE OR ALTER PROCEDURE dbo.spProductSearch
    @Search NVARCHAR(100) = NULL, @CategoryId INT = NULL, @IncludeInactive BIT = 0, @LowStockOnly BIT = 0
AS
BEGIN
    SET NOCOUNT ON;
    SELECT *
    FROM dbo.vwProductInventory
    WHERE (@IncludeInactive = 1 OR IsActive = 1)
      AND (@CategoryId IS NULL OR CategoryId = @CategoryId)
      AND (@LowStockOnly = 0 OR IsLowStock = 1)
      AND (@Search IS NULL OR @Search = ''
           OR SKU LIKE '%' + @Search + '%' OR Name LIKE '%' + @Search + '%' OR CategoryName LIKE '%' + @Search + '%')
    ORDER BY Name;
END
GO
