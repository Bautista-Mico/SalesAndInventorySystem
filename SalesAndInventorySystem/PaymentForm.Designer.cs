namespace SalesInventory.UI
{
    partial class PaymentForm
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
            pnlTop = new Panel();
            lblPaymentTitle = new Label();
            lblSummary = new Label();
            lblDue = new Label();
            pnlMid = new Panel();
            btnCash = new Button();
            btnCard = new Button();
            lblCaption = new Label();
            txtInput = new TextBox();
            btnAux = new Button();
            lblInfo = new Label();
            btnFinalize = new Button();
            pnlTop.SuspendLayout();
            pnlMid.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.BorderStyle = BorderStyle.FixedSingle;
            pnlTop.Controls.Add(lblPaymentTitle);
            pnlTop.Controls.Add(lblSummary);
            pnlTop.Controls.Add(lblDue);
            pnlTop.Location = new Point(20, 20);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(500, 92);
            pnlTop.TabIndex = 0;
            // 
            // lblPaymentTitle
            // 
            lblPaymentTitle.AutoSize = true;
            lblPaymentTitle.BackColor = Color.Transparent;
            lblPaymentTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPaymentTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblPaymentTitle.Location = new Point(14, 12);
            lblPaymentTitle.Margin = new Padding(0, 8, 8, 0);
            lblPaymentTitle.Name = "lblPaymentTitle";
            lblPaymentTitle.Size = new Size(87, 25);
            lblPaymentTitle.TabIndex = 0;
            lblPaymentTitle.Text = "Payment";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.BackColor = Color.Transparent;
            lblSummary.Font = new Font("Segoe UI", 10F);
            lblSummary.ForeColor = Color.FromArgb(100, 116, 139);
            lblSummary.Location = new Point(14, 48);
            lblSummary.Margin = new Padding(0, 8, 8, 0);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(130, 19);
            lblSummary.TabIndex = 1;
            lblSummary.Text = "0 item(s)  -  Walk-in";
            // 
            // lblDue
            // 
            lblDue.BackColor = Color.FromArgb(71, 85, 105);
            lblDue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDue.ForeColor = Color.White;
            lblDue.Location = new Point(270, 12);
            lblDue.Name = "lblDue";
            lblDue.Size = new Size(214, 66);
            lblDue.TabIndex = 2;
            lblDue.Text = "Total due";
            // 
            // pnlMid
            // 
            pnlMid.BackColor = Color.White;
            pnlMid.BorderStyle = BorderStyle.FixedSingle;
            pnlMid.Controls.Add(btnCash);
            pnlMid.Controls.Add(btnCard);
            pnlMid.Controls.Add(lblCaption);
            pnlMid.Controls.Add(txtInput);
            pnlMid.Controls.Add(btnAux);
            pnlMid.Controls.Add(lblInfo);
            pnlMid.Location = new Point(20, 128);
            pnlMid.Name = "pnlMid";
            pnlMid.Size = new Size(500, 270);
            pnlMid.TabIndex = 1;
            // 
            // btnCash
            // 
            btnCash.BackColor = Color.FromArgb(226, 232, 240);
            btnCash.Cursor = Cursors.Hand;
            btnCash.FlatAppearance.BorderSize = 0;
            btnCash.FlatStyle = FlatStyle.Flat;
            btnCash.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCash.ForeColor = Color.FromArgb(30, 41, 59);
            btnCash.Location = new Point(14, 14);
            btnCash.Margin = new Padding(0);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(221, 52);
            btnCash.TabIndex = 0;
            btnCash.Text = "Cash";
            btnCash.UseVisualStyleBackColor = false;
            btnCash.Click += btnCash_Click;
            // 
            // btnCard
            // 
            btnCard.BackColor = Color.FromArgb(226, 232, 240);
            btnCard.Cursor = Cursors.Hand;
            btnCard.FlatAppearance.BorderSize = 0;
            btnCard.FlatStyle = FlatStyle.Flat;
            btnCard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCard.ForeColor = Color.FromArgb(30, 41, 59);
            btnCard.Location = new Point(256, 14);
            btnCard.Margin = new Padding(0);
            btnCard.Name = "btnCard";
            btnCard.Size = new Size(228, 52);
            btnCard.TabIndex = 1;
            btnCard.Text = "Card";
            btnCard.UseVisualStyleBackColor = false;
            btnCard.Click += btnCard_Click;
            // 
            // lblCaption
            // 
            lblCaption.AutoSize = true;
            lblCaption.BackColor = Color.Transparent;
            lblCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCaption.ForeColor = Color.FromArgb(71, 85, 105);
            lblCaption.Location = new Point(14, 84);
            lblCaption.Margin = new Padding(0, 8, 8, 0);
            lblCaption.Name = "lblCaption";
            lblCaption.Size = new Size(105, 19);
            lblCaption.TabIndex = 3;
            lblCaption.Text = "Cash tendered";
            // 
            // txtInput
            // 
            txtInput.BorderStyle = BorderStyle.FixedSingle;
            txtInput.Font = new Font("Segoe UI", 10F);
            txtInput.Location = new Point(14, 112);
            txtInput.Margin = new Padding(0, 6, 10, 6);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(300, 25);
            txtInput.TabIndex = 4;
            // 
            // btnAux
            // 
            btnAux.BackColor = Color.FromArgb(226, 232, 240);
            btnAux.Cursor = Cursors.Hand;
            btnAux.FlatAppearance.BorderSize = 0;
            btnAux.FlatStyle = FlatStyle.Flat;
            btnAux.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAux.ForeColor = Color.FromArgb(30, 41, 59);
            btnAux.Location = new Point(324, 108);
            btnAux.Margin = new Padding(0);
            btnAux.Name = "btnAux";
            btnAux.Size = new Size(160, 40);
            btnAux.TabIndex = 5;
            btnAux.Text = "Exact amount";
            btnAux.UseVisualStyleBackColor = false;
            btnAux.Click += btnAux_Click;
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblInfo.ForeColor = Color.FromArgb(30, 41, 59);
            lblInfo.Location = new Point(14, 164);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(470, 56);
            lblInfo.TabIndex = 6;
            // 
            // btnFinalize
            // 
            btnFinalize.BackColor = Color.FromArgb(17, 24, 39);
            btnFinalize.Cursor = Cursors.Hand;
            btnFinalize.FlatAppearance.BorderSize = 0;
            btnFinalize.FlatStyle = FlatStyle.Flat;
            btnFinalize.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnFinalize.ForeColor = Color.White;
            btnFinalize.Location = new Point(20, 418);
            btnFinalize.Margin = new Padding(0);
            btnFinalize.Name = "btnFinalize";
            btnFinalize.Size = new Size(500, 62);
            btnFinalize.TabIndex = 2;
            btnFinalize.Text = "FINALIZE PAYMENT";
            btnFinalize.UseVisualStyleBackColor = false;
            btnFinalize.Click += btnFinalize_Click;
            // 
            // PaymentForm
            // 
            AcceptButton = btnFinalize;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(540, 520);
            Controls.Add(pnlTop);
            Controls.Add(pnlMid);
            Controls.Add(btnFinalize);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Payment";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlMid.ResumeLayout(false);
            pnlMid.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblPaymentTitle;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnWallet;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAux;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnFinalize;
    }
}
