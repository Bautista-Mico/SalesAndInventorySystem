using System.Globalization;

namespace SalesInventory.UI;

/// <summary>Payment Processing screen: total due, payment mode tiles, tendered / reference input, big finalize button.</summary>
public partial class PaymentForm : Form
{
    private readonly SalesController _sales;
    private readonly PaymentController _pay = new();
    private readonly Dictionary<string, Button> _tiles = new();
    private string _mode = "Cash";
    private string _gatewayRef;

    public Sale Result { get; private set; }

    public PaymentForm() : this(null) { }

    public PaymentForm(SalesController sales)
    {
        _sales = sales;
        InitializeComponent();
        if (Ui.InDesigner) return;

        lblSummary.Text = $"{_sales.Totals.ItemCount} item(s)  -  {_sales.CustomerType}";
        lblDue.Text = "Total due\n" + Ui.Money(_sales.Totals.Total);

        // the three tiles are laid out in the designer; their text matches PaymentController.Modes
        _tiles[btnCash.Text] = btnCash; _tiles[btnCard.Text] = btnCard; _tiles[btnWallet.Text] = btnWallet;

        txtInput.TextChanged += (s, e) => UpdateInfo();
        SelectMode("Cash");
    }

    private void btnCash_Click(object sender, EventArgs e) => SelectMode(btnCash.Text);
    private void btnCard_Click(object sender, EventArgs e) => SelectMode(btnCard.Text);
    private void btnWallet_Click(object sender, EventArgs e) => SelectMode(btnWallet.Text);
    private void btnAux_Click(object sender, EventArgs e) => Aux();
    private void btnFinalize_Click(object sender, EventArgs e) => DoFinalize();

    private void SelectMode(string mode)
    {
        _mode = mode; _gatewayRef = null; txtInput.Clear();
        foreach (var kv in _tiles) { kv.Value.BackColor = kv.Key == mode ? Theme.Accent : Theme.Light; kv.Value.ForeColor = kv.Key == mode ? Color.White : Theme.Navy; }
        if (mode == "Cash") { lblCaption.Text = "Cash tendered"; btnAux.Text = "Exact amount"; txtInput.PlaceholderText = "0.00"; txtInput.ReadOnly = false; }
        else { lblCaption.Text = "Gateway reference / token"; btnAux.Text = "Terminal handshake"; txtInput.PlaceholderText = "Waiting for terminal..."; txtInput.ReadOnly = true; }
        UpdateInfo();
        txtInput.Focus();
    }

    private void Aux() => Ui.Guard(() =>
    {
        if (_mode == "Cash") { txtInput.Text = _sales.Totals.Total.ToString("0.00", CultureInfo.CurrentCulture); return; }
        var r = _pay.Handshake(_mode, _sales.Totals.Total);
        _gatewayRef = r.Reference; txtInput.Text = r.Reference; UpdateInfo();
    });

    private void UpdateInfo()
    {
        if (_mode == "Cash")
        {
            if (Ui.TryMoney(txtInput.Text, out var t))
            {
                if (t >= _sales.Totals.Total) { lblInfo.ForeColor = Theme.Success; lblInfo.Text = "Change due: " + Ui.Money(t - _sales.Totals.Total); }
                else { lblInfo.ForeColor = Theme.Danger; lblInfo.Text = "Short by " + Ui.Money(_sales.Totals.Total - t); }
            }
            else { lblInfo.ForeColor = Theme.Slate; lblInfo.Text = "Enter the amount received."; }
        }
        else if (_gatewayRef != null) { lblInfo.ForeColor = Theme.Success; lblInfo.Text = "Approved by terminal"; }
        else { lblInfo.ForeColor = Theme.Slate; lblInfo.Text = "Press 'Terminal handshake' to charge the customer."; }
    }

    private void DoFinalize() => Ui.Guard(() =>
    {
        decimal? tendered = null;
        if (_mode == "Cash")
        {
            if (!Ui.TryMoney(txtInput.Text, out var t)) throw new BusinessRuleException("Enter the cash tendered amount.");
            tendered = t;
        }
        btnFinalize.Enabled = false;
        try
        {
            Result = _pay.Finalize(_sales, _mode, tendered, _gatewayRef);
            DialogResult = DialogResult.OK;
        }
        finally { btnFinalize.Enabled = true; }
    });
}
