IF OBJECT_ID('dbo.Payments', 'U') IS NULL
CREATE TABLE dbo.Payments
(
    PaymentId   INT IDENTITY(1,1) PRIMARY KEY,
    SaleId      INT           NOT NULL REFERENCES dbo.Sales(SaleId),
    PaymentMode NVARCHAR(20)  NOT NULL,
    Amount      DECIMAL(18,2) NOT NULL,
    Reference   NVARCHAR(100) NULL,
    Status      NVARCHAR(12)  NOT NULL DEFAULT 'Success' CHECK (Status IN ('Pending','Success','Refunded')),
    CreatedAt   DATETIME2     NOT NULL DEFAULT SYSDATETIME()
);
GO
