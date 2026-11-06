using BusinessLogic.Controller;
using BusinessLogic.Repository;
using Model;

namespace UI;

public partial class AdminPortalForm : Form
{
    private readonly UserController _controller = new(new UserRepository());
    private int? _selectedId;

    public AdminPortalForm()
    {
        InitializeComponent();
        cboRole.SelectedIndex = 2;
    }

    private void AdminPortalForm_Load(object sender, EventArgs e) => Run(() => LoadUsers(""));

    // ---------- Search ----------
    private void btnSearch_Click(object sender, EventArgs e) => Run(() => LoadUsers(txtSearch.Text));

    private void btnShowAll_Click(object sender, EventArgs e)
    {
        txtSearch.Clear();
        Run(() => LoadUsers(""));
    }

    private void txtSearch_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            Run(() => LoadUsers(txtSearch.Text));
        }
    }

    // ---------- Grid ----------
    private void dgvUsers_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvUsers.CurrentRow?.DataBoundItem is not User u || !dgvUsers.CurrentRow.Selected) return;
        _selectedId = u.UserId;
        txtUsername.Text = u.Username;
        txtFullName.Text = u.FullName;
        cboRole.SelectedItem = u.Role;
        chkActive.Checked = u.IsActive;
        txtPassword.Clear();
    }

    // ---------- CRUD ----------
    private void btnAdd_Click(object sender, EventArgs e) => Run(() =>
    {
        _controller.Create(ReadForm(), txtPassword.Text);
        LoadUsers(txtSearch.Text);
        lblStatus.Text = "User added.";
    });

    private void btnUpdate_Click(object sender, EventArgs e) => Run(() =>
    {
        if (_selectedId == null) throw new InvalidOperationException("Select a user to update.");
        _controller.Update(ReadForm(), txtPassword.Text);
        LoadUsers(txtSearch.Text);
        lblStatus.Text = "User updated.";
    });

    private void btnDelete_Click(object sender, EventArgs e) => Run(() =>
    {
        if (_selectedId == null) throw new InvalidOperationException("Select a user to delete.");
        if (MessageBox.Show("Delete this user?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
        _controller.Delete(_selectedId.Value);
        LoadUsers(txtSearch.Text);
        lblStatus.Text = "User deleted.";
    });

    private void btnUnlock_Click(object sender, EventArgs e) => Run(() =>
    {
        if (_selectedId == null) throw new InvalidOperationException("Select a user to unlock.");
        // This portal is for the System Administrator, so unlocking is done as Admin.
        _controller.Unlock(_selectedId.Value, new User { Role = "Admin" });
        LoadUsers(txtSearch.Text);
        lblStatus.Text = "User unlocked.";
    });

    private void btnClear_Click(object sender, EventArgs e)
    {
        dgvUsers.ClearSelection();
        ClearForm();
    }

    // ---------- Helpers ----------
    private void LoadUsers(string keyword)
    {
        var users = string.IsNullOrWhiteSpace(keyword) ? _controller.GetAll() : _controller.Search(keyword);
        dgvUsers.DataSource = users;
        dgvUsers.ClearSelection();
        ClearForm();
        lblStatus.Text = users.Count == 0 ? "No matching records found." : $"{users.Count} record(s) found.";
    }

    private User ReadForm() => new()
    {
        UserId = _selectedId ?? 0,
        Username = txtUsername.Text.Trim(),
        FullName = txtFullName.Text.Trim(),
        Role = cboRole.SelectedItem?.ToString() ?? "Cashier",
        IsActive = chkActive.Checked
    };

    private void ClearForm()
    {
        _selectedId = null;
        txtUsername.Clear();
        txtFullName.Clear();
        txtPassword.Clear();
        cboRole.SelectedIndex = 2;
        chkActive.Checked = true;
    }

    private void Run(Action action)
    {
        try { action(); }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}