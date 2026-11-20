CREATE OR ALTER PROCEDURE dbo.spSaleVoid @SaleId INT, @ApprovedBy INT, @Reason NVARCHAR(200)
AS
BEGIN
    SET NOCOUNT ON; SET XACT_ABORT ON;
    IF ISNULL(LTRIM(RTRIM(@Reason)), '') = '' THROW 50050, 'An explicit reason is required to void or refund a sale.', 1;
    IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE UserId = @ApprovedBy AND Role = 'Administrator' AND IsActive = 1)
        THROW 50051, 'Voiding or refunding a finalized sale requires administrator authorization.', 1;

    BEGIN TRAN;
    IF NOT EXISTS (SELECT 1 FROM dbo.Sales WITH (UPDLOCK) WHERE SaleId = @SaleId AND Status = 'Paid')
        THROW 50052, 'Only finalized (Paid) sales can be voided.', 1;

    INSERT dbo.StockMovements (ProductId, ActionType, Quantity, QtyBefore, QtyAfter, Location, Reference, Reason, UserId)
    SELECT p.ProductId, 'Void Return', si.Quantity, p.QtyOnHand, p.QtyOnHand + si.Quantity, p.StorageLocation, s.InvoiceNo, @Reason, @ApprovedBy
    FROM dbo.SaleItems si
    JOIN dbo.Products p ON p.ProductId = si.ProductId
    JOIN dbo.Sales s ON s.SaleId = si.SaleId
    WHERE si.SaleId = @SaleId;

    UPDATE p SET QtyOnHand = p.QtyOnHand + si.Quantity, UpdatedAt = SYSDATETIME()
    FROM dbo.Products p JOIN dbo.SaleItems si ON si.ProductId = p.ProductId
    WHERE si.SaleId = @SaleId;

    UPDATE dbo.Sales SET Status = 'Voided', VoidReason = @Reason, VoidedBy = @ApprovedBy, VoidedAt = SYSDATETIME() WHERE SaleId = @SaleId;
    UPDATE dbo.Payments SET Status = 'Refunded' WHERE SaleId = @SaleId;
    INSERT dbo.AuditLogs (UserId, Action, Details)
    SELECT @ApprovedBy, 'SaleVoided', InvoiceNo + ' - ' + @Reason FROM dbo.Sales WHERE SaleId = @SaleId;
    COMMIT;
END
GO
