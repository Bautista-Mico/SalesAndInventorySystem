CREATE OR ALTER PROCEDURE dbo.spUserSetPassword @UserId INT, @PasswordHash NVARCHAR(200)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Users SET PasswordHash = @PasswordHash, FailedAttempts = 0, LockoutEnd = NULL WHERE UserId = @UserId;
END
GO
