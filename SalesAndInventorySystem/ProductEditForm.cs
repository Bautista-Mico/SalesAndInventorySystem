using UI;

namespace SalesInventory.UI;

public partial class ProductEditForm : Form
{
    private readonly ProductController _ctl = new();
    private readonly Product _p;
    private readonly bool _isNew;
    private string _imagePath;

    public ProductEditForm() : this(null) { }

    public ProductEditForm(Product p)
    {
        InitializeComponent();
        _isNew = p == null; _p = p ?? new Product();
        Text = _isNew ? "Add product" : "Edit product";

        cmbUom.Items.AddRange(ProductController.UnitsOfMeasure.Cast<object>().ToArray()); cmbUom.SelectedIndex = 0;
        cmbTax.Items.AddRange(ProductController.TaxGroups.Cast<object>().ToArray()); cmbTax.SelectedIndex = 0;

        if (Ui.InDesigner) return;
        var cats = _ctl.Categories(); cmbCategory.DataSource = cats;
        var sups = _ctl.Suppliers(); sups.Insert(0, new Supplier { SupplierId = 0, Name = "(none)" }); cmbSupplier.DataSource = sups;

        Populate(_p);
    }

    private void btnNewCategory_Click(object sender, EventArgs e) => NewCategory();
    private void btnNewSupplier_Click(object sender, EventArgs e) => NewSupplier();
    private void btnBrowse_Click(object sender, EventArgs e) => Browse();
    private void btnSave_Click(object sender, EventArgs e) => Save();

    private void Populate(Product p)
    {
        txtSku.Text = p.SKU; txtName.Text = p.Name; txtDescription.Text = p.Description; txtSpec.Text = p.Specification; txtLocation.Text = p.StorageLocation;
        if (!_isNew)
        {
            cmbCategory.SelectedItem = ((List<Category>)cmbCategory.DataSource).FirstOrDefault(c => c.CategoryId == p.CategoryId);
            cmbSupplier.SelectedItem = ((List<Supplier>)cmbSupplier.DataSource).FirstOrDefault(s => s.SupplierId == (p.SupplierId ?? 0));
            cmbUom.SelectedItem = p.UnitOfMeasure; cmbTax.SelectedItem = p.TaxGroup;
            numCost.Value = p.UnitCost; numPrice.Value = p.SellingPrice; numQty.Value = p.QtyOnHand; numReorder.Value = Math.Max(1, p.ReorderPoint);
            chkDiscount.Checked = p.DiscountEligible; _imagePath = p.ImagePath;
            try { if (!string.IsNullOrEmpty(p.ImagePath) && File.Exists(p.ImagePath)) { using var fs0 = new FileStream(p.ImagePath, FileMode.Open, FileAccess.Read); using var tmp0 = Image.FromStream(fs0); picProduct.Image = new Bitmap(tmp0); } } catch { }
        }
        // Who may change what
        txtSku.ReadOnly = !_isNew;
        numQty.Enabled = _isNew;                               // later quantity changes go through Stock Update (with reason codes)
        bool canPrice = Permissions.CanEditCatalog || _isNew; // inventory staff may price new items but not re-price existing ones
        numPrice.Enabled = cmbTax.Enabled = chkDiscount.Enabled = canPrice;
        numCost.Enabled = Permissions.CanViewCost;
    }

    private void NewCategory() => Ui.Guard(() =>
    {
        var n = PromptForm.Ask(this, "New category", "Category name:"); if (n == null) return;
        var id = _ctl.AddCategory(n);
        var cats = _ctl.Categories(); cmbCategory.DataSource = cats; cmbCategory.SelectedItem = cats.First(c => c.CategoryId == id);
    });

    private void NewSupplier() => Ui.Guard(() =>
    {
        var n = PromptForm.Ask(this, "New supplier", "Supplier name:"); if (n == null) return;
        var c = PromptForm.Ask(this, "New supplier", "Contact information (person, phone, email):") ?? "";
        var id = _ctl.AddSupplier(n, c);
        var sups = _ctl.Suppliers(); sups.Insert(0, new Supplier { SupplierId = 0, Name = "(none)" }); cmbSupplier.DataSource = sups;
        cmbSupplier.SelectedItem = sups.First(s => s.SupplierId == id);
    });

    private void Browse() => Ui.Guard(() =>
    {
        using var dlg = new OpenFileDialog { Filter = "Images|*.png;*.jpg;*.jpeg;*.bmp;*.gif" };
        if (dlg.ShowDialog(this) != DialogResult.OK) return;
        _imagePath = _ctl.StoreImage(dlg.FileName);
        picProduct.Image?.Dispose();
        using var fs = new FileStream(_imagePath, FileMode.Open, FileAccess.Read);
        using var tmp = Image.FromStream(fs);
        picProduct.Image = new Bitmap(tmp);
    });

    private void Save() => Ui.Guard(() =>
    {
        var sup = cmbSupplier.SelectedItem as Supplier;
        var p = new Product
        {
            ProductId = _p.ProductId,
            SKU = txtSku.Text,
            Name = txtName.Text,
            Description = txtDescription.Text,
            Specification = txtSpec.Text,
            CategoryId = (cmbCategory.SelectedItem as Category)?.CategoryId ?? 0,
            SupplierId = sup == null || sup.SupplierId == 0 ? null : sup.SupplierId,
            UnitOfMeasure = cmbUom.Text,
            UnitCost = numCost.Value,
            SellingPrice = numPrice.Value,
            TaxGroup = cmbTax.Text,
            DiscountEligible = chkDiscount.Checked,
            ImagePath = _imagePath,
            StorageLocation = txtLocation.Text,
            QtyOnHand = (int)numQty.Value,
            ReorderPoint = (int)numReorder.Value
        };
        // Fields the user may not change keep their stored values.
        if (!_isNew && !(Permissions.CanEditCatalog)) { p.SellingPrice = _p.SellingPrice; p.TaxGroup = _p.TaxGroup; p.DiscountEligible = _p.DiscountEligible; }
        if (!Permissions.CanViewCost) p.UnitCost = _p.UnitCost;
        _ctl.Save(p);
        DialogResult = DialogResult.OK;
    });
}
