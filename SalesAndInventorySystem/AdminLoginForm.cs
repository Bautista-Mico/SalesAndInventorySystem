using BusinessLogic.Controller;
using BusinessLogic.Repository;

namespace UI;

public partial class AdminLoginForm : Form
{
    private readonly LoginController _login = new(new LoginRepository());

    public AdminLoginForm()
    {
        InitializeComponent();
        AcceptButton = btnLogin;   
    }

    private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            LoginResult result = _login.Login(txtUsername.Text, txtPassword.Text);

            if (result.IsLocked)
            {
                lblMessage.Text = result.Message;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                chkShowPassword.Enabled = false;
                btnLogin.Enabled = false;
                return;
            }

            if (!result.Success)
            {
                lblMessage.Text = result.Message;
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            if (result.Role != "Admin")
            {
                lblMessage.Text = "Only a System Administrator can use this portal.";
                txtPassword.Clear();
                return;
            }

            DialogResult = DialogResult.OK;   // closes this form and returns OK to the landing form
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}