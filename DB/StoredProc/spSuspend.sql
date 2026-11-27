CREATE OR ALTER PROCEDURE dbo.spSuspendSave
    @CashierId INT, @CustomerType NVARCHAR(20), @CustomerRef NVARCHAR(50) = NULL, @CartJson NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT dbo.SuspendedTransactions (CashierId, CustomerType, CustomerRef, CartJson)
    VALUES (@CashierId, @CustomerType, @CustomerRef, @CartJson);
    SELECT SCOPE_IDENTITY() AS SuspendedId;
END
GO
CREATE OR ALTER PROCEDURE dbo.spSuspendList @CashierId INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT SuspendedId, CustomerType, CustomerRef, CartJson, CreatedAt
    FROM dbo.SuspendedTransactions WHERE CashierId = @CashierId ORDER BY CreatedAt DESC;
END
GO
CREATE OR ALTER PROCEDURE dbo.spSuspendDelete @SuspendedId INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE dbo.SuspendedTransactions WHERE SuspendedId = @SuspendedId;
END
GO
