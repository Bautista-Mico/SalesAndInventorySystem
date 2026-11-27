IF OBJECT_ID('dbo.Products', 'U') IS NULL
CREATE TABLE dbo.Products
(
    ProductId        INT IDENTITY(1,1) PRIMARY KEY,
    SKU              NVARCHAR(40)  NOT NULL CONSTRAINT UQ_Products_SKU UNIQUE,
    Name             NVARCHAR(200) NOT NULL,
    Description      NVARCHAR(500) NULL,
    Specification    NVARCHAR(300) NULL,
    CategoryId       INT           NOT NULL REFERENCES dbo.Categories(CategoryId),
    SupplierId       INT           NULL     REFERENCES dbo.Suppliers(SupplierId),
    UnitOfMeasure    NVARCHAR(20)  NOT NULL DEFAULT 'Piece',
    UnitCost         DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (UnitCost >= 0),
    SellingPrice     DECIMAL(18,2) NOT NULL CHECK (SellingPrice >= 0),
    TaxGroup         NVARCHAR(20)  NOT NULL DEFAULT 'VAT' CHECK (TaxGroup IN ('VAT','Exempt')),
    DiscountEligible BIT           NOT NULL DEFAULT 0,
    ImagePath        NVARCHAR(300) NULL,
    StorageLocation  NVARCHAR(100) NULL,
    QtyOnHand        INT           NOT NULL DEFAULT 0 CHECK (QtyOnHand >= 0),
    ReorderPoint     INT           NOT NULL DEFAULT 5 CHECK (ReorderPoint > 0),
    IsActive         BIT           NOT NULL DEFAULT 1,
    CreatedAt        DATETIME2     NOT NULL DEFAULT SYSDATETIME(),
    UpdatedAt        DATETIME2     NULL
);
GO
