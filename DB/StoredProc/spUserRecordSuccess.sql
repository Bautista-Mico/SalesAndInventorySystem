CREATE OR ALTER PROCEDURE dbo.spUserRecordSuccess @UserId INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Users SET FailedAttempts = 0, LockoutEnd = NULL, LastLoginAt = SYSDATETIME() WHERE UserId = @UserId;
END
GO
