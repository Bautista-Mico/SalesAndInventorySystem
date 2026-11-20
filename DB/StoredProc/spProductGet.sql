CREATE OR ALTER PROCEDURE dbo.spProductGet @ProductId INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM dbo.vwProductInventory WHERE ProductId = @ProductId;
END
GO
