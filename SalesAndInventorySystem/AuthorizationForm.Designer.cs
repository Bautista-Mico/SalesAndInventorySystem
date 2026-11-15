namespace SalesInventory.UI
{
    partial class AuthorizationForm
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblAllowed = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAuthorize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.lblTitle.Text = "Authorization required";
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.BackColor = System.Drawing.Color.Transparent;
            this.lblPurpose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPurpose.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPurpose.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.lblPurpose.Text = "Purpose";
            this.lblPurpose.Location = new System.Drawing.Point(30, 56);
            this.lblPurpose.MaximumSize = new System.Drawing.Size(300, 0);
            // 
            // lblAllowed
            // 
            this.lblAllowed.AutoSize = true;
            this.lblAllowed.BackColor = System.Drawing.Color.Transparent;
            this.lblAllowed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAllowed.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblAllowed.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.lblAllowed.Text = "Allowed:";
            this.lblAllowed.Location = new System.Drawing.Point(30, 108);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0, 6, 10, 6);
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(300, 25);
            this.txtUsername.Location = new System.Drawing.Point(30, 140);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0, 6, 10, 6);
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(300, 25);
            this.txtPassword.Location = new System.Drawing.Point(30, 184);
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnAuthorize
            // 
            this.btnAuthorize.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.btnAuthorize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuthorize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthorize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAuthorize.ForeColor = System.Drawing.Color.White;
            this.btnAuthorize.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnAuthorize.Size = new System.Drawing.Size(140, 40);
            this.btnAuthorize.Text = "Authorize";
            this.btnAuthorize.UseVisualStyleBackColor = false;
            this.btnAuthorize.FlatAppearance.BorderSize = 0;
            this.btnAuthorize.Location = new System.Drawing.Point(30, 232);
            this.btnAuthorize.Click += new System.EventHandler(this.btnAuthorize_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnCancel.Size = new System.Drawing.Size(140, 40);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(190, 232);
            // 
            // AuthorizationForm
            // 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.AcceptButton = this.btnAuthorize;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(360, 290);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Text = "Authorization required";
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblAllowed);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnAuthorize);
            this.Controls.Add(this.btnCancel);
            this.Name = "AuthorizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblAllowed;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAuthorize;
        private System.Windows.Forms.Button btnCancel;
    }
}
