using System.Globalization;

namespace SalesInventory.UI;

/// <summary>Reporting &amp; Analytics: filters on top, chart left, results right, action buttons at the bottom.</summary>
public partial class ReportsPage : BasePage
{
    private readonly ReportController _ctl = new();
    private ReportResult _result;

    public override string PageTitle => "Reports & Analytics";

    public ReportsPage()
    {
        InitializeComponent();
        dtpFrom.Value = DateTime.Today.AddDays(-30);
        dtpTo.Value = DateTime.Today;
        if (Ui.InDesigner) return;

        cmbReport.DataSource = _ctl.Available();
        var cashiers = _ctl.Cashiers(); cashiers.Insert(0, new User { UserId = 0, FullName = "All cashiers" });
        cmbCashier.DataSource = cashiers; cmbCashier.DisplayMember = "FullName";

        txtCounted.TextChanged += (s, e) => Reconcile();
        cmbReport.SelectedIndexChanged += (s, e) => { var d = cmbReport.SelectedItem as ReportDef; cmbCashier.Enabled = d?.UsesCashier == true; txtCounted.Visible = d?.Name == "Cash Drawer Reconciliation"; lblRecon.Text = ""; };

        cmbReport.SelectedIndex = 0; txtCounted.Visible = false;
    }

    private void btnGenerate_Click(object sender, EventArgs e) => Generate();
    private void btnExport_Click(object sender, EventArgs e) => Export();
    private void btnClear_Click(object sender, EventArgs e) => Clear();

    private void Generate() => Ui.Guard(() =>
    {
        var def = cmbReport.SelectedItem as ReportDef ?? throw new BusinessRuleException("Choose a report type.");
        if (def.NeedsAdminCredential)
        {
            using var a = new AuthorizationForm("Unmasked financial data and tax ledgers need Administrator verification.", Roles.Administrator);
            if (a.ShowDialog(this) != DialogResult.OK) return;
        }
        var cashier = cmbCashier.SelectedItem as User;
        _result = _ctl.Run(def, dtpFrom.Value, dtpTo.Value, def.UsesCashier && cashier != null && cashier.UserId > 0 ? cashier.UserId : null);
        dgvReport.DataSource = _result.Table;
        chart.SetData(_result.Table, def.LabelCol, def.ValueCol, def.Name + " - " + def.ValueCol);
        Reconcile();
    });

    private void Reconcile()
    {
        if (_result?.Def.Name != "Cash Drawer Reconciliation") { lblRecon.Text = ""; return; }
        decimal expected = _result.Table.Rows.Cast<DataRow>().Sum(r => Convert.ToDecimal(r["ExpectedCash"]));
        if (!Ui.TryMoney(txtCounted.Text, out var counted)) { lblRecon.ForeColor = Theme.Slate; lblRecon.Text = "Expected cash: " + Ui.Money(expected); return; }
        var v = counted - expected;
        lblRecon.ForeColor = v == 0 ? Theme.Success : Theme.Danger;
        lblRecon.Text = $"Expected {Ui.Money(expected)}  |  Variance {(v >= 0 ? "+" : "-")}{Ui.Money(Math.Abs(v))}{(v == 0 ? "" : "  DISCREPANCY")}";
    }

    private void Export() => Ui.Guard(() =>
    {
        if (_result == null) throw new BusinessRuleException("Generate a report first.");
        using var dlg = new SaveFileDialog { Filter = "CSV spreadsheet|*.csv", FileName = _result.Def.Name.Replace(' ', '_') + "_" + DateTime.Today.ToString("yyyyMMdd") + ".csv" };
        if (dlg.ShowDialog(this) != DialogResult.OK) return;
        _ctl.ExportCsv(_result.Table, dlg.FileName);
        Ui.Info("Report exported to:\n" + dlg.FileName);
    });

    private void Clear() { _result = null; dgvReport.DataSource = null; chart.SetData(null, "", "", ""); lblRecon.Text = ""; txtCounted.Clear(); }
}
