CREATE OR ALTER PROCEDURE dbo.spSupplierSave @SupplierId INT = NULL, @Name NVARCHAR(150), @ContactInfo NVARCHAR(300) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM dbo.Suppliers WHERE Name = @Name AND (@SupplierId IS NULL OR SupplierId <> @SupplierId))
        THROW 50004, 'A supplier with that name already exists.', 1;
    IF @SupplierId IS NULL OR @SupplierId = 0
    BEGIN
        INSERT dbo.Suppliers (Name, ContactInfo) VALUES (@Name, @ContactInfo);
        SET @SupplierId = SCOPE_IDENTITY();
    END
    ELSE
        UPDATE dbo.Suppliers SET Name = @Name, ContactInfo = @ContactInfo WHERE SupplierId = @SupplierId;
    SELECT @SupplierId AS SupplierId;
END
GO
