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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tlpRoot = new TableLayoutPanel();
            tlpLeft = new TableLayoutPanel();
            dgvCart = new DataGridView();
            colCartSKU = new DataGridViewTextBoxColumn();
            colCartItem = new DataGridViewTextBoxColumn();
            colCartQty = new DataGridViewTextBoxColumn();
            colCartUnitPrice = new DataGridViewTextBoxColumn();
            colCartDiscount = new DataGridViewTextBoxColumn();
            colCartTotal = new DataGridViewTextBoxColumn();
            pnlAdd = new Panel();
            flpAdd = new FlowLayoutPanel();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnRemoveLine = new Button();
            btnOverride = new Button();
            btnClear = new Button();
            pnlRight = new Panel();
            flpStack = new FlowLayoutPanel();
            lblCustomer = new Label();
            cmbCustomerType = new ComboBox();
            txtCustomerRef = new TextBox();
            txtDiscountCode = new TextBox();
            btnApply = new Button();
            pnlSpacer1 = new Panel();
            pnlSubtotal = new Panel();
            lblSubtotalCaption = new Label();
            lblSubtotal = new Label();
            pnlDiscount = new Panel();
            lblDiscountCaption = new Label();
            lblDiscount = new Label();
            pnlVat = new Panel();
            lblVatCaption = new Label();
            lblVat = new Label();
            lblTotalDue = new Label();
            lblTotal = new Label();
            pnlSpacer2 = new Panel();
            flpHoldRecall = new FlowLayoutPanel();
            btnHold = new Button();
            btnRecall = new Button();
            btnPay = new Button();
            tlpRoot.SuspendLayout();
            tlpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            pnlAdd.SuspendLayout();
            flpAdd.SuspendLayout();
            pnlRight.SuspendLayout();
            flpStack.SuspendLayout();
            pnlSubtotal.SuspendLayout();
            pnlDiscount.SuspendLayout();
            pnlVat.SuspendLayout();
            flpHoldRecall.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRoot
            // 
            tlpRoot.ColumnCount = 2;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360F));
            tlpRoot.Controls.Add(tlpLeft, 0, 0);
            tlpRoot.Controls.Add(pnlRight, 1, 0);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(20, 20);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.RowCount = 1;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpRoot.Size = new Size(1005, 523);
            tlpRoot.TabIndex = 0;
            // 
            // tlpLeft
            // 
            tlpLeft.BackColor = Color.Transparent;
            tlpLeft.ColumnCount = 1;
            tlpLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLeft.Controls.Add(dgvCart, 0, 0);
            tlpLeft.Controls.Add(pnlAdd, 0, 1);
            tlpLeft.Dock = DockStyle.Fill;
            tlpLeft.Location = new Point(3, 3);
            tlpLeft.Name = "tlpLeft";
            tlpLeft.RowCount = 2;
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tlpLeft.Size = new Size(639, 517);
            tlpLeft.TabIndex = 0;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.White;
            dgvCart.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCart.ColumnHeadersHeight = 38;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { colCartSKU, colCartItem, colCartQty, colCartUnitPrice, colCartDiscount, colCartTotal });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(191, 219, 254);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvCart.DefaultCellStyle = dataGridViewCellStyle7;
            dgvCart.Dock = DockStyle.Fill;
            dgvCart.EnableHeadersVisualStyles = false;
            dgvCart.Font = new Font("Segoe UI", 10F);
            dgvCart.GridColor = Color.FromArgb(226, 232, 240);
            dgvCart.Location = new Point(3, 3);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersVisible = false;
            dgvCart.RowTemplate.Height = 32;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(633, 435);
            dgvCart.TabIndex = 0;
            // 
            // colCartSKU
            // 
            colCartSKU.DataPropertyName = "SKU";
            colCartSKU.FillWeight = 90F;
            colCartSKU.HeaderText = "SKU";
            colCartSKU.Name = "colCartSKU";
            colCartSKU.ReadOnly = true;
            colCartSKU.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCartItem
            // 
            colCartItem.DataPropertyName = "ProductName";
            colCartItem.FillWeight = 240F;
            colCartItem.HeaderText = "Item";
            colCartItem.Name = "colCartItem";
            colCartItem.ReadOnly = true;
            colCartItem.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCartQty
            // 
            colCartQty.DataPropertyName = "Quantity";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCartQty.DefaultCellStyle = dataGridViewCellStyle3;
            colCartQty.FillWeight = 60F;
            colCartQty.HeaderText = "Qty";
            colCartQty.Name = "colCartQty";
            colCartQty.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCartUnitPrice
            // 
            colCartUnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            colCartUnitPrice.DefaultCellStyle = dataGridViewCellStyle4;
            colCartUnitPrice.FillWeight = 90F;
            colCartUnitPrice.HeaderText = "Unit price";
            colCartUnitPrice.Name = "colCartUnitPrice";
            colCartUnitPrice.ReadOnly = true;
            colCartUnitPrice.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCartDiscount
            // 
            colCartDiscount.DataPropertyName = "Discount";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            colCartDiscount.DefaultCellStyle = dataGridViewCellStyle5;
            colCartDiscount.FillWeight = 80F;
            colCartDiscount.HeaderText = "Discount";
            colCartDiscount.Name = "colCartDiscount";
            colCartDiscount.ReadOnly = true;
            colCartDiscount.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCartTotal
            // 
            colCartTotal.DataPropertyName = "LineTotal";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            colCartTotal.DefaultCellStyle = dataGridViewCellStyle6;
            colCartTotal.HeaderText = "Total";
            colCartTotal.Name = "colCartTotal";
            colCartTotal.ReadOnly = true;
            colCartTotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlAdd
            // 
            pnlAdd.BackColor = Color.White;
            pnlAdd.BorderStyle = BorderStyle.FixedSingle;
            pnlAdd.Controls.Add(flpAdd);
            pnlAdd.Dock = DockStyle.Fill;
            pnlAdd.Location = new Point(3, 444);
            pnlAdd.Name = "pnlAdd";
            pnlAdd.Padding = new Padding(12);
            pnlAdd.Size = new Size(633, 70);
            pnlAdd.TabIndex = 1;
            // 
            // flpAdd
            // 
            flpAdd.BackColor = Color.Transparent;
            flpAdd.Controls.Add(txtSearch);
            flpAdd.Controls.Add(btnAdd);
            flpAdd.Controls.Add(btnRemoveLine);
            flpAdd.Controls.Add(btnOverride);
            flpAdd.Controls.Add(btnClear);
            flpAdd.Dock = DockStyle.Fill;
            flpAdd.Location = new Point(12, 12);
            flpAdd.Name = "flpAdd";
            flpAdd.Padding = new Padding(0, 2, 0, 2);
            flpAdd.Size = new Size(607, 44);
            flpAdd.TabIndex = 0;
            flpAdd.WrapContents = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(0, 8);
            txtSearch.Margin = new Padding(0, 6, 10, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Scan barcode or type SKU / item name, then press Enter";
            txtSearch.Size = new Size(430, 25);
            txtSearch.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(71, 85, 105);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(440, 6);
            btnAdd.Margin = new Padding(0, 4, 10, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemoveLine
            // 
            btnRemoveLine.BackColor = Color.FromArgb(226, 232, 240);
            btnRemoveLine.Cursor = Cursors.Hand;
            btnRemoveLine.FlatAppearance.BorderSize = 0;
            btnRemoveLine.FlatStyle = FlatStyle.Flat;
            btnRemoveLine.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRemoveLine.ForeColor = Color.FromArgb(30, 41, 59);
            btnRemoveLine.Location = new Point(530, 6);
            btnRemoveLine.Margin = new Padding(0, 4, 10, 4);
            btnRemoveLine.Name = "btnRemoveLine";
            btnRemoveLine.Size = new Size(120, 40);
            btnRemoveLine.TabIndex = 2;
            btnRemoveLine.Text = "Remove line";
            btnRemoveLine.UseVisualStyleBackColor = false;
            btnRemoveLine.Click += btnRemoveLine_Click;
            // 
            // btnOverride
            // 
            btnOverride.BackColor = Color.FromArgb(226, 232, 240);
            btnOverride.Cursor = Cursors.Hand;
            btnOverride.FlatAppearance.BorderSize = 0;
            btnOverride.FlatStyle = FlatStyle.Flat;
            btnOverride.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOverride.ForeColor = Color.FromArgb(30, 41, 59);
            btnOverride.Location = new Point(660, 6);
            btnOverride.Margin = new Padding(0, 4, 10, 4);
            btnOverride.Name = "btnOverride";
            btnOverride.Size = new Size(140, 40);
            btnOverride.TabIndex = 3;
            btnOverride.Text = "Override price";
            btnOverride.UseVisualStyleBackColor = false;
            btnOverride.Click += btnOverride_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(226, 232, 240);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(30, 41, 59);
            btnClear.Location = new Point(810, 6);
            btnClear.Margin = new Padding(0, 4, 10, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 40);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.BorderStyle = BorderStyle.FixedSingle;
            pnlRight.Controls.Add(flpStack);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(648, 3);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(12);
            pnlRight.Size = new Size(354, 517);
            pnlRight.TabIndex = 1;
            // 
            // flpStack
            // 
            flpStack.Controls.Add(lblCustomer);
            flpStack.Controls.Add(cmbCustomerType);
            flpStack.Controls.Add(txtCustomerRef);
            flpStack.Controls.Add(txtDiscountCode);
            flpStack.Controls.Add(btnApply);
            flpStack.Controls.Add(pnlSpacer1);
            flpStack.Controls.Add(pnlSubtotal);
            flpStack.Controls.Add(pnlDiscount);
            flpStack.Controls.Add(pnlVat);
            flpStack.Controls.Add(lblTotalDue);
            flpStack.Controls.Add(lblTotal);
            flpStack.Controls.Add(pnlSpacer2);
            flpStack.Controls.Add(flpHoldRecall);
            flpStack.Controls.Add(btnPay);
            flpStack.Dock = DockStyle.Fill;
            flpStack.FlowDirection = FlowDirection.TopDown;
            flpStack.Location = new Point(12, 12);
            flpStack.Name = "flpStack";
            flpStack.Size = new Size(328, 491);
            flpStack.TabIndex = 0;
            flpStack.WrapContents = false;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.BackColor = Color.Transparent;
            lblCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCustomer.ForeColor = Color.FromArgb(30, 41, 59);
            lblCustomer.Location = new Point(0, 8);
            lblCustomer.Margin = new Padding(0, 8, 8, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(73, 19);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Customer";
            // 
            // cmbCustomerType
            // 
            cmbCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomerType.Font = new Font("Segoe UI", 10F);
            cmbCustomerType.FormattingEnabled = true;
            cmbCustomerType.Location = new Point(0, 33);
            cmbCustomerType.Margin = new Padding(0, 6, 10, 6);
            cmbCustomerType.Name = "cmbCustomerType";
            cmbCustomerType.Size = new Size(300, 25);
            cmbCustomerType.TabIndex = 1;
            // 
            // txtCustomerRef
            // 
            txtCustomerRef.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerRef.Font = new Font("Segoe UI", 10F);
            txtCustomerRef.Location = new Point(0, 70);
            txtCustomerRef.Margin = new Padding(0, 6, 10, 6);
            txtCustomerRef.Name = "txtCustomerRef";
            txtCustomerRef.PlaceholderText = "Student / Staff ID";
            txtCustomerRef.Size = new Size(300, 25);
            txtCustomerRef.TabIndex = 2;
            // 
            // txtDiscountCode
            // 
            txtDiscountCode.BorderStyle = BorderStyle.FixedSingle;
            txtDiscountCode.Font = new Font("Segoe UI", 10F);
            txtDiscountCode.Location = new Point(0, 107);
            txtDiscountCode.Margin = new Padding(0, 6, 10, 6);
            txtDiscountCode.Name = "txtDiscountCode";
            txtDiscountCode.PlaceholderText = "Discount code (optional)";
            txtDiscountCode.Size = new Size(300, 25);
            txtDiscountCode.TabIndex = 3;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.FromArgb(226, 232, 240);
            btnApply.Cursor = Cursors.Hand;
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnApply.ForeColor = Color.FromArgb(30, 41, 59);
            btnApply.Location = new Point(0, 142);
            btnApply.Margin = new Padding(0, 4, 10, 4);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(300, 40);
            btnApply.TabIndex = 4;
            btnApply.Text = "Apply customer / discount";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // pnlSpacer1
            // 
            pnlSpacer1.BackColor = Color.Transparent;
            pnlSpacer1.Location = new Point(3, 189);
            pnlSpacer1.Name = "pnlSpacer1";
            pnlSpacer1.Size = new Size(300, 14);
            pnlSpacer1.TabIndex = 5;
            // 
            // pnlSubtotal
            // 
            pnlSubtotal.Controls.Add(lblSubtotalCaption);
            pnlSubtotal.Controls.Add(lblSubtotal);
            pnlSubtotal.Location = new Point(3, 209);
            pnlSubtotal.Name = "pnlSubtotal";
            pnlSubtotal.Size = new Size(300, 28);
            pnlSubtotal.TabIndex = 6;
            // 
            // lblSubtotalCaption
            // 
            lblSubtotalCaption.AutoSize = true;
            lblSubtotalCaption.BackColor = Color.Transparent;
            lblSubtotalCaption.Font = new Font("Segoe UI", 10F);
            lblSubtotalCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtotalCaption.Location = new Point(0, 4);
            lblSubtotalCaption.Margin = new Padding(0, 8, 8, 0);
            lblSubtotalCaption.Name = "lblSubtotalCaption";
            lblSubtotalCaption.Size = new Size(60, 19);
            lblSubtotalCaption.TabIndex = 0;
            lblSubtotalCaption.Text = "Subtotal";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Dock = DockStyle.Right;
            lblSubtotal.Font = new Font("Segoe UI", 10F);
            lblSubtotal.Location = new Point(140, 0);
            lblSubtotal.Margin = new Padding(0, 0, 0, 2);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(160, 28);
            lblSubtotal.TabIndex = 1;
            // 
            // pnlDiscount
            // 
            pnlDiscount.Controls.Add(lblDiscountCaption);
            pnlDiscount.Controls.Add(lblDiscount);
            pnlDiscount.Location = new Point(3, 243);
            pnlDiscount.Name = "pnlDiscount";
            pnlDiscount.Size = new Size(300, 28);
            pnlDiscount.TabIndex = 7;
            // 
            // lblDiscountCaption
            // 
            lblDiscountCaption.AutoSize = true;
            lblDiscountCaption.BackColor = Color.Transparent;
            lblDiscountCaption.Font = new Font("Segoe UI", 10F);
            lblDiscountCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblDiscountCaption.Location = new Point(0, 4);
            lblDiscountCaption.Margin = new Padding(0, 8, 8, 0);
            lblDiscountCaption.Name = "lblDiscountCaption";
            lblDiscountCaption.Size = new Size(63, 19);
            lblDiscountCaption.TabIndex = 0;
            lblDiscountCaption.Text = "Discount";
            // 
            // lblDiscount
            // 
            lblDiscount.Dock = DockStyle.Right;
            lblDiscount.Font = new Font("Segoe UI", 10F);
            lblDiscount.Location = new Point(140, 0);
            lblDiscount.Margin = new Padding(0, 0, 0, 2);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(160, 28);
            lblDiscount.TabIndex = 1;
            // 
            // pnlVat
            // 
            pnlVat.Controls.Add(lblVatCaption);
            pnlVat.Controls.Add(lblVat);
            pnlVat.Location = new Point(3, 277);
            pnlVat.Name = "pnlVat";
            pnlVat.Size = new Size(300, 28);
            pnlVat.TabIndex = 8;
            // 
            // lblVatCaption
            // 
            lblVatCaption.AutoSize = true;
            lblVatCaption.BackColor = Color.Transparent;
            lblVatCaption.Font = new Font("Segoe UI", 10F);
            lblVatCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblVatCaption.Location = new Point(0, 4);
            lblVatCaption.Margin = new Padding(0, 8, 8, 0);
            lblVatCaption.Name = "lblVatCaption";
            lblVatCaption.Size = new Size(87, 19);
            lblVatCaption.TabIndex = 0;
            lblVatCaption.Text = "VAT included";
            // 
            // lblVat
            // 
            lblVat.Dock = DockStyle.Right;
            lblVat.Font = new Font("Segoe UI", 10F);
            lblVat.Location = new Point(140, 0);
            lblVat.Margin = new Padding(0, 0, 0, 2);
            lblVat.Name = "lblVat";
            lblVat.Size = new Size(160, 28);
            lblVat.TabIndex = 1;
            // 
            // lblTotalDue
            // 
            lblTotalDue.AutoSize = true;
            lblTotalDue.BackColor = Color.Transparent;
            lblTotalDue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalDue.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotalDue.Location = new Point(0, 316);
            lblTotalDue.Margin = new Padding(0, 8, 8, 0);
            lblTotalDue.Name = "lblTotalDue";
            lblTotalDue.Size = new Size(81, 19);
            lblTotalDue.TabIndex = 9;
            lblTotalDue.Text = "TOTAL DUE";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotal.Location = new Point(3, 335);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(300, 54);
            lblTotal.TabIndex = 10;
            // 
            // pnlSpacer2
            // 
            pnlSpacer2.BackColor = Color.Transparent;
            pnlSpacer2.Location = new Point(3, 392);
            pnlSpacer2.Name = "pnlSpacer2";
            pnlSpacer2.Size = new Size(300, 8);
            pnlSpacer2.TabIndex = 11;
            // 
            // flpHoldRecall
            // 
            flpHoldRecall.BackColor = Color.Transparent;
            flpHoldRecall.Controls.Add(btnHold);
            flpHoldRecall.Controls.Add(btnRecall);
            flpHoldRecall.Location = new Point(3, 406);
            flpHoldRecall.Name = "flpHoldRecall";
            flpHoldRecall.Padding = new Padding(0, 2, 0, 2);
            flpHoldRecall.Size = new Size(300, 48);
            flpHoldRecall.TabIndex = 12;
            flpHoldRecall.WrapContents = false;
            // 
            // btnHold
            // 
            btnHold.BackColor = Color.FromArgb(226, 232, 240);
            btnHold.Cursor = Cursors.Hand;
            btnHold.FlatAppearance.BorderSize = 0;
            btnHold.FlatStyle = FlatStyle.Flat;
            btnHold.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHold.ForeColor = Color.FromArgb(30, 41, 59);
            btnHold.Location = new Point(0, 6);
            btnHold.Margin = new Padding(0, 4, 10, 4);
            btnHold.Name = "btnHold";
            btnHold.Size = new Size(144, 40);
            btnHold.TabIndex = 0;
            btnHold.Text = "Hold";
            btnHold.UseVisualStyleBackColor = false;
            btnHold.Click += btnHold_Click;
            // 
            // btnRecall
            // 
            btnRecall.BackColor = Color.FromArgb(226, 232, 240);
            btnRecall.Cursor = Cursors.Hand;
            btnRecall.FlatAppearance.BorderSize = 0;
            btnRecall.FlatStyle = FlatStyle.Flat;
            btnRecall.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRecall.ForeColor = Color.FromArgb(30, 41, 59);
            btnRecall.Location = new Point(154, 6);
            btnRecall.Margin = new Padding(0, 4, 10, 4);
            btnRecall.Name = "btnRecall";
            btnRecall.Size = new Size(144, 40);
            btnRecall.TabIndex = 1;
            btnRecall.Text = "Recall";
            btnRecall.UseVisualStyleBackColor = false;
            btnRecall.Click += btnRecall_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(17, 24, 39);
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(0, 461);
            btnPay.Margin = new Padding(0, 4, 10, 4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(300, 64);
            btnPay.TabIndex = 13;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // PosPage
            // 
            Controls.Add(tlpRoot);
            Name = "PosPage";
            Size = new Size(1045, 563);
            tlpRoot.ResumeLayout(false);
            tlpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            pnlAdd.ResumeLayout(false);
            flpAdd.ResumeLayout(false);
            flpAdd.PerformLayout();
            pnlRight.ResumeLayout(false);
            flpStack.ResumeLayout(false);
            flpStack.PerformLayout();
            pnlSubtotal.ResumeLayout(false);
            pnlSubtotal.PerformLayout();
            pnlDiscount.ResumeLayout(false);
            pnlDiscount.PerformLayout();
            pnlVat.ResumeLayout(false);
            pnlVat.PerformLayout();
            flpHoldRecall.ResumeLayout(false);
            ResumeLayout(false);
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
