IF OBJECT_ID('dbo.SuspendedTransactions', 'U') IS NULL
CREATE TABLE dbo.SuspendedTransactions
(
    SuspendedId  INT IDENTITY(1,1) PRIMARY KEY,
    CashierId    INT           NOT NULL REFERENCES dbo.Users(UserId),
    CustomerType NVARCHAR(20)  NOT NULL,
    CustomerRef  NVARCHAR(50)  NULL,
    CartJson     NVARCHAR(MAX) NOT NULL,
    CreatedAt    DATETIME2     NOT NULL DEFAULT SYSDATETIME()
);
GO
