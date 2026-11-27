using UI;

namespace SalesInventory.UI;

public partial class UsersPage : BasePage
{
    private readonly UserController _ctl = new();

    public override string PageTitle => "Users";

    public UsersPage()
    {
        InitializeComponent();
        dgvUsers.AutoGenerateColumns = false;
        txtSearch.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; Reload(); } };
    }

    private void btnSearch_Click(object sender, EventArgs e) => Reload();
    private void btnAdd_Click(object sender, EventArgs e) => Edit(null);
    private void btnEdit_Click(object sender, EventArgs e) => EditSelected();
    private void btnToggle_Click(object sender, EventArgs e) => Toggle();
    private void btnReset_Click(object sender, EventArgs e) => Reset();

    private User Selected => dgvUsers.CurrentRow?.DataBoundItem as User;
    public override void OnActivated() => Reload();
    private void Reload() => Ui.Guard(() => dgvUsers.DataSource = _ctl.List(txtSearch.Text));

    private void Edit(User u) => Ui.Guard(() =>
    {
        using var f = new UserEditForm(u); if (f.ShowDialog(this) == DialogResult.OK) Reload();
    });

    private void EditSelected()
    {
        if (Selected == null) { Ui.Warn("Select a user first."); return; }
        Edit(Selected);
    }

    private void Toggle() => Ui.Guard(() =>
    {
        var u = Selected ?? throw new BusinessRuleException("Select a user first.");
        _ctl.SetActive(u, !u.IsActive); Reload();
    });

    private void Reset() => Ui.Guard(() =>
    {
        var u = Selected ?? throw new BusinessRuleException("Select a user first.");
        var pw = PromptForm.Ask(this, "Reset password", $"New password for {u.Username} (min. 8 characters):", "", true);
        if (pw == null) return;
        _ctl.ResetPassword(u, pw); Ui.Info("Password updated and any lockout cleared.");
    });
}
