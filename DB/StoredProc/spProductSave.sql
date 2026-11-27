CREATE OR ALTER PROCEDURE dbo.spProductDelete
    @ProductId INT, @UserId INT, @WriteOffStock BIT = 0, @HardDelete BIT = 0
AS
BEGIN
    SET NOCOUNT ON; SET XACT_ABORT ON;
    DECLARE @Qty INT, @SKU NVARCHAR(40), @Loc NVARCHAR(100);
    SELECT @Qty = QtyOnHand, @SKU = SKU, @Loc = StorageLocation FROM dbo.Products WHERE ProductId = @ProductId;
    IF @SKU IS NULL THROW 50020, 'Product not found.', 1;

    BEGIN TRAN;
    IF @Qty > 0
    BEGIN
        IF @WriteOffStock = 0
            THROW 50021, 'This product still has stock. Write off or sell the stock first.', 1;
        INSERT dbo.StockMovements (ProductId, ActionType, Quantity, QtyBefore, QtyAfter, Location, Reference, Reason, UserId)
        VALUES (@ProductId, 'Discrepancy Adjustment', -@Qty, @Qty, 0, @Loc, @SKU, 'Written off on product removal', @UserId);
        UPDATE dbo.Products SET QtyOnHand = 0 WHERE ProductId = @ProductId;
    END

    IF @HardDelete = 1 AND NOT EXISTS (SELECT 1 FROM dbo.SaleItems WHERE ProductId = @ProductId)
    BEGIN
        DELETE dbo.StockMovements WHERE ProductId = @ProductId;
        DELETE dbo.Products WHERE ProductId = @ProductId;
        INSERT dbo.AuditLogs (UserId, Action, Details) VALUES (@UserId, 'ProductDeleted', @SKU);
        SELECT 'Deleted' AS Result;
    END
    ELSE
    BEGIN
        UPDATE dbo.Products SET IsActive = 0, UpdatedAt = SYSDATETIME() WHERE ProductId = @ProductId;
        INSERT dbo.AuditLogs (UserId, Action, Details) VALUES (@UserId, 'ProductDeactivated', @SKU);
        SELECT 'Deactivated' AS Result;
    END
    COMMIT;
END
GO