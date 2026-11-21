CREATE OR ALTER PROCEDURE dbo.spUserRecordFailedLogin @UserId INT, @MaxAttempts INT = 5, @LockMinutes INT = 15
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Users SET FailedAttempts = FailedAttempts + 1 WHERE UserId = @UserId;
    UPDATE dbo.Users
       SET LockoutEnd = DATEADD(MINUTE, @LockMinutes, SYSDATETIME()), FailedAttempts = 0
     WHERE UserId = @UserId AND FailedAttempts >= @MaxAttempts;
    SELECT FailedAttempts,
           CAST(CASE WHEN LockoutEnd IS NOT NULL AND LockoutEnd > SYSDATETIME() THEN 1 ELSE 0 END AS BIT) AS IsLocked
    FROM dbo.Users WHERE UserId = @UserId;
END
GO
