IF OBJECT_ID('dbo.Suppliers', 'U') IS NULL
CREATE TABLE dbo.Suppliers
(
    SupplierId  INT IDENTITY(1,1) PRIMARY KEY,
    Name        NVARCHAR(150) NOT NULL,
    ContactInfo NVARCHAR(300) NULL,
    CONSTRAINT UQ_Suppliers_Name UNIQUE (Name)
);
GO
