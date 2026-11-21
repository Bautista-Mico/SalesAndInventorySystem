CREATE OR ALTER PROCEDURE dbo.spProductDelete @ProductId INT, @UserId INT
AS
BEGIN
    SET NOCOUNT ON; SET XACT_ABORT ON;
    DECLARE @Qty INT, @SKU NVARCHAR(40);
    SELECT @Qty = QtyOnHand, @SKU = SKU FROM dbo.Products WHERE ProductId = @ProductId;
    IF @SKU IS NULL THROW 50020, 'Product not found.', 1;
    IF @Qty > 0 THROW 50021, 'A product with active on-hand quantity cannot be archived or deleted. Write off or sell the stock first.', 1;

    IF EXISTS (SELECT 1 FROM dbo.SaleItems WHERE ProductId = @ProductId)
       OR EXISTS (SELECT 1 FROM dbo.StockMovements WHERE ProductId = @ProductId)
    BEGIN
        UPDATE dbo.Products SET IsActive = 0, UpdatedAt = SYSDATETIME() WHERE ProductId = @ProductId;
        INSERT dbo.AuditLogs (UserId, Action, Details) VALUES (@UserId, 'ProductDeactivated', @SKU);
        SELECT 'Deactivated' AS Result;
    END
    ELSE
    BEGIN
        DELETE dbo.Products WHERE ProductId = @ProductId;
        INSERT dbo.AuditLogs (UserId, Action, Details) VALUES (@UserId, 'ProductDeleted', @SKU);
        SELECT 'Deleted' AS Result;
    END
END
GO
