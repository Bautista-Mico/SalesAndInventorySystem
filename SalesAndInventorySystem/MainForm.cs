using static System.Collections.Specialized.BitVector32;

namespace SalesInventory.UI;

public partial class MainForm : Form, IMessageFilter
{
    public bool LogoutRequested { get; private set; }

    private readonly Dictionary<string, Button> _buttons = new();
    private readonly Dictionary<string, BasePage> _pages = new();
    private readonly Dictionary<string, Func<BasePage>> _factories = new();
    private readonly AuthController _auth = new();
    private DateTime _lastActivity = DateTime.Now;
    private string _current;

    public MainForm()
    {
        InitializeComponent();
        if (Ui.InDesigner) return;
        var user = Session.Current;
        lblUser.Text = user.FullName + "\n" + user.RoleDisplay;

        // The sidebar buttons depend on the signed-in role, so they are the one part built in code.
        var items = new List<(string Key, string Text, bool Visible, Func<BasePage> Make)>
        {
            ("dash", "Dashboard", true, () => new DashboardPage(this)),
            ("pos", "Point of Sale", Permissions.CanSell, () => new PosPage()),
            ("catalog", "Product Catalog", true, () => new ProductsPage(ProductsMode.Catalog)),
            ("inventory", "Inventory", Permissions.CanEditInventory, () => new ProductsPage(ProductsMode.Inventory)),
            ("stock", "Stock Update", true, () => new StockPage()),
            ("trans", "Receipts & Transactions", Permissions.CanViewTransactions, () => new TransactionsPage()),
            ("reports", "Reports & Analytics", Permissions.CanViewReports, () => new ReportsPage()),
            ("users", "Users", Permissions.CanManageUsers, () => new UsersPage()),
        };
        foreach (var (key, text, visible, make) in items)
        {
            if (!visible) continue;
            var k = key;
            var b = new Button
            {
                Text = "  " + text.Replace("&", "&&"),
                Width = 210,
                Height = 42,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Theme.Navy,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = Theme.Base,
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 0, 0, 4)
            };
            b.FlatAppearance.BorderSize = 0;
            b.Click += (s, e) => Navigate(k);
            _buttons[key] = b; _factories[key] = make; flpNav.Controls.Add(b);
        }

        idleTimer.Tick += (s, e) => CheckIdle();
        Load += (s, e) =>
        {
            Application.AddMessageFilter(this);
            idleTimer.Start();
            // Role-based landing screen
            Navigate(user.Role switch
            {
                Roles.Cashier => "pos",
                Roles.StoreManager => "inventory",
                Roles.InventoryStaff => "inventory",
                _ => "dash"
            });
        };
        FormClosed += (s, e) => { Application.RemoveMessageFilter(this); idleTimer.Stop(); };
    }

    private void btnLogout_Click(object sender, EventArgs e) => Logout("Logout");

    public void Navigate(string key)
    {
        if (!_factories.ContainsKey(key)) return;
        if (!_pages.TryGetValue(key, out var page)) { page = _factories[key](); _pages[key] = page; }
        pnlContent.Controls.Clear();
        pnlContent.Controls.Add(page);
        _current = key;
        foreach (var kv in _buttons) kv.Value.BackColor = kv.Key == key ? Theme.Accent : Theme.Navy;
        lblTitle.Text = page.PageTitle;
        page.OnActivated();
    }

    private void Logout(string reason, string notice = null)
    {
        if (_pages.TryGetValue("pos", out var p) && p is PosPage pos) pos.AutoSuspend();
        _auth.Logout(reason);
        Program.LoginNotice = notice;
        LogoutRequested = true;
        Close();
    }

    // ---- 15-minute inactivity timeout ----
    public bool PreFilterMessage(ref Message m)
    {
        if (m.Msg == 0x100 || m.Msg == 0x200 || m.Msg == 0x201 || m.Msg == 0x20A) _lastActivity = DateTime.Now;
        return false;
    }

    private void CheckIdle()
    {
        if (ActiveForm != this) return;   // a dialog is open - the cashier is mid-transaction
        if ((DateTime.Now - _lastActivity).TotalMinutes >= AuthController.SessionTimeoutMinutes)
        {
            idleTimer.Stop();
            Logout("SessionTimeout", $"You were signed out after {AuthController.SessionTimeoutMinutes} minutes of inactivity.");
        }
    }
}
