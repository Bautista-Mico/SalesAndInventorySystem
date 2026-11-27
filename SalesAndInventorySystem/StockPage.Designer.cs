namespace SalesInventory.UI
{
    partial class StockPage
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            tabs = new TabControl();
            tabUpdate = new TabPage();
            tlpUpdate = new TableLayoutPanel();
            pnlPick = new Panel();
            flpFind = new FlowLayoutPanel();
            txtFind = new TextBox();
            btnFind = new Button();
            lblPicked = new Label();
            pnlFields = new Panel();
            flpFields = new FlowLayoutPanel();
            flpRow1 = new FlowLayoutPanel();
            lblAction = new Label();
            cmbAction = new ComboBox();
            lblQty = new Label();
            numQty = new NumericUpDown();
            lblReason = new Label();
            cmbReason = new ComboBox();
            flpRow2 = new FlowLayoutPanel();
            txtLocation = new TextBox();
            txtRef = new TextBox();
            btnAddLine = new Button();
            lblHint = new Label();
            dgvBatch = new DataGridView();
            colBatchSKU = new DataGridViewTextBoxColumn();
            colBatchItem = new DataGridViewTextBoxColumn();
            colBatchAction = new DataGridViewTextBoxColumn();
            colBatchChange = new DataGridViewTextBoxColumn();
            colBatchOnHandNow = new DataGridViewTextBoxColumn();
            colBatchLocation = new DataGridViewTextBoxColumn();
            colBatchReason = new DataGridViewTextBoxColumn();
            flpPost = new FlowLayoutPanel();
            btnPost = new Button();
            btnRemoveLine = new Button();
            btnRecover = new Button();
            tabAvailability = new TabPage();
            tlpAvailability = new TableLayoutPanel();
            flpAvailBar = new FlowLayoutPanel();
            txtAvailSearch = new TextBox();
            btnCheckStock = new Button();
            dgvAvailability = new DataGridView();
            colAvailabilitySKU = new DataGridViewTextBoxColumn();
            colAvailabilityItem = new DataGridViewTextBoxColumn();
            colAvailabilityCategory = new DataGridViewTextBoxColumn();
            colAvailabilityInStock = new DataGridViewTextBoxColumn();
            colAvailabilityLocation = new DataGridViewTextBoxColumn();
            colAvailabilityPrice = new DataGridViewTextBoxColumn();
            tabLedger = new TabPage();
            tlpLedger = new TableLayoutPanel();
            flpLedgerBar = new FlowLayoutPanel();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            cmbLedgerAction = new ComboBox();
            txtLedgerSearch = new TextBox();
            btnShowLedger = new Button();
            dgvLedger = new DataGridView();
            tabs.SuspendLayout();
            tabUpdate.SuspendLayout();
            tlpUpdate.SuspendLayout();
            pnlPick.SuspendLayout();
            flpFind.SuspendLayout();
            pnlFields.SuspendLayout();
            flpFields.SuspendLayout();
            flpRow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            flpRow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatch).BeginInit();
            flpPost.SuspendLayout();
            tabAvailability.SuspendLayout();
            tlpAvailability.SuspendLayout();
            flpAvailBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailability).BeginInit();
            tabLedger.SuspendLayout();
            tlpLedger.SuspendLayout();
            flpLedgerBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLedger).BeginInit();
            SuspendLayout();
            // 
            // tabs
            // 
            tabs.Controls.Add(tabUpdate);
            tabs.Controls.Add(tabAvailability);
            tabs.Controls.Add(tabLedger);
            tabs.Dock = DockStyle.Fill;
            tabs.Font = new Font("Segoe UI", 10F);
            tabs.Location = new Point(20, 20);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(817, 325);
            tabs.TabIndex = 0;
            // 
            // tabUpdate
            // 
            tabUpdate.BackColor = Color.FromArgb(248, 250, 252);
            tabUpdate.Controls.Add(tlpUpdate);
            tabUpdate.Location = new Point(4, 26);
            tabUpdate.Name = "tabUpdate";
            tabUpdate.Padding = new Padding(12);
            tabUpdate.Size = new Size(809, 295);
            tabUpdate.TabIndex = 0;
            tabUpdate.Text = "Stock update";
            // 
            // tlpUpdate
            // 
            tlpUpdate.BackColor = Color.Transparent;
            tlpUpdate.ColumnCount = 1;
            tlpUpdate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpUpdate.Controls.Add(pnlPick, 0, 0);
            tlpUpdate.Controls.Add(pnlFields, 0, 1);
            tlpUpdate.Controls.Add(dgvBatch, 0, 2);
            tlpUpdate.Controls.Add(flpPost, 0, 3);
            tlpUpdate.Dock = DockStyle.Fill;
            tlpUpdate.Location = new Point(12, 12);
            tlpUpdate.Name = "tlpUpdate";
            tlpUpdate.RowCount = 4;
            tlpUpdate.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpUpdate.RowStyles.Add(new RowStyle(SizeType.Absolute, 134F));
            tlpUpdate.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUpdate.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tlpUpdate.Size = new Size(785, 271);
            tlpUpdate.TabIndex = 0;
            // 
            // pnlPick
            // 
            pnlPick.BackColor = Color.White;
            pnlPick.BorderStyle = BorderStyle.FixedSingle;
            pnlPick.Controls.Add(flpFind);
            pnlPick.Dock = DockStyle.Fill;
            pnlPick.Location = new Point(3, 3);
            pnlPick.Name = "pnlPick";
            pnlPick.Padding = new Padding(12);
            pnlPick.Size = new Size(779, 64);
            pnlPick.TabIndex = 0;
            // 
            // flpFind
            // 
            flpFind.BackColor = Color.Transparent;
            flpFind.Controls.Add(txtFind);
            flpFind.Controls.Add(btnFind);
            flpFind.Controls.Add(lblPicked);
            flpFind.Dock = DockStyle.Fill;
            flpFind.Location = new Point(12, 12);
            flpFind.Name = "flpFind";
            flpFind.Padding = new Padding(0, 2, 0, 2);
            flpFind.Size = new Size(753, 38);
            flpFind.TabIndex = 0;
            flpFind.WrapContents = false;
            // 
            // txtFind
            // 
            txtFind.BorderStyle = BorderStyle.FixedSingle;
            txtFind.Font = new Font("Segoe UI", 10F);
            txtFind.Location = new Point(0, 8);
            txtFind.Margin = new Padding(0, 6, 10, 6);
            txtFind.Name = "txtFind";
            txtFind.PlaceholderText = "Scan barcode or search SKU / name, then press Enter";
            txtFind.Size = new Size(430, 25);
            txtFind.TabIndex = 0;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.FromArgb(71, 85, 105);
            btnFind.Cursor = Cursors.Hand;
            btnFind.FlatAppearance.BorderSize = 0;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(440, 6);
            btnFind.Margin = new Padding(0, 4, 10, 4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 40);
            btnFind.TabIndex = 1;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // lblPicked
            // 
            lblPicked.AutoSize = true;
            lblPicked.BackColor = Color.Transparent;
            lblPicked.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPicked.ForeColor = Color.FromArgb(100, 116, 139);
            lblPicked.Location = new Point(540, 10);
            lblPicked.Margin = new Padding(0, 8, 8, 0);
            lblPicked.Name = "lblPicked";
            lblPicked.Size = new Size(122, 19);
            lblPicked.TabIndex = 2;
            lblPicked.Text = "No item selected";
            // 
            // pnlFields
            // 
            pnlFields.BackColor = Color.White;
            pnlFields.BorderStyle = BorderStyle.FixedSingle;
            pnlFields.Controls.Add(flpFields);
            pnlFields.Dock = DockStyle.Fill;
            pnlFields.Location = new Point(3, 73);
            pnlFields.Name = "pnlFields";
            pnlFields.Padding = new Padding(12);
            pnlFields.Size = new Size(779, 128);
            pnlFields.TabIndex = 1;
            // 
            // flpFields
            // 
            flpFields.Controls.Add(flpRow1);
            flpFields.Controls.Add(flpRow2);
            flpFields.Controls.Add(lblHint);
            flpFields.Dock = DockStyle.Fill;
            flpFields.FlowDirection = FlowDirection.TopDown;
            flpFields.Location = new Point(12, 12);
            flpFields.Name = "flpFields";
            flpFields.Size = new Size(753, 102);
            flpFields.TabIndex = 0;
            flpFields.WrapContents = false;
            // 
            // flpRow1
            // 
            flpRow1.BackColor = Color.Transparent;
            flpRow1.Controls.Add(lblAction);
            flpRow1.Controls.Add(cmbAction);
            flpRow1.Controls.Add(lblQty);
            flpRow1.Controls.Add(numQty);
            flpRow1.Controls.Add(lblReason);
            flpRow1.Controls.Add(cmbReason);
            flpRow1.Location = new Point(3, 3);
            flpRow1.Name = "flpRow1";
            flpRow1.Padding = new Padding(0, 2, 0, 2);
            flpRow1.Size = new Size(900, 44);
            flpRow1.TabIndex = 0;
            flpRow1.WrapContents = false;
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.BackColor = Color.Transparent;
            lblAction.Font = new Font("Segoe UI", 10F);
            lblAction.ForeColor = Color.FromArgb(30, 41, 59);
            lblAction.Location = new Point(0, 10);
            lblAction.Margin = new Padding(0, 8, 8, 0);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(48, 19);
            lblAction.TabIndex = 0;
            lblAction.Text = "Action";
            // 
            // cmbAction
            // 
            cmbAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAction.Font = new Font("Segoe UI", 10F);
            cmbAction.FormattingEnabled = true;
            cmbAction.Location = new Point(56, 8);
            cmbAction.Margin = new Padding(0, 6, 10, 6);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(210, 25);
            cmbAction.TabIndex = 1;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.BackColor = Color.Transparent;
            lblQty.Font = new Font("Segoe UI", 10F);
            lblQty.ForeColor = Color.FromArgb(30, 41, 59);
            lblQty.Location = new Point(276, 10);
            lblQty.Margin = new Padding(0, 8, 8, 0);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(32, 19);
            lblQty.TabIndex = 2;
            lblQty.Text = "Qty";
            // 
            // numQty
            // 
            numQty.Location = new Point(319, 5);
            numQty.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numQty.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            numQty.Name = "numQty";
            numQty.Size = new Size(90, 25);
            numQty.TabIndex = 3;
            numQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.BackColor = Color.Transparent;
            lblReason.Font = new Font("Segoe UI", 10F);
            lblReason.ForeColor = Color.FromArgb(30, 41, 59);
            lblReason.Location = new Point(412, 10);
            lblReason.Margin = new Padding(0, 8, 8, 0);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(53, 19);
            lblReason.TabIndex = 4;
            lblReason.Text = "Reason";
            // 
            // cmbReason
            // 
            cmbReason.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReason.Font = new Font("Segoe UI", 10F);
            cmbReason.FormattingEnabled = true;
            cmbReason.Location = new Point(473, 8);
            cmbReason.Margin = new Padding(0, 6, 10, 6);
            cmbReason.Name = "cmbReason";
            cmbReason.Size = new Size(210, 25);
            cmbReason.TabIndex = 5;
            // 
            // flpRow2
            // 
            flpRow2.BackColor = Color.Transparent;
            flpRow2.Controls.Add(txtLocation);
            flpRow2.Controls.Add(txtRef);
            flpRow2.Controls.Add(btnAddLine);
            flpRow2.Location = new Point(3, 53);
            flpRow2.Name = "flpRow2";
            flpRow2.Padding = new Padding(0, 2, 0, 2);
            flpRow2.Size = new Size(900, 48);
            flpRow2.TabIndex = 1;
            flpRow2.WrapContents = false;
            // 
            // txtLocation
            // 
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.Font = new Font("Segoe UI", 10F);
            txtLocation.Location = new Point(0, 8);
            txtLocation.Margin = new Padding(0, 6, 10, 6);
            txtLocation.Name = "txtLocation";
            txtLocation.PlaceholderText = "Location (optional)";
            txtLocation.Size = new Size(190, 25);
            txtLocation.TabIndex = 0;
            // 
            // txtRef
            // 
            txtRef.BorderStyle = BorderStyle.FixedSingle;
            txtRef.Font = new Font("Segoe UI", 10F);
            txtRef.Location = new Point(200, 8);
            txtRef.Margin = new Padding(0, 6, 10, 6);
            txtRef.Name = "txtRef";
            txtRef.PlaceholderText = "Supplier invoice / PO ref";
            txtRef.Size = new Size(190, 25);
            txtRef.TabIndex = 1;
            // 
            // btnAddLine
            // 
            btnAddLine.BackColor = Color.FromArgb(226, 232, 240);
            btnAddLine.Cursor = Cursors.Hand;
            btnAddLine.FlatAppearance.BorderSize = 0;
            btnAddLine.FlatStyle = FlatStyle.Flat;
            btnAddLine.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddLine.ForeColor = Color.FromArgb(30, 41, 59);
            btnAddLine.Location = new Point(400, 6);
            btnAddLine.Margin = new Padding(0, 4, 10, 4);
            btnAddLine.Name = "btnAddLine";
            btnAddLine.Size = new Size(140, 40);
            btnAddLine.TabIndex = 2;
            btnAddLine.Text = "Add to batch";
            btnAddLine.UseVisualStyleBackColor = false;
            btnAddLine.Click += btnAddLine_Click;
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.BackColor = Color.Transparent;
            lblHint.Font = new Font("Segoe UI", 10F);
            lblHint.ForeColor = Color.FromArgb(100, 116, 139);
            lblHint.Location = new Point(0, 112);
            lblHint.Margin = new Padding(0, 8, 8, 0);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(651, 19);
            lblHint.TabIndex = 2;
            lblHint.Text = "Quantity: enter a positive number. For a Discrepancy Adjustment use a negative number to reduce stock.";
            // 
            // dgvBatch
            // 
            dgvBatch.AllowUserToAddRows = false;
            dgvBatch.AllowUserToDeleteRows = false;
            dgvBatch.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvBatch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBatch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBatch.BackgroundColor = Color.White;
            dgvBatch.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBatch.ColumnHeadersHeight = 38;
            dgvBatch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBatch.Columns.AddRange(new DataGridViewColumn[] { colBatchSKU, colBatchItem, colBatchAction, colBatchChange, colBatchOnHandNow, colBatchLocation, colBatchReason });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(191, 219, 254);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvBatch.DefaultCellStyle = dataGridViewCellStyle5;
            dgvBatch.Dock = DockStyle.Fill;
            dgvBatch.EnableHeadersVisualStyles = false;
            dgvBatch.Font = new Font("Segoe UI", 10F);
            dgvBatch.GridColor = Color.FromArgb(226, 232, 240);
            dgvBatch.Location = new Point(3, 207);
            dgvBatch.MultiSelect = false;
            dgvBatch.Name = "dgvBatch";
            dgvBatch.ReadOnly = true;
            dgvBatch.RowHeadersVisible = false;
            dgvBatch.RowTemplate.Height = 32;
            dgvBatch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBatch.Size = new Size(779, 1);
            dgvBatch.TabIndex = 2;
            // 
            // colBatchSKU
            // 
            colBatchSKU.DataPropertyName = "SKU";
            colBatchSKU.FillWeight = 90F;
            colBatchSKU.HeaderText = "SKU";
            colBatchSKU.Name = "colBatchSKU";
            colBatchSKU.ReadOnly = true;
            colBatchSKU.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colBatchItem
            // 
            colBatchItem.DataPropertyName = "ProductName";
            colBatchItem.FillWeight = 200F;
            colBatchItem.HeaderText = "Item";
            colBatchItem.Name = "colBatchItem";
            colBatchItem.ReadOnly = true;
            colBatchItem.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colBatchAction
            // 
            colBatchAction.DataPropertyName = "ActionType";
            colBatchAction.FillWeight = 130F;
            colBatchAction.HeaderText = "Action";
            colBatchAction.Name = "colBatchAction";
            colBatchAction.ReadOnly = true;
            colBatchAction.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colBatchChange
            // 
            colBatchChange.DataPropertyName = "Delta";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colBatchChange.DefaultCellStyle = dataGridViewCellStyle3;
            colBatchChange.FillWeight = 70F;
            colBatchChange.HeaderText = "Change";
            colBatchChange.Name = "colBatchChange";
            colBatchChange.ReadOnly = true;
            colBatchChange.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colBatchOnHandNow
            // 
            colBatchOnHandNow.DataPropertyName = "CurrentQty";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            colBatchOnHandNow.DefaultCellStyle = dataGridViewCellStyle4;
            colBatchOnHandNow.FillWeight = 90F;
            colBatchOnHandNow.HeaderText = "On hand now";
            colBatchOnHandNow.Name = "colBatchOnHandNow";
            colBatchOnHandNow.ReadOnly = true;
            colBatchOnHandNow.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colBatchLocation
            // 
            colBatchLocation.DataPropertyName = "Location";
            colBatchLocation.FillWeight = 130F;
            colBatchLocation.HeaderText = "Location";
            colBatchLocation.Name = "colBatchLocation";
            colBatchLocation.ReadOnly = true;
            colBatchLocation.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colBatchReason
            // 
            colBatchReason.DataPropertyName = "Reason";
            colBatchReason.FillWeight = 140F;
            colBatchReason.HeaderText = "Reason";
            colBatchReason.Name = "colBatchReason";
            colBatchReason.ReadOnly = true;
            colBatchReason.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // flpPost
            // 
            flpPost.BackColor = Color.Transparent;
            flpPost.Controls.Add(btnPost);
            flpPost.Controls.Add(btnRemoveLine);
            flpPost.Controls.Add(btnRecover);
            flpPost.Dock = DockStyle.Fill;
            flpPost.Location = new Point(3, 210);
            flpPost.Name = "flpPost";
            flpPost.Padding = new Padding(0, 2, 0, 2);
            flpPost.Size = new Size(779, 58);
            flpPost.TabIndex = 3;
            flpPost.WrapContents = false;
            // 
            // btnPost
            // 
            btnPost.BackColor = Color.FromArgb(71, 85, 105);
            btnPost.Cursor = Cursors.Hand;
            btnPost.FlatAppearance.BorderSize = 0;
            btnPost.FlatStyle = FlatStyle.Flat;
            btnPost.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPost.ForeColor = Color.White;
            btnPost.Location = new Point(0, 6);
            btnPost.Margin = new Padding(0, 4, 10, 4);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(340, 52);
            btnPost.TabIndex = 0;
            btnPost.Text = "POST STOCK UPDATE";
            btnPost.UseVisualStyleBackColor = false;
            btnPost.Click += btnPost_Click;
            // 
            // btnRemoveLine
            // 
            btnRemoveLine.BackColor = Color.FromArgb(226, 232, 240);
            btnRemoveLine.Cursor = Cursors.Hand;
            btnRemoveLine.FlatAppearance.BorderSize = 0;
            btnRemoveLine.FlatStyle = FlatStyle.Flat;
            btnRemoveLine.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRemoveLine.ForeColor = Color.FromArgb(30, 41, 59);
            btnRemoveLine.Location = new Point(350, 6);
            btnRemoveLine.Margin = new Padding(0, 4, 10, 4);
            btnRemoveLine.Name = "btnRemoveLine";
            btnRemoveLine.Size = new Size(130, 40);
            btnRemoveLine.TabIndex = 1;
            btnRemoveLine.Text = "Remove line";
            btnRemoveLine.UseVisualStyleBackColor = false;
            btnRemoveLine.Click += btnRemoveLine_Click;
            // 
            // btnRecover
            // 
            btnRecover.BackColor = Color.FromArgb(226, 232, 240);
            btnRecover.Cursor = Cursors.Hand;
            btnRecover.FlatAppearance.BorderSize = 0;
            btnRecover.FlatStyle = FlatStyle.Flat;
            btnRecover.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRecover.ForeColor = Color.FromArgb(30, 41, 59);
            btnRecover.Location = new Point(490, 6);
            btnRecover.Margin = new Padding(0, 4, 10, 4);
            btnRecover.Name = "btnRecover";
            btnRecover.Size = new Size(150, 40);
            btnRecover.TabIndex = 2;
            btnRecover.Text = "Recover session";
            btnRecover.UseVisualStyleBackColor = false;
            btnRecover.Click += btnRecover_Click;
            // 
            // tabAvailability
            // 
            tabAvailability.BackColor = Color.FromArgb(248, 250, 252);
            tabAvailability.Controls.Add(tlpAvailability);
            tabAvailability.Location = new Point(4, 26);
            tabAvailability.Name = "tabAvailability";
            tabAvailability.Padding = new Padding(12);
            tabAvailability.Size = new Size(809, 295);
            tabAvailability.TabIndex = 1;
            tabAvailability.Text = "Availability lookup";
            // 
            // tlpAvailability
            // 
            tlpAvailability.BackColor = Color.Transparent;
            tlpAvailability.ColumnCount = 1;
            tlpAvailability.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAvailability.Controls.Add(flpAvailBar, 0, 0);
            tlpAvailability.Controls.Add(dgvAvailability, 0, 1);
            tlpAvailability.Dock = DockStyle.Fill;
            tlpAvailability.Location = new Point(12, 12);
            tlpAvailability.Name = "tlpAvailability";
            tlpAvailability.RowCount = 2;
            tlpAvailability.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpAvailability.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAvailability.Size = new Size(785, 271);
            tlpAvailability.TabIndex = 0;
            // 
            // flpAvailBar
            // 
            flpAvailBar.BackColor = Color.Transparent;
            flpAvailBar.Controls.Add(txtAvailSearch);
            flpAvailBar.Controls.Add(btnCheckStock);
            flpAvailBar.Dock = DockStyle.Fill;
            flpAvailBar.Location = new Point(3, 3);
            flpAvailBar.Name = "flpAvailBar";
            flpAvailBar.Padding = new Padding(0, 2, 0, 2);
            flpAvailBar.Size = new Size(779, 46);
            flpAvailBar.TabIndex = 0;
            flpAvailBar.WrapContents = false;
            // 
            // txtAvailSearch
            // 
            txtAvailSearch.BorderStyle = BorderStyle.FixedSingle;
            txtAvailSearch.Font = new Font("Segoe UI", 10F);
            txtAvailSearch.Location = new Point(0, 8);
            txtAvailSearch.Margin = new Padding(0, 6, 10, 6);
            txtAvailSearch.Name = "txtAvailSearch";
            txtAvailSearch.PlaceholderText = "Search SKU, name or category";
            txtAvailSearch.Size = new Size(380, 25);
            txtAvailSearch.TabIndex = 0;
            // 
            // btnCheckStock
            // 
            btnCheckStock.BackColor = Color.FromArgb(71, 85, 105);
            btnCheckStock.Cursor = Cursors.Hand;
            btnCheckStock.FlatAppearance.BorderSize = 0;
            btnCheckStock.FlatStyle = FlatStyle.Flat;
            btnCheckStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCheckStock.ForeColor = Color.White;
            btnCheckStock.Location = new Point(390, 6);
            btnCheckStock.Margin = new Padding(0, 4, 10, 4);
            btnCheckStock.Name = "btnCheckStock";
            btnCheckStock.Size = new Size(130, 40);
            btnCheckStock.TabIndex = 1;
            btnCheckStock.Text = "Check stock";
            btnCheckStock.UseVisualStyleBackColor = false;
            btnCheckStock.Click += btnCheckStock_Click;
            // 
            // dgvAvailability
            // 
            dgvAvailability.AllowUserToAddRows = false;
            dgvAvailability.AllowUserToDeleteRows = false;
            dgvAvailability.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(248, 250, 252);
            dgvAvailability.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvAvailability.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailability.BackgroundColor = Color.White;
            dgvAvailability.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvAvailability.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvAvailability.ColumnHeadersHeight = 38;
            dgvAvailability.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAvailability.Columns.AddRange(new DataGridViewColumn[] { colAvailabilitySKU, colAvailabilityItem, colAvailabilityCategory, colAvailabilityInStock, colAvailabilityLocation, colAvailabilityPrice });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(191, 219, 254);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvAvailability.DefaultCellStyle = dataGridViewCellStyle10;
            dgvAvailability.Dock = DockStyle.Fill;
            dgvAvailability.EnableHeadersVisualStyles = false;
            dgvAvailability.Font = new Font("Segoe UI", 10F);
            dgvAvailability.GridColor = Color.FromArgb(226, 232, 240);
            dgvAvailability.Location = new Point(3, 55);
            dgvAvailability.MultiSelect = false;
            dgvAvailability.Name = "dgvAvailability";
            dgvAvailability.ReadOnly = true;
            dgvAvailability.RowHeadersVisible = false;
            dgvAvailability.RowTemplate.Height = 32;
            dgvAvailability.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailability.Size = new Size(779, 213);
            dgvAvailability.TabIndex = 1;
            // 
            // colAvailabilitySKU
            // 
            colAvailabilitySKU.DataPropertyName = "SKU";
            colAvailabilitySKU.FillWeight = 90F;
            colAvailabilitySKU.HeaderText = "SKU";
            colAvailabilitySKU.Name = "colAvailabilitySKU";
            colAvailabilitySKU.ReadOnly = true;
            colAvailabilitySKU.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colAvailabilityItem
            // 
            colAvailabilityItem.DataPropertyName = "Name";
            colAvailabilityItem.FillWeight = 220F;
            colAvailabilityItem.HeaderText = "Item";
            colAvailabilityItem.Name = "colAvailabilityItem";
            colAvailabilityItem.ReadOnly = true;
            colAvailabilityItem.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colAvailabilityCategory
            // 
            colAvailabilityCategory.DataPropertyName = "CategoryName";
            colAvailabilityCategory.FillWeight = 120F;
            colAvailabilityCategory.HeaderText = "Category";
            colAvailabilityCategory.Name = "colAvailabilityCategory";
            colAvailabilityCategory.ReadOnly = true;
            colAvailabilityCategory.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colAvailabilityInStock
            // 
            colAvailabilityInStock.DataPropertyName = "QtyOnHand";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            colAvailabilityInStock.DefaultCellStyle = dataGridViewCellStyle8;
            colAvailabilityInStock.FillWeight = 70F;
            colAvailabilityInStock.HeaderText = "In stock";
            colAvailabilityInStock.Name = "colAvailabilityInStock";
            colAvailabilityInStock.ReadOnly = true;
            colAvailabilityInStock.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colAvailabilityLocation
            // 
            colAvailabilityLocation.DataPropertyName = "StorageLocation";
            colAvailabilityLocation.FillWeight = 150F;
            colAvailabilityLocation.HeaderText = "Location";
            colAvailabilityLocation.Name = "colAvailabilityLocation";
            colAvailabilityLocation.ReadOnly = true;
            colAvailabilityLocation.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colAvailabilityPrice
            // 
            colAvailabilityPrice.DataPropertyName = "SellingPrice";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            colAvailabilityPrice.DefaultCellStyle = dataGridViewCellStyle9;
            colAvailabilityPrice.FillWeight = 80F;
            colAvailabilityPrice.HeaderText = "Price";
            colAvailabilityPrice.Name = "colAvailabilityPrice";
            colAvailabilityPrice.ReadOnly = true;
            colAvailabilityPrice.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // tabLedger
            // 
            tabLedger.BackColor = Color.FromArgb(248, 250, 252);
            tabLedger.Controls.Add(tlpLedger);
            tabLedger.Location = new Point(4, 26);
            tabLedger.Name = "tabLedger";
            tabLedger.Padding = new Padding(12);
            tabLedger.Size = new Size(809, 295);
            tabLedger.TabIndex = 2;
            tabLedger.Text = "Ledger & variance";
            // 
            // tlpLedger
            // 
            tlpLedger.BackColor = Color.Transparent;
            tlpLedger.ColumnCount = 1;
            tlpLedger.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLedger.Controls.Add(flpLedgerBar, 0, 0);
            tlpLedger.Controls.Add(dgvLedger, 0, 1);
            tlpLedger.Dock = DockStyle.Fill;
            tlpLedger.Location = new Point(12, 12);
            tlpLedger.Name = "tlpLedger";
            tlpLedger.RowCount = 2;
            tlpLedger.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpLedger.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLedger.Size = new Size(785, 271);
            tlpLedger.TabIndex = 0;
            // 
            // flpLedgerBar
            // 
            flpLedgerBar.BackColor = Color.Transparent;
            flpLedgerBar.Controls.Add(lblFrom);
            flpLedgerBar.Controls.Add(dtpFrom);
            flpLedgerBar.Controls.Add(lblTo);
            flpLedgerBar.Controls.Add(dtpTo);
            flpLedgerBar.Controls.Add(cmbLedgerAction);
            flpLedgerBar.Controls.Add(txtLedgerSearch);
            flpLedgerBar.Controls.Add(btnShowLedger);
            flpLedgerBar.Dock = DockStyle.Fill;
            flpLedgerBar.Location = new Point(3, 3);
            flpLedgerBar.Name = "flpLedgerBar";
            flpLedgerBar.Padding = new Padding(0, 2, 0, 2);
            flpLedgerBar.Size = new Size(779, 46);
            flpLedgerBar.TabIndex = 0;
            flpLedgerBar.WrapContents = false;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.BackColor = Color.Transparent;
            lblFrom.Font = new Font("Segoe UI", 10F);
            lblFrom.ForeColor = Color.FromArgb(30, 41, 59);
            lblFrom.Location = new Point(0, 10);
            lblFrom.Margin = new Padding(0, 8, 8, 0);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(41, 19);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(52, 5);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(120, 25);
            dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.BackColor = Color.Transparent;
            lblTo.Font = new Font("Segoe UI", 10F);
            lblTo.ForeColor = Color.FromArgb(30, 41, 59);
            lblTo.Location = new Point(175, 10);
            lblTo.Margin = new Padding(0, 8, 8, 0);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(23, 19);
            lblTo.TabIndex = 2;
            lblTo.Text = "To";
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(209, 5);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(120, 25);
            dtpTo.TabIndex = 3;
            // 
            // cmbLedgerAction
            // 
            cmbLedgerAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLedgerAction.Font = new Font("Segoe UI", 10F);
            cmbLedgerAction.FormattingEnabled = true;
            cmbLedgerAction.Location = new Point(332, 8);
            cmbLedgerAction.Margin = new Padding(0, 6, 10, 6);
            cmbLedgerAction.Name = "cmbLedgerAction";
            cmbLedgerAction.Size = new Size(220, 25);
            cmbLedgerAction.TabIndex = 4;
            // 
            // txtLedgerSearch
            // 
            txtLedgerSearch.BorderStyle = BorderStyle.FixedSingle;
            txtLedgerSearch.Font = new Font("Segoe UI", 10F);
            txtLedgerSearch.Location = new Point(562, 8);
            txtLedgerSearch.Margin = new Padding(0, 6, 10, 6);
            txtLedgerSearch.Name = "txtLedgerSearch";
            txtLedgerSearch.PlaceholderText = "SKU / name";
            txtLedgerSearch.Size = new Size(160, 25);
            txtLedgerSearch.TabIndex = 5;
            // 
            // btnShowLedger
            // 
            btnShowLedger.BackColor = Color.FromArgb(71, 85, 105);
            btnShowLedger.Cursor = Cursors.Hand;
            btnShowLedger.FlatAppearance.BorderSize = 0;
            btnShowLedger.FlatStyle = FlatStyle.Flat;
            btnShowLedger.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnShowLedger.ForeColor = Color.White;
            btnShowLedger.Location = new Point(732, 6);
            btnShowLedger.Margin = new Padding(0, 4, 10, 4);
            btnShowLedger.Name = "btnShowLedger";
            btnShowLedger.Size = new Size(130, 40);
            btnShowLedger.TabIndex = 6;
            btnShowLedger.Text = "Show ledger";
            btnShowLedger.UseVisualStyleBackColor = false;
            btnShowLedger.Click += btnShowLedger_Click;
            // 
            // dgvLedger
            // 
            dgvLedger.AllowUserToAddRows = false;
            dgvLedger.AllowUserToDeleteRows = false;
            dgvLedger.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(248, 250, 252);
            dgvLedger.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvLedger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLedger.BackgroundColor = Color.White;
            dgvLedger.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvLedger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvLedger.ColumnHeadersHeight = 38;
            dgvLedger.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(191, 219, 254);
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgvLedger.DefaultCellStyle = dataGridViewCellStyle13;
            dgvLedger.Dock = DockStyle.Fill;
            dgvLedger.EnableHeadersVisualStyles = false;
            dgvLedger.Font = new Font("Segoe UI", 10F);
            dgvLedger.GridColor = Color.FromArgb(226, 232, 240);
            dgvLedger.Location = new Point(3, 55);
            dgvLedger.MultiSelect = false;
            dgvLedger.Name = "dgvLedger";
            dgvLedger.ReadOnly = true;
            dgvLedger.RowHeadersVisible = false;
            dgvLedger.RowTemplate.Height = 32;
            dgvLedger.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLedger.Size = new Size(779, 213);
            dgvLedger.TabIndex = 1;
            // 
            // StockPage
            // 
            Controls.Add(tabs);
            Name = "StockPage";
            Size = new Size(857, 365);
            tabs.ResumeLayout(false);
            tabUpdate.ResumeLayout(false);
            tlpUpdate.ResumeLayout(false);
            pnlPick.ResumeLayout(false);
            flpFind.ResumeLayout(false);
            flpFind.PerformLayout();
            pnlFields.ResumeLayout(false);
            flpFields.ResumeLayout(false);
            flpFields.PerformLayout();
            flpRow1.ResumeLayout(false);
            flpRow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            flpRow2.ResumeLayout(false);
            flpRow2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatch).EndInit();
            flpPost.ResumeLayout(false);
            tabAvailability.ResumeLayout(false);
            tlpAvailability.ResumeLayout(false);
            flpAvailBar.ResumeLayout(false);
            flpAvailBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailability).EndInit();
            tabLedger.ResumeLayout(false);
            tlpLedger.ResumeLayout(false);
            flpLedgerBar.ResumeLayout(false);
            flpLedgerBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLedger).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.TableLayoutPanel tlpUpdate;
        private System.Windows.Forms.Panel pnlPick;
        private System.Windows.Forms.FlowLayoutPanel flpFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblPicked;
        private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.FlowLayoutPanel flpFields;
        private System.Windows.Forms.FlowLayoutPanel flpRow1;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.ComboBox cmbAction;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.ComboBox cmbReason;
        private System.Windows.Forms.FlowLayoutPanel flpRow2;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.DataGridView dgvBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchOnHandNow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchReason;
        private System.Windows.Forms.FlowLayoutPanel flpPost;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnRemoveLine;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.TabPage tabAvailability;
        private System.Windows.Forms.TableLayoutPanel tlpAvailability;
        private System.Windows.Forms.FlowLayoutPanel flpAvailBar;
        private System.Windows.Forms.TextBox txtAvailSearch;
        private System.Windows.Forms.Button btnCheckStock;
        private System.Windows.Forms.DataGridView dgvAvailability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailabilitySKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailabilityItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailabilityCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailabilityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailabilityLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailabilityPrice;
        private System.Windows.Forms.TabPage tabLedger;
        private System.Windows.Forms.TableLayoutPanel tlpLedger;
        private System.Windows.Forms.FlowLayoutPanel flpLedgerBar;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cmbLedgerAction;
        private System.Windows.Forms.TextBox txtLedgerSearch;
        private System.Windows.Forms.Button btnShowLedger;
        private System.Windows.Forms.DataGridView dgvLedger;
    }
}
