CREATE OR ALTER PROCEDURE dbo.spUserLogin @Login NVARCHAR(120)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT UserId, Username, Email, FullName, PasswordHash, Role, IsActive, FailedAttempts, LockoutEnd, LastLoginAt,
           CAST(CASE WHEN LockoutEnd IS NOT NULL AND LockoutEnd > SYSDATETIME() THEN 1 ELSE 0 END AS BIT) AS IsLocked
    FROM dbo.Users
    WHERE Username = @Login OR Email = @Login;
END
GO
