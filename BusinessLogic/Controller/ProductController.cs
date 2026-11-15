using static System.Collections.Specialized.BitVector32;

namespace SalesInventory.BusinessLogic.Controller;

public class ProductController
{
    public static readonly string[] UnitsOfMeasure = { "Piece", "Pack", "Box", "Set" };
    public static readonly string[] TaxGroups = { "VAT", "Exempt" };

    public List<Product> Search(string text, int? categoryId, bool includeInactive, bool lowStockOnly) =>
        ProductRepository.Search(text, categoryId, includeInactive, lowStockOnly);

    public List<Category> Categories() => ProductRepository.Categories();
    public List<Supplier> Suppliers() => ProductRepository.Suppliers();

    public int AddCategory(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new BusinessRuleException("Category name is required.");
        return ProductRepository.SaveCategory(name.Trim());
    }

    public int AddSupplier(string name, string contact)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new BusinessRuleException("Supplier name is required.");
        return ProductRepository.SaveSupplier(new Supplier { Name = name.Trim(), ContactInfo = contact?.Trim() });
    }

    public int Save(Product p)
    {
        if (!Permissions.CanEditInventory && !Permissions.CanEditCatalog)
            throw new BusinessRuleException("You do not have permission to change product records.");
        if (string.IsNullOrWhiteSpace(p.Name)) throw new BusinessRuleException("Product name is mandatory.");
        if (p.CategoryId <= 0) throw new BusinessRuleException("Category is mandatory.");
        if (p.SellingPrice < 0) throw new BusinessRuleException("Retail selling price cannot be lower than 0.00.");
        if (p.UnitCost < 0) throw new BusinessRuleException("Unit cost cannot be negative.");
        if (p.QtyOnHand < 0) throw new BusinessRuleException("Inventory quantity cannot be negative.");
        if (p.ReorderPoint <= 0) throw new BusinessRuleException("Reorder point must be greater than zero.");
        return ProductRepository.Save(p, Session.Current.UserId);
    }

    /// <summary>Returns "Deleted" or "Deactivated".</summary>
    public string Delete(Product p) => ProductRepository.Delete(p.ProductId, Session.Current.UserId);

    public void Reactivate(Product p) => ProductRepository.SetActive(p.ProductId, true);

    /// <summary>Copies a chosen picture into the app's data folder so the catalog keeps working if the original moves.</summary>
    public string StoreImage(string sourcePath)
    {
        var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SalesInventory", "Images");
        Directory.CreateDirectory(dir);
        var dest = Path.Combine(dir, Guid.NewGuid().ToString("N") + Path.GetExtension(sourcePath));
        File.Copy(sourcePath, dest);
        return dest;
    }
}
