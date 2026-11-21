IF OBJECT_ID('dbo.SaleItems', 'U') IS NULL
CREATE TABLE dbo.SaleItems
(
    SaleItemId      INT IDENTITY(1,1) PRIMARY KEY,
    SaleId          INT           NOT NULL REFERENCES dbo.Sales(SaleId),
    ProductId       INT           NOT NULL REFERENCES dbo.Products(ProductId),
    SKU             NVARCHAR(40)  NOT NULL,
    ProductName     NVARCHAR(200) NOT NULL,
    Quantity        INT           NOT NULL CHECK (Quantity > 0),
    UnitPrice       DECIMAL(18,2) NOT NULL,
    GrossAmount     DECIMAL(18,2) NOT NULL,
    DiscountAmount  DECIMAL(18,2) NOT NULL DEFAULT 0,
    LineTotal       DECIMAL(18,2) NOT NULL,
    VatAmount       DECIMAL(18,2) NOT NULL DEFAULT 0,
    PriceOverridden BIT           NOT NULL DEFAULT 0
);
GO
