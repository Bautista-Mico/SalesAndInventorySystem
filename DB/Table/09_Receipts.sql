IF OBJECT_ID('dbo.Receipts', 'U') IS NULL
CREATE TABLE dbo.Receipts
(
    ReceiptId      INT IDENTITY(1,1) PRIMARY KEY,
    SaleId         INT            NOT NULL REFERENCES dbo.Sales(SaleId),
    InvoiceNo      NVARCHAR(30)   NOT NULL,
    OutputFormat   NVARCHAR(30)   NOT NULL,
    Destination    NVARCHAR(150)  NULL,
    TaxInfo        NVARCHAR(150)  NULL,
    Content        NVARCHAR(MAX)  NOT NULL,
    IsDuplicate    BIT            NOT NULL DEFAULT 0,
    DeliveryStatus NVARCHAR(40)   NOT NULL DEFAULT 'Generated',
    Note           NVARCHAR(200)  NULL,
    CreatedBy      INT            NOT NULL REFERENCES dbo.Users(UserId),
    CreatedAt      DATETIME2      NOT NULL DEFAULT SYSDATETIME()
);
GO
