CREATE OR ALTER VIEW dbo.vwStockLedger
AS
SELECT m.MovementId, m.CreatedAt, m.ProductId, p.SKU, p.Name AS ProductName,
       m.ActionType, m.Quantity, m.QtyBefore, m.QtyAfter, m.Location, m.Reference, m.Reason,
       ISNULL(u.FullName, 'System') AS UserName
FROM dbo.StockMovements m
JOIN dbo.Products p ON p.ProductId = m.ProductId
LEFT JOIN dbo.Users u ON u.UserId = m.UserId;
GO
