namespace SalesInventory.UI;

/// <summary>Point of Sale: cart on the left, customer / totals / pay on the right (see the Sales Processing sketch).</summary>
public partial class PosPage : BasePage
{
    private readonly SalesController _sales = new();
    private readonly AuthController _auth = new();

    public override string PageTitle => "Point of Sale";

    public PosPage()
    {
        InitializeComponent();

        // ----- cart -----
        cmbCustomerType.Items.AddRange(SalesController.CustomerTypes.Cast<object>().ToArray());
        cmbCustomerType.SelectedIndex = 0;
        dgvCart.AutoGenerateColumns = false;
        dgvCart.DataSource = _sales.Cart;
        dgvCart.CellValidating += (s, e) =>
        {
            if (dgvCart.Columns[e.ColumnIndex].DataPropertyName != "Quantity") return;
            if (!int.TryParse(Convert.ToString(e.FormattedValue), out var q) || q < 1)
            { e.Cancel = true; Ui.Warn("Quantities must be positive whole numbers."); }
        };
        dgvCart.CellEndEdit += (s, e) => BeginInvoke(new Action(() => Ui.Guard(() => { var w = _sales.ClampQuantities(); if (w != null) Ui.Warn(w); Refresh(); })));
        txtSearch.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; AddFromSearch(); } };

        UpdateTotals();
    }

    private void btnAdd_Click(object sender, EventArgs e) => AddFromSearch();
    private void btnRemoveLine_Click(object sender, EventArgs e) => RemoveLine();
    private void btnOverride_Click(object sender, EventArgs e) => OverridePrice();
    private void btnClear_Click(object sender, EventArgs e) => ClearCart();
    private void btnApply_Click(object sender, EventArgs e) => Ui.Guard(ApplyCustomer);
    private void btnHold_Click(object sender, EventArgs e) => Hold();
    private void btnRecall_Click(object sender, EventArgs e) => Recall();
    private void btnPay_Click(object sender, EventArgs e) => Pay();

    public override void OnActivated() => txtSearch.Focus();

    private void UpdateTotals()
    {
        var t = _sales.Totals;
        lblSubtotal.Text = Ui.Money(t.Subtotal); lblDiscount.Text = "-" + Ui.Money(t.Discount); lblVat.Text = Ui.Money(t.Vat); lblTotal.Text = Ui.Money(t.Total);
        dgvCart.Refresh();
    }

    private void AddFromSearch() => Ui.Guard(() =>
    {
        var text = txtSearch.Text.Trim(); if (text.Length == 0) return;
        var found = _sales.Find(text);
        var exact = found.FirstOrDefault(p => string.Equals(p.SKU, text, StringComparison.OrdinalIgnoreCase));
        Product chosen = exact ?? (found.Count == 1 ? found[0] : null);
        if (chosen == null)
        {
            if (found.Count == 0) throw new BusinessRuleException("No matching product was found.");
            var id = PickerForm.Pick(this, "Choose a product", Ui.ProductTable(found));
            if (id == null) return;
            chosen = found.First(p => p.ProductId == id);
        }
        _sales.AddProduct(chosen);
        txtSearch.Clear(); UpdateTotals(); txtSearch.Focus();
    });

    private CartLine SelectedLine => dgvCart.CurrentRow?.DataBoundItem as CartLine;

    private void RemoveLine() => Ui.Guard(() =>
    {
        var l = SelectedLine; if (l == null) throw new BusinessRuleException("Select a cart line first.");
        _sales.Remove(l); UpdateTotals();
    });

    private void ClearCart() => Ui.Guard(() => { if (_sales.Cart.Count > 0 && !Ui.Confirm("Clear the whole cart?")) return; _sales.Clear(); UpdateTotals(); });

    private void OverridePrice() => Ui.Guard(() =>
    {
        var l = SelectedLine; if (l == null) throw new BusinessRuleException("Select a cart line first.");
        var text = PromptForm.Ask(this, "Manual price override", $"New unit price for \"{l.ProductName}\" (current {Ui.Money(l.UnitPrice)}):");
        if (text == null) return;
        if (!Ui.TryMoney(text, out var price)) throw new BusinessRuleException("Enter a valid price.");
        using var a = new AuthorizationForm("A manual price override needs a supervisor or administrator.", Roles.StoreManager, Roles.Administrator);
        if (a.ShowDialog(this) != DialogResult.OK) return;
        _sales.SetOverride(l, price, a.Approver); UpdateTotals();
    });

    private void ApplyCustomer()
    {
        _sales.SetCustomer(cmbCustomerType.Text, txtCustomerRef.Text, txtDiscountCode.Text);
        UpdateTotals();
    }

    private void Pay() => Ui.Guard(() =>
    {
        ApplyCustomer();
        if (_sales.Cart.Count == 0) throw new BusinessRuleException("The cart is empty. Add at least one item before checkout.");
        using var pf = new PaymentForm(_sales);
        if (pf.ShowDialog(this) == DialogResult.OK && pf.Result != null)
        {
            cmbCustomerType.SelectedIndex = 0; txtCustomerRef.Clear(); txtDiscountCode.Clear();
            UpdateTotals();
            using var rf = new ReceiptForm(pf.Result, false);
            rf.ShowDialog(this);
            txtSearch.Focus();
        }
    });

    private void Hold() => Ui.Guard(() =>
    {
        ApplyCustomer();
        var id = _sales.Suspend(); UpdateTotals();
        Ui.Info($"Transaction held as #{id}. Use Recall to continue it.");
    });

    private void Recall() => Ui.Guard(() =>
    {
        var list = _sales.SuspendedList();
        if (list.Rows.Count == 0) throw new BusinessRuleException("There are no held transactions.");
        var id = PickerForm.Pick(this, "Recall a held transaction", list); if (id == null) return;
        var warning = _sales.Recall(id.Value); UpdateTotals();
        if (warning != null) Ui.Warn(warning);
    });

    /// <summary>Called by MainForm on timeout / logout so an unfinished cart is never lost.</summary>
    public void AutoSuspend() { try { if (_sales.Cart.Count > 0) _sales.Suspend(); } catch { } }
}
