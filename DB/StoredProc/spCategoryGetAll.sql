CREATE OR ALTER PROCEDURE dbo.spCategoryGetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT CategoryId, Name FROM dbo.Categories ORDER BY Name;
END
GO
