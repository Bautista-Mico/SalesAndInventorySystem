namespace SalesInventory.UI;

/// <summary>Transaction log + receipt retrieval/reprint + voids (Receipt Management / Sales admin stories).</summary>
public partial class TransactionsPage : BasePage
{
    private readonly SalesController _sales = new();
    private readonly ReceiptController _receipts = new();

    public override string PageTitle => "Receipts & Transactions";

    public TransactionsPage()
    {
        InitializeComponent();
        dtpFrom.Value = DateTime.Today.AddDays(-7);
        dtpTo.Value = DateTime.Today;

        dgvTransactions.DataBindingComplete += (s, e) =>
        {
            foreach (var c in new[] { "SaleId", "CashierId", "PaymentRef", "DiscountPercent", "CashTendered", "ChangeDue", "VoidedAt" })
                if (dgvTransactions.Columns.Contains(c)) dgvTransactions.Columns[c].Visible = false;
            foreach (DataGridViewRow r in dgvTransactions.Rows)
                if (r.DataBoundItem is DataRowView v && Convert.ToString(v["Status"]) == "Voided") r.DefaultCellStyle.ForeColor = Theme.Danger;
        };
        txtSearch.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; Reload(); } };
        dgvTransactions.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) ViewReceipt(); };

        btnVoid.Visible = Permissions.CanVoid;
        btnReceiptLog.Visible = Permissions.CanViewReports;
    }

    private void btnSearch_Click(object sender, EventArgs e) => Reload();
    private void btnView_Click(object sender, EventArgs e) => ViewReceipt();
    private void btnVoid_Click(object sender, EventArgs e) => VoidSale();
    private void btnReceiptLog_Click(object sender, EventArgs e) => ReceiptLog();

    public override void OnActivated() => Reload();

    private int? SelectedSaleId => dgvTransactions.CurrentRow?.DataBoundItem is DataRowView v ? Convert.ToInt32(v["SaleId"]) : null;

    private void Reload() => Ui.Guard(() =>
    {
        if (dtpFrom.Value.Date > dtpTo.Value.Date) throw new BusinessRuleException("The Start Date cannot be after the End Date.");
        dgvTransactions.DataSource = _sales.Search(txtSearch.Text, dtpFrom.Value, dtpTo.Value, cmbStatus.SelectedIndex == 0 ? null : cmbStatus.Text);
    });

    private void ViewReceipt() => Ui.Guard(() =>
    {
        var id = SelectedSaleId ?? throw new BusinessRuleException("Select a transaction first.");
        // Reprints after checkout are always "DUPLICATE" copies and need the user's own password again.
        var pw = PromptForm.Ask(this, "Duplicate receipt", "Enter your password to print a DUPLICATE copy:", "", true);
        if (pw == null) return;
        var sale = _sales.GetSale(id);
        var tax = _receipts.OriginalTaxInfo(id);
        var content = _receipts.Build(sale, tax, true);
        _receipts.LogDuplicate(sale, content, tax, pw);
        using var f = new ReceiptForm(sale, true);
        f.ShowDialog(this);
    });

    private void VoidSale() => Ui.Guard(() =>
    {
        var id = SelectedSaleId ?? throw new BusinessRuleException("Select a transaction first.");
        var sale = _sales.GetSale(id);
        if (sale.Status == "Voided") throw new BusinessRuleException("That sale is already voided.");
        using var a = new AuthorizationForm("Voiding or refunding a finalized sale needs an administrator signature.", Roles.Administrator);
        if (a.ShowDialog(this) != DialogResult.OK) return;
        var reason = PromptForm.Ask(this, "Void reason", "Reason (e.g. Customer Return, Cashier Error):");
        if (string.IsNullOrWhiteSpace(reason)) return;
        if (!Ui.Confirm($"Void {sale.InvoiceNo} ({Ui.Money(sale.TotalAmount)}) and return its items to stock?")) return;
        _sales.VoidSale(id, a.Approver, reason);
        Ui.Info("The sale was voided and the stock was returned.");
        Reload();
    });

    private void ReceiptLog() => Ui.Guard(() =>
        PickerForm.View(this, "Receipt & reprint log", ReceiptRepository.List(txtSearch.Text, false)));
}
