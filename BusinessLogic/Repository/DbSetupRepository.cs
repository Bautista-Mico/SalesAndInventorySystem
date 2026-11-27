
using Microsoft.Data.SqlClient;
using SalesInventory.BusinessLogic.Controller;
using SalesInventory.Model;
using System.Text.RegularExpressions;

namespace SalesInventory.BusinessLogic.Repository;

/// <summary>
/// Creates the database if needed and runs the scripts of the DB project in order:
/// Table -> View -> StoredProc -> PostScript. All scripts are idempotent, so this is safe on every start.
/// </summary>
public static class DbSetup
{
    private static readonly string[] Folders = { "Table", "View", "StoredProc", "PostScript" };

    public static void EnsureDatabase(string scriptRoot)
    {
        var builder = new SqlConnectionStringBuilder(Db.ConnectionString);
        var dbName = builder.InitialCatalog;
        if (string.IsNullOrWhiteSpace(dbName))
            throw new InvalidOperationException("The connection string must specify a Database (Initial Catalog).");

        builder.InitialCatalog = "master";
        using (var master = new SqlConnection(builder.ConnectionString))
        {
            master.Open();
            using var cmd = new SqlCommand(
                "IF DB_ID(@n) IS NULL BEGIN DECLARE @sql NVARCHAR(400) = N'CREATE DATABASE ' + QUOTENAME(@n); EXEC(@sql); END", master);
            cmd.Parameters.AddWithValue("@n", dbName);
            cmd.ExecuteNonQuery();
        }

        foreach (var folder in Folders)
        {
            var dir = Path.Combine(scriptRoot, folder);
            if (!Directory.Exists(dir)) throw new DirectoryNotFoundException("Database script folder not found: " + dir);
            foreach (var file in Directory.GetFiles(dir, "*.sql").OrderBy(f => f, StringComparer.OrdinalIgnoreCase))
                RunScript(file);
        }

        SeedDefaultUsers();
    }

    private static void RunScript(string file)
    {
        var text = File.ReadAllText(file);
        var batches = Regex.Split(text, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
        using var con = Db.Open();
        foreach (var batch in batches)
        {
            if (string.IsNullOrWhiteSpace(batch)) continue;
            try
            {
                using var cmd = new SqlCommand(batch, con) { CommandTimeout = 120 };
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new InvalidOperationException($"Script {Path.GetFileName(file)} failed: {ex.Message}", ex);
            }
        }
    }

    /// <summary>Demo accounts so the system can be used right after the first run. Change these passwords!</summary>
    private static void SeedDefaultUsers()
    {
        if (UserRepository.Count() > 0) return;
        void Add(string user, string email, string name, string role, string pw) =>
            UserRepository.Save(new User { Username = user, Email = email, FullName = name, Role = role, IsActive = true }, PasswordHasher.Hash(pw));

        Add("admin", "admin@school.local", "System Administrator", Roles.Administrator, "Admin@1234");
        Add("manager", "manager@school.local", "Store Manager", Roles.StoreManager, "Manager@1234");
        Add("cashier", "cashier@school.local", "Cashier One", Roles.Cashier, "Cashier@1234");
        Add("inventory", "inventory@school.local", "Inventory Specialist", Roles.InventoryStaff, "Inventory@1234");
    }
}
