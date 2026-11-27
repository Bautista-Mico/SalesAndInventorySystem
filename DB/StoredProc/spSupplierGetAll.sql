CREATE OR ALTER PROCEDURE dbo.spSupplierGetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT SupplierId, Name, ContactInfo FROM dbo.Suppliers ORDER BY Name;
END
GO
