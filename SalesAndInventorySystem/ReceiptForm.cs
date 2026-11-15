using System.Drawing.Printing;
using UI;

namespace SalesInventory.UI;

/// <summary>Receipt preview + print / digital delivery (see the Receipt Management sketch).</summary>
public partial class ReceiptForm : Form
{
    private readonly ReceiptController _ctl = new();
    private readonly Sale _sale;
    private readonly bool _duplicate;
    private string _content, _taxInfo;
    private bool _saved;

    public ReceiptForm() : this(null, false) { }

    public ReceiptForm(Sale sale, bool duplicate)
    {
        _sale = sale; _duplicate = duplicate;
        InitializeComponent();
        if (Ui.InDesigner) return;
        Text = duplicate ? "Receipt (duplicate copy)" : "Receipt";

        // top bar: invoice / terminal / cashier + tax registration
        lblInvoice.Text = "Invoice " + sale.InvoiceNo;
        lblMeta.Text = $"Terminal {Environment.MachineName}  -  Cashier #{sale.CashierId}";
        cmbTax.Items.AddRange(ReceiptController.TaxOptions.Cast<object>().ToArray());
        cmbTax.SelectedIndex = 0;

        var original = duplicate ? _ctl.OriginalTaxInfo(sale.SaleId) : "VAT-In";
        if (duplicate)
        {
            cmbTax.Enabled = false; txtTin.Enabled = false; _taxInfo = original;
        }
        cmbTax.SelectedIndexChanged += (s, e) => { txtTin.Visible = cmbTax.Text == "Business TIN"; if (!_saved) Rebuild(); };
        txtTin.TextChanged += (s, e) => { if (!_saved && cmbTax.Text == "Business TIN") Rebuild(); };
        txtTin.Visible = false;
        Rebuild();
        FormClosing += (s, e) => EnsureSaved();
    }

    private void btnPrint_Click(object sender, EventArgs e) => Print();
    private void btnSend_Click(object sender, EventArgs e) => SendDigital();
    private void btnReplacement_Click(object sender, EventArgs e) => Replacement();

    private void Rebuild()
    {
        if (!_duplicate)
        {
            try { _taxInfo = ReceiptController.ComposeTaxInfo(cmbTax.Text, txtTin.Text); }
            catch (BusinessRuleException) { _taxInfo = "Business TIN: (pending)"; }
        }
        _content = _ctl.Build(_sale, _taxInfo, _duplicate);
        txtPreview.Text = _content;
    }

    /// <summary>The original receipt is archived once; after that its tax fields are locked.</summary>
    private void EnsureSaved()
    {
        if (_saved) return;
        try
        {
            if (!_duplicate) { _taxInfo = ReceiptController.ComposeTaxInfo(cmbTax.Text, txtTin.Text); _content = _ctl.Build(_sale, _taxInfo, false); _ctl.SaveOriginal(_sale, _content, _taxInfo); }
            _saved = true; cmbTax.Enabled = false; txtTin.Enabled = false;
        }
        catch (BusinessRuleException ex) { Ui.Warn(ex.Message); }
    }

    private void Print() => Ui.Guard(() =>
    {
        EnsureSaved();
        try
        {
            using var doc = new PrintDocument();
            doc.PrintPage += (s, e) =>
            {
                using var f = new Font("Consolas", 9f);
                e.Graphics.DrawString(_content, f, Brushes.Black, new RectangleF(20, 20, e.PageBounds.Width - 40, e.PageBounds.Height - 40));
            };
            using var dlg = new PrintPreviewDialog { Document = doc, Width = 760, Height = 860 };
            dlg.ShowDialog(this);
            btnPrint.Text = "Print";
        }
        catch (Exception ex)
        {
            btnPrint.Text = "Retry Print";   // the receipt stays queued; no admin credentials are needed to retry
            Ui.Error("The printer reported a problem (paper jam or communication error).\nThe receipt is kept - press Retry Print.\n\n" + ex.Message);
        }
    });

    private void SendDigital() => Ui.Guard(() =>
    {
        EnsureSaved();
        var format = PickFormat(); if (format == null) return;
        var dest = PromptForm.Ask(this, "Send digital receipt", format == "Email PDF" ? "Customer email address:" : "Customer mobile number:");
        if (dest == null) return;
        var path = _ctl.SendDigital(_sale, format, dest, _taxInfo, _content);
        Ui.Info("Digital receipt queued for delivery.\nA read-only snapshot was saved to:\n" + path);
    });

    private string PickFormat() => MessageBox.Show(this, "Send as an Email PDF?\n\nYes = Email PDF\nNo = SMS link", "Digital receipt",
        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) switch
    { DialogResult.Yes => "Email PDF", DialogResult.No => "SMS Link", _ => null };

    private void Replacement() => Ui.Guard(() =>
    {
        EnsureSaved();
        using var a = new AuthorizationForm("Issuing a replacement receipt / changing tax details needs administrator verification.", Roles.Administrator);
        if (a.ShowDialog(this) != DialogResult.OK) return;
        var reason = PromptForm.Ask(this, "Modification reason", "Reason for the replacement (e.g. Corporate Tax Detail Adjust):");
        if (string.IsNullOrWhiteSpace(reason)) return;
        var tin = PromptForm.Ask(this, "Tax details", "Business TIN to print on the replacement (leave blank for VAT-In):");
        if (tin == null) return;
        var taxInfo = string.IsNullOrWhiteSpace(tin) ? "VAT-In" : ReceiptController.ComposeTaxInfo("Business TIN", tin);
        _taxInfo = taxInfo;
        _content = _ctl.Build(_sale, taxInfo, true, "Replacement: " + reason.Trim());
        txtPreview.Text = _content;
        _ctl.SaveReplacement(_sale, _content, taxInfo, reason, a.Approver);
        Ui.Info("Replacement receipt generated and logged.");
    });
}
