IF OBJECT_ID('dbo.AuditLogs', 'U') IS NULL
CREATE TABLE dbo.AuditLogs
(
    AuditId   INT IDENTITY(1,1) PRIMARY KEY,
    UserId    INT           NULL,
    Action    NVARCHAR(60)  NOT NULL,
    Details   NVARCHAR(400) NULL,
    CreatedAt DATETIME2     NOT NULL DEFAULT SYSDATETIME()
);
GO
