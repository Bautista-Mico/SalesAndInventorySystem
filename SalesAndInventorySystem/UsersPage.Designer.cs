namespace SalesInventory.UI
{
    partial class UsersPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tlpMain = new TableLayoutPanel();
            flpTop = new FlowLayoutPanel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvUsers = new DataGridView();
            colUsersUsername = new DataGridViewTextBoxColumn();
            colUsersFullName = new DataGridViewTextBoxColumn();
            colUsersEmail = new DataGridViewTextBoxColumn();
            colUsersRole = new DataGridViewTextBoxColumn();
            colUsersStatus = new DataGridViewTextBoxColumn();
            colUsersLastLogin = new DataGridViewTextBoxColumn();
            flpBottom = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnToggle = new Button();
            btnReset = new Button();
            tlpMain.SuspendLayout();
            flpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            flpBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.Transparent;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(flpTop, 0, 0);
            tlpMain.Controls.Add(dgvUsers, 0, 1);
            tlpMain.Controls.Add(flpBottom, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(20, 20);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tlpMain.Size = new Size(1005, 523);
            tlpMain.TabIndex = 0;
            // 
            // flpTop
            // 
            flpTop.BackColor = Color.Transparent;
            flpTop.Controls.Add(txtSearch);
            flpTop.Controls.Add(btnSearch);
            flpTop.Dock = DockStyle.Fill;
            flpTop.Location = new Point(3, 3);
            flpTop.Name = "flpTop";
            flpTop.Padding = new Padding(0, 2, 0, 2);
            flpTop.Size = new Size(999, 46);
            flpTop.TabIndex = 0;
            flpTop.WrapContents = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(0, 8);
            txtSearch.Margin = new Padding(0, 6, 10, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search users...";
            txtSearch.Size = new Size(300, 25);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(71, 85, 105);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(310, 6);
            btnSearch.Margin = new Padding(0, 4, 10, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 40);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.ColumnHeadersHeight = 38;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { colUsersUsername, colUsersFullName, colUsersEmail, colUsersRole, colUsersStatus, colUsersLastLogin });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(191, 219, 254);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle4;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.Font = new Font("Segoe UI", 10F);
            dgvUsers.GridColor = Color.FromArgb(226, 232, 240);
            dgvUsers.Location = new Point(3, 55);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowTemplate.Height = 32;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(999, 409);
            dgvUsers.TabIndex = 1;
            // 
            // colUsersUsername
            // 
            colUsersUsername.DataPropertyName = "Username";
            colUsersUsername.HeaderText = "Username";
            colUsersUsername.Name = "colUsersUsername";
            colUsersUsername.ReadOnly = true;
            colUsersUsername.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colUsersFullName
            // 
            colUsersFullName.DataPropertyName = "FullName";
            colUsersFullName.FillWeight = 160F;
            colUsersFullName.HeaderText = "Full name";
            colUsersFullName.Name = "colUsersFullName";
            colUsersFullName.ReadOnly = true;
            colUsersFullName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colUsersEmail
            // 
            colUsersEmail.DataPropertyName = "Email";
            colUsersEmail.FillWeight = 180F;
            colUsersEmail.HeaderText = "Email";
            colUsersEmail.Name = "colUsersEmail";
            colUsersEmail.ReadOnly = true;
            colUsersEmail.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colUsersRole
            // 
            colUsersRole.DataPropertyName = "RoleDisplay";
            colUsersRole.HeaderText = "Role";
            colUsersRole.Name = "colUsersRole";
            colUsersRole.ReadOnly = true;
            colUsersRole.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colUsersStatus
            // 
            colUsersStatus.DataPropertyName = "StatusText";
            colUsersStatus.FillWeight = 70F;
            colUsersStatus.HeaderText = "Status";
            colUsersStatus.Name = "colUsersStatus";
            colUsersStatus.ReadOnly = true;
            colUsersStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colUsersLastLogin
            // 
            colUsersLastLogin.DataPropertyName = "LastLoginAt";
            dataGridViewCellStyle3.Format = "g";
            colUsersLastLogin.DefaultCellStyle = dataGridViewCellStyle3;
            colUsersLastLogin.FillWeight = 120F;
            colUsersLastLogin.HeaderText = "Last login";
            colUsersLastLogin.Name = "colUsersLastLogin";
            colUsersLastLogin.ReadOnly = true;
            colUsersLastLogin.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // flpBottom
            // 
            flpBottom.BackColor = Color.Transparent;
            flpBottom.Controls.Add(btnAdd);
            flpBottom.Controls.Add(btnEdit);
            flpBottom.Controls.Add(btnToggle);
            flpBottom.Controls.Add(btnReset);
            flpBottom.Dock = DockStyle.Fill;
            flpBottom.Location = new Point(3, 470);
            flpBottom.Name = "flpBottom";
            flpBottom.Padding = new Padding(0, 2, 0, 2);
            flpBottom.Size = new Size(999, 50);
            flpBottom.TabIndex = 2;
            flpBottom.WrapContents = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(17, 24, 39);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 6);
            btnAdd.Margin = new Padding(0, 4, 10, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 40);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add user";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(226, 232, 240);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.ForeColor = Color.FromArgb(30, 41, 59);
            btnEdit.Location = new Point(140, 6);
            btnEdit.Margin = new Padding(0, 4, 10, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 40);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnToggle
            // 
            btnToggle.BackColor = Color.FromArgb(226, 232, 240);
            btnToggle.Cursor = Cursors.Hand;
            btnToggle.FlatAppearance.BorderSize = 0;
            btnToggle.FlatStyle = FlatStyle.Flat;
            btnToggle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnToggle.ForeColor = Color.FromArgb(30, 41, 59);
            btnToggle.Location = new Point(250, 6);
            btnToggle.Margin = new Padding(0, 4, 10, 4);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(160, 40);
            btnToggle.TabIndex = 2;
            btnToggle.Text = "Enable / disable";
            btnToggle.UseVisualStyleBackColor = false;
            btnToggle.Click += btnToggle_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(226, 232, 240);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReset.ForeColor = Color.FromArgb(30, 41, 59);
            btnReset.Location = new Point(420, 6);
            btnReset.Margin = new Padding(0, 4, 10, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 40);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset password";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // UsersPage
            // 
            Controls.Add(tlpMain);
            Name = "UsersPage";
            Size = new Size(1045, 563);
            tlpMain.ResumeLayout(false);
            flpTop.ResumeLayout(false);
            flpTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            flpBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsersUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsersFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsersEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsersRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsersStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsersLastLogin;
        private System.Windows.Forms.FlowLayoutPanel flpBottom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnReset;
    }
}
