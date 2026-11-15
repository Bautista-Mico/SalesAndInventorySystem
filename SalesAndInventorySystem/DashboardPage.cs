namespace SalesInventory.UI;

public partial class DashboardPage : BasePage
{
    private readonly MainForm _owner;
    private readonly ReportController _reports = new();
    private readonly ProductController _products = new();

    public override string PageTitle => "Dashboard";

    public DashboardPage() : this(null) { }

    public DashboardPage(MainForm owner)
    {
        InitializeComponent();
        _owner = owner;
        dgvLowStock.AutoGenerateColumns = false;
        pnlKpiValue.Visible = Permissions.CanViewCost;   // cost figures are role-restricted
        btnNewSale.Visible = Permissions.CanSell;
    }

    private void btnNewSale_Click(object sender, EventArgs e) => _owner.Navigate("pos");
    private void btnCatalog_Click(object sender, EventArgs e) => _owner.Navigate("catalog");
    private void btnStockUpdate_Click(object sender, EventArgs e) => _owner.Navigate("stock");

    public override void OnActivated() => Ui.Guard(() =>
    {
        var d = _reports.Dashboard();
        lblSales.Text = Ui.Money(d.TodaySales); lblTransactions.Text = d.TodayTransactions.ToString(); lblProducts.Text = d.ActiveProducts.ToString();
        lblLowStock.Text = d.LowStockItems.ToString(); lblValue.Text = Ui.Money(d.InventoryValue);
        dgvLowStock.DataSource = _products.Search(null, null, false, true);
    });
}
