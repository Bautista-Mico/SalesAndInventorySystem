CREATE OR ALTER PROCEDURE dbo.spAuditLogAdd @UserId INT = NULL, @Action NVARCHAR(60), @Details NVARCHAR(400) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT dbo.AuditLogs (UserId, Action, Details) VALUES (@UserId, @Action, @Details);
END
GO
