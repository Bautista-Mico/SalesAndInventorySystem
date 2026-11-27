namespace SalesInventory.UI
{
    partial class DashboardPage
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tlpMain = new TableLayoutPanel();
            flpKpis = new FlowLayoutPanel();
            pnlKpiSales = new Panel();
            lblSalesCaption = new Label();
            lblSales = new Label();
            pnlKpiTransactions = new Panel();
            lblTransactionsCaption = new Label();
            lblTransactions = new Label();
            pnlKpiProducts = new Panel();
            lblProductsCaption = new Label();
            lblProducts = new Label();
            pnlKpiLowStock = new Panel();
            lblLowStockCaption = new Label();
            lblLowStock = new Label();
            pnlKpiValue = new Panel();
            lblValueCaption = new Label();
            lblValue = new Label();
            lblHeading = new Label();
            dgvLowStock = new DataGridView();
            colLowStockSKU = new DataGridViewTextBoxColumn();
            colLowStockProduct = new DataGridViewTextBoxColumn();
            colLowStockCategory = new DataGridViewTextBoxColumn();
            colLowStockOnHand = new DataGridViewTextBoxColumn();
            colLowStockReorderPoint = new DataGridViewTextBoxColumn();
            colLowStockSupplier = new DataGridViewTextBoxColumn();
            flpQuick = new FlowLayoutPanel();
            btnNewSale = new Button();
            btnCatalog = new Button();
            btnStockUpdate = new Button();
            tlpMain.SuspendLayout();
            flpKpis.SuspendLayout();
            pnlKpiSales.SuspendLayout();
            pnlKpiTransactions.SuspendLayout();
            pnlKpiProducts.SuspendLayout();
            pnlKpiLowStock.SuspendLayout();
            pnlKpiValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            flpQuick.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.Transparent;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(flpKpis, 0, 0);
            tlpMain.Controls.Add(lblHeading, 0, 1);
            tlpMain.Controls.Add(dgvLowStock, 0, 2);
            tlpMain.Controls.Add(flpQuick, 0, 3);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(20, 20);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tlpMain.Size = new Size(844, 325);
            tlpMain.TabIndex = 0;
            // 
            // flpKpis
            // 
            flpKpis.BackColor = Color.Transparent;
            flpKpis.Controls.Add(pnlKpiSales);
            flpKpis.Controls.Add(pnlKpiTransactions);
            flpKpis.Controls.Add(pnlKpiProducts);
            flpKpis.Controls.Add(pnlKpiLowStock);
            flpKpis.Controls.Add(pnlKpiValue);
            flpKpis.Dock = DockStyle.Fill;
            flpKpis.Location = new Point(3, 3);
            flpKpis.Name = "flpKpis";
            flpKpis.Size = new Size(838, 104);
            flpKpis.TabIndex = 0;
            flpKpis.WrapContents = false;
            // 
            // pnlKpiSales
            // 
            pnlKpiSales.BackColor = Color.White;
            pnlKpiSales.BorderStyle = BorderStyle.FixedSingle;
            pnlKpiSales.Controls.Add(lblSalesCaption);
            pnlKpiSales.Controls.Add(lblSales);
            pnlKpiSales.Location = new Point(0, 4);
            pnlKpiSales.Margin = new Padding(0, 4, 14, 4);
            pnlKpiSales.Name = "pnlKpiSales";
            pnlKpiSales.Size = new Size(215, 92);
            pnlKpiSales.TabIndex = 0;
            // 
            // lblSalesCaption
            // 
            lblSalesCaption.AutoSize = true;
            lblSalesCaption.BackColor = Color.Transparent;
            lblSalesCaption.Font = new Font("Segoe UI", 10F);
            lblSalesCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblSalesCaption.Location = new Point(12, 10);
            lblSalesCaption.Margin = new Padding(0, 8, 8, 0);
            lblSalesCaption.Name = "lblSalesCaption";
            lblSalesCaption.Size = new Size(87, 19);
            lblSalesCaption.TabIndex = 0;
            lblSalesCaption.Text = "Today's sales";
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSales.ForeColor = Color.FromArgb(17, 24, 39);
            lblSales.Location = new Point(10, 38);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(24, 32);
            lblSales.TabIndex = 1;
            lblSales.Text = "-";
            // 
            // pnlKpiTransactions
            // 
            pnlKpiTransactions.BackColor = Color.White;
            pnlKpiTransactions.BorderStyle = BorderStyle.FixedSingle;
            pnlKpiTransactions.Controls.Add(lblTransactionsCaption);
            pnlKpiTransactions.Controls.Add(lblTransactions);
            pnlKpiTransactions.Location = new Point(229, 4);
            pnlKpiTransactions.Margin = new Padding(0, 4, 14, 4);
            pnlKpiTransactions.Name = "pnlKpiTransactions";
            pnlKpiTransactions.Size = new Size(215, 92);
            pnlKpiTransactions.TabIndex = 1;
            // 
            // lblTransactionsCaption
            // 
            lblTransactionsCaption.AutoSize = true;
            lblTransactionsCaption.BackColor = Color.Transparent;
            lblTransactionsCaption.Font = new Font("Segoe UI", 10F);
            lblTransactionsCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblTransactionsCaption.Location = new Point(12, 10);
            lblTransactionsCaption.Margin = new Padding(0, 8, 8, 0);
            lblTransactionsCaption.Name = "lblTransactionsCaption";
            lblTransactionsCaption.Size = new Size(123, 19);
            lblTransactionsCaption.TabIndex = 0;
            lblTransactionsCaption.Text = "Transactions today";
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTransactions.ForeColor = Color.FromArgb(17, 24, 39);
            lblTransactions.Location = new Point(10, 38);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(24, 32);
            lblTransactions.TabIndex = 1;
            lblTransactions.Text = "-";
            // 
            // pnlKpiProducts
            // 
            pnlKpiProducts.BackColor = Color.White;
            pnlKpiProducts.BorderStyle = BorderStyle.FixedSingle;
            pnlKpiProducts.Controls.Add(lblProductsCaption);
            pnlKpiProducts.Controls.Add(lblProducts);
            pnlKpiProducts.Location = new Point(458, 4);
            pnlKpiProducts.Margin = new Padding(0, 4, 14, 4);
            pnlKpiProducts.Name = "pnlKpiProducts";
            pnlKpiProducts.Size = new Size(215, 92);
            pnlKpiProducts.TabIndex = 2;
            // 
            // lblProductsCaption
            // 
            lblProductsCaption.AutoSize = true;
            lblProductsCaption.BackColor = Color.Transparent;
            lblProductsCaption.Font = new Font("Segoe UI", 10F);
            lblProductsCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblProductsCaption.Location = new Point(12, 10);
            lblProductsCaption.Margin = new Padding(0, 8, 8, 0);
            lblProductsCaption.Name = "lblProductsCaption";
            lblProductsCaption.Size = new Size(104, 19);
            lblProductsCaption.TabIndex = 0;
            lblProductsCaption.Text = "Active products";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblProducts.ForeColor = Color.FromArgb(17, 24, 39);
            lblProducts.Location = new Point(10, 38);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(24, 32);
            lblProducts.TabIndex = 1;
            lblProducts.Text = "-";
            // 
            // pnlKpiLowStock
            // 
            pnlKpiLowStock.BackColor = Color.White;
            pnlKpiLowStock.BorderStyle = BorderStyle.FixedSingle;
            pnlKpiLowStock.Controls.Add(lblLowStockCaption);
            pnlKpiLowStock.Controls.Add(lblLowStock);
            pnlKpiLowStock.Location = new Point(687, 4);
            pnlKpiLowStock.Margin = new Padding(0, 4, 14, 4);
            pnlKpiLowStock.Name = "pnlKpiLowStock";
            pnlKpiLowStock.Size = new Size(215, 92);
            pnlKpiLowStock.TabIndex = 3;
            // 
            // lblLowStockCaption
            // 
            lblLowStockCaption.AutoSize = true;
            lblLowStockCaption.BackColor = Color.Transparent;
            lblLowStockCaption.Font = new Font("Segoe UI", 10F);
            lblLowStockCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblLowStockCaption.Location = new Point(12, 10);
            lblLowStockCaption.Margin = new Padding(0, 8, 8, 0);
            lblLowStockCaption.Name = "lblLowStockCaption";
            lblLowStockCaption.Size = new Size(109, 19);
            lblLowStockCaption.TabIndex = 0;
            lblLowStockCaption.Text = "Low-stock items";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLowStock.ForeColor = Color.FromArgb(17, 24, 39);
            lblLowStock.Location = new Point(10, 38);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(24, 32);
            lblLowStock.TabIndex = 1;
            lblLowStock.Text = "-";
            // 
            // pnlKpiValue
            // 
            pnlKpiValue.BackColor = Color.White;
            pnlKpiValue.BorderStyle = BorderStyle.FixedSingle;
            pnlKpiValue.Controls.Add(lblValueCaption);
            pnlKpiValue.Controls.Add(lblValue);
            pnlKpiValue.Location = new Point(916, 4);
            pnlKpiValue.Margin = new Padding(0, 4, 14, 4);
            pnlKpiValue.Name = "pnlKpiValue";
            pnlKpiValue.Size = new Size(215, 92);
            pnlKpiValue.TabIndex = 4;
            // 
            // lblValueCaption
            // 
            lblValueCaption.AutoSize = true;
            lblValueCaption.BackColor = Color.Transparent;
            lblValueCaption.Font = new Font("Segoe UI", 10F);
            lblValueCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblValueCaption.Location = new Point(12, 10);
            lblValueCaption.Margin = new Padding(0, 8, 8, 0);
            lblValueCaption.Name = "lblValueCaption";
            lblValueCaption.Size = new Size(141, 19);
            lblValueCaption.TabIndex = 0;
            lblValueCaption.Text = "Inventory value (cost)";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblValue.ForeColor = Color.FromArgb(17, 24, 39);
            lblValue.Location = new Point(10, 38);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(24, 32);
            lblValue.TabIndex = 1;
            lblValue.Text = "-";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.BackColor = Color.Transparent;
            lblHeading.Dock = DockStyle.Fill;
            lblHeading.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblHeading.ForeColor = Color.FromArgb(30, 41, 59);
            lblHeading.Location = new Point(0, 118);
            lblHeading.Margin = new Padding(0, 8, 8, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(836, 28);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "Items at or below their reorder point";
            // 
            // dgvLowStock
            // 
            dgvLowStock.AllowUserToAddRows = false;
            dgvLowStock.AllowUserToDeleteRows = false;
            dgvLowStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvLowStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLowStock.BackgroundColor = Color.White;
            dgvLowStock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLowStock.ColumnHeadersHeight = 38;
            dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLowStock.Columns.AddRange(new DataGridViewColumn[] { colLowStockSKU, colLowStockProduct, colLowStockCategory, colLowStockOnHand, colLowStockReorderPoint, colLowStockSupplier });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(191, 219, 254);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvLowStock.DefaultCellStyle = dataGridViewCellStyle5;
            dgvLowStock.Dock = DockStyle.Fill;
            dgvLowStock.EnableHeadersVisualStyles = false;
            dgvLowStock.Font = new Font("Segoe UI", 10F);
            dgvLowStock.GridColor = Color.FromArgb(226, 232, 240);
            dgvLowStock.Location = new Point(3, 149);
            dgvLowStock.MultiSelect = false;
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.ReadOnly = true;
            dgvLowStock.RowHeadersVisible = false;
            dgvLowStock.RowTemplate.Height = 32;
            dgvLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLowStock.Size = new Size(838, 117);
            dgvLowStock.TabIndex = 2;
            // 
            // colLowStockSKU
            // 
            colLowStockSKU.DataPropertyName = "SKU";
            colLowStockSKU.FillWeight = 80F;
            colLowStockSKU.HeaderText = "SKU";
            colLowStockSKU.Name = "colLowStockSKU";
            colLowStockSKU.ReadOnly = true;
            colLowStockSKU.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colLowStockProduct
            // 
            colLowStockProduct.DataPropertyName = "Name";
            colLowStockProduct.FillWeight = 220F;
            colLowStockProduct.HeaderText = "Product";
            colLowStockProduct.Name = "colLowStockProduct";
            colLowStockProduct.ReadOnly = true;
            colLowStockProduct.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colLowStockCategory
            // 
            colLowStockCategory.DataPropertyName = "CategoryName";
            colLowStockCategory.FillWeight = 120F;
            colLowStockCategory.HeaderText = "Category";
            colLowStockCategory.Name = "colLowStockCategory";
            colLowStockCategory.ReadOnly = true;
            colLowStockCategory.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colLowStockOnHand
            // 
            colLowStockOnHand.DataPropertyName = "QtyOnHand";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colLowStockOnHand.DefaultCellStyle = dataGridViewCellStyle3;
            colLowStockOnHand.FillWeight = 70F;
            colLowStockOnHand.HeaderText = "On hand";
            colLowStockOnHand.Name = "colLowStockOnHand";
            colLowStockOnHand.ReadOnly = true;
            colLowStockOnHand.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colLowStockReorderPoint
            // 
            colLowStockReorderPoint.DataPropertyName = "ReorderPoint";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            colLowStockReorderPoint.DefaultCellStyle = dataGridViewCellStyle4;
            colLowStockReorderPoint.FillWeight = 80F;
            colLowStockReorderPoint.HeaderText = "Reorder point";
            colLowStockReorderPoint.Name = "colLowStockReorderPoint";
            colLowStockReorderPoint.ReadOnly = true;
            colLowStockReorderPoint.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colLowStockSupplier
            // 
            colLowStockSupplier.DataPropertyName = "SupplierName";
            colLowStockSupplier.FillWeight = 140F;
            colLowStockSupplier.HeaderText = "Supplier";
            colLowStockSupplier.Name = "colLowStockSupplier";
            colLowStockSupplier.ReadOnly = true;
            colLowStockSupplier.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // flpQuick
            // 
            flpQuick.BackColor = Color.Transparent;
            flpQuick.Controls.Add(btnNewSale);
            flpQuick.Controls.Add(btnCatalog);
            flpQuick.Controls.Add(btnStockUpdate);
            flpQuick.Dock = DockStyle.Fill;
            flpQuick.Location = new Point(3, 272);
            flpQuick.Name = "flpQuick";
            flpQuick.Padding = new Padding(0, 2, 0, 2);
            flpQuick.Size = new Size(838, 50);
            flpQuick.TabIndex = 3;
            flpQuick.WrapContents = false;
            // 
            // btnNewSale
            // 
            btnNewSale.BackColor = Color.FromArgb(17, 24, 39);
            btnNewSale.Cursor = Cursors.Hand;
            btnNewSale.FlatAppearance.BorderSize = 0;
            btnNewSale.FlatStyle = FlatStyle.Flat;
            btnNewSale.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNewSale.ForeColor = Color.White;
            btnNewSale.Location = new Point(0, 6);
            btnNewSale.Margin = new Padding(0, 4, 10, 4);
            btnNewSale.Name = "btnNewSale";
            btnNewSale.Size = new Size(150, 40);
            btnNewSale.TabIndex = 0;
            btnNewSale.Text = "New sale";
            btnNewSale.UseVisualStyleBackColor = false;
            btnNewSale.Click += btnNewSale_Click;
            // 
            // btnCatalog
            // 
            btnCatalog.BackColor = Color.FromArgb(226, 232, 240);
            btnCatalog.Cursor = Cursors.Hand;
            btnCatalog.FlatAppearance.BorderSize = 0;
            btnCatalog.FlatStyle = FlatStyle.Flat;
            btnCatalog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCatalog.ForeColor = Color.FromArgb(30, 41, 59);
            btnCatalog.Location = new Point(160, 6);
            btnCatalog.Margin = new Padding(0, 4, 10, 4);
            btnCatalog.Name = "btnCatalog";
            btnCatalog.Size = new Size(160, 40);
            btnCatalog.TabIndex = 1;
            btnCatalog.Text = "Product catalog";
            btnCatalog.UseVisualStyleBackColor = false;
            btnCatalog.Click += btnCatalog_Click;
            // 
            // btnStockUpdate
            // 
            btnStockUpdate.BackColor = Color.FromArgb(226, 232, 240);
            btnStockUpdate.Cursor = Cursors.Hand;
            btnStockUpdate.FlatAppearance.BorderSize = 0;
            btnStockUpdate.FlatStyle = FlatStyle.Flat;
            btnStockUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStockUpdate.ForeColor = Color.FromArgb(30, 41, 59);
            btnStockUpdate.Location = new Point(330, 6);
            btnStockUpdate.Margin = new Padding(0, 4, 10, 4);
            btnStockUpdate.Name = "btnStockUpdate";
            btnStockUpdate.Size = new Size(150, 40);
            btnStockUpdate.TabIndex = 2;
            btnStockUpdate.Text = "Stock update";
            btnStockUpdate.UseVisualStyleBackColor = false;
            btnStockUpdate.Click += btnStockUpdate_Click;
            // 
            // DashboardPage
            // 
            Controls.Add(tlpMain);
            Name = "DashboardPage";
            Size = new Size(884, 365);
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            flpKpis.ResumeLayout(false);
            pnlKpiSales.ResumeLayout(false);
            pnlKpiSales.PerformLayout();
            pnlKpiTransactions.ResumeLayout(false);
            pnlKpiTransactions.PerformLayout();
            pnlKpiProducts.ResumeLayout(false);
            pnlKpiProducts.PerformLayout();
            pnlKpiLowStock.ResumeLayout(false);
            pnlKpiLowStock.PerformLayout();
            pnlKpiValue.ResumeLayout(false);
            pnlKpiValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            flpQuick.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpKpis;
        private System.Windows.Forms.Panel pnlKpiSales;
        private System.Windows.Forms.Label lblSalesCaption;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Panel pnlKpiTransactions;
        private System.Windows.Forms.Label lblTransactionsCaption;
        private System.Windows.Forms.Label lblTransactions;
        private System.Windows.Forms.Panel pnlKpiProducts;
        private System.Windows.Forms.Label lblProductsCaption;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Panel pnlKpiLowStock;
        private System.Windows.Forms.Label lblLowStockCaption;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Panel pnlKpiValue;
        private System.Windows.Forms.Label lblValueCaption;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView dgvLowStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLowStockSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLowStockProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLowStockCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLowStockOnHand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLowStockReorderPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLowStockSupplier;
        private System.Windows.Forms.FlowLayoutPanel flpQuick;
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.Button btnCatalog;
        private System.Windows.Forms.Button btnStockUpdate;
    }
}
