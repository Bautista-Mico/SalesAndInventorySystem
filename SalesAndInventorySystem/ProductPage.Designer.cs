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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.flpTop = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.chkInactive = new System.Windows.Forms.CheckBox();
            this.chkLowStock = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.flpBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReactivate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.flpTop.SuspendLayout();
            this.flpBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.RowCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlpMain.Controls.Add(this.flpTop, 0, 0);
            this.tlpMain.Controls.Add(this.dgvProducts, 0, 1);
            this.tlpMain.Controls.Add(this.flpBottom, 0, 2);
            // 
            // flpTop
            // 
            this.flpTop.BackColor = System.Drawing.Color.Transparent;
            this.flpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTop.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flpTop.WrapContents = false;
            this.flpTop.Controls.Add(this.txtSearch);
            this.flpTop.Controls.Add(this.cmbCategory);
            this.flpTop.Controls.Add(this.chkInactive);
            this.flpTop.Controls.Add(this.chkLowStock);
            this.flpTop.Controls.Add(this.btnSearch);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0, 6, 10, 6);
            this.txtSearch.PlaceholderText = "Search by name, category or SKU...";
            this.txtSearch.Size = new System.Drawing.Size(380, 25);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(0, 6, 10, 6);
            this.cmbCategory.Size = new System.Drawing.Size(200, 25);
            // 
            // chkInactive
            // 
            this.chkInactive.AutoSize = true;
            this.chkInactive.Margin = new System.Windows.Forms.Padding(0, 12, 10, 0);
            this.chkInactive.Text = "Show inactive";
            // 
            // chkLowStock
            // 
            this.chkLowStock.AutoSize = true;
            this.chkLowStock.Margin = new System.Windows.Forms.Padding(0, 12, 10, 0);
            this.chkLowStock.Text = "Low stock only";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnSearch.Size = new System.Drawing.Size(90, 40);
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(191, 219, 254);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.ColumnHeadersHeight = 38;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowTemplate.Height = 32;
            // 
            // flpBottom
            // 
            this.flpBottom.BackColor = System.Drawing.Color.Transparent;
            this.flpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBottom.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flpBottom.WrapContents = false;
            this.flpBottom.Controls.Add(this.btnAdd);
            this.flpBottom.Controls.Add(this.btnEdit);
            this.flpBottom.Controls.Add(this.btnDelete);
            this.flpBottom.Controls.Add(this.btnReactivate);
            this.flpBottom.Controls.Add(this.btnRefresh);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.Text = "Add product";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnEdit.Size = new System.Drawing.Size(110, 40);
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnDelete.Size = new System.Drawing.Size(160, 40);
            this.btnDelete.Text = "Delete / Archive";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReactivate
            // 
            this.btnReactivate.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnReactivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReactivate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReactivate.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnReactivate.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnReactivate.Size = new System.Drawing.Size(120, 40);
            this.btnReactivate.Text = "Reactivate";
            this.btnReactivate.UseVisualStyleBackColor = false;
            this.btnReactivate.FlatAppearance.BorderSize = 0;
            this.btnReactivate.Click += new System.EventHandler(this.btnReactivate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnRefresh.Size = new System.Drawing.Size(110, 40);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ProductsPage
            // 
            this.Size = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.tlpMain);
            this.Name = "ProductsPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.flpBottom.ResumeLayout(false);
            this.flpBottom.PerformLayout();
            this.flpTop.ResumeLayout(false);
            this.flpTop.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);
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
