-- Atomically finalizes a sale: validates the cart, recomputes prices/discount/VAT on the server (prices are VAT-inclusive),
-- decrements stock, writes the stock ledger, the invoice, its lines and the payment.
CREATE OR ALTER PROCEDURE dbo.spSaleComplete
    @CashierId INT, @CustomerType NVARCHAR(20), @CustomerRef NVARCHAR(50) = NULL,
    @DiscountPercent DECIMAL(5,2) = 0, @PaymentMode NVARCHAR(20), @PaymentRef NVARCHAR(100) = NULL,
    @CashTendered DECIMAL(18,2) = NULL, @OverrideApprovedBy INT = NULL,
    @Items dbo.SaleItemType READONLY,
    @SaleId INT OUTPUT, @InvoiceNo NVARCHAR(30) OUTPUT
AS
BEGIN
    SET NOCOUNT ON; SET XACT_ABORT ON;

    IF NOT EXISTS (SELECT 1 FROM @Items) THROW 50040, 'The cart cannot be finalized because it contains zero items.', 1;
    IF EXISTS (SELECT 1 FROM @Items WHERE Quantity <= 0) THROW 50041, 'Quantities must be positive whole numbers.', 1;
    IF @PaymentMode NOT IN ('Cash', 'Card', 'Mobile Wallet') THROW 50042, 'Unsupported payment mode.', 1;
    IF @PaymentMode <> 'Cash' AND ISNULL(LTRIM(RTRIM(@PaymentRef)), '') = ''
        THROW 50043, 'A successful gateway response is required for card and wallet payments.', 1;
    IF @DiscountPercent < 0 OR @DiscountPercent > 100 THROW 50048, 'Invalid discount rate.', 1;
    IF EXISTS (SELECT 1 FROM @Items WHERE OverridePrice IS NOT NULL)
       AND NOT EXISTS (SELECT 1 FROM dbo.Users WHERE UserId = @OverrideApprovedBy AND IsActive = 1 AND Role IN ('Administrator', 'StoreManager'))
        THROW 50044, 'Manual price overrides require supervisor or administrator authorization.', 1;

    DECLARE @Lines TABLE (ProductId INT PRIMARY KEY, Quantity INT NOT NULL, OverridePrice DECIMAL(18,2) NULL);
    INSERT @Lines SELECT ProductId, SUM(Quantity), MAX(OverridePrice) FROM @Items GROUP BY ProductId;

    DECLARE @Calc TABLE (ProductId INT PRIMARY KEY, SKU NVARCHAR(40), ProdName NVARCHAR(200), TaxGroup NVARCHAR(20),
                         Qty INT, UnitPrice DECIMAL(18,2), Gross DECIMAL(18,2), Disc DECIMAL(18,2),
                         LineTotal DECIMAL(18,2), Vat DECIMAL(18,2), Overridden BIT, QtyBefore INT);
    DECLARE @Sub DECIMAL(18,2), @Disc DECIMAL(18,2), @Total DECIMAL(18,2), @Vat DECIMAL(18,2), @Change DECIMAL(18,2), @n INT, @Inv NVARCHAR(30);

    BEGIN TRAN;

    INSERT @Calc (ProductId, SKU, ProdName, TaxGroup, Qty, UnitPrice, Gross, Disc, LineTotal, Vat, Overridden, QtyBefore)
    SELECT p.ProductId, p.SKU, p.Name, p.TaxGroup, l.Quantity,
           ISNULL(l.OverridePrice, p.SellingPrice),
           ROUND(ISNULL(l.OverridePrice, p.SellingPrice) * l.Quantity, 2),
           CASE WHEN p.DiscountEligible = 1
                THEN ROUND(ROUND(ISNULL(l.OverridePrice, p.SellingPrice) * l.Quantity, 2) * @DiscountPercent / 100.0, 2)
                ELSE 0 END,
           0, 0, CASE WHEN l.OverridePrice IS NULL THEN 0 ELSE 1 END, p.QtyOnHand
    FROM @Lines l
    JOIN dbo.Products p WITH (UPDLOCK, HOLDLOCK) ON p.ProductId = l.ProductId
    WHERE p.IsActive = 1;

    IF (SELECT COUNT(*) FROM @Calc) <> (SELECT COUNT(*) FROM @Lines)
        THROW 50045, 'One or more products are unavailable or inactive.', 1;
    IF EXISTS (SELECT 1 FROM @Calc WHERE Qty > QtyBefore)
        THROW 50046, 'Insufficient stock for one or more items.', 1;

    UPDATE @Calc SET LineTotal = Gross - Disc;
    UPDATE @Calc SET Vat = CASE WHEN TaxGroup = 'VAT' THEN ROUND(LineTotal / 1.12 * 0.12, 2) ELSE 0 END;
    SELECT @Sub = SUM(Gross), @Disc = SUM(Disc), @Total = SUM(LineTotal), @Vat = SUM(Vat) FROM @Calc;

    IF @PaymentMode = 'Cash'
    BEGIN
        IF @CashTendered IS NULL OR @CashTendered < @Total THROW 50047, 'Cash tendered is less than the total amount due.', 1;
        SET @Change = @CashTendered - @Total;
    END
    ELSE
    BEGIN
        SET @CashTendered = NULL; SET @Change = NULL;
    END

    SET @n = NEXT VALUE FOR dbo.InvoiceSeq;
    SET @Inv = 'INV-' + FORMAT(SYSDATETIME(), 'yyyyMMdd') + '-' + RIGHT('000000' + CAST(@n AS VARCHAR(10)), 6);

    INSERT dbo.Sales (InvoiceNo, CashierId, CustomerType, CustomerRef, Subtotal, DiscountPercent, DiscountAmount, VatAmount, TotalAmount,
                      PaymentMode, PaymentRef, CashTendered, ChangeDue, OverrideApprovedBy, Status)
    VALUES (@Inv, @CashierId, @CustomerType, @CustomerRef, @Sub, @DiscountPercent, @Disc, @Vat, @Total,
            @PaymentMode, @PaymentRef, @CashTendered, @Change, @OverrideApprovedBy, 'Paid');
    SET @SaleId = SCOPE_IDENTITY();
    SET @InvoiceNo = @Inv;

    INSERT dbo.SaleItems (SaleId, ProductId, SKU, ProductName, Quantity, UnitPrice, GrossAmount, DiscountAmount, LineTotal, VatAmount, PriceOverridden)
    SELECT @SaleId, ProductId, SKU, ProdName, Qty, UnitPrice, Gross, Disc, LineTotal, Vat, Overridden FROM @Calc;

    INSERT dbo.StockMovements (ProductId, ActionType, Quantity, QtyBefore, QtyAfter, Location, Reference, Reason, UserId)
    SELECT c.ProductId, 'POS Sales Decrement', -c.Qty, c.QtyBefore, c.QtyBefore - c.Qty, p.StorageLocation, @Inv, 'POS sale', @CashierId
    FROM @Calc c JOIN dbo.Products p ON p.ProductId = c.ProductId;

    UPDATE p SET QtyOnHand = p.QtyOnHand - c.Qty, UpdatedAt = SYSDATETIME()
    FROM dbo.Products p JOIN @Calc c ON c.ProductId = p.ProductId;

    INSERT dbo.Payments (SaleId, PaymentMode, Amount, Reference, Status) VALUES (@SaleId, @PaymentMode, @Total, @PaymentRef, 'Success');
    INSERT dbo.AuditLogs (UserId, Action, Details) VALUES (@CashierId, 'SaleCompleted', @Inv + ' total ' + CAST(@Total AS NVARCHAR(30)));
    COMMIT;
END
GO
