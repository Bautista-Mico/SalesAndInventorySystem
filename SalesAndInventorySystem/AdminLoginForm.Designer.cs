#nullable disable
namespace UI;

partial class AdminLoginForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        txtUsername = new TextBox();
        txtPassword = new TextBox();
        chkShowPassword = new CheckBox();
        btnLogin = new Button();
        lblMessage = new Label();
        SuspendLayout();

        // lblTitle
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitle.Location = new Point(30, 25);
        lblTitle.Text = "Administrator Login";

        // txtUsername
        txtUsername.Location = new Point(30, 80);
        txtUsername.Size = new Size(300, 27);
        txtUsername.PlaceholderText = "Username";

        // txtPassword
        txtPassword.Location = new Point(30, 125);
        txtPassword.Size = new Size(300, 27);
        txtPassword.PlaceholderText = "Password";
        txtPassword.UseSystemPasswordChar = true;

        // chkShowPassword
        chkShowPassword.AutoSize = true;
        chkShowPassword.Location = new Point(30, 165);
        chkShowPassword.Text = "Show password";
        chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;

        // btnLogin
        btnLogin.Location = new Point(30, 205);
        btnLogin.Size = new Size(300, 36);
        btnLogin.Text = "Login";
        btnLogin.Click += btnLogin_Click;

        // lblMessage
        lblMessage.ForeColor = Color.Firebrick;
        lblMessage.Location = new Point(30, 252);
        lblMessage.Size = new Size(300, 45);

        // AdminLoginForm
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(360, 310);
        Controls.Add(lblTitle);
        Controls.Add(txtUsername);
        Controls.Add(txtPassword);
        Controls.Add(chkShowPassword);
        Controls.Add(btnLogin);
        Controls.Add(lblMessage);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Administrator Login";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private TextBox txtUsername;
    private TextBox txtPassword;
    private CheckBox chkShowPassword;
    private Button btnLogin;
    private Label lblMessage;
}