

namespace SalesInventory.UI;

public partial class UserEditForm : Form
{
    private readonly UserController _ctl = new();
    private readonly User _u;

    public UserEditForm() : this(null) { }

    public UserEditForm(User u)
    {
        InitializeComponent();
        _u = u ?? new User();
        Text = u == null ? "Add user" : "Edit user";
        cmbRole.DataSource = Roles.All.Select(r => new RoleItem(r)).ToList();

        if (u != null)
        {
            // the password box only exists when adding; move the "active" box up into its place
            lblPassword.Visible = false; txtPassword.Visible = false;
            chkActive.Location = new Point(30, 288);
            txtUsername.Text = u.Username; txtFullName.Text = u.FullName; txtEmail.Text = u.Email; chkActive.Checked = u.IsActive;
            cmbRole.SelectedItem = ((List<RoleItem>)cmbRole.DataSource).First(r => r.Role == u.Role);
        }
    }

    private sealed class RoleItem
    {
        public string Role { get; }
        public RoleItem(string r) { Role = r; }
        public override string ToString() => Roles.Display(Role);
    }

    private void btnSave_Click(object sender, EventArgs e) => Ui.Guard(() =>
    {
        _u.Username = txtUsername.Text.Trim(); _u.FullName = txtFullName.Text.Trim(); _u.Email = txtEmail.Text.Trim();
        _u.Role = (cmbRole.SelectedItem as RoleItem)?.Role; _u.IsActive = chkActive.Checked;
        _ctl.Save(_u, _u.UserId == 0 ? txtPassword.Text : null);
        DialogResult = DialogResult.OK;
    });
}
