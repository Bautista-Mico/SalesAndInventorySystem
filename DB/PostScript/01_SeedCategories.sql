INSERT dbo.Categories (Name)
SELECT v.Name FROM (VALUES (N'Textbooks'), (N'Uniforms'), (N'School Supplies'), (N'Office Supplies'), (N'School Merchandise')) AS v(Name)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Categories c WHERE c.Name = v.Name);
GO
