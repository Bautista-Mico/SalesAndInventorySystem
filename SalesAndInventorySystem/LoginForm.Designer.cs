namespace SalesInventory.UI
{
    partial class LoginForm
    {
        /// <summary>Required designer variable.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Clean up any resources being used.</summary>
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

        /// <summary>Required method for Designer support - do not modify the contents of this method with the code editor.</summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pnlTop = new Panel();
            lblSubtitle = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            chkRemember = new CheckBox();
            btnLogin = new Button();
            lblError = new Label();
            lblNotice = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(37, 99, 235);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(480, 5);
            pnlTop.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(129, 204);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(218, 28);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Sign in to your account";
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Segoe UI", 10F);
            txtUser.Location = new Point(70, 250);
            txtUser.Margin = new Padding(0, 6, 10, 6);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Username / Email";
            txtUser.Size = new Size(340, 25);
            txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(70, 300);
            txtPassword.Margin = new Padding(0, 6, 10, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(340, 25);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Font = new Font("Segoe UI", 10F);
            chkRemember.ForeColor = Color.FromArgb(71, 85, 105);
            chkRemember.Location = new Point(72, 352);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(117, 23);
            chkRemember.TabIndex = 5;
            chkRemember.Text = "Remember me";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(17, 24, 39);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(70, 392);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(340, 46);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 10F);
            lblError.ForeColor = Color.FromArgb(220, 38, 38);
            lblError.Location = new Point(70, 450);
            lblError.Name = "lblError";
            lblError.Size = new Size(340, 50);
            lblError.TabIndex = 7;
            // 
            // lblNotice
            // 
            lblNotice.ForeColor = Color.FromArgb(100, 116, 139);
            lblNotice.Location = new Point(70, 510);
            lblNotice.Name = "lblNotice";
            lblNotice.Size = new Size(340, 40);
            lblNotice.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(198, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 154);
            label1.Name = "label1";
            label1.Size = new Size(200, 25);
            label1.TabIndex = 10;
            label1.Text = "Sales And Inventory";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(480, 600);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pnlTop);
            Controls.Add(lblSubtitle);
            Controls.Add(txtUser);
            Controls.Add(txtPassword);
            Controls.Add(chkRemember);
            Controls.Add(btnLogin);
            Controls.Add(lblError);
            Controls.Add(lblNotice);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales & Inventory - Sign in";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private LogoBadge logo;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblNotice;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
