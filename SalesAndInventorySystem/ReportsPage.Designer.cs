namespace SalesInventory.UI
{
    partial class ReportsPage
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
            flpFilters = new FlowLayoutPanel();
            lblReport = new Label();
            cmbReport = new ComboBox();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            cmbCashier = new ComboBox();
            tlpMid = new TableLayoutPanel();
            pnlChart = new Panel();
            chart = new BarChartPanel();
            tlpRight = new TableLayoutPanel();
            dgvReport = new DataGridView();
            flpCounted = new FlowLayoutPanel();
            txtCounted = new TextBox();
            lblRecon = new Label();
            flpBottom = new FlowLayoutPanel();
            btnGenerate = new Button();
            btnExport = new Button();
            btnClear = new Button();
            tlpMain.SuspendLayout();
            flpFilters.SuspendLayout();
            tlpMid.SuspendLayout();
            pnlChart.SuspendLayout();
            tlpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            flpCounted.SuspendLayout();
            flpBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.Transparent;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(flpFilters, 0, 0);
            tlpMain.Controls.Add(tlpMid, 0, 1);
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
            // flpFilters
            // 
            flpFilters.BackColor = Color.Transparent;
            flpFilters.Controls.Add(lblReport);
            flpFilters.Controls.Add(cmbReport);
            flpFilters.Controls.Add(lblFrom);
            flpFilters.Controls.Add(dtpFrom);
            flpFilters.Controls.Add(lblTo);
            flpFilters.Controls.Add(dtpTo);
            flpFilters.Controls.Add(cmbCashier);
            flpFilters.Dock = DockStyle.Fill;
            flpFilters.Location = new Point(3, 3);
            flpFilters.Name = "flpFilters";
            flpFilters.Padding = new Padding(0, 2, 0, 2);
            flpFilters.Size = new Size(811, 46);
            flpFilters.TabIndex = 0;
            flpFilters.WrapContents = false;
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.BackColor = Color.Transparent;
            lblReport.Font = new Font("Segoe UI", 10F);
            lblReport.ForeColor = Color.FromArgb(30, 41, 59);
            lblReport.Location = new Point(0, 10);
            lblReport.Margin = new Padding(0, 8, 8, 0);
            lblReport.Name = "lblReport";
            lblReport.Size = new Size(50, 19);
            lblReport.TabIndex = 0;
            lblReport.Text = "Report";
            // 
            // cmbReport
            // 
            cmbReport.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReport.Font = new Font("Segoe UI", 10F);
            cmbReport.FormattingEnabled = true;
            cmbReport.Location = new Point(58, 8);
            cmbReport.Margin = new Padding(0, 6, 10, 6);
            cmbReport.Name = "cmbReport";
            cmbReport.Size = new Size(230, 25);
            cmbReport.TabIndex = 1;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.BackColor = Color.Transparent;
            lblFrom.Font = new Font("Segoe UI", 10F);
            lblFrom.ForeColor = Color.FromArgb(30, 41, 59);
            lblFrom.Location = new Point(298, 10);
            lblFrom.Margin = new Padding(0, 8, 8, 0);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(41, 19);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(350, 5);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(120, 25);
            dtpFrom.TabIndex = 3;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.BackColor = Color.Transparent;
            lblTo.Font = new Font("Segoe UI", 10F);
            lblTo.ForeColor = Color.FromArgb(30, 41, 59);
            lblTo.Location = new Point(473, 10);
            lblTo.Margin = new Padding(0, 8, 8, 0);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(23, 19);
            lblTo.TabIndex = 4;
            lblTo.Text = "To";
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(507, 5);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(120, 25);
            dtpTo.TabIndex = 5;
            // 
            // cmbCashier
            // 
            cmbCashier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCashier.Font = new Font("Segoe UI", 10F);
            cmbCashier.FormattingEnabled = true;
            cmbCashier.Location = new Point(630, 8);
            cmbCashier.Margin = new Padding(0, 6, 10, 6);
            cmbCashier.Name = "cmbCashier";
            cmbCashier.Size = new Size(180, 25);
            cmbCashier.TabIndex = 6;
            // 
            // tlpMid
            // 
            tlpMid.ColumnCount = 2;
            tlpMid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpMid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpMid.Controls.Add(pnlChart, 0, 0);
            tlpMid.Controls.Add(tlpRight, 1, 0);
            tlpMid.Dock = DockStyle.Fill;
            tlpMid.Location = new Point(3, 55);
            tlpMid.Name = "tlpMid";
            tlpMid.RowCount = 1;
            tlpMid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMid.Size = new Size(811, 211);
            tlpMid.TabIndex = 1;
            // 
            // pnlChart
            // 
            pnlChart.BackColor = Color.White;
            pnlChart.BorderStyle = BorderStyle.FixedSingle;
            pnlChart.Controls.Add(chart);
            pnlChart.Dock = DockStyle.Fill;
            pnlChart.Location = new Point(3, 3);
            pnlChart.Name = "pnlChart";
            pnlChart.Padding = new Padding(2);
            pnlChart.Size = new Size(318, 205);
            pnlChart.TabIndex = 0;
            // 
            // chart
            // 
            chart.BackColor = Color.White;
            chart.Dock = DockStyle.Fill;
            chart.Location = new Point(2, 2);
            chart.Name = "chart";
            chart.Size = new Size(312, 199);
            chart.TabIndex = 0;
            // 
            // tlpRight
            // 
            tlpRight.BackColor = Color.Transparent;
            tlpRight.ColumnCount = 1;
            tlpRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRight.Controls.Add(dgvReport, 0, 0);
            tlpRight.Controls.Add(flpCounted, 0, 1);
            tlpRight.Dock = DockStyle.Fill;
            tlpRight.Location = new Point(334, 0);
            tlpRight.Margin = new Padding(10, 0, 0, 0);
            tlpRight.Name = "tlpRight";
            tlpRight.RowCount = 2;
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tlpRight.Size = new Size(477, 211);
            tlpRight.TabIndex = 1;
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = Color.White;
            dgvReport.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(203, 213, 225);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReport.ColumnHeadersHeight = 38;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(191, 219, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReport.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.EnableHeadersVisualStyles = false;
            dgvReport.Font = new Font("Segoe UI", 10F);
            dgvReport.GridColor = Color.FromArgb(226, 232, 240);
            dgvReport.Location = new Point(3, 3);
            dgvReport.MultiSelect = false;
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersVisible = false;
            dgvReport.RowTemplate.Height = 32;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(471, 159);
            dgvReport.TabIndex = 0;
            // 
            // flpCounted
            // 
            flpCounted.BackColor = Color.Transparent;
            flpCounted.Controls.Add(txtCounted);
            flpCounted.Controls.Add(lblRecon);
            flpCounted.Dock = DockStyle.Fill;
            flpCounted.Location = new Point(3, 168);
            flpCounted.Name = "flpCounted";
            flpCounted.Padding = new Padding(0, 2, 0, 2);
            flpCounted.Size = new Size(471, 40);
            flpCounted.TabIndex = 1;
            flpCounted.WrapContents = false;
            // 
            // txtCounted
            // 
            txtCounted.BorderStyle = BorderStyle.FixedSingle;
            txtCounted.Font = new Font("Segoe UI", 10F);
            txtCounted.Location = new Point(0, 8);
            txtCounted.Margin = new Padding(0, 6, 10, 6);
            txtCounted.Name = "txtCounted";
            txtCounted.PlaceholderText = "Counted cash in drawer";
            txtCounted.Size = new Size(190, 25);
            txtCounted.TabIndex = 0;
            // 
            // lblRecon
            // 
            lblRecon.AutoSize = true;
            lblRecon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRecon.Location = new Point(200, 12);
            lblRecon.Margin = new Padding(0, 10, 0, 0);
            lblRecon.Name = "lblRecon";
            lblRecon.Size = new Size(0, 19);
            lblRecon.TabIndex = 1;
            // 
            // flpBottom
            // 
            flpBottom.BackColor = Color.Transparent;
            flpBottom.Controls.Add(btnGenerate);
            flpBottom.Controls.Add(btnExport);
            flpBottom.Controls.Add(btnClear);
            flpBottom.Dock = DockStyle.Fill;
            flpBottom.Location = new Point(3, 272);
            flpBottom.Name = "flpBottom";
            flpBottom.Padding = new Padding(0, 2, 0, 2);
            flpBottom.Size = new Size(811, 50);
            flpBottom.TabIndex = 2;
            flpBottom.WrapContents = false;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(17, 24, 39);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(0, 6);
            btnGenerate.Margin = new Padding(0, 4, 10, 4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(170, 40);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate report";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(226, 232, 240);
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExport.ForeColor = Color.FromArgb(30, 41, 59);
            btnExport.Location = new Point(180, 6);
            btnExport.Margin = new Padding(0, 4, 10, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(140, 40);
            btnExport.TabIndex = 1;
            btnExport.Text = "Export CSV";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(226, 232, 240);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(30, 41, 59);
            btnClear.Location = new Point(330, 6);
            btnClear.Margin = new Padding(0, 4, 10, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 40);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // ReportsPage
            // 
            Controls.Add(tlpMain);
            Name = "ReportsPage";
            Size = new Size(857, 365);
            tlpMain.ResumeLayout(false);
            flpFilters.ResumeLayout(false);
            flpFilters.PerformLayout();
            tlpMid.ResumeLayout(false);
            pnlChart.ResumeLayout(false);
            tlpRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            flpCounted.ResumeLayout(false);
            flpCounted.PerformLayout();
            flpBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpFilters;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.ComboBox cmbReport;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cmbCashier;
        private System.Windows.Forms.TableLayoutPanel tlpMid;
        private System.Windows.Forms.Panel pnlChart;
        private BarChartPanel chart;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.FlowLayoutPanel flpCounted;
        private System.Windows.Forms.TextBox txtCounted;
        private System.Windows.Forms.Label lblRecon;
        private System.Windows.Forms.FlowLayoutPanel flpBottom;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClear;
    }
}
