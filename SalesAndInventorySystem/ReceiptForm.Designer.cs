namespace SalesInventory.UI
{
    partial class ReceiptForm
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
            tlpMain = new TableLayoutPanel();
            pnlTop = new Panel();
            lblInvoice = new Label();
            lblMeta = new Label();
            lblTax = new Label();
            cmbTax = new ComboBox();
            txtTin = new TextBox();
            pnlPaper = new Panel();
            txtPreview = new TextBox();
            flpButtons = new FlowLayoutPanel();
            btnPrint = new Button();
            tlpMain.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlPaper.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.Transparent;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlTop, 0, 0);
            tlpMain.Controls.Add(pnlPaper, 0, 1);
            tlpMain.Controls.Add(flpButtons, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(16);
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tlpMain.Size = new Size(620, 701);
            tlpMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.BorderStyle = BorderStyle.FixedSingle;
            pnlTop.Controls.Add(lblInvoice);
            pnlTop.Controls.Add(lblMeta);
            pnlTop.Controls.Add(lblTax);
            pnlTop.Controls.Add(cmbTax);
            pnlTop.Controls.Add(txtTin);
            pnlTop.Dock = DockStyle.Fill;
            pnlTop.Location = new Point(19, 19);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(582, 70);
            pnlTop.TabIndex = 0;
            // 
            // lblInvoice
            // 
            lblInvoice.AutoSize = true;
            lblInvoice.BackColor = Color.Transparent;
            lblInvoice.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblInvoice.ForeColor = Color.FromArgb(30, 41, 59);
            lblInvoice.Location = new Point(12, 8);
            lblInvoice.Margin = new Padding(0, 8, 8, 0);
            lblInvoice.Name = "lblInvoice";
            lblInvoice.Size = new Size(74, 25);
            lblInvoice.TabIndex = 0;
            lblInvoice.Text = "Invoice";
            // 
            // lblMeta
            // 
            lblMeta.AutoSize = true;
            lblMeta.BackColor = Color.Transparent;
            lblMeta.Font = new Font("Segoe UI", 10F);
            lblMeta.ForeColor = Color.FromArgb(100, 116, 139);
            lblMeta.Location = new Point(12, 40);
            lblMeta.Margin = new Padding(0, 8, 8, 0);
            lblMeta.Name = "lblMeta";
            lblMeta.Size = new Size(60, 19);
            lblMeta.TabIndex = 1;
            lblMeta.Text = "Terminal";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.BackColor = Color.Transparent;
            lblTax.Font = new Font("Segoe UI", 10F);
            lblTax.ForeColor = Color.FromArgb(100, 116, 139);
            lblTax.Location = new Point(300, 42);
            lblTax.Margin = new Padding(0, 8, 8, 0);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(30, 19);
            lblTax.TabIndex = 2;
            lblTax.Text = "Tax:";
            // 
            // cmbTax
            // 
            cmbTax.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTax.Font = new Font("Segoe UI", 10F);
            cmbTax.FormattingEnabled = true;
            cmbTax.Location = new Point(338, 36);
            cmbTax.Margin = new Padding(0, 6, 10, 6);
            cmbTax.Name = "cmbTax";
            cmbTax.Size = new Size(130, 25);
            cmbTax.TabIndex = 3;
            // 
            // txtTin
            // 
            txtTin.BorderStyle = BorderStyle.FixedSingle;
            txtTin.Font = new Font("Segoe UI", 10F);
            txtTin.Location = new Point(478, 38);
            txtTin.Margin = new Padding(0, 6, 10, 6);
            txtTin.Name = "txtTin";
            txtTin.PlaceholderText = "Business TIN";
            txtTin.Size = new Size(130, 25);
            txtTin.TabIndex = 4;
            // 
            // pnlPaper
            // 
            pnlPaper.BackColor = Color.White;
            pnlPaper.BorderStyle = BorderStyle.FixedSingle;
            pnlPaper.Controls.Add(txtPreview);
            pnlPaper.Dock = DockStyle.Fill;
            pnlPaper.Location = new Point(19, 95);
            pnlPaper.Name = "pnlPaper";
            pnlPaper.Padding = new Padding(14);
            pnlPaper.Size = new Size(582, 531);
            pnlPaper.TabIndex = 1;
            // 
            // txtPreview
            // 
            txtPreview.BackColor = Color.White;
            txtPreview.BorderStyle = BorderStyle.None;
            txtPreview.Dock = DockStyle.Fill;
            txtPreview.Font = new Font("Consolas", 9.5F);
            txtPreview.Location = new Point(14, 14);
            txtPreview.Multiline = true;
            txtPreview.Name = "txtPreview";
            txtPreview.ReadOnly = true;
            txtPreview.ScrollBars = ScrollBars.Vertical;
            txtPreview.Size = new Size(552, 501);
            txtPreview.TabIndex = 0;
            // 
            // flpButtons
            // 
            flpButtons.BackColor = Color.Transparent;
            flpButtons.Controls.Add(btnPrint);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.Location = new Point(19, 632);
            flpButtons.Name = "flpButtons";
            flpButtons.Padding = new Padding(0, 2, 0, 2);
            flpButtons.Size = new Size(582, 50);
            flpButtons.TabIndex = 2;
            flpButtons.WrapContents = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(17, 24, 39);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(0, 6);
            btnPrint.Margin = new Padding(0, 4, 10, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(582, 40);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // ReceiptForm
            // 
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(620, 701);
            Controls.Add(tlpMain);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(560, 640);
            Name = "ReceiptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Receipt";
            tlpMain.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlPaper.ResumeLayout(false);
            pnlPaper.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label lblMeta;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.ComboBox cmbTax;
        private System.Windows.Forms.TextBox txtTin;
        private System.Windows.Forms.Panel pnlPaper;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnPrint;
    }
}
