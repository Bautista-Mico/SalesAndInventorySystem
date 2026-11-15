namespace SalesInventory.UI;

/// <summary>Pick one row from a table (hidden "Id" column is returned), or just view a table.</summary>
public partial class PickerForm : Form
{
    private readonly bool _pick;
    public int? SelectedId { get; private set; }

    public PickerForm() : this("", new DataTable(), false) { }

    private PickerForm(string title, DataTable table, bool pick)
    {
        InitializeComponent();
        _pick = pick;
        Text = title;
        btnSelect.Visible = pick;
        btnCancel.Text = pick ? "Cancel" : "Close";
        dgvPicker.DataSource = table;
        dgvPicker.DataBindingComplete += (s, e) => { if (dgvPicker.Columns.Contains("Id")) dgvPicker.Columns["Id"].Visible = false; };
        dgvPicker.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) Choose(); };
    }

    private void btnSelect_Click(object sender, EventArgs e) => Choose();
    private void btnCancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

    private void Choose()
    {
        if (!_pick || dgvPicker.CurrentRow == null) return;
        SelectedId = Convert.ToInt32(((DataRowView)dgvPicker.CurrentRow.DataBoundItem)["Id"]);
        DialogResult = DialogResult.OK;
    }

    public static int? Pick(IWin32Window owner, string title, DataTable table)
    {
        using var f = new PickerForm(title, table, true);
        return f.ShowDialog(owner) == DialogResult.OK ? f.SelectedId : null;
    }

    public static void View(IWin32Window owner, string title, DataTable table)
    {
        using var f = new PickerForm(title, table, false);
        f.ShowDialog(owner);
    }
}
