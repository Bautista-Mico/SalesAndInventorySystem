IF OBJECT_ID('dbo.Users', 'U') IS NULL
CREATE TABLE dbo.Users
(
    UserId         INT IDENTITY(1,1) PRIMARY KEY,
    Username       NVARCHAR(50)  NOT NULL,
    Email          NVARCHAR(120) NOT NULL,
    FullName       NVARCHAR(120) NOT NULL,
    PasswordHash   NVARCHAR(200) NOT NULL,
    Role           NVARCHAR(30)  NOT NULL CHECK (Role IN ('Administrator','StoreManager','Cashier','InventoryStaff')),
    IsActive       BIT           NOT NULL DEFAULT 1,
    FailedAttempts INT           NOT NULL DEFAULT 0,
    LockoutEnd     DATETIME2     NULL,
    LastLoginAt    DATETIME2     NULL,
    CreatedAt      DATETIME2     NOT NULL DEFAULT SYSDATETIME(),
    CONSTRAINT UQ_Users_Username UNIQUE (Username),
    CONSTRAINT UQ_Users_Email UNIQUE (Email)
);
GO
