CREATE OR ALTER PROCEDURE dbo.spReportDailySales @From DATE, @To DATE, @CashierId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT CAST(s.SaleDate AS DATE) AS SaleDate, COUNT(*) AS Transactions,
           SUM(s.Subtotal) AS GrossSales, SUM(s.DiscountAmount) AS Discounts, SUM(s.VatAmount) AS Vat, SUM(s.TotalAmount) AS NetSales
    FROM dbo.Sales s
    WHERE s.Status = 'Paid' AND s.SaleDate >= @From AND s.SaleDate < DATEADD(DAY, 1, @To)
      AND (@CashierId IS NULL OR s.CashierId = @CashierId)
    GROUP BY CAST(s.SaleDate AS DATE)
    ORDER BY CAST(s.SaleDate AS DATE);
END
GO
CREATE OR ALTER PROCEDURE dbo.spReportPaymentModes @From DATE, @To DATE, @CashierId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT s.PaymentMode, COUNT(*) AS Transactions, SUM(s.TotalAmount) AS Amount,
           CAST(100.0 * SUM(s.TotalAmount) / NULLIF(SUM(SUM(s.TotalAmount)) OVER (), 0) AS DECIMAL(5,2)) AS SharePct
    FROM dbo.Sales s
    WHERE s.Status = 'Paid' AND s.SaleDate >= @From AND s.SaleDate < DATEADD(DAY, 1, @To)
      AND (@CashierId IS NULL OR s.CashierId = @CashierId)
    GROUP BY s.PaymentMode
    ORDER BY Amount DESC;
END
GO
CREATE OR ALTER PROCEDURE dbo.spReportCashDrawer @From DATE, @To DATE, @CashierId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT CAST(s.SaleDate AS DATE) AS SaleDate, u.FullName AS Cashier,
           COUNT(CASE WHEN s.Status = 'Paid' THEN 1 END) AS Transactions,
           SUM(CASE WHEN s.Status = 'Paid' AND s.PaymentMode = 'Cash' THEN s.TotalAmount ELSE 0 END) AS ExpectedCash,
           SUM(CASE WHEN s.Status = 'Paid' AND s.PaymentMode = 'Card' THEN s.TotalAmount ELSE 0 END) AS CardTotal,
           SUM(CASE WHEN s.Status = 'Paid' AND s.PaymentMode = 'Mobile Wallet' THEN s.TotalAmount ELSE 0 END) AS WalletTotal,
           SUM(CASE WHEN s.Status = 'Paid' THEN s.TotalAmount ELSE 0 END) AS TotalSales,
           COUNT(CASE WHEN s.Status = 'Voided' THEN 1 END) AS Voids
    FROM dbo.Sales s JOIN dbo.Users u ON u.UserId = s.CashierId
    WHERE s.SaleDate >= @From AND s.SaleDate < DATEADD(DAY, 1, @To) AND (@CashierId IS NULL OR s.CashierId = @CashierId)
    GROUP BY CAST(s.SaleDate AS DATE), u.FullName
    ORDER BY CAST(s.SaleDate AS DATE), u.FullName;
END
GO
CREATE OR ALTER PROCEDURE dbo.spReportStockVariance @From DATE, @To DATE, @CashierId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT m.CreatedAt, p.SKU, p.Name AS ProductName, m.ActionType, m.Quantity,
           CAST(m.Quantity * p.UnitCost AS DECIMAL(18,2)) AS ValueImpact, m.Reason, ISNULL(u.FullName, 'System') AS UserName
    FROM dbo.StockMovements m
    JOIN dbo.Products p ON p.ProductId = m.ProductId
    LEFT JOIN dbo.Users u ON u.UserId = m.UserId
    WHERE m.ActionType IN ('Damage Writeoff', 'Discrepancy Adjustment')
      AND m.CreatedAt >= @From AND m.CreatedAt < DATEADD(DAY, 1, @To)
    ORDER BY m.CreatedAt DESC;
END
GO
CREATE OR ALTER PROCEDURE dbo.spReportTopProducts @From DATE, @To DATE, @CashierId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP (20) si.SKU, si.ProductName, SUM(si.Quantity) AS Units, SUM(si.LineTotal) AS Revenue
    FROM dbo.SaleItems si JOIN dbo.Sales s ON s.SaleId = si.SaleId
    WHERE s.Status = 'Paid' AND s.SaleDate >= @From AND s.SaleDate < DATEADD(DAY, 1, @To)
      AND (@CashierId IS NULL OR s.CashierId = @CashierId)
    GROUP BY si.SKU, si.ProductName
    ORDER BY Revenue DESC;
