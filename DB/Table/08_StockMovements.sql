-- Append-only stock ledger. Rows are never updated or deleted; corrections are new rows.
IF OBJECT_ID('dbo.StockMovements', 'U') IS NULL
CREATE TABLE dbo.StockMovements
(
    MovementId INT IDENTITY(1,1) PRIMARY KEY,
    ProductId  INT           NOT NULL REFERENCES dbo.Products(ProductId),
    ActionType NVARCHAR(40)  NOT NULL,
    Quantity   INT           NOT NULL,          -- signed change
    QtyBefore  INT           NOT NULL,
    QtyAfter   INT           NOT NULL,
    Location   NVARCHAR(100) NULL,
    Reference  NVARCHAR(100) NULL,
    Reason     NVARCHAR(200) NULL,
    UserId     INT           NULL REFERENCES dbo.Users(UserId),
    CreatedAt  DATETIME2     NOT NULL DEFAULT SYSDATETIME()
);
GO
