CREATE OR ALTER PROCEDURE dbo.spCategorySave @Name NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM dbo.Categories WHERE Name = @Name)
        INSERT dbo.Categories (Name) VALUES (@Name);
    SELECT CategoryId FROM dbo.Categories WHERE Name = @Name;
END
GO
