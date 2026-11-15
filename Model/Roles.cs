namespace SalesInventory.Model;

public static class Roles
{
    public const string Administrator = "Administrator";
    public const string StoreManager = "StoreManager";
    public const string Cashier = "Cashier";
    public const string InventoryStaff = "InventoryStaff";

    public static readonly string[] All = { Administrator, StoreManager, Cashier, InventoryStaff };

    public static string Display(string role) => role switch
    {
        StoreManager => "Store Manager",
        InventoryStaff => "Inventory Staff",
        _ => role
    };
}
