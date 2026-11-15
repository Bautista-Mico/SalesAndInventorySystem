namespace SalesInventory.UI
{
    partial class PosPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.components = new System.ComponentModel.Container();
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.colCartSKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.flpAdd = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoveLine = new System.Windows.Forms.Button();
            this.btnOverride = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.flpStack = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbCustomerType = new System.Windows.Forms.ComboBox();
            this.txtCustomerRef = new System.Windows.Forms.TextBox();
            this.txtDiscountCode = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.pnlSpacer1 = new System.Windows.Forms.Panel();
            this.pnlSubtotal = new System.Windows.Forms.Panel();
            this.lblSubtotalCaption = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.pnlDiscount = new System.Windows.Forms.Panel();
            this.lblDiscountCaption = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.pnlVat = new System.Windows.Forms.Panel();
            this.lblVatCaption = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlSpacer2 = new System.Windows.Forms.Panel();
            this.flpHoldRecall = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnRecall = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.tlpRoot.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.flpAdd.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.flpStack.SuspendLayout();
            this.pnlSpacer1.SuspendLayout();
            this.pnlSubtotal.SuspendLayout();
            this.pnlDiscount.SuspendLayout();
            this.pnlVat.SuspendLayout();
            this.pnlSpacer2.SuspendLayout();
            this.flpHoldRecall.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 2;
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.RowCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tlpRoot.Controls.Add(this.tlpLeft, 0, 0);
            this.tlpRoot.Controls.Add(this.pnlRight, 1, 0);
            // 
            // tlpLeft
            // 
            this.tlpLeft.BackColor = System.Drawing.Color.Transparent;
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.RowCount = 2;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlpLeft.Controls.Add(this.dgvCart, 0, 0);
            this.tlpLeft.Controls.Add(this.pnlAdd, 0, 1);
            // 
            // dgvCart
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(191, 219, 254);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCart.ColumnHeadersHeight = 38;
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.EnableHeadersVisualStyles = false;
            this.dgvCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvCart.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.RowTemplate.Height = 32;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colCartSKU, this.colCartItem, this.colCartQty, this.colCartUnitPrice, this.colCartDiscount, this.colCartTotal });
            // 
            // colCartSKU
            // 
            this.colCartSKU.DataPropertyName = "SKU";
            this.colCartSKU.FillWeight = 90F;
            this.colCartSKU.HeaderText = "SKU";
            this.colCartSKU.Name = "colCartSKU";
            this.colCartSKU.ReadOnly = true;
            this.colCartSKU.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCartItem
            // 
            this.colCartItem.DataPropertyName = "ProductName";
            this.colCartItem.FillWeight = 240F;
            this.colCartItem.HeaderText = "Item";
            this.colCartItem.Name = "colCartItem";
            this.colCartItem.ReadOnly = true;
            this.colCartItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCartQty
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCartQty.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCartQty.DataPropertyName = "Quantity";
            this.colCartQty.FillWeight = 60F;
            this.colCartQty.HeaderText = "Qty";
            this.colCartQty.Name = "colCartQty";
            this.colCartQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCartUnitPrice
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.colCartUnitPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCartUnitPrice.DataPropertyName = "UnitPrice";
            this.colCartUnitPrice.FillWeight = 90F;
            this.colCartUnitPrice.HeaderText = "Unit price";
            this.colCartUnitPrice.Name = "colCartUnitPrice";
            this.colCartUnitPrice.ReadOnly = true;
            this.colCartUnitPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCartDiscount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.colCartDiscount.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCartDiscount.DataPropertyName = "Discount";
            this.colCartDiscount.FillWeight = 80F;
            this.colCartDiscount.HeaderText = "Discount";
            this.colCartDiscount.Name = "colCartDiscount";
            this.colCartDiscount.ReadOnly = true;
            this.colCartDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCartTotal
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.colCartTotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.colCartTotal.DataPropertyName = "LineTotal";
            this.colCartTotal.FillWeight = 100F;
            this.colCartTotal.HeaderText = "Total";
            this.colCartTotal.Name = "colCartTotal";
            this.colCartTotal.ReadOnly = true;
            this.colCartTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.White;
            this.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdd.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.pnlAdd.Controls.Add(this.flpAdd);
            // 
            // flpAdd
            // 
            this.flpAdd.BackColor = System.Drawing.Color.Transparent;
            this.flpAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAdd.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flpAdd.WrapContents = false;
            this.flpAdd.Controls.Add(this.txtSearch);
            this.flpAdd.Controls.Add(this.btnAdd);
            this.flpAdd.Controls.Add(this.btnRemoveLine);
            this.flpAdd.Controls.Add(this.btnOverride);
            this.flpAdd.Controls.Add(this.btnClear);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0, 6, 10, 6);
            this.txtSearch.PlaceholderText = "Scan barcode or type SKU / item name, then press Enter";
            this.txtSearch.Size = new System.Drawing.Size(430, 25);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnAdd.Size = new System.Drawing.Size(80, 40);
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveLine
            // 
            this.btnRemoveLine.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnRemoveLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveLine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveLine.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnRemoveLine.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnRemoveLine.Size = new System.Drawing.Size(120, 40);
            this.btnRemoveLine.Text = "Remove line";
            this.btnRemoveLine.UseVisualStyleBackColor = false;
            this.btnRemoveLine.FlatAppearance.BorderSize = 0;
            this.btnRemoveLine.Click += new System.EventHandler(this.btnRemoveLine_Click);
            // 
            // btnOverride
            // 
            this.btnOverride.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnOverride.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverride.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverride.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOverride.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnOverride.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnOverride.Size = new System.Drawing.Size(140, 40);
            this.btnOverride.Text = "Override price";
            this.btnOverride.UseVisualStyleBackColor = false;
            this.btnOverride.FlatAppearance.BorderSize = 0;
            this.btnOverride.Click += new System.EventHandler(this.btnOverride_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnClear.Size = new System.Drawing.Size(80, 40);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.pnlRight.Controls.Add(this.flpStack);
            // 
            // flpStack
            // 
            this.flpStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpStack.WrapContents = false;
            this.flpStack.Controls.Add(this.lblCustomer);
            this.flpStack.Controls.Add(this.cmbCustomerType);
            this.flpStack.Controls.Add(this.txtCustomerRef);
            this.flpStack.Controls.Add(this.txtDiscountCode);
            this.flpStack.Controls.Add(this.btnApply);
            this.flpStack.Controls.Add(this.pnlSpacer1);
            this.flpStack.Controls.Add(this.pnlSubtotal);
            this.flpStack.Controls.Add(this.pnlDiscount);
            this.flpStack.Controls.Add(this.pnlVat);
            this.flpStack.Controls.Add(this.lblTotalDue);
            this.flpStack.Controls.Add(this.lblTotal);
            this.flpStack.Controls.Add(this.pnlSpacer2);
            this.flpStack.Controls.Add(this.flpHoldRecall);
            this.flpStack.Controls.Add(this.btnPay);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.lblCustomer.Text = "Customer";
            // 
            // cmbCustomerType
            // 
            this.cmbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCustomerType.FormattingEnabled = true;
            this.cmbCustomerType.Margin = new System.Windows.Forms.Padding(0, 6, 10, 6);
            this.cmbCustomerType.Size = new System.Drawing.Size(300, 25);
            // 
            // txtCustomerRef
            // 
            this.txtCustomerRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerRef.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomerRef.Margin = new System.Windows.Forms.Padding(0, 6, 10, 6);
            this.txtCustomerRef.PlaceholderText = "Student / Staff ID";
            this.txtCustomerRef.Size = new System.Drawing.Size(300, 25);
            // 
            // txtDiscountCode
            // 
            this.txtDiscountCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscountCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiscountCode.Margin = new System.Windows.Forms.Padding(0, 6, 10, 6);
            this.txtDiscountCode.PlaceholderText = "Discount code (optional)";
            this.txtDiscountCode.Size = new System.Drawing.Size(300, 25);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApply.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnApply.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnApply.Size = new System.Drawing.Size(300, 40);
            this.btnApply.Text = "Apply customer / discount";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // pnlSpacer1
            // 
            this.pnlSpacer1.BackColor = System.Drawing.Color.Transparent;
            this.pnlSpacer1.Size = new System.Drawing.Size(300, 14);
            // 
            // pnlSubtotal
            // 
            this.pnlSubtotal.Size = new System.Drawing.Size(300, 28);
            this.pnlSubtotal.Controls.Add(this.lblSubtotalCaption);
            this.pnlSubtotal.Controls.Add(this.lblSubtotal);
            // 
            // lblSubtotalCaption
            // 
            this.lblSubtotalCaption.AutoSize = true;
            this.lblSubtotalCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotalCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtotalCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtotalCaption.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.lblSubtotalCaption.Text = "Subtotal";
            this.lblSubtotalCaption.Location = new System.Drawing.Point(0, 4);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = false;
            this.lblSubtotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblSubtotal.Size = new System.Drawing.Size(160, 26);
            // 
            // pnlDiscount
            // 
            this.pnlDiscount.Size = new System.Drawing.Size(300, 28);
            this.pnlDiscount.Controls.Add(this.lblDiscountCaption);
            this.pnlDiscount.Controls.Add(this.lblDiscount);
            // 
            // lblDiscountCaption
            // 
            this.lblDiscountCaption.AutoSize = true;
            this.lblDiscountCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscountCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiscountCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDiscountCaption.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.lblDiscountCaption.Text = "Discount";
            this.lblDiscountCaption.Location = new System.Drawing.Point(0, 4);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = false;
            this.lblDiscount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblDiscount.Size = new System.Drawing.Size(160, 26);
            // 
            // pnlVat
            // 
            this.pnlVat.Size = new System.Drawing.Size(300, 28);
            this.pnlVat.Controls.Add(this.lblVatCaption);
            this.pnlVat.Controls.Add(this.lblVat);
            // 
            // lblVatCaption
            // 
            this.lblVatCaption.AutoSize = true;
            this.lblVatCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblVatCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVatCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblVatCaption.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.lblVatCaption.Text = "VAT included";
            this.lblVatCaption.Location = new System.Drawing.Point(0, 4);
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = false;
            this.lblVat.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblVat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVat.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblVat.Size = new System.Drawing.Size(160, 26);
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDue.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTotalDue.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.lblTotalDue.Text = "TOTAL DUE";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = false;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Size = new System.Drawing.Size(300, 54);
            // 
            // pnlSpacer2
            // 
            this.pnlSpacer2.BackColor = System.Drawing.Color.Transparent;
            this.pnlSpacer2.Size = new System.Drawing.Size(300, 8);
            // 
            // flpHoldRecall
            // 
            this.flpHoldRecall.BackColor = System.Drawing.Color.Transparent;
            this.flpHoldRecall.Dock = System.Windows.Forms.DockStyle.None;
            this.flpHoldRecall.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flpHoldRecall.WrapContents = false;
            this.flpHoldRecall.Size = new System.Drawing.Size(300, 48);
            this.flpHoldRecall.Controls.Add(this.btnHold);
            this.flpHoldRecall.Controls.Add(this.btnRecall);
            // 
            // btnHold
            // 
            this.btnHold.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnHold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHold.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnHold.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnHold.Size = new System.Drawing.Size(144, 40);
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = false;
            this.btnHold.FlatAppearance.BorderSize = 0;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnRecall
            // 
            this.btnRecall.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnRecall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecall.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRecall.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnRecall.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnRecall.Size = new System.Drawing.Size(144, 40);
            this.btnRecall.Text = "Recall";
            this.btnRecall.UseVisualStyleBackColor = false;
            this.btnRecall.FlatAppearance.BorderSize = 0;
            this.btnRecall.Click += new System.EventHandler(this.btnRecall_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnPay.Size = new System.Drawing.Size(300, 64);
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // PosPage
            // 
            this.Size = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.tlpRoot);
            this.Name = "PosPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.flpHoldRecall.ResumeLayout(false);
            this.flpHoldRecall.PerformLayout();
            this.pnlSpacer2.ResumeLayout(false);
            this.pnlVat.ResumeLayout(false);
            this.pnlDiscount.ResumeLayout(false);
            this.pnlSubtotal.ResumeLayout(false);
            this.pnlSpacer1.ResumeLayout(false);
            this.flpStack.ResumeLayout(false);
            this.flpStack.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.flpAdd.ResumeLayout(false);
            this.flpAdd.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            this.tlpLeft.PerformLayout();
            this.tlpRoot.ResumeLayout(false);
            this.tlpRoot.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartTotal;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.FlowLayoutPanel flpAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveLine;
        private System.Windows.Forms.Button btnOverride;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.FlowLayoutPanel flpStack;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbCustomerType;
        private System.Windows.Forms.TextBox txtCustomerRef;
        private System.Windows.Forms.TextBox txtDiscountCode;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel pnlSpacer1;
        private System.Windows.Forms.Panel pnlSubtotal;
        private System.Windows.Forms.Label lblSubtotalCaption;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Panel pnlDiscount;
        private System.Windows.Forms.Label lblDiscountCaption;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Panel pnlVat;
        private System.Windows.Forms.Label lblVatCaption;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlSpacer2;
        private System.Windows.Forms.FlowLayoutPanel flpHoldRecall;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnRecall;
        private System.Windows.Forms.Button btnPay;
    }
}
