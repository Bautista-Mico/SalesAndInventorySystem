CREATE OR ALTER VIEW dbo.vwSaleSummary
AS
SELECT s.SaleId, s.InvoiceNo, s.SaleDate, s.CashierId, u.FullName AS CashierName,
       s.CustomerType, s.CustomerRef, s.Subtotal, s.DiscountPercent, s.DiscountAmount,
       s.VatAmount, s.TotalAmount, s.PaymentMode, s.PaymentRef, s.CashTendered, s.ChangeDue,
       s.Status, s.VoidReason, s.VoidedAt
FROM dbo.Sales s
JOIN dbo.Users u ON u.UserId = s.CashierId;
GO
