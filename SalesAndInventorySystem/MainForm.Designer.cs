namespace SalesInventory.UI
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            pnlBody = new Panel();
            pnlContent = new Panel();
            lblTitle = new Label();
            pnlSide = new Panel();
            flpNav = new FlowLayoutPanel();
            pnlFooter = new Panel();
            btnLogout = new Button();
            lblUser = new Label();
            lblBrand = new Label();
            idleTimer = new System.Windows.Forms.Timer(components);
            pnlBody.SuspendLayout();
            pnlSide.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(pnlContent);
            pnlBody.Controls.Add(lblTitle);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(230, 0);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(854, 661);
            pnlBody.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(248, 250, 252);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 64);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(854, 597);
            pnlContent.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.White;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(17, 24, 39);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(24, 14, 0, 0);
            lblTitle.Size = new Size(854, 64);
            lblTitle.TabIndex = 1;
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.FromArgb(30, 41, 59);
            pnlSide.Controls.Add(flpNav);
            pnlSide.Controls.Add(pnlFooter);
            pnlSide.Controls.Add(lblBrand);
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Location = new Point(0, 0);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(230, 661);
            pnlSide.TabIndex = 1;
            // 
            // flpNav
            // 
            flpNav.Dock = DockStyle.Fill;
            flpNav.FlowDirection = FlowDirection.TopDown;
            flpNav.Location = new Point(0, 66);
            flpNav.Name = "flpNav";
            flpNav.Padding = new Padding(10, 10, 10, 0);
            flpNav.Size = new Size(230, 485);
            flpNav.TabIndex = 0;
            flpNav.WrapContents = false;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(btnLogout);
            pnlFooter.Controls.Add(lblUser);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 551);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new Padding(14, 10, 14, 10);
            pnlFooter.Size = new Size(230, 110);
            pnlFooter.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(71, 85, 105);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(14, 64);
            btnLogout.Margin = new Padding(0, 4, 10, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(202, 36);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblUser
            // 
            lblUser.Dock = DockStyle.Top;
            lblUser.Font = new Font("Segoe UI", 10F);
            lblUser.ForeColor = Color.FromArgb(203, 213, 225);
            lblUser.Location = new Point(14, 10);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(202, 46);
            lblUser.TabIndex = 1;
            // 
            // lblBrand
            // 
            lblBrand.Dock = DockStyle.Top;
            lblBrand.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(0, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Padding = new Padding(18, 0, 0, 0);
            lblBrand.Size = new Size(230, 66);
            lblBrand.TabIndex = 2;
            lblBrand.Text = "Sales And Inventory";
            // 
            // idleTimer
            // 
            idleTimer.Interval = 10000;
            // 
            // MainForm
            // 
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1084, 661);
            Controls.Add(pnlBody);
            Controls.Add(pnlSide);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1100, 700);
            Name = "MainForm";
            Text = "Sales & Inventory";
            WindowState = FormWindowState.Maximized;
            pnlBody.ResumeLayout(false);
            pnlSide.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.FlowLayoutPanel flpNav;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Timer idleTimer;
    }
}
