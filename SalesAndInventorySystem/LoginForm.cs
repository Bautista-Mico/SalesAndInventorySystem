namespace SalesInventory.UI;

/// <summary>Login screen laid out like the "Sample Sketch" in the Login Module PDF. Layout: LoginForm.Designer.cs.</summary>
public partial class LoginForm : Form
{
    private readonly AuthController _auth = new();

    public LoginForm()
    {
        InitializeComponent();

        lblNotice.Text = Program.LoginNotice ?? "";
        Program.LoginNotice = null;

        var saved = Prefs.Remembered();
        if (!string.IsNullOrEmpty(saved)) { txtUser.Text = saved; chkRemember.Checked = true; ActiveControl = txtPassword; }
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        try
        {
            _auth.Login(txtUser.Text, txtPassword.Text);
            if (chkRemember.Checked) Prefs.Remember(txtUser.Text.Trim()); else Prefs.Forget();
            DialogResult = DialogResult.OK;
        }
        catch (BusinessRuleException ex) { lblError.Text = ex.Message; txtPassword.Clear(); txtPassword.Focus(); }
        catch (Exception ex) { lblError.Text = "Could not reach the database: " + ex.Message; }
    }

    private void lblTitle_Click(object sender, EventArgs e)
    {

    }
}
