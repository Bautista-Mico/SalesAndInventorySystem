namespace SalesInventory.UI
{
    partial class ProductEditForm
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
            tlpFields = new TableLayoutPanel();
            lblSku = new Label();
            txtSku = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblSpec = new Label();
            txtSpec = new TextBox();
            lblCategory = new Label();
            flpCategory = new FlowLayoutPanel();
            cmbCategory = new ComboBox();
            btnNewCategory = new Button();
            lblSupplier = new Label();
            flpSupplier = new FlowLayoutPanel();
            cmbSupplier = new ComboBox();
            btnNewSupplier = new Button();
            lblUom = new Label();
            cmbUom = new ComboBox();
            lblCost = new Label();
            numCost = new NumericUpDown();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            lblTax = new Label();
            cmbTax = new ComboBox();
            lblBlank = new Label();
            chkDiscount = new CheckBox();
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblQty = new Label();
            numQty = new NumericUpDown();
            lblReorder = new Label();
            numReorder = new NumericUpDown();
            lblImage = new Label();
            flpImage = new FlowLayoutPanel();
            picProduct = new PictureBox();
            btnBrowse = new Button();
            flpBottom = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            tlpFields.SuspendLayout();
            flpCategory.SuspendLayout();
            flpSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReorder).BeginInit();
            flpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            flpBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tlpFields
            // 
            tlpFields.AutoScroll = true;
            tlpFields.ColumnCount = 2;
            tlpFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFields.Controls.Add(lblSku, 0, 0);
            tlpFields.Controls.Add(txtSku, 1, 0);
            tlpFields.Controls.Add(lblName, 0, 1);
            tlpFields.Controls.Add(txtName, 1, 1);
            tlpFields.Controls.Add(lblDescription, 0, 2);
            tlpFields.Controls.Add(txtDescription, 1, 2);
            tlpFields.Controls.Add(lblSpec, 0, 3);
            tlpFields.Controls.Add(txtSpec, 1, 3);
            tlpFields.Controls.Add(lblCategory, 0, 4);
            tlpFields.Controls.Add(flpCategory, 1, 4);
            tlpFields.Controls.Add(lblSupplier, 0, 5);
            tlpFields.Controls.Add(flpSupplier, 1, 5);
            tlpFields.Controls.Add(lblUom, 0, 6);
            tlpFields.Controls.Add(cmbUom, 1, 6);
            tlpFields.Controls.Add(lblCost, 0, 7);
            tlpFields.Controls.Add(numCost, 1, 7);
            tlpFields.Controls.Add(lblPrice, 0, 8);
            tlpFields.Controls.Add(numPrice, 1, 8);
            tlpFields.Controls.Add(lblTax, 0, 9);
            tlpFields.Controls.Add(cmbTax, 1, 9);
            tlpFields.Controls.Add(lblBlank, 0, 10);
            tlpFields.Controls.Add(chkDiscount, 1, 10);
            tlpFields.Controls.Add(lblLocation, 0, 11);
            tlpFields.Controls.Add(txtLocation, 1, 11);
            tlpFields.Controls.Add(lblQty, 0, 12);
            tlpFields.Controls.Add(numQty, 1, 12);
            tlpFields.Controls.Add(lblReorder, 0, 13);
            tlpFields.Controls.Add(numReorder, 1, 13);
            tlpFields.Controls.Add(lblImage, 0, 14);
            tlpFields.Controls.Add(flpImage, 1, 14);
            tlpFields.Dock = DockStyle.Fill;
            tlpFields.Location = new Point(0, 0);
            tlpFields.Name = "tlpFields";
            tlpFields.Padding = new Padding(20, 16, 20, 0);
            tlpFields.RowCount = 15;
            tlpFields.RowStyles.Add(new RowStyle());
            tlpFields.RowStyles.Add(new RowStyle());
            tlpFields.RowStyles.Add(new RowStyle());
            tlpFields.RowStyles.Add(new RowStyle());
            tlpFields.RowStyles.Add(new RowStyle());
            tlpFields.RowStyles.Add(new RowStyle());
            tlpFields.RowStyles.Add(new RowStyle());
            tlpFields.RowStyles.Add(new RowStyle());
            tlpFields.RowStyles.Add(new RowStyle());
            tlpFields.RowStyles.Add(new RowStyle());
            tlpFields.RowStyles.Add(new RowStyle());
            tlpFields.RowStyles.Add(new RowStyle());
            tlpFields.RowStyles.Add(new RowStyle());
            tlpFields.RowStyles.Add(new RowStyle());
            tlpFields.RowStyles.Add(new RowStyle());
            tlpFields.Size = new Size(640, 637);
            tlpFields.TabIndex = 0;
            // 
            // lblSku
            // 
            lblSku.AutoSize = true;
            lblSku.BackColor = Color.Transparent;
            lblSku.Font = new Font("Segoe UI", 10F);
            lblSku.ForeColor = Color.FromArgb(71, 85, 105);
            lblSku.Location = new Point(20, 24);
            lblSku.Margin = new Padding(0, 8, 8, 0);
            lblSku.Name = "lblSku";
            lblSku.Size = new Size(96, 19);
            lblSku.TabIndex = 0;
            lblSku.Text = "SKU / Barcode";
            // 
            // txtSku
            // 
            txtSku.BorderStyle = BorderStyle.FixedSingle;
            txtSku.Font = new Font("Segoe UI", 10F);
            txtSku.Location = new Point(170, 22);
            txtSku.Margin = new Padding(0, 6, 10, 6);
            txtSku.Name = "txtSku";
            txtSku.PlaceholderText = "Leave blank to auto-generate";
            txtSku.Size = new Size(320, 25);
            txtSku.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.ForeColor = Color.FromArgb(71, 85, 105);
            lblName.Location = new Point(20, 61);
            lblName.Margin = new Padding(0, 8, 8, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 19);
            lblName.TabIndex = 2;
            lblName.Text = "Product name *";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(170, 59);
            txtName.Margin = new Padding(0, 6, 10, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(320, 25);
            txtName.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.FromArgb(71, 85, 105);
            lblDescription.Location = new Point(20, 98);
            lblDescription.Margin = new Padding(0, 8, 8, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(78, 19);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(170, 96);
            txtDescription.Margin = new Padding(0, 6, 10, 6);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(320, 25);
            txtDescription.TabIndex = 5;
            // 
            // lblSpec
            // 
            lblSpec.AutoSize = true;
            lblSpec.BackColor = Color.Transparent;
            lblSpec.Font = new Font("Segoe UI", 10F);
            lblSpec.ForeColor = Color.FromArgb(71, 85, 105);
            lblSpec.Location = new Point(20, 135);
            lblSpec.Margin = new Padding(0, 8, 8, 0);
            lblSpec.Name = "lblSpec";
            lblSpec.Size = new Size(84, 19);
            lblSpec.TabIndex = 6;
            lblSpec.Text = "Specification";
            // 
            // txtSpec
            // 
            txtSpec.BorderStyle = BorderStyle.FixedSingle;
            txtSpec.Font = new Font("Segoe UI", 10F);
            txtSpec.Location = new Point(170, 133);
            txtSpec.Margin = new Padding(0, 6, 10, 6);
            txtSpec.Name = "txtSpec";
            txtSpec.PlaceholderText = "Size / Color / Edition / Brand";
            txtSpec.Size = new Size(320, 25);
            txtSpec.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Segoe UI", 10F);
            lblCategory.ForeColor = Color.FromArgb(71, 85, 105);
            lblCategory.Location = new Point(20, 172);
            lblCategory.Margin = new Padding(0, 8, 8, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(75, 19);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category *";
            // 
            // flpCategory
            // 
            flpCategory.AutoSize = true;
            flpCategory.BackColor = Color.Transparent;
            flpCategory.Controls.Add(cmbCategory);
            flpCategory.Controls.Add(btnNewCategory);
            flpCategory.Dock = DockStyle.Fill;
            flpCategory.Location = new Point(173, 167);
            flpCategory.Name = "flpCategory";
            flpCategory.Padding = new Padding(0, 2, 0, 2);
            flpCategory.Size = new Size(427, 52);
            flpCategory.TabIndex = 9;
            flpCategory.WrapContents = false;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(0, 8);
            cmbCategory.Margin = new Padding(0, 6, 10, 6);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(320, 25);
            cmbCategory.TabIndex = 0;
            // 
            // btnNewCategory
            // 
            btnNewCategory.BackColor = Color.FromArgb(226, 232, 240);
            btnNewCategory.Cursor = Cursors.Hand;
            btnNewCategory.FlatAppearance.BorderSize = 0;
            btnNewCategory.FlatStyle = FlatStyle.Flat;
            btnNewCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNewCategory.ForeColor = Color.FromArgb(30, 41, 59);
            btnNewCategory.Location = new Point(330, 6);
            btnNewCategory.Margin = new Padding(0, 4, 10, 4);
            btnNewCategory.Name = "btnNewCategory";
            btnNewCategory.Size = new Size(36, 40);
            btnNewCategory.TabIndex = 1;
            btnNewCategory.Text = "+";
            btnNewCategory.UseVisualStyleBackColor = false;
            btnNewCategory.Click += btnNewCategory_Click;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.BackColor = Color.Transparent;
            lblSupplier.Font = new Font("Segoe UI", 10F);
            lblSupplier.ForeColor = Color.FromArgb(71, 85, 105);
            lblSupplier.Location = new Point(20, 230);
            lblSupplier.Margin = new Padding(0, 8, 8, 0);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(58, 19);
            lblSupplier.TabIndex = 10;
            lblSupplier.Text = "Supplier";
            // 
            // flpSupplier
            // 
            flpSupplier.AutoSize = true;
            flpSupplier.BackColor = Color.Transparent;
            flpSupplier.Controls.Add(cmbSupplier);
            flpSupplier.Controls.Add(btnNewSupplier);
            flpSupplier.Dock = DockStyle.Fill;
            flpSupplier.Location = new Point(173, 225);
            flpSupplier.Name = "flpSupplier";
            flpSupplier.Padding = new Padding(0, 2, 0, 2);
            flpSupplier.Size = new Size(427, 52);
            flpSupplier.TabIndex = 11;
            flpSupplier.WrapContents = false;
            // 
            // cmbSupplier
            // 
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.Font = new Font("Segoe UI", 10F);
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(0, 8);
            cmbSupplier.Margin = new Padding(0, 6, 10, 6);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(320, 25);
            cmbSupplier.TabIndex = 0;
            // 
            // btnNewSupplier
            // 
            btnNewSupplier.BackColor = Color.FromArgb(226, 232, 240);
            btnNewSupplier.Cursor = Cursors.Hand;
            btnNewSupplier.FlatAppearance.BorderSize = 0;
            btnNewSupplier.FlatStyle = FlatStyle.Flat;
            btnNewSupplier.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNewSupplier.ForeColor = Color.FromArgb(30, 41, 59);
            btnNewSupplier.Location = new Point(330, 6);
            btnNewSupplier.Margin = new Padding(0, 4, 10, 4);
            btnNewSupplier.Name = "btnNewSupplier";
            btnNewSupplier.Size = new Size(36, 40);
            btnNewSupplier.TabIndex = 1;
            btnNewSupplier.Text = "+";
            btnNewSupplier.UseVisualStyleBackColor = false;
            btnNewSupplier.Click += btnNewSupplier_Click;
            // 
            // lblUom
            // 
            lblUom.AutoSize = true;
            lblUom.BackColor = Color.Transparent;
            lblUom.Font = new Font("Segoe UI", 10F);
            lblUom.ForeColor = Color.FromArgb(71, 85, 105);
            lblUom.Location = new Point(20, 288);
            lblUom.Margin = new Padding(0, 8, 8, 0);
            lblUom.Name = "lblUom";
            lblUom.Size = new Size(107, 19);
            lblUom.TabIndex = 12;
            lblUom.Text = "Unit of measure";
            // 
            // cmbUom
            // 
            cmbUom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUom.Font = new Font("Segoe UI", 10F);
            cmbUom.FormattingEnabled = true;
            cmbUom.Location = new Point(170, 286);
            cmbUom.Margin = new Padding(0, 6, 10, 6);
            cmbUom.Name = "cmbUom";
            cmbUom.Size = new Size(150, 25);
            cmbUom.TabIndex = 13;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.BackColor = Color.Transparent;
            lblCost.Font = new Font("Segoe UI", 10F);
            lblCost.ForeColor = Color.FromArgb(71, 85, 105);
            lblCost.Location = new Point(20, 325);
            lblCost.Margin = new Padding(0, 8, 8, 0);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(64, 19);
            lblCost.TabIndex = 14;
            lblCost.Text = "Unit cost";
            // 
            // numCost
            // 
            numCost.DecimalPlaces = 2;
            numCost.Location = new Point(173, 320);
            numCost.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numCost.Name = "numCost";
            numCost.Size = new Size(150, 25);
            numCost.TabIndex = 15;
            numCost.ThousandsSeparator = true;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI", 10F);
            lblPrice.ForeColor = Color.FromArgb(71, 85, 105);
            lblPrice.Location = new Point(20, 356);
            lblPrice.Margin = new Padding(0, 8, 8, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(91, 19);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "Selling price *";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(173, 351);
            numPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(150, 25);
            numPrice.TabIndex = 17;
            numPrice.ThousandsSeparator = true;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.BackColor = Color.Transparent;
            lblTax.Font = new Font("Segoe UI", 10F);
            lblTax.ForeColor = Color.FromArgb(71, 85, 105);
            lblTax.Location = new Point(20, 387);
            lblTax.Margin = new Padding(0, 8, 8, 0);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(68, 19);
            lblTax.TabIndex = 18;
            lblTax.Text = "Tax group";
            // 
            // cmbTax
            // 
            cmbTax.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTax.Font = new Font("Segoe UI", 10F);
            cmbTax.FormattingEnabled = true;
            cmbTax.Location = new Point(170, 385);
            cmbTax.Margin = new Padding(0, 6, 10, 6);
            cmbTax.Name = "cmbTax";
            cmbTax.Size = new Size(150, 25);
            cmbTax.TabIndex = 19;
            // 
            // lblBlank
            // 
            lblBlank.AutoSize = true;
            lblBlank.BackColor = Color.Transparent;
            lblBlank.Font = new Font("Segoe UI", 10F);
            lblBlank.ForeColor = Color.FromArgb(71, 85, 105);
            lblBlank.Location = new Point(20, 426);
            lblBlank.Margin = new Padding(0, 8, 8, 0);
            lblBlank.Name = "lblBlank";
            lblBlank.Size = new Size(0, 19);
            lblBlank.TabIndex = 20;
            // 
            // chkDiscount
            // 
            chkDiscount.AutoSize = true;
            chkDiscount.Location = new Point(173, 421);
            chkDiscount.Name = "chkDiscount";
            chkDiscount.Size = new Size(325, 23);
            chkDiscount.TabIndex = 21;
            chkDiscount.Text = "Eligible for promotional / student / staff discount";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.BackColor = Color.Transparent;
            lblLocation.Font = new Font("Segoe UI", 10F);
            lblLocation.ForeColor = Color.FromArgb(71, 85, 105);
            lblLocation.Location = new Point(20, 455);
            lblLocation.Margin = new Padding(0, 8, 8, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(108, 19);
            lblLocation.TabIndex = 22;
            lblLocation.Text = "Storage location";
            // 
            // txtLocation
            // 
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.Font = new Font("Segoe UI", 10F);
            txtLocation.Location = new Point(170, 453);
            txtLocation.Margin = new Padding(0, 6, 10, 6);
            txtLocation.Name = "txtLocation";
            txtLocation.PlaceholderText = "e.g. Warehouse A, Shelf B";
            txtLocation.Size = new Size(320, 25);
            txtLocation.TabIndex = 23;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.BackColor = Color.Transparent;
            lblQty.Font = new Font("Segoe UI", 10F);
            lblQty.ForeColor = Color.FromArgb(71, 85, 105);
            lblQty.Location = new Point(20, 492);
            lblQty.Margin = new Padding(0, 8, 8, 0);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(118, 19);
            lblQty.TabIndex = 24;
            lblQty.Text = "Quantity on hand";
            // 
            // numQty
            // 
            numQty.Location = new Point(173, 487);
            numQty.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numQty.Name = "numQty";
            numQty.Size = new Size(150, 25);
            numQty.TabIndex = 25;
            // 
            // lblReorder
            // 
            lblReorder.AutoSize = true;
            lblReorder.BackColor = Color.Transparent;
            lblReorder.Font = new Font("Segoe UI", 10F);
            lblReorder.ForeColor = Color.FromArgb(71, 85, 105);
            lblReorder.Location = new Point(20, 523);
            lblReorder.Margin = new Padding(0, 8, 8, 0);
            lblReorder.Name = "lblReorder";
            lblReorder.Size = new Size(103, 19);
            lblReorder.TabIndex = 26;
            lblReorder.Text = "Reorder point *";
            // 
            // numReorder
            // 
            numReorder.Location = new Point(173, 518);
            numReorder.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numReorder.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numReorder.Name = "numReorder";
            numReorder.Size = new Size(150, 25);
            numReorder.TabIndex = 27;
            numReorder.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.BackColor = Color.Transparent;
            lblImage.Font = new Font("Segoe UI", 10F);
            lblImage.ForeColor = Color.FromArgb(71, 85, 105);
            lblImage.Location = new Point(20, 554);
            lblImage.Margin = new Padding(0, 8, 8, 0);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(98, 19);
            lblImage.TabIndex = 28;
            lblImage.Text = "Product image";
            // 
            // flpImage
            // 
            flpImage.AutoSize = true;
            flpImage.BackColor = Color.Transparent;
            flpImage.Controls.Add(picProduct);
            flpImage.Controls.Add(btnBrowse);
            flpImage.Dock = DockStyle.Fill;
            flpImage.Location = new Point(173, 549);
            flpImage.Name = "flpImage";
            flpImage.Padding = new Padding(0, 2, 0, 2);
            flpImage.Size = new Size(427, 120);
            flpImage.TabIndex = 29;
            flpImage.WrapContents = false;
            // 
            // picProduct
            // 
            picProduct.BackColor = Color.White;
            picProduct.BorderStyle = BorderStyle.FixedSingle;
            picProduct.Location = new Point(3, 5);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(110, 110);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.TabIndex = 0;
            picProduct.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(226, 232, 240);
            btnBrowse.Cursor = Cursors.Hand;
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBrowse.ForeColor = Color.FromArgb(30, 41, 59);
            btnBrowse.Location = new Point(116, 6);
            btnBrowse.Margin = new Padding(0, 4, 10, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(100, 40);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // flpBottom
            // 
            flpBottom.Controls.Add(btnCancel);
            flpBottom.Controls.Add(btnSave);
            flpBottom.Dock = DockStyle.Bottom;
            flpBottom.FlowDirection = FlowDirection.RightToLeft;
            flpBottom.Location = new Point(0, 637);
            flpBottom.Name = "flpBottom";
            flpBottom.Padding = new Padding(20, 10, 20, 10);
            flpBottom.Size = new Size(640, 64);
            flpBottom.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(226, 232, 240);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(30, 41, 59);
            btnCancel.Location = new Point(480, 14);
            btnCancel.Margin = new Padding(0, 4, 10, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 40);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(17, 24, 39);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(360, 14);
            btnSave.Margin = new Padding(0, 4, 10, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // ProductEditForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(640, 701);
            Controls.Add(tlpFields);
            Controls.Add(flpBottom);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit product";
            tlpFields.ResumeLayout(false);
            tlpFields.PerformLayout();
            flpCategory.ResumeLayout(false);
            flpSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReorder).EndInit();
            flpImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            flpBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFields;
        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.FlowLayoutPanel flpCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.FlowLayoutPanel flpSupplier;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Button btnNewSupplier;
        private System.Windows.Forms.Label lblUom;
        private System.Windows.Forms.ComboBox cmbUom;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.ComboBox cmbTax;
        private System.Windows.Forms.Label lblBlank;
        private System.Windows.Forms.CheckBox chkDiscount;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label lblReorder;
        private System.Windows.Forms.NumericUpDown numReorder;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.FlowLayoutPanel flpImage;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FlowLayoutPanel flpBottom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
