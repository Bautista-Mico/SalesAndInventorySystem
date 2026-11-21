CREATE OR ALTER PROCEDURE dbo.spProductSetActive @ProductId INT, @IsActive BIT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Products SET IsActive = @IsActive, UpdatedAt = SYSDATETIME() WHERE ProductId = @ProductId;
END
GO
