using System.ComponentModel;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesInventory.UI;

/// <summary>Stock Update module: batch updates (staff), availability lookup (everyone), ledger / variance (staff, managers).</summary>
public partial class StockPage : BasePage
{
    private readonly StockController _ctl = new();
    private readonly ProductController _products = new();
    private readonly BindingList<StockLine> _batch = new();
    private Product _selected;

    public override string PageTitle => "Stock Update";

    public StockPage()
    {
        InitializeComponent();

        // combo contents
        cmbAction.Items.AddRange(StockController.ActionTypes.Cast<object>().ToArray()); cmbAction.SelectedIndex = 0;
        cmbReason.Items.AddRange(StockController.ReasonCodes.Cast<object>().ToArray()); cmbReason.SelectedIndex = 0;
        cmbLedgerAction.Items.Add("(all actions)");
        foreach (var a in new[] { "Initial Stock", "Replenishment", "Damage Writeoff", "Discrepancy Adjustment", "POS Sales Decrement", "Void Return" }) cmbLedgerAction.Items.Add(a);
        cmbLedgerAction.SelectedIndex = 0;
        dtpFrom.Value = DateTime.Today.AddDays(-30);
        dtpTo.Value = DateTime.Today;

        // grids
        dgvBatch.AutoGenerateColumns = false; dgvBatch.DataSource = _batch;
        dgvAvailability.AutoGenerateColumns = false;

        // events
        cmbAction.SelectedIndexChanged += (s, e) =>
        {
            cmbReason.SelectedItem = cmbAction.Text switch { "Replenishment" => "Supplier Intake", "Damage Writeoff" => "Damaged Cargo", _ => "Discrepancy Audit" };
        };
        txtFind.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; FindItem(); } };
        txtAvailSearch.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; Lookup(); } };

        // tabs by role
        if (!Permissions.CanEditInventory) tabs.TabPages.Remove(tabUpdate);
        if (!(Permissions.CanEditInventory || Permissions.CanViewReports)) tabs.TabPages.Remove(tabLedger);
    }

    private void btnFind_Click(object sender, EventArgs e) => FindItem();
    private void btnAddLine_Click(object sender, EventArgs e) => AddLine();
    private void btnPost_Click(object sender, EventArgs e) => Post();
    private void btnRemoveLine_Click(object sender, EventArgs e) => RemoveLine();
    private void btnRecover_Click(object sender, EventArgs e) => Recover();
    private void btnCheckStock_Click(object sender, EventArgs e) => Lookup();
    private void btnShowLedger_Click(object sender, EventArgs e) => LoadLedger();

    // ------------------------------------------------------------- update
    private void FindItem() => Ui.Guard(() =>
    {
        var text = txtFind.Text.Trim(); if (text.Length == 0) return;
        var found = _products.Search(text, null, false, false);
        var exact = found.FirstOrDefault(p => string.Equals(p.SKU, text, StringComparison.OrdinalIgnoreCase));
        var chosen = exact ?? (found.Count == 1 ? found[0] : null);
        if (chosen == null)
        {
            if (found.Count == 0) throw new BusinessRuleException("No matching product was found.");
            var id = PickerForm.Pick(this, "Choose a product", Ui.ProductTable(found)); if (id == null) return;
            chosen = found.First(p => p.ProductId == id);
        }
        _selected = chosen; lblPicked.Text = $"{chosen.SKU} - {chosen.Name}  (on hand: {chosen.QtyOnHand})"; lblPicked.ForeColor = Theme.Navy;
        txtLocation.Text = chosen.StorageLocation;
    });

    private void AddLine() => Ui.Guard(() =>
    {
        _batch.Add(_ctl.BuildLine(_selected, cmbAction.Text, (int)numQty.Value, txtLocation.Text, txtRef.Text, cmbReason.Text));
        _selected = null; lblPicked.Text = "No item selected"; lblPicked.ForeColor = Theme.Slate; txtFind.Clear(); txtFind.Focus();
    });

    private void RemoveLine() { if (dgvBatch.CurrentRow?.DataBoundItem is StockLine l) _batch.Remove(l); }

    private void Post() => Ui.Guard(() =>
    {
        if (_batch.Count == 0) throw new BusinessRuleException("The inventory update has no SKU entries.");
        int? approver = null;
        if (_ctl.NeedsApproval(_batch))
        {
            using var a = new AuthorizationForm($"A write-off above {Ui.Money(StockController.WriteOffApprovalLimit)} needs a manager or administrator.", Roles.StoreManager, Roles.Administrator);
            if (a.ShowDialog(this) != DialogResult.OK) return;
            approver = a.Approver.UserId;
        }
        _ctl.Post(_batch.ToList(), approver);
        Ui.Info($"{_batch.Count} stock line(s) posted to the ledger.");
        _batch.Clear();
    });

    private void Recover() => Ui.Guard(() =>
    {
        if (!_ctl.HasSuspended) throw new BusinessRuleException("There is no suspended inventory session.");
        foreach (var l in _ctl.RecoverSuspended()) _batch.Add(l);
        _ctl.ClearSuspended();
        Ui.Info("Suspended session restored. Review the lines and post again.");
    });

    // ------------------------------------------------------------- availability
    private void Lookup() => Ui.Guard(() => dgvAvailability.DataSource = _products.Search(txtAvailSearch.Text, null, false, false));

    // ------------------------------------------------------------- ledger
    private void LoadLedger() => Ui.Guard(() =>
    {
        if (dtpFrom.Value.Date > dtpTo.Value.Date) throw new BusinessRuleException("The Start Date cannot be after the End Date.");
        dgvLedger.DataSource = _ctl.Ledger(dtpFrom.Value, dtpTo.Value, txtLedgerSearch.Text, cmbLedgerAction.SelectedIndex == 0 ? null : cmbLedgerAction.Text);
    });

    public override void OnActivated()
    {
        if (tabs.TabPages.Contains(tabUpdate) && _ctl.HasSuspended && _batch.Count == 0)
            Ui.Info("A suspended inventory session was found from an earlier interruption. Press 'Recover session' to restore it.");
    }
}
