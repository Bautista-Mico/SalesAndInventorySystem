CREATE OR ALTER PROCEDURE dbo.spStockAdjust
    @ProductId INT, @ActionType NVARCHAR(40), @Quantity INT,
    @Location NVARCHAR(100) = NULL, @Reference NVARCHAR(100) = NULL, @Reason NVARCHAR(200) = NULL,
    @UserId INT, @ApprovedBy INT = NULL, @ApprovalLimit DECIMAL(18,2) = 5000
AS
BEGIN
    SET NOCOUNT ON; SET XACT_ABORT ON;
    DECLARE @Before INT, @Cost DECIMAL(18,2), @Delta INT;

    IF @Quantity = 0 THROW 50030, 'Adjustment quantity cannot be zero.', 1;
    IF ISNULL(LTRIM(RTRIM(@Reason)), '') = '' THROW 50031, 'An inventory reason code is required for every stock change.', 1;
    IF @ActionType NOT IN ('Replenishment', 'Damage Writeoff', 'Discrepancy Adjustment')
        THROW 50032, 'Unsupported stock action type.', 1;

    SET @Delta = CASE @ActionType WHEN 'Replenishment' THEN ABS(@Quantity)
                                  WHEN 'Damage Writeoff' THEN -ABS(@Quantity)
                                  ELSE @Quantity END;
    BEGIN TRAN;
    SELECT @Before = QtyOnHand, @Cost = UnitCost FROM dbo.Products WITH (UPDLOCK, HOLDLOCK) WHERE ProductId = @ProductId;
    IF @Before IS NULL THROW 50033, 'Product not found.', 1;
    IF @Before + @Delta < 0 THROW 50034, 'The decrement exceeds the available stock-on-hand balance.', 1;
    IF @Delta < 0 AND ABS(@Delta) * @Cost > @ApprovalLimit AND @ApprovedBy IS NULL
        THROW 50035, 'This write-off exceeds the financial limit and needs manager or administrator authorization.', 1;

    UPDATE dbo.Products
       SET QtyOnHand = @Before + @Delta,
           StorageLocation = COALESCE(NULLIF(LTRIM(RTRIM(@Location)), ''), StorageLocation),
           UpdatedAt = SYSDATETIME()
     WHERE ProductId = @ProductId;

    INSERT dbo.StockMovements (ProductId, ActionType, Quantity, QtyBefore, QtyAfter, Location, Reference, Reason, UserId)
    VALUES (@ProductId, @ActionType, @Delta, @Before, @Before + @Delta,
            COALESCE(NULLIF(LTRIM(RTRIM(@Location)), ''), (SELECT StorageLocation FROM dbo.Products WHERE ProductId = @ProductId)),
            @Reference, @Reason, @UserId);

    IF @ApprovedBy IS NOT NULL
        INSERT dbo.AuditLogs (UserId, Action, Details)
        VALUES (@ApprovedBy, 'StockAdjustApproved', CONCAT('Product ', @ProductId, ' delta ', @Delta, ' - ', @Reason));
    COMMIT;
    SELECT @Before + @Delta AS NewQty;
END
GO
