namespace SalesInventory.UI;

/// <summary>
/// Product Catalog (pricing view) and Product Inventory (stock / cost view) share one layout:
/// search + filter on top, grid in the middle, action buttons at the bottom (see the sketches).
/// The grid columns differ per mode, so they are added in code; everything else is in the designer.
/// </summary>
public partial class ProductsPage : BasePage
{
    private readonly ProductsMode _mode;
    private readonly ProductController _ctl = new();
    private bool _loading;

    public override string PageTitle => _mode == ProductsMode.Catalog ? "Product Catalog" : "Inventory";

    public ProductsPage() : this(ProductsMode.Catalog) { }

    public ProductsPage(ProductsMode mode)
    {
        InitializeComponent();
        _mode = mode;
        chkLowStock.Visible = mode == ProductsMode.Inventory;

        dgvProducts.AutoGenerateColumns = false;
        Ui.Col(dgvProducts, "SKU", "SKU", null, 0.9f);
        Ui.Col(dgvProducts, "Product", "Name", null, 2.2f);
        Ui.Col(dgvProducts, "Category", "CategoryName", null, 1.2f);
        if (mode == ProductsMode.Catalog)
        {
            Ui.Col(dgvProducts, "Specification", "Specification", null, 1.4f);
            Ui.Col(dgvProducts, "Price", "SellingPrice", "N2", 0.8f, true);
            Ui.Col(dgvProducts, "Tax", "TaxGroup", null, 0.6f);
            Ui.Col(dgvProducts, "Discount", "DiscountText", null, 0.7f);
            Ui.Col(dgvProducts, "Status", "StatusText", null, 0.8f);
        }
        else
        {
            Ui.Col(dgvProducts, "UoM", "UnitOfMeasure", null, 0.6f);
            if (Permissions.CanViewCost) Ui.Col(dgvProducts, "Unit cost", "UnitCost", "N2", 0.8f, true);
            Ui.Col(dgvProducts, "On hand", "QtyOnHand", null, 0.7f, true);
            Ui.Col(dgvProducts, "Reorder pt", "ReorderPoint", null, 0.7f, true);
            if (Permissions.CanViewCost) Ui.Col(dgvProducts, "Value", "InventoryValue", "N2", 0.9f, true);
            Ui.Col(dgvProducts, "Location", "StorageLocation", null, 1.4f);
            Ui.Col(dgvProducts, "Supplier", "SupplierName", null, 1.2f);
            Ui.Col(dgvProducts, "Status", "StatusText", null, 0.8f);
        }
        dgvProducts.DataBindingComplete += (s, e) => Colorize();
        dgvProducts.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) Edit(); };
        txtSearch.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; Reload(); } };
        cmbCategory.SelectedIndexChanged += (s, e) => Reload();
        chkInactive.CheckedChanged += (s, e) => Reload();
        chkLowStock.CheckedChanged += (s, e) => Reload();

        bool canEdit = mode == ProductsMode.Catalog ? Permissions.CanEditCatalog : Permissions.CanEditInventory;
        btnAdd.Text = mode == ProductsMode.Catalog ? "Add product" : "Add item";
        btnAdd.Visible = btnEdit.Visible = btnDelete.Visible = btnReactivate.Visible = canEdit;
    }

    private void btnSearch_Click(object sender, EventArgs e) => Reload();
    private void btnAdd_Click(object sender, EventArgs e) => Add();
    private void btnEdit_Click(object sender, EventArgs e) => Edit();
    private void btnDelete_Click(object sender, EventArgs e) => Delete();
    private void btnReactivate_Click(object sender, EventArgs e) => Reactivate();
    private void btnRefresh_Click(object sender, EventArgs e) => Reload();

    public override void OnActivated() => Ui.Guard(() =>
    {
        _loading = true;
        var cats = _ctl.Categories();
        cats.Insert(0, new Category { CategoryId = 0, Name = "All categories" });
        var keep = (cmbCategory.SelectedItem as Category)?.CategoryId ?? 0;
        cmbCategory.DataSource = cats;
        cmbCategory.SelectedItem = cats.FirstOrDefault(c => c.CategoryId == keep) ?? cats[0];
        _loading = false;
        Reload();
    });

    private void Reload() => Ui.Guard(() =>
    {
        if (_loading) return;
        var cat = (cmbCategory.SelectedItem as Category)?.CategoryId ?? 0;
        dgvProducts.DataSource = _ctl.Search(txtSearch.Text, cat == 0 ? null : cat, chkInactive.Checked, chkLowStock.Checked);
    });

    private void Colorize()
    {
        foreach (DataGridViewRow r in dgvProducts.Rows)
        {
            if (r.DataBoundItem is not Product p) continue;
            if (!p.IsActive) r.DefaultCellStyle.ForeColor = Theme.Muted;
            else if (_mode == ProductsMode.Inventory && p.IsLowStock) r.DefaultCellStyle.BackColor = Theme.Warn;
        }
    }

    private Product Selected => dgvProducts.CurrentRow?.DataBoundItem as Product;

    private void Add() => Ui.Guard(() => { using var f = new ProductEditForm(null); if (f.ShowDialog(this) == DialogResult.OK) Reload(); });

    private void Edit() => Ui.Guard(() =>
    {
        var p = Selected; if (p == null) throw new BusinessRuleException("Select a product first.");
        if (!(_mode == ProductsMode.Catalog ? Permissions.CanEditCatalog : Permissions.CanEditInventory)) return;
        using var f = new ProductEditForm(p); if (f.ShowDialog(this) == DialogResult.OK) Reload();
    });

    private void Delete() => Ui.Guard(() =>
    {
        var p = Selected; if (p == null) throw new BusinessRuleException("Select a product first.");
        if (!Ui.Confirm($"Delete \"{p.Name}\"?\n\nProducts that already have sales or stock history are archived (set inactive) instead of erased.")) return;
        var result = _ctl.Delete(p);
        Ui.Info(result == "Deleted" ? "The product was deleted." : "The product has history, so it was set to inactive to keep the accounting trail intact.");
        Reload();
    });

    private void Reactivate() => Ui.Guard(() =>
    {
        var p = Selected; if (p == null) throw new BusinessRuleException("Select a product first.");
        if (p.IsActive) throw new BusinessRuleException("That product is already active.");
        _ctl.Reactivate(p); Reload();
    });
}
