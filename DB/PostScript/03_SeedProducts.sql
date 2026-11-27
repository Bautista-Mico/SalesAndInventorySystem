INSERT dbo.Products (SKU, Name, Description, Specification, CategoryId, SupplierId, UnitOfMeasure, UnitCost, SellingPrice,
                     TaxGroup, DiscountEligible, StorageLocation, QtyOnHand, ReorderPoint)
SELECT v.SKU, v.Name, v.Descr, v.Spec, c.CategoryId, s.SupplierId, v.Uom, v.Cost, v.Price, v.Tax, v.Disc, v.Loc, v.Qty, v.Reorder
FROM (VALUES
 ('TXT-0001', N'Grade 7 English Textbook',    N'Core English textbook',          N'Edition 2026',        N'Textbooks',         N'Rex Book Supply',     N'Piece', 320.00, 450.00, 'Exempt', 1, N'Warehouse A, Shelf B1', 40, 10),
 ('TXT-0002', N'Grade 7 Science Textbook',    N'Core Science textbook',          N'Edition 2026',        N'Textbooks',         N'Rex Book Supply',     N'Piece', 340.00, 480.00, 'Exempt', 1, N'Warehouse A, Shelf B1', 35, 10),
 ('TXT-0003', N'Grade 8 Mathematics Textbook',N'Core Mathematics textbook',      N'Edition 2026',        N'Textbooks',         N'Rex Book Supply',     N'Piece', 330.00, 465.00, 'Exempt', 1, N'Warehouse A, Shelf B2', 8,  10),
 ('UNI-0001', N'Polo Shirt (Small)',          N'School polo shirt',              N'Size S, White',       N'Uniforms',          N'Uniform Hub Trading', N'Piece', 180.00, 285.00, 'VAT',    1, N'Warehouse A, Rack U1',  50, 15),
 ('UNI-0002', N'Polo Shirt (Medium)',         N'School polo shirt',              N'Size M, White',       N'Uniforms',          N'Uniform Hub Trading', N'Piece', 190.00, 295.00, 'VAT',    1, N'Warehouse A, Rack U1',  60, 15),
 ('UNI-0003', N'PE Jogging Pants (Large)',    N'Physical education uniform',     N'Size L, Navy',        N'Uniforms',          N'Uniform Hub Trading', N'Piece', 220.00, 340.00, 'VAT',    1, N'Warehouse A, Rack U2',  25, 10),
 ('SUP-0001', N'Notebook 80 Leaves',          N'Ruled notebook',                 N'80 leaves, Brand: Sunrise', N'School Supplies', N'Metro Office Depot', N'Piece', 18.00,  30.00,  'VAT',    0, N'Warehouse B, Shelf S1', 200, 50),
 ('SUP-0002', N'Ballpen Blue (Box of 12)',    N'Ballpoint pens',                 N'0.7mm, Blue',         N'School Supplies',   N'Metro Office Depot',  N'Box',   60.00,  95.00,  'VAT',    0, N'Warehouse B, Shelf S2', 40, 10),
 ('SUP-0003', N'Pad Paper (Pack of 10)',      N'Intermediate pad paper',         N'Short, 80 sheets',    N'School Supplies',   N'Metro Office Depot',  N'Pack',  70.00,  110.00, 'VAT',    0, N'Warehouse B, Shelf S2', 5,  12),
 ('OFF-0001', N'A4 Bond Paper (Ream)',        N'Copy paper',                     N'A4, 70gsm, 500 sheets', N'Office Supplies', N'Metro Office Depot',  N'Pack',  220.00, 295.00, 'VAT',    0, N'Warehouse B, Shelf O1', 30, 10),
 ('MER-0001', N'School Logo Tote Bag',        N'Canvas tote bag with school logo',N'Natural canvas',     N'School Merchandise',N'Uniform Hub Trading', N'Piece', 90.00,  165.00, 'VAT',    1, N'Warehouse A, Shelf M1', 45, 10),
 ('MER-0002', N'School ID Lanyard',           N'Printed ID lanyard',             N'Blue, 20mm',          N'School Merchandise',N'Uniform Hub Trading', N'Piece', 25.00,  50.00,  'VAT',    1, N'Warehouse A, Shelf M1', 120, 30)
) AS v(SKU, Name, Descr, Spec, Cat, Sup, Uom, Cost, Price, Tax, Disc, Loc, Qty, Reorder)
JOIN dbo.Categories c ON c.Name = v.Cat
LEFT JOIN dbo.Suppliers s ON s.Name = v.Sup
WHERE NOT EXISTS (SELECT 1 FROM dbo.Products p WHERE p.SKU = v.SKU);
GO

-- Opening ledger entry for any product that has no movement yet
INSERT dbo.StockMovements (ProductId, ActionType, Quantity, QtyBefore, QtyAfter, Location, Reference, Reason, UserId)
SELECT p.ProductId, 'Initial Stock', p.QtyOnHand, 0, p.QtyOnHand, p.StorageLocation, p.SKU, 'Seed data', NULL
FROM dbo.Products p
WHERE p.QtyOnHand > 0 AND NOT EXISTS (SELECT 1 FROM dbo.StockMovements m WHERE m.ProductId = p.ProductId);
GO

BEGIN TRAN;
EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL';
DELETE dbo.Receipts;
DELETE dbo.Payments;
DELETE dbo.SaleItems;
DELETE dbo.Sales;
DELETE dbo.StockMovements;
DELETE dbo.Products;
EXEC sp_MSforeachtable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL';
COMMIT;