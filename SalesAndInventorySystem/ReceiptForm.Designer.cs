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
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.lblMeta = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.cmbTax = new System.Windows.Forms.ComboBox();
            this.txtTin = new System.Windows.Forms.TextBox();
            this.pnlPaper = new System.Windows.Forms.Panel();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReplacement = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlPaper.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.RowCount = 3;
            this.tlpMain.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlpMain.Controls.Add(this.pnlTop, 0, 0);
            this.tlpMain.Controls.Add(this.pnlPaper, 0, 1);
            this.tlpMain.Controls.Add(this.flpButtons, 0, 2);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Controls.Add(this.lblInvoice);
            this.pnlTop.Controls.Add(this.lblMeta);
            this.pnlTop.Controls.Add(this.lblTax);
            this.pnlTop.Controls.Add(this.cmbTax);
            this.pnlTop.Controls.Add(this.txtTin);
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoice.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInvoice.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblInvoice.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.lblInvoice.Text = "Invoice";
            this.lblInvoice.Location = new System.Drawing.Point(12, 8);
            // 
            // lblMeta
            // 
            this.lblMeta.AutoSize = true;
            this.lblMeta.BackColor = System.Drawing.Color.Transparent;
            this.lblMeta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMeta.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMeta.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.lblMeta.Text = "Terminal";
            this.lblMeta.Location = new System.Drawing.Point(12, 40);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTax.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.lblTax.Text = "Tax:";
            this.lblTax.Location = new System.Drawing.Point(300, 42);
            // 
            // cmbTax
            // 
            this.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTax.FormattingEnabled = true;
            this.cmbTax.Margin = new System.Windows.Forms.Padding(0, 6, 10, 6);
            this.cmbTax.Size = new System.Drawing.Size(130, 25);
            this.cmbTax.Location = new System.Drawing.Point(338, 36);
            // 
            // txtTin
            // 
            this.txtTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTin.Margin = new System.Windows.Forms.Padding(0, 6, 10, 6);
            this.txtTin.PlaceholderText = "Business TIN";
            this.txtTin.Size = new System.Drawing.Size(130, 25);
            this.txtTin.Location = new System.Drawing.Point(478, 38);
            // 
            // pnlPaper
            // 
            this.pnlPaper.BackColor = System.Drawing.Color.White;
            this.pnlPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaper.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.pnlPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaper.Controls.Add(this.txtPreview);
            // 
            // txtPreview
            // 
            this.txtPreview.BackColor = System.Drawing.Color.White;
            this.txtPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPreview.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPreview.Multiline = true;
            this.txtPreview.ReadOnly = true;
            this.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // flpButtons
            // 
            this.flpButtons.BackColor = System.Drawing.Color.Transparent;
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButtons.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flpButtons.WrapContents = false;
            this.flpButtons.Controls.Add(this.btnPrint);
            this.flpButtons.Controls.Add(this.btnSend);
            this.flpButtons.Controls.Add(this.btnReplacement);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnPrint.Size = new System.Drawing.Size(200, 40);
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnSend.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnSend.Size = new System.Drawing.Size(200, 40);
            this.btnSend.Text = "Send digital copy";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReplacement
            // 
            this.btnReplacement.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnReplacement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplacement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReplacement.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnReplacement.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.btnReplacement.Size = new System.Drawing.Size(190, 40);
            this.btnReplacement.Text = "Replacement (admin)";
            this.btnReplacement.UseVisualStyleBackColor = false;
            this.btnReplacement.FlatAppearance.BorderSize = 0;
            this.btnReplacement.Click += new System.EventHandler(this.btnReplacement_Click);
            // 
            // ReceiptForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(620, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(560, 640);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Receipt";
            this.Controls.Add(this.tlpMain);
            this.Name = "ReceiptForm";
            this.flpButtons.ResumeLayout(false);
            this.flpButtons.PerformLayout();
            this.pnlPaper.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReplacement;
    }
}
