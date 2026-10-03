namespace UI
{
    partial class LandingForm
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
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            btnAdmin = new Button();
            btnManager = new Button();
            btnCashier = new Button();
            SuspendLayout();
       
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(50, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(373, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sales & Inventory System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(110, 70);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(246, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Select your portal to log in";
            btnAdmin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.Location = new Point(80, 110);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(240, 45);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "Administrator Portal";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click; 
            btnManager.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManager.Location = new Point(80, 170);
            btnManager.Name = "btnManager";
            btnManager.Size = new Size(240, 45);
            btnManager.TabIndex = 3;
            btnManager.Text = "Store Manager Portal";
            btnManager.UseVisualStyleBackColor = true;
            btnManager.Click += btnManager_Click;
            btnCashier.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashier.Location = new Point(80, 230);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(240, 45);
            btnCashier.TabIndex = 4;
            btnCashier.Text = "Cashier Portal";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 320);
            Controls.Add(btnCashier);
            Controls.Add(btnManager);
            Controls.Add(btnAdmin);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LandingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome - Select Portal";
            Load += LandingForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnCashier;
    }
}