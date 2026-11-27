
using Microsoft.Data.SqlClient;
using SalesInventory.Model;
using System.Data;

namespace SalesInventory.BusinessLogic.Repository;

public static class ProductRepository
{
    public static List<Product> Search(string search, int? categoryId, bool includeInactive, bool lowStockOnly) =>
        Db.Query("dbo.spProductSearch",
                Db.P("@Search", string.IsNullOrWhiteSpace(search) ? null : search.Trim()),
                Db.P("@CategoryId", categoryId),
                Db.P("@IncludeInactive", includeInactive),
                Db.P("@LowStockOnly", lowStockOnly))
          .Rows.Cast<DataRow>().Select(Map).ToList();

    public static Product Get(int productId)
    {
        var dt = Db.Query("dbo.spProductGet", Db.P("@ProductId", productId));
        return dt.Rows.Count == 0 ? null : Map(dt.Rows[0]);
    }

    public static int Save(Product p, int userId)
    {
        var dt = Db.Query("dbo.spProductSave",
            Db.P("@ProductId", p.ProductId == 0 ? (object)null : p.ProductId),
            Db.P("@SKU", string.IsNullOrWhiteSpace(p.SKU) ? null : p.SKU.Trim()),
            Db.P("@Name", p.Name?.Trim()),
            Db.P("@Description", p.Description), Db.P("@Specification", p.Specification),
            Db.P("@CategoryId", p.CategoryId), Db.P("@SupplierId", p.SupplierId),
            Db.P("@UnitOfMeasure", p.UnitOfMeasure), Db.P("@UnitCost", p.UnitCost), Db.P("@SellingPrice", p.SellingPrice),
            Db.P("@TaxGroup", p.TaxGroup), Db.P("@DiscountEligible", p.DiscountEligible),
            Db.P("@ImagePath", p.ImagePath), Db.P("@StorageLocation", p.StorageLocation),
            Db.P("@QtyOnHand", p.QtyOnHand), Db.P("@ReorderPoint", p.ReorderPoint), Db.P("@UserId", userId));
        return Db.Val<int>(dt.Rows[0], "ProductId");
    }

    /// <summary>Returns "Deleted" or "Deactivated" (products with history are archived, never erased).</summary>
    public static string Delete(int productId, int userId) =>
        Db.Val<string>(Db.Query("dbo.spProductDelete", Db.P("@ProductId", productId), Db.P("@UserId", userId)).Rows[0], "Result");

    public static void SetActive(int productId, bool active) =>
        Db.Query("dbo.spProductSetActive", Db.P("@ProductId", productId), Db.P("@IsActive", active));

    public static List<Category> Categories() =>
        Db.Query("dbo.spCategoryGetAll").Rows.Cast<DataRow>()
          .Select(r => new Category { CategoryId = Db.Val<int>(r, "CategoryId"), Name = Db.Val<string>(r, "Name") }).ToList();

    public static int SaveCategory(string name) =>
        Db.Val<int>(Db.Query("dbo.spCategorySave", Db.P("@Name", name)).Rows[0], "CategoryId");

    public static List<Supplier> Suppliers() =>
        Db.Query("dbo.spSupplierGetAll").Rows.Cast<DataRow>()
          .Select(r => new Supplier { SupplierId = Db.Val<int>(r, "SupplierId"), Name = Db.Val<string>(r, "Name"), ContactInfo = Db.Val<string>(r, "ContactInfo") }).ToList();

    public static int SaveSupplier(Supplier s) =>
        Db.Val<int>(Db.Query("dbo.spSupplierSave",
            Db.P("@SupplierId", s.SupplierId == 0 ? (object)null : s.SupplierId),
            Db.P("@Name", s.Name), Db.P("@ContactInfo", s.ContactInfo)).Rows[0], "SupplierId");

    private static Product Map(DataRow r) => new()
    {
        ProductId = Db.Val<int>(r, "ProductId"),
        SKU = Db.Val<string>(r, "SKU"),
        Name = Db.Val<string>(r, "Name"),
        Description = Db.Val<string>(r, "Description"),
        Specification = Db.Val<string>(r, "Specification"),
        CategoryId = Db.Val<int>(r, "CategoryId"),
        CategoryName = Db.Val<string>(r, "CategoryName"),
        SupplierId = Db.Val<int?>(r, "SupplierId"),
        SupplierName = Db.Val<string>(r, "SupplierName"),
        UnitOfMeasure = Db.Val<string>(r, "UnitOfMeasure"),
        UnitCost = Db.Val<decimal>(r, "UnitCost"),
        SellingPrice = Db.Val<decimal>(r, "SellingPrice"),
        TaxGroup = Db.Val<string>(r, "TaxGroup"),
        DiscountEligible = Db.Val<bool>(r, "DiscountEligible"),
        ImagePath = Db.Val<string>(r, "ImagePath"),
        StorageLocation = Db.Val<string>(r, "StorageLocation"),
        QtyOnHand = Db.Val<int>(r, "QtyOnHand"),
        ReorderPoint = Db.Val<int>(r, "ReorderPoint"),
        IsActive = Db.Val<bool>(r, "IsActive")
    };
}
