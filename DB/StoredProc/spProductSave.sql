CREATE OR ALTER PROCEDURE dbo.spProductSave
    @ProductId INT = NULL, @SKU NVARCHAR(40) = NULL, @Name NVARCHAR(200),
    @Description NVARCHAR(500) = NULL, @Specification NVARCHAR(300) = NULL,
    @CategoryId INT, @SupplierId INT = NULL, @UnitOfMeasure NVARCHAR(20),
    @UnitCost DECIMAL(18,2), @SellingPrice DECIMAL(18,2), @TaxGroup NVARCHAR(20), @DiscountEligible BIT,
    @ImagePath NVARCHAR(300) = NULL, @StorageLocation NVARCHAR(100) = NULL,
    @QtyOnHand INT = 0, @ReorderPoint INT, @UserId INT
AS
BEGIN
    SET NOCOUNT ON; SET XACT_ABORT ON;

    IF ISNULL(LTRIM(RTRIM(@Name)), '') = '' THROW 50010, 'Product name is required.', 1;
    IF @SellingPrice IS NULL OR @SellingPrice < 0 THROW 50011, 'Retail selling price must be numeric and cannot be lower than 0.00.', 1;
    IF @UnitCost < 0 THROW 50012, 'Unit cost cannot be negative.', 1;
    IF @ReorderPoint IS NULL OR @ReorderPoint <= 0 THROW 50013, 'Reorder point must be a number greater than zero.', 1;
    IF @QtyOnHand < 0 THROW 50014, 'Inventory quantity cannot be negative.', 1;

    IF ISNULL(LTRIM(RTRIM(@SKU)), '') = ''
    BEGIN
        DECLARE @n INT;
        SET @n = NEXT VALUE FOR dbo.SkuSeq;
        SET @SKU = 'SKU-' + RIGHT('000000' + CAST(@n AS VARCHAR(10)), 6);
    END

    IF EXISTS (SELECT 1 FROM dbo.Products WHERE SKU = @SKU AND (@ProductId IS NULL OR @ProductId = 0 OR ProductId <> @ProductId))
        THROW 50015, 'That SKU already exists. Product IDs / SKUs must be unique.', 1;

    IF @ProductId IS NULL OR @ProductId = 0
    BEGIN
        BEGIN TRAN;
        INSERT dbo.Products (SKU, Name, Description, Specification, CategoryId, SupplierId, UnitOfMeasure, UnitCost, SellingPrice,
                             TaxGroup, DiscountEligible, ImagePath, StorageLocation, QtyOnHand, ReorderPoint)
        VALUES (@SKU, @Name, @Description, @Specification, @CategoryId, @SupplierId, @UnitOfMeasure, @UnitCost, @SellingPrice,
                @TaxGroup, @DiscountEligible, @ImagePath, @StorageLocation, @QtyOnHand, @ReorderPoint);
        SET @ProductId = SCOPE_IDENTITY();

        IF @QtyOnHand > 0
            INSERT dbo.StockMovements (ProductId, ActionType, Quantity, QtyBefore, QtyAfter, Location, Reference, Reason, UserId)
            VALUES (@ProductId, 'Initial Stock', @QtyOnHand, 0, @QtyOnHand, @StorageLocation, @SKU, 'Initial stock on item creation', @UserId);
        COMMIT;
    END
    ELSE
    BEGIN
        UPDATE dbo.Products
           SET SKU = @SKU, Name = @Name, Description = @Description, Specification = @Specification,
               CategoryId = @CategoryId, SupplierId = @SupplierId, UnitOfMeasure = @UnitOfMeasure,
               UnitCost = @UnitCost, SellingPrice = @SellingPrice, TaxGroup = @TaxGroup,
               DiscountEligible = @DiscountEligible, ImagePath = @ImagePath, StorageLocation = @StorageLocation,
               ReorderPoint = @ReorderPoint, UpdatedAt = SYSDATETIME()
         WHERE ProductId = @ProductId;     -- quantity is only changed through spStockAdjust
    END

    INSERT dbo.AuditLogs (UserId, Action, Details) VALUES (@UserId, 'ProductSaved', @SKU + ' / ' + @Name);
    SELECT @ProductId AS ProductId;
END
GO
