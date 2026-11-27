namespace SalesInventory.UI
{
    partial class ProductsPage
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tlpMain = new TableLayoutPanel();
            flpTop = new FlowLayoutPanel();
            txtSearch = new TextBox();
            cmbCategory = new ComboBox();
            chkInactive = new CheckBox();
            chkLowStock = new CheckBox();
            btnSearch = new Button();
            dgvProducts = new DataGridView();
            flpBottom = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnReactivate = new Button();
            btnRefresh = new Button();
            tlpMain.SuspendLayout();
            flpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            flpBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.Transparent;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(flpTop, 0, 0);
            tlpMain.Controls.Add(dgvProducts, 0, 1);
            tlpMain.Controls.Add(flpBottom, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(20, 20);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tlpMain.Size = new Size(817, 325);
            tlpMain.TabIndex = 0;
            // 
            // flpTop
            // 
            flpTop.BackColor = Color.Transparent;
            flpTop.Controls.Add(txtSearch);
            flpTop.Controls.Add(cmbCategory);
            flpTop.Controls.Add(chkInactive);
            flpTop.Controls.Add(chkLowStock);
            flpTop.Controls.Add(btnSearch);
            flpTop.Dock = DockStyle.Fill;
            flpTop.Location = new Point(3, 3);
            flpTop.Name = "flpTop";
            flpTop.Padding = new Padding(0, 2, 0, 2);
            flpTop.Size = new Size(811, 46);
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
            txtSearch.PlaceholderText = "Search by name, category or SKU...";
            txtSearch.Size = new Size(380, 25);
            txtSearch.TabIndex = 0;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(390, 8);
            cmbCategory.Margin = new Padding(0, 6, 10, 6);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 25);
            cmbCategory.TabIndex = 1;
            // 
            // chkInactive
            // 
            chkInactive.AutoSize = true;
            chkInactive.Location = new Point(600, 14);
            chkInactive.Margin = new Padding(0, 12, 10, 0);
            chkInactive.Name = "chkInactive";
            chkInactive.Size = new Size(111, 23);
            chkInactive.TabIndex = 2;
            chkInactive.Text = "Show inactive";
            // 
            // chkLowStock
            // 
            chkLowStock.AutoSize = true;
            chkLowStock.Location = new Point(721, 14);
            chkLowStock.Margin = new Padding(0, 12, 10, 0);
            chkLowStock.Name = "chkLowStock";
            chkLowStock.Size = new Size(119, 23);
            chkLowStock.TabIndex = 3;
            chkLowStock.Text = "Low stock only";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(226, 232, 240);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.FromArgb(30, 41, 59);
            btnSearch.Location = new Point(850, 6);
            btnSearch.Margin = new Padding(0, 4, 10, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 40);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.ColumnHeadersHeight = 38;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(191, 219, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.Font = new Font("Segoe UI", 10F);
            dgvProducts.GridColor = Color.FromArgb(226, 232, 240);
            dgvProducts.Location = new Point(3, 55);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowTemplate.Height = 32;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(811, 211);
            dgvProducts.TabIndex = 1;
            // 
            // flpBottom
            // 
            flpBottom.BackColor = Color.Transparent;
            flpBottom.Controls.Add(btnAdd);
            flpBottom.Controls.Add(btnEdit);
            flpBottom.Controls.Add(btnDelete);
            flpBottom.Controls.Add(btnReactivate);
            flpBottom.Controls.Add(btnRefresh);
            flpBottom.Dock = DockStyle.Fill;
            flpBottom.Location = new Point(3, 272);
            flpBottom.Name = "flpBottom";
            flpBottom.Padding = new Padding(0, 2, 0, 2);
            flpBottom.Size = new Size(811, 50);
            flpBottom.TabIndex = 2;
            flpBottom.WrapContents = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(71, 85, 105);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 6);
            btnAdd.Margin = new Padding(0, 4, 10, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 40);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add product";
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
            btnEdit.Location = new Point(160, 6);
            btnEdit.Margin = new Padding(0, 4, 10, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 40);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 38, 38);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(280, 6);
            btnDelete.Margin = new Padding(0, 4, 10, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete / Archive";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReactivate
            // 
            btnReactivate.BackColor = Color.FromArgb(226, 232, 240);
            btnReactivate.Cursor = Cursors.Hand;
            btnReactivate.FlatAppearance.BorderSize = 0;
            btnReactivate.FlatStyle = FlatStyle.Flat;
            btnReactivate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReactivate.ForeColor = Color.FromArgb(30, 41, 59);
            btnReactivate.Location = new Point(450, 6);
            btnReactivate.Margin = new Padding(0, 4, 10, 4);
            btnReactivate.Name = "btnReactivate";
            btnReactivate.Size = new Size(120, 40);
            btnReactivate.TabIndex = 3;
            btnReactivate.Text = "Reactivate";
            btnReactivate.UseVisualStyleBackColor = false;
            btnReactivate.Click += btnReactivate_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(226, 232, 240);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(30, 41, 59);
            btnRefresh.Location = new Point(580, 6);
            btnRefresh.Margin = new Padding(0, 4, 10, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 40);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ProductsPage
            // 
            Controls.Add(tlpMain);
            Name = "ProductsPage";
            Size = new Size(857, 365);
            tlpMain.ResumeLayout(false);
            flpTop.ResumeLayout(false);
            flpTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            flpBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.CheckBox chkInactive;
        private System.Windows.Forms.CheckBox chkLowStock;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.FlowLayoutPanel flpBottom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReactivate;
        private System.Windows.Forms.Button btnRefresh;
    }
}
