#nullable disable
namespace UI;

partial class AdminPortalForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlTop = new Panel();
        txtSearch = new TextBox();
        btnSearch = new Button();
        btnShowAll = new Button();
        dgvUsers = new DataGridView();
        pnlForm = new Panel();
        lblUsername = new Label();
        txtUsername = new TextBox();
        lblFullName = new Label();
        txtFullName = new TextBox();
        lblPassword = new Label();
        txtPassword = new TextBox();
        lblRole = new Label();
        cboRole = new ComboBox();
        chkActive = new CheckBox();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnUnlock = new Button();
        btnClear = new Button();
        lblStatus = new Label();
        pnlTop.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
        pnlForm.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTop
        // 
        pnlTop.Controls.Add(txtSearch);
        pnlTop.Controls.Add(btnSearch);
        pnlTop.Controls.Add(btnShowAll);
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Location = new Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(960, 50);
        pnlTop.TabIndex = 2;
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(12, 13);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search username or full name";
        txtSearch.Size = new Size(260, 27);
        txtSearch.TabIndex = 0;
        txtSearch.KeyDown += txtSearch_KeyDown;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(284, 11);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(90, 30);
        btnSearch.TabIndex = 1;
        btnSearch.Text = "Search";
        btnSearch.Click += btnSearch_Click;
        // 
        // btnShowAll
        // 
        btnShowAll.Location = new Point(380, 11);
        btnShowAll.Name = "btnShowAll";
        btnShowAll.Size = new Size(90, 30);
        btnShowAll.TabIndex = 2;
        btnShowAll.Text = "Show All";
        btnShowAll.Click += btnShowAll_Click;
        // 
        // dgvUsers
        // 
        dgvUsers.AllowUserToAddRows = false;
        dgvUsers.AllowUserToDeleteRows = false;
        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvUsers.ColumnHeadersHeight = 29;
        dgvUsers.Dock = DockStyle.Fill;
        dgvUsers.Location = new Point(0, 50);
        dgvUsers.MultiSelect = false;
        dgvUsers.Name = "dgvUsers";
        dgvUsers.ReadOnly = true;
        dgvUsers.RowHeadersVisible = false;
        dgvUsers.RowHeadersWidth = 51;
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvUsers.Size = new Size(660, 484);
        dgvUsers.TabIndex = 0;
        dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;
        // 
        // pnlForm
        // 
        pnlForm.Controls.Add(lblUsername);
        pnlForm.Controls.Add(txtUsername);
        pnlForm.Controls.Add(lblFullName);
        pnlForm.Controls.Add(txtFullName);
        pnlForm.Controls.Add(lblPassword);
        pnlForm.Controls.Add(txtPassword);
        pnlForm.Controls.Add(lblRole);
        pnlForm.Controls.Add(cboRole);
        pnlForm.Controls.Add(chkActive);
        pnlForm.Controls.Add(btnAdd);
        pnlForm.Controls.Add(btnUpdate);
        pnlForm.Controls.Add(btnDelete);
        pnlForm.Controls.Add(btnUnlock);
        pnlForm.Controls.Add(btnClear);
        pnlForm.Dock = DockStyle.Right;
        pnlForm.Location = new Point(660, 50);
        pnlForm.Name = "pnlForm";
        pnlForm.Size = new Size(300, 484);
        pnlForm.TabIndex = 1;
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Location = new Point(12, 23);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(75, 20);
        lblUsername.TabIndex = 0;
        lblUsername.Text = "Username";
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(100, 20);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(180, 27);
        txtUsername.TabIndex = 1;
        // 
        // lblFullName
        // 
        lblFullName.AutoSize = true;
        lblFullName.Location = new Point(12, 63);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new Size(73, 20);
        lblFullName.TabIndex = 2;
        lblFullName.Text = "Full name";
        // 
        // txtFullName
        // 
        txtFullName.Location = new Point(100, 60);
        txtFullName.Name = "txtFullName";
        txtFullName.Size = new Size(180, 27);
        txtFullName.TabIndex = 3;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Location = new Point(12, 103);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(70, 20);
        lblPassword.TabIndex = 4;
        lblPassword.Text = "Password";
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(100, 100);
        txtPassword.Name = "txtPassword";
        txtPassword.PlaceholderText = "(blank = keep current)";
        txtPassword.Size = new Size(180, 27);
        txtPassword.TabIndex = 5;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // lblRole
        // 
        lblRole.AutoSize = true;
        lblRole.Location = new Point(12, 143);
        lblRole.Name = "lblRole";
        lblRole.Size = new Size(39, 20);
        lblRole.TabIndex = 6;
        lblRole.Text = "Role";
        // 
        // cboRole
        // 
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRole.Items.AddRange(new object[] { "Admin", "Manager", "Cashier" });
        cboRole.Location = new Point(100, 140);
        cboRole.Name = "cboRole";
        cboRole.Size = new Size(180, 28);
        cboRole.TabIndex = 7;
        // 
        // chkActive
        // 
        chkActive.AutoSize = true;
        chkActive.Checked = true;
        chkActive.CheckState = CheckState.Checked;
        chkActive.Location = new Point(100, 182);
        chkActive.Name = "chkActive";
        chkActive.Size = new Size(72, 24);
        chkActive.TabIndex = 8;
        chkActive.Text = "Active";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(12, 230);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(80, 32);
        btnAdd.TabIndex = 9;
        btnAdd.Text = "Add";
        btnAdd.Click += btnAdd_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(100, 230);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(80, 32);
        btnUpdate.TabIndex = 10;
        btnUpdate.Text = "Update";
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(188, 230);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(80, 32);
        btnDelete.TabIndex = 11;
        btnDelete.Text = "Delete";
        btnDelete.Click += btnDelete_Click;
        // 
        // btnUnlock
        // 
        btnUnlock.Location = new Point(12, 272);
        btnUnlock.Name = "btnUnlock";
        btnUnlock.Size = new Size(80, 32);
        btnUnlock.TabIndex = 12;
        btnUnlock.Text = "Unlock";
        btnUnlock.Click += btnUnlock_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(100, 272);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(80, 32);
        btnClear.TabIndex = 13;
        btnClear.Text = "Clear";
        btnClear.Click += btnClear_Click;
        // 
        // lblStatus
        // 
        lblStatus.Dock = DockStyle.Bottom;
        lblStatus.Location = new Point(0, 534);
        lblStatus.Name = "lblStatus";
        lblStatus.Padding = new Padding(8, 5, 0, 0);
        lblStatus.Size = new Size(960, 26);
        lblStatus.TabIndex = 3;
        // 
        // AdminPortalForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(960, 560);
        Controls.Add(dgvUsers);
        Controls.Add(pnlForm);
        Controls.Add(pnlTop);
        Controls.Add(lblStatus);
        Name = "AdminPortalForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Administrator Portal - User Management";
        Load += AdminPortalForm_Load;
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
        pnlForm.ResumeLayout(false);
        pnlForm.PerformLayout();
        ResumeLayout(false);
    }

    private Panel pnlTop;
    private TextBox txtSearch;
    private Button btnSearch;
    private Button btnShowAll;
    private DataGridView dgvUsers;
    private Panel pnlForm;
    private Label lblUsername;
    private TextBox txtUsername;
    private Label lblFullName;
    private TextBox txtFullName;
    private Label lblPassword;
    private TextBox txtPassword;
    private Label lblRole;
    private ComboBox cboRole;
    private CheckBox chkActive;
    private Button btnAdd;
    private Button btnUpdate;
    private Button btnDelete;
    private Button btnUnlock;
    private Button btnClear;
    private Label lblStatus;
}