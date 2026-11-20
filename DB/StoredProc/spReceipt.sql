CREATE OR ALTER PROCEDURE dbo.spReceiptSave
    @SaleId INT, @InvoiceNo NVARCHAR(30), @OutputFormat NVARCHAR(30), @Destination NVARCHAR(150) = NULL,
    @TaxInfo NVARCHAR(150) = NULL, @Content NVARCHAR(MAX), @IsDuplicate BIT = 0,
    @DeliveryStatus NVARCHAR(40) = 'Generated', @Note NVARCHAR(200) = NULL, @CreatedBy INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT dbo.Receipts (SaleId, InvoiceNo, OutputFormat, Destination, TaxInfo, Content, IsDuplicate, DeliveryStatus, Note, CreatedBy)
    VALUES (@SaleId, @InvoiceNo, @OutputFormat, @Destination, @TaxInfo, @Content, @IsDuplicate, @DeliveryStatus, @Note, @CreatedBy);
    SELECT SCOPE_IDENTITY() AS ReceiptId;
END
GO
CREATE OR ALTER PROCEDURE dbo.spReceiptList @Search NVARCHAR(100) = NULL, @DuplicatesOnly BIT = 0
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP (500) r.ReceiptId, r.InvoiceNo, r.OutputFormat, r.Destination, r.TaxInfo,
           CASE WHEN r.IsDuplicate = 1 THEN 'Yes' ELSE 'No' END AS Duplicate,
           r.DeliveryStatus, r.Note, u.FullName AS CreatedBy, r.CreatedAt
    FROM dbo.Receipts r JOIN dbo.Users u ON u.UserId = r.CreatedBy
    WHERE (@Search IS NULL OR @Search = '' OR r.InvoiceNo LIKE '%' + @Search + '%')
      AND (@DuplicatesOnly = 0 OR r.IsDuplicate = 1)
    ORDER BY r.CreatedAt DESC;
END
GO
CREATE OR ALTER PROCEDURE dbo.spReceiptOriginalTax @SaleId INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP (1) TaxInfo FROM dbo.Receipts WHERE SaleId = @SaleId AND IsDuplicate = 0 ORDER BY ReceiptId DESC;
END
GO
