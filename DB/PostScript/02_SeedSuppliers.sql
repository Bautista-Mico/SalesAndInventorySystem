INSERT dbo.Suppliers (Name, ContactInfo)
SELECT v.Name, v.Contact FROM (VALUES
    (N'Rex Book Supply',        N'Maria Cruz - 0917 000 0001 - orders@rexbooks.example'),
    (N'Uniform Hub Trading',    N'Jose Reyes - 0917 000 0002 - sales@uniformhub.example'),
    (N'Metro Office Depot',     N'Ana Lim - 0917 000 0003 - b2b@metrooffice.example')
) AS v(Name, Contact)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Suppliers s WHERE s.Name = v.Name);
GO
