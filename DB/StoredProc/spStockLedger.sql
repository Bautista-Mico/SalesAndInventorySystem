CREATE OR ALTER PROCEDURE dbo.spStockLedger
    @From DATE = NULL, @To DATE = NULL, @Search NVARCHAR(100) = NULL, @ActionType NVARCHAR(40) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP (1000) CreatedAt, SKU, ProductName, ActionType, Quantity, QtyBefore, QtyAfter, Location, Reference, Reason, UserName
    FROM dbo.vwStockLedger
    WHERE (@From IS NULL OR CreatedAt >= @From)
      AND (@To IS NULL OR CreatedAt < DATEADD(DAY, 1, @To))
      AND (@ActionType IS NULL OR ActionType = @ActionType)
      AND (@Search IS NULL OR @Search = '' OR SKU LIKE '%' + @Search + '%' OR ProductName LIKE '%' + @Search + '%')
    ORDER BY CreatedAt DESC, MovementId DESC;
END
GO