END
GO
CREATE OR ALTER PROCEDURE dbo.spReportInventoryValuation @From DATE, @To DATE, @CashierId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT CategoryName AS Category, COUNT(*) AS Items, SUM(QtyOnHand) AS UnitsOnHand,
           SUM(InventoryValue) AS InventoryValue, SUM(CAST(QtyOnHand * SellingPrice AS DECIMAL(18,2))) AS RetailValue
    FROM dbo.vwProductInventory WHERE IsActive = 1
    GROUP BY CategoryName ORDER BY InventoryValue DESC;
END
GO
CREATE OR ALTER PROCEDURE dbo.spReportTax @From DATE, @To DATE, @CashierId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT CAST(s.SaleDate AS DATE) AS SaleDate, COUNT(DISTINCT s.SaleId) AS Invoices,
           SUM(CASE WHEN si.VatAmount > 0 THEN si.LineTotal ELSE 0 END) AS VatableSales,
           SUM(CASE WHEN si.VatAmount = 0 THEN si.LineTotal ELSE 0 END) AS ExemptSales,
           SUM(si.VatAmount) AS VatAmount
    FROM dbo.Sales s JOIN dbo.SaleItems si ON si.SaleId = s.SaleId
    WHERE s.Status = 'Paid' AND s.SaleDate >= @From AND s.SaleDate < DATEADD(DAY, 1, @To)
    GROUP BY CAST(s.SaleDate AS DATE)
    ORDER BY CAST(s.SaleDate AS DATE);
END
GO
CREATE OR ALTER PROCEDURE dbo.spReportVoids @From DATE, @To DATE, @CashierId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT u.FullName AS Cashier, COUNT(*) AS TotalSales,
           COUNT(CASE WHEN s.Status = 'Voided' THEN 1 END) AS Voids,
           SUM(CASE WHEN s.Status = 'Voided' THEN s.TotalAmount ELSE 0 END) AS VoidedAmount,
           CAST(100.0 * COUNT(CASE WHEN s.Status = 'Voided' THEN 1 END) / COUNT(*) AS DECIMAL(5,2)) AS VoidRatePct,
           SUM(CASE WHEN s.OverrideApprovedBy IS NOT NULL THEN 1 ELSE 0 END) AS PriceOverrides
    FROM dbo.Sales s JOIN dbo.Users u ON u.UserId = s.CashierId
    WHERE s.SaleDate >= @From AND s.SaleDate < DATEADD(DAY, 1, @To)
    GROUP BY u.FullName
    ORDER BY Voids DESC;
END
GO
CREATE OR ALTER PROCEDURE dbo.spReportPayments @From DATE, @To DATE, @CashierId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP (500) p.CreatedAt, s.InvoiceNo, p.PaymentMode, p.Reference AS GatewayToken, p.Amount, p.Status
    FROM dbo.Payments p JOIN dbo.Sales s ON s.SaleId = p.SaleId
    WHERE p.CreatedAt >= @From AND p.CreatedAt < DATEADD(DAY, 1, @To)
    ORDER BY p.CreatedAt DESC;
END
GO
CREATE OR ALTER PROCEDURE dbo.spDashboardSummary
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
      (SELECT ISNULL(SUM(TotalAmount), 0) FROM dbo.Sales WHERE Status = 'Paid' AND CAST(SaleDate AS DATE) = CAST(SYSDATETIME() AS DATE)) AS TodaySales,
      (SELECT COUNT(*) FROM dbo.Sales WHERE Status = 'Paid' AND CAST(SaleDate AS DATE) = CAST(SYSDATETIME() AS DATE)) AS TodayTransactions,
      (SELECT COUNT(*) FROM dbo.Products WHERE IsActive = 1) AS ActiveProducts,
      (SELECT COUNT(*) FROM dbo.Products WHERE IsActive = 1 AND QtyOnHand <= ReorderPoint) AS LowStockItems,
      (SELECT ISNULL(SUM(QtyOnHand * UnitCost), 0) FROM dbo.Products WHERE IsActive = 1) AS InventoryValue;
END
GO
