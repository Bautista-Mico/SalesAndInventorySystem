IF OBJECT_ID('dbo.Categories', 'U') IS NULL
CREATE TABLE dbo.Categories
(
    CategoryId INT IDENTITY(1,1) PRIMARY KEY,
    Name       NVARCHAR(100) NOT NULL,
    CONSTRAINT UQ_Categories_Name UNIQUE (Name)
);
GO
