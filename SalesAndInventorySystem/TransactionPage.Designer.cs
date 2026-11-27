namespace SalesInventory.UI
{
    partial class TransactionsPage
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
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            cmbStatus = new ComboBox();
            btnSearch = new Button();
            dgvTransactions = new DataGridView();
            flpBottom = new FlowLayoutPanel();
            btnView = new Button();
            btnVoid = new Button();
            btnReceiptLog = new Button();
            tlpMain.SuspendLayout();
            flpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            flpBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.Transparent;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(flpTop, 0, 0);
            tlpMain.Controls.Add(dgvTransactions, 0, 1);
            tlpMain.Controls.Add(flpBottom, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(20, 20);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tlpMain.Size = new Size(844, 325);
            tlpMain.TabIndex = 0;
            // 
            // flpTop
            // 
            flpTop.BackColor = Color.Transparent;
            flpTop.Controls.Add(txtSearch);
            flpTop.Controls.Add(lblFrom);
            flpTop.Controls.Add(dtpFrom);
            flpTop.Controls.Add(lblTo);
            flpTop.Controls.Add(dtpTo);
            flpTop.Controls.Add(cmbStatus);
            flpTop.Controls.Add(btnSearch);
            flpTop.Dock = DockStyle.Fill;
            flpTop.Location = new Point(3, 3);
            flpTop.Name = "flpTop";
            flpTop.Padding = new Padding(0, 2, 0, 2);
            flpTop.Size = new Size(838, 46);
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
            txtSearch.PlaceholderText = "Invoice no. or customer ID";
            txtSearch.Size = new Size(240, 25);
            txtSearch.TabIndex = 0;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.BackColor = Color.Transparent;
            lblFrom.Font = new Font("Segoe UI", 10F);
            lblFrom.ForeColor = Color.FromArgb(30, 41, 59);
            lblFrom.Location = new Point(250, 10);
            lblFrom.Margin = new Padding(0, 8, 8, 0);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(41, 19);
            lblFrom.TabIndex = 1;
            lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(302, 5);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(120, 25);
            dtpFrom.TabIndex = 2;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.BackColor = Color.Transparent;
            lblTo.Font = new Font("Segoe UI", 10F);
            lblTo.ForeColor = Color.FromArgb(30, 41, 59);
            lblTo.Location = new Point(425, 10);
            lblTo.Margin = new Padding(0, 8, 8, 0);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(23, 19);
            lblTo.TabIndex = 3;
            lblTo.Text = "To";
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(459, 5);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(120, 25);
            dtpTo.TabIndex = 4;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "(all)", "Paid", "Voided" });
            cmbStatus.Location = new Point(582, 8);
            cmbStatus.Margin = new Padding(0, 6, 10, 6);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(120, 25);
            cmbStatus.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(71, 85, 105);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(712, 6);
            btnSearch.Margin = new Padding(0, 4, 10, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 40);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTransactions.ColumnHeadersHeight = 38;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(191, 219, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTransactions.Dock = DockStyle.Fill;
            dgvTransactions.EnableHeadersVisualStyles = false;
            dgvTransactions.Font = new Font("Segoe UI", 10F);
            dgvTransactions.GridColor = Color.FromArgb(226, 232, 240);
            dgvTransactions.Location = new Point(3, 55);
            dgvTransactions.MultiSelect = false;
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.RowTemplate.Height = 32;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(838, 211);
            dgvTransactions.TabIndex = 1;
            // 
            // flpBottom
            // 
            flpBottom.BackColor = Color.Transparent;
            flpBottom.Controls.Add(btnView);
            flpBottom.Controls.Add(btnVoid);
            flpBottom.Controls.Add(btnReceiptLog);
            flpBottom.Dock = DockStyle.Fill;
            flpBottom.Location = new Point(3, 272);
            flpBottom.Name = "flpBottom";
            flpBottom.Padding = new Padding(0, 2, 0, 2);
            flpBottom.Size = new Size(838, 50);
            flpBottom.TabIndex = 2;
            flpBottom.WrapContents = false;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(17, 24, 39);
            btnView.Cursor = Cursors.Hand;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(0, 6);
            btnView.Margin = new Padding(0, 4, 10, 4);
            btnView.Name = "btnView";
            btnView.Size = new Size(220, 40);
            btnView.TabIndex = 0;
            btnView.Text = "View / reprint receipt";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnVoid
            // 
            btnVoid.BackColor = Color.FromArgb(220, 38, 38);
            btnVoid.Cursor = Cursors.Hand;
            btnVoid.FlatAppearance.BorderSize = 0;
            btnVoid.FlatStyle = FlatStyle.Flat;
            btnVoid.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVoid.ForeColor = Color.White;
            btnVoid.Location = new Point(230, 6);
            btnVoid.Margin = new Padding(0, 4, 10, 4);
            btnVoid.Name = "btnVoid";
            btnVoid.Size = new Size(130, 40);
            btnVoid.TabIndex = 1;
            btnVoid.Text = "Void sale";
            btnVoid.UseVisualStyleBackColor = false;
            btnVoid.Click += btnVoid_Click;
            // 
            // btnReceiptLog
            // 
            btnReceiptLog.BackColor = Color.FromArgb(226, 232, 240);
            btnReceiptLog.Cursor = Cursors.Hand;
            btnReceiptLog.FlatAppearance.BorderSize = 0;
            btnReceiptLog.FlatStyle = FlatStyle.Flat;
            btnReceiptLog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReceiptLog.ForeColor = Color.FromArgb(30, 41, 59);
            btnReceiptLog.Location = new Point(370, 6);
            btnReceiptLog.Margin = new Padding(0, 4, 10, 4);
            btnReceiptLog.Name = "btnReceiptLog";
            btnReceiptLog.Size = new Size(130, 40);
            btnReceiptLog.TabIndex = 2;
            btnReceiptLog.Text = "Receipt log";
            btnReceiptLog.UseVisualStyleBackColor = false;
            btnReceiptLog.Click += btnReceiptLog_Click;
            // 
            // TransactionsPage
            // 
            Controls.Add(tlpMain);
            Name = "TransactionsPage";
            Size = new Size(884, 365);
            tlpMain.ResumeLayout(false);
            flpTop.ResumeLayout(false);
            flpTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            flpBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.FlowLayoutPanel flpBottom;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Button btnReceiptLog;
    }
}
