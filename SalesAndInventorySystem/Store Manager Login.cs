using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesAndInventorySystem
{
    public partial class StoreManagerLoginForm : Form
    {
        public string AuthenticatedUserRole { get; private set; } = string.Empty;
        public string AuthenticatedUsername { get; private set; } = string.Empty;

        private int _failedAttempts = 0;
        private bool _isLockedOut = false;
        private DateTime _lockoutEndTime;

        public StoreManagerLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ExecuteLogin();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ExecuteLogin();
            }
        }

        private void ExecuteLogin()
        {
            if (_isLockedOut)
            {
                if (DateTime.Now < _lockoutEndTime)
                {
                    TimeSpan remaining = _lockoutEndTime - DateTime.Now;
                    ShowErrorMessage($"Account locked out. Try again in {remaining.Minutes}m {remaining.Seconds}s.");
                    return;
                }
                else
                {
                    _isLockedOut = false;
                    _failedAttempts = 0;
                }
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ShowErrorMessage("Both Username/Email and Password are mandatory.");
                return;
            }

            if (password.Length < 8)
            {
                ShowErrorMessage("Password must be at least 8 characters.");
                return;
            }

            bool isValidUser = VerifyCredentials(username, password, out string role);

            if (isValidUser)
            {
                _failedAttempts = 0;
                AuthenticatedUsername = username;
                AuthenticatedUserRole = role;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                _failedAttempts++;

                if (_failedAttempts >= 5)
                {
                    _isLockedOut = true;
                    _lockoutEndTime = DateTime.Now.AddMinutes(15);
                    ShowErrorMessage("Too many failed attempts. Account locked out for 15 minutes.");
                }
                else
                {
                    int remaining = 5 - _failedAttempts;
                    ShowErrorMessage($"Invalid credentials. {remaining} attempt(s) remaining.");
                }

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private bool VerifyCredentials(string username, string password, out string role)
        {
           
            if ((username.Equals("manager", StringComparison.OrdinalIgnoreCase) ||
                 username.Equals("manager@store.com", StringComparison.OrdinalIgnoreCase)) &&
                 password == "manager123")
            {
                role = "Store Manager";
                return true;
            }

            role = string.Empty;
            return false;
        }

        private void ShowErrorMessage(string message)
        {
            lblStatusMessage.Text = message;
            lblStatusMessage.ForeColor = Color.Red;
            lblStatusMessage.Visible = true;
        }
    }
}