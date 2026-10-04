using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class CashierLoginForm : Form
    {
        //temporary hardcoded credentials for demonstration purposes
        private const string CashierUsername = "cashier";
        private const string CashierPassword = "cashier123";

        public CashierLoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object? sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblStatus.Text = "Enter your username and password.";
                return;
            }

            if (string.Equals(username, CashierUsername, StringComparison.OrdinalIgnoreCase)
                && password == CashierPassword)
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            lblStatus.Text = "Invalid cashier username or password.";
            txtPassword.Clear();
            txtPassword.Focus();
        }
    }
}
