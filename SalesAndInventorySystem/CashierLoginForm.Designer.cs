namespace UI
{
    partial class CashierLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private  TextBox txtUsername;
        private  TextBox txtPassword;
        private  Button btnLogin;
        private  Button btnCancel;
        private  Label lblStatus;
        private void InitializeComponent()
        {
            Text = "Cashier Login";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(380, 250);

            var title = new Label
            {
                Text = "Cashier Login",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(25, 20)
            };

            var usernameLabel = new Label
            {
                Text = "Username",
                AutoSize = true,
                Location = new Point(25, 70)
            };

            txtUsername = new TextBox
            {
                Name = "txtUsername",
                Location = new Point(25, 92),
                Size = new Size(330, 27),
                TabIndex = 0
            };

            var passwordLabel = new Label
            {
                Text = "Password",
                AutoSize = true,
                Location = new Point(25, 125)
            };

            txtPassword = new TextBox
            {
                Name = "txtPassword",
                Location = new Point(25, 147),
                Size = new Size(330, 27),
                PasswordChar = '•',
                TabIndex = 1
            };

            lblStatus = new Label
            {
                AutoSize = true,
                ForeColor = Color.Firebrick,
                Location = new Point(25, 180)
            };

            btnLogin = new Button
            {
                Text = "Login",
                Location = new Point(200, 205),
                Size = new Size(75, 30),
                TabIndex = 2
            };
            btnLogin.Click += btnLogin_Click;

            btnCancel = new Button
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new Point(280, 205),
                Size = new Size(75, 30),
                TabIndex = 3
            };

            AcceptButton = btnLogin;
            CancelButton = btnCancel;

            Controls.AddRange(new Control[]
            {
                title, usernameLabel, txtUsername, passwordLabel, txtPassword,
                lblStatus, btnLogin, btnCancel
            });
        }

        #endregion

    }
}