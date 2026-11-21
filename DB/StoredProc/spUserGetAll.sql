CREATE OR ALTER PROCEDURE dbo.spUserGetAll @Search NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT UserId, Username, Email, FullName, PasswordHash, Role, IsActive, FailedAttempts, LockoutEnd, LastLoginAt,
           CAST(CASE WHEN LockoutEnd IS NOT NULL AND LockoutEnd > SYSDATETIME() THEN 1 ELSE 0 END AS BIT) AS IsLocked
    FROM dbo.Users
    WHERE @Search IS NULL OR @Search = ''
       OR Username LIKE '%' + @Search + '%' OR FullName LIKE '%' + @Search + '%' OR Email LIKE '%' + @Search + '%'
    ORDER BY FullName;
END
GO
