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
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblPaymentTitle = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblDue = new System.Windows.Forms.Label();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnWallet = new System.Windows.Forms.Button();
            this.lblCaption = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAux = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Location = new System.Drawing.Point(20, 20);
            this.pnlTop.Size = new System.Drawing.Size(500, 92);
            this.pnlTop.Controls.Add(this.lblPaymentTitle);
            this.pnlTop.Controls.Add(this.lblSummary);
            this.pnlTop.Controls.Add(this.lblDue);
            // 
            // lblPaymentTitle
            // 
            this.lblPaymentTitle.AutoSize = true;
            this.lblPaymentTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPaymentTitle.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.lblPaymentTitle.Text = "Payment";
            this.lblPaymentTitle.Location = new System.Drawing.Point(14, 12);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.BackColor = System.Drawing.Color.Transparent;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSummary.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.lblSummary.Text = "0 item(s)  -  Walk-in";
            this.lblSummary.Location = new System.Drawing.Point(14, 48);
            // 
            // lblDue
            // 
            this.lblDue.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblDue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDue.ForeColor = System.Drawing.Color.White;
            this.lblDue.Location = new System.Drawing.Point(270, 12);
            this.lblDue.Size = new System.Drawing.Size(214, 66);
            this.lblDue.Text = "Total due";
            // 
            // pnlMid
            // 
            this.pnlMid.BackColor = System.Drawing.Color.White;
            this.pnlMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMid.Location = new System.Drawing.Point(20, 128);
            this.pnlMid.Size = new System.Drawing.Size(500, 270);
            this.pnlMid.Controls.Add(this.btnCash);
            this.pnlMid.Controls.Add(this.btnCard);
            this.pnlMid.Controls.Add(this.btnWallet);
            this.pnlMid.Controls.Add(this.lblCaption);
            this.pnlMid.Controls.Add(this.txtInput);
            this.pnlMid.Controls.Add(this.btnAux);
            this.pnlMid.Controls.Add(this.lblInfo);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCash.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnCash.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnCash.Size = new System.Drawing.Size(150, 52);
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.Location = new System.Drawing.Point(14, 14);
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCard.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnCard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnCard.Size = new System.Drawing.Size(150, 52);
            this.btnCard.Text = "Card";
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.FlatAppearance.BorderSize = 0;
            this.btnCard.Location = new System.Drawing.Point(174, 14);
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnWallet
            // 
            this.btnWallet.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnWallet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWallet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWallet.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnWallet.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnWallet.Size = new System.Drawing.Size(150, 52);
            this.btnWallet.Text = "Mobile Wallet";
            this.btnWallet.UseVisualStyleBackColor = false;
            this.btnWallet.FlatAppearance.BorderSize = 0;
            this.btnWallet.Location = new System.Drawing.Point(334, 14);
            this.btnWallet.Click += new System.EventHandler(this.btnWallet_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.lblCaption.Text = "Cash tendered";
            this.lblCaption.Location = new System.Drawing.Point(14, 84);
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInput.Margin = new System.Windows.Forms.Padding(0, 6, 10, 6);
            this.txtInput.Size = new System.Drawing.Size(300, 25);
            this.txtInput.Location = new System.Drawing.Point(14, 112);
            // 
            // btnAux
            // 
            this.btnAux.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnAux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAux.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAux.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnAux.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnAux.Size = new System.Drawing.Size(160, 40);
            this.btnAux.Text = "Exact amount";
            this.btnAux.UseVisualStyleBackColor = false;
            this.btnAux.FlatAppearance.BorderSize = 0;
            this.btnAux.Location = new System.Drawing.Point(324, 108);
            this.btnAux.Click += new System.EventHandler(this.btnAux_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = false;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblInfo.Location = new System.Drawing.Point(14, 164);
            this.lblInfo.Size = new System.Drawing.Size(470, 56);
            // 
            // btnFinalize
            // 
            this.btnFinalize.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.btnFinalize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalize.ForeColor = System.Drawing.Color.White;
            this.btnFinalize.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnFinalize.Size = new System.Drawing.Size(500, 62);
            this.btnFinalize.Text = "FINALIZE PAYMENT";
            this.btnFinalize.UseVisualStyleBackColor = false;
            this.btnFinalize.FlatAppearance.BorderSize = 0;
            this.btnFinalize.Location = new System.Drawing.Point(20, 418);
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // PaymentForm
            // 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.AcceptButton = this.btnFinalize;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(540, 520);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Text = "Payment";
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMid);
            this.Controls.Add(this.btnFinalize);
            this.Name = "PaymentForm";
            this.pnlMid.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
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
