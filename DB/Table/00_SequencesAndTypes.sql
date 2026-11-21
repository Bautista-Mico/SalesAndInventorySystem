IF NOT EXISTS (SELECT 1 FROM sys.sequences WHERE name = 'InvoiceSeq')
    CREATE SEQUENCE dbo.InvoiceSeq AS INT START WITH 1 INCREMENT BY 1;
GO
IF NOT EXISTS (SELECT 1 FROM sys.sequences WHERE name = 'SkuSeq')
    CREATE SEQUENCE dbo.SkuSeq AS INT START WITH 1000 INCREMENT BY 1;
GO
IF TYPE_ID('dbo.SaleItemType') IS NULL
    CREATE TYPE dbo.SaleItemType AS TABLE
    (
        ProductId     INT           NOT NULL,
        Quantity      INT           NOT NULL,
        OverridePrice DECIMAL(18,2) NULL
    );
GO
