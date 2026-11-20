IF OBJECT_ID('dbo.Sales', 'U') IS NULL
CREATE TABLE dbo.Sales
(
    SaleId             INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceNo          NVARCHAR(30)  NOT NULL,
    SaleDate           DATETIME2     NOT NULL DEFAULT SYSDATETIME(),
    CashierId          INT           NOT NULL REFERENCES dbo.Users(UserId),
    CustomerType       NVARCHAR(20)  NOT NULL DEFAULT 'Walk-in',
    CustomerRef        NVARCHAR(50)  NULL,
    Subtotal           DECIMAL(18,2) NOT NULL,
    DiscountPercent    DECIMAL(5,2)  NOT NULL DEFAULT 0,
    DiscountAmount     DECIMAL(18,2) NOT NULL DEFAULT 0,
    VatAmount          DECIMAL(18,2) NOT NULL DEFAULT 0,
    TotalAmount        DECIMAL(18,2) NOT NULL,
    PaymentMode        NVARCHAR(20)  NOT NULL,
    PaymentRef         NVARCHAR(100) NULL,
    CashTendered       DECIMAL(18,2) NULL,
    ChangeDue          DECIMAL(18,2) NULL,
    OverrideApprovedBy INT           NULL,
    Status             NVARCHAR(10)  NOT NULL DEFAULT 'Paid' CHECK (Status IN ('Paid','Voided')),
    VoidReason         NVARCHAR(200) NULL,
    VoidedBy           INT           NULL,
    VoidedAt           DATETIME2     NULL,
    CONSTRAINT UQ_Sales_InvoiceNo UNIQUE (InvoiceNo)
);
GO
