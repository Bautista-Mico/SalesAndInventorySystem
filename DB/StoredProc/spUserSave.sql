CREATE OR ALTER PROCEDURE dbo.spUserSave
    @UserId INT = NULL, @Username NVARCHAR(50), @Email NVARCHAR(120), @FullName NVARCHAR(120),
    @Role NVARCHAR(30), @IsActive BIT = 1, @PasswordHash NVARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM dbo.Users WHERE Username = @Username AND (@UserId IS NULL OR UserId <> @UserId))
        THROW 50001, 'That username is already taken.', 1;
    IF EXISTS (SELECT 1 FROM dbo.Users WHERE Email = @Email AND (@UserId IS NULL OR UserId <> @UserId))
        THROW 50002, 'That email address is already registered.', 1;

    IF @UserId IS NULL OR @UserId = 0
    BEGIN
        IF @PasswordHash IS NULL THROW 50003, 'A password is required for a new user.', 1;
        INSERT dbo.Users (Username, Email, FullName, PasswordHash, Role, IsActive)
        VALUES (@Username, @Email, @FullName, @PasswordHash, @Role, @IsActive);
        SET @UserId = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        UPDATE dbo.Users
           SET Username = @Username, Email = @Email, FullName = @FullName, Role = @Role, IsActive = @IsActive,
               PasswordHash = ISNULL(@PasswordHash, PasswordHash)
         WHERE UserId = @UserId;
    END
    SELECT @UserId AS UserId;
END
GO
