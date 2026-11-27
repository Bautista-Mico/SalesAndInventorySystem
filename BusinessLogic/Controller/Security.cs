using SalesInventory.Model;
using System.Security.Cryptography;

namespace SalesInventory.BusinessLogic.Controller;

public static class PasswordHasher
{
    private const int Iterations = 100_000;

    public static string Hash(string password)
    {
        var salt = RandomNumberGenerator.GetBytes(16);
        var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, 32);
        return Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
    }

    public static bool Verify(string password, string stored)
    {
        if (string.IsNullOrEmpty(stored)) return false;
        var parts = stored.Split(':');
        if (parts.Length != 2) return false;
        var salt = Convert.FromBase64String(parts[0]);
        var expected = Convert.FromBase64String(parts[1]);
        var actual = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, expected.Length);
        return CryptographicOperations.FixedTimeEquals(actual, expected);
    }
}

/// <summary>The signed-in user for this terminal.</summary>
public static class Session
{
    public static User Current { get; set; }
    public static bool InRole(params string[] roles) => Current != null && roles.Contains(Current.Role);
}

/// <summary>Role-based access rules used by the UI (and re-checked by controllers where it matters).</summary>
public static class Permissions
{
    public static bool CanSell => Session.InRole(Roles.Administrator, Roles.StoreManager, Roles.Cashier);
    public static bool CanEditCatalog => Session.InRole(Roles.Administrator, Roles.StoreManager);
    public static bool CanEditInventory => Session.InRole(Roles.Administrator, Roles.StoreManager, Roles.InventoryStaff);
    public static bool CanViewCost => Session.InRole(Roles.Administrator, Roles.StoreManager, Roles.InventoryStaff);
    public static bool CanViewReports => Session.InRole(Roles.Administrator, Roles.StoreManager);
    public static bool CanViewTransactions => Session.InRole(Roles.Administrator, Roles.StoreManager, Roles.Cashier);
    public static bool CanManageUsers => Session.InRole(Roles.Administrator);
    public static bool CanVoid => Session.InRole(Roles.Administrator);
}
