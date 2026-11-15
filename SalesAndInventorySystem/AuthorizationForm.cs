namespace SalesInventory.UI;

/// <summary>Asks a second person (supervisor / admin) for credentials.</summary>
public partial class AuthorizationForm : Form
{
    private readonly string[] _roles;
    public User Approver { get; private set; }

    public AuthorizationForm() : this("") { }

    public AuthorizationForm(string purpose, params string[] roles)
    {
        InitializeComponent();
        _roles = roles;
        lblPurpose.Text = purpose;
        lblAllowed.Text = "Allowed: " + string.Join(" / ", roles.Select(Roles.Display));
    }

    private void btnAuthorize_Click(object sender, EventArgs e) => Ui.Guard(() =>
    {
        Approver = new AuthController().Authorize(txtUsername.Text, txtPassword.Text, _roles);
        DialogResult = DialogResult.OK;
    });
}
