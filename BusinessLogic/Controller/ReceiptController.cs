using SalesInventory.BusinessLogic.Repository;
using SalesInventory.Model;
using System.Text;
using System.Text.RegularExpressions;

namespace SalesInventory.BusinessLogic.Controller;

public class ReceiptController
{
    public static readonly string[] TaxOptions = { "VAT-In", "VAT-Exempt", "Business TIN" };
    public static readonly string[] DigitalFormats = { "Email PDF", "SMS Link" };
    private const int W = 42;

    public static string ComposeTaxInfo(string option, string tin)
    {
        if (option == "Business TIN")
        {
            if (string.IsNullOrWhiteSpace(tin)) throw new BusinessRuleException("Enter the Business TIN to include it on the receipt.");
            return "Business TIN: " + tin.Trim();
        }
        return option;
    }

    public string Build(Sale s, string taxInfo, bool duplicate, string note = null)
    {
        var sb = new StringBuilder();
        string C(string t) => t.Length >= W ? t : new string(' ', (W - t.Length) / 2) + t;
        string LR(string l, string r) { var sp = W - l.Length - r.Length; return sp > 0 ? l + new string(' ', sp) + r : l + " " + r; }
        string Trim(string t) => t.Length > W ? t.Substring(0, W) : t;

        if (duplicate)
        {
            sb.AppendLine(new string('=', W)); sb.AppendLine(C("*** DUPLICATE COPY ***")); sb.AppendLine(new string('=', W));
        }
        sb.AppendLine(C("SALES & INVENTORY"));
        sb.AppendLine(C("OFFICIAL RECEIPT"));
        sb.AppendLine(new string('-', W));
        sb.AppendLine(LR("Invoice:", s.InvoiceNo));
        sb.AppendLine(LR("Date:", s.SaleDate.ToString("yyyy-MM-dd HH:mm")));
        sb.AppendLine(LR("Terminal:", Environment.MachineName));
        sb.AppendLine(LR("Cashier:", $"{s.CashierName} (#{s.CashierId})"));
        sb.AppendLine(LR("Customer:", (s.CustomerType + " " + s.CustomerRef).Trim()));
        sb.AppendLine(new string('-', W));
        foreach (var i in s.Items)
        {
            sb.AppendLine(Trim(i.ProductName));
            sb.AppendLine(LR($"  {i.Quantity} x {i.UnitPrice:N2}", (i.UnitPrice * i.Quantity).ToString("N2")));
            if (i.DiscountAmount > 0) sb.AppendLine(LR("  Discount", "-" + i.DiscountAmount.ToString("N2")));
        }
        sb.AppendLine(new string('-', W));
        sb.AppendLine(LR("Subtotal", s.Subtotal.ToString("N2")));
        if (s.DiscountAmount > 0) sb.AppendLine(LR($"Discount ({s.DiscountPercent:0.##}%)", "-" + s.DiscountAmount.ToString("N2")));
        sb.AppendLine(LR("TOTAL (PHP)", s.TotalAmount.ToString("N2")));
        sb.AppendLine(LR("  VAT included", s.VatAmount.ToString("N2")));
        sb.AppendLine(LR("Payment", s.PaymentMode));
        if (s.PaymentMode == "Cash")
        {
            sb.AppendLine(LR("Cash tendered", (s.CashTendered ?? 0).ToString("N2")));
            sb.AppendLine(LR("Change", (s.ChangeDue ?? 0).ToString("N2")));
        }
        else sb.AppendLine(LR("Reference", s.PaymentRef ?? ""));
        sb.AppendLine(LR("You saved", s.DiscountAmount.ToString("N2")));
        sb.AppendLine(new string('-', W));
        if (!string.IsNullOrWhiteSpace(taxInfo)) sb.AppendLine(Trim("Tax: " + taxInfo));
        if (!string.IsNullOrWhiteSpace(note)) sb.AppendLine(Trim("Note: " + note));
        if (s.Status == "Voided") sb.AppendLine(C("*** VOIDED ***"));
        sb.AppendLine();
        sb.AppendLine(C("*" + s.InvoiceNo + "*"));
        sb.AppendLine(C("Thank you!"));
        return sb.ToString();
    }

    public string OriginalTaxInfo(int saleId) => ReceiptRepository.OriginalTaxInfo(saleId) ?? "VAT-In";

    public int SaveOriginal(Sale s, string content, string taxInfo) =>
        ReceiptRepository.Save(s.SaleId, s.InvoiceNo, "Physical Thermal Print", null, taxInfo, content, false, "Generated", null, Session.Current.UserId);

    /// <summary>A reprint after checkout. The cashier must re-enter their own password first.</summary>
    public int LogDuplicate(Sale s, string content, string taxInfo, string password)
    {
        new AuthController().VerifyCurrentPassword(password);
        return ReceiptRepository.Save(s.SaleId, s.InvoiceNo, "Physical Thermal Print", null, taxInfo, content, true, "Reprinted", "Duplicate copy", Session.Current.UserId);
    }

    public int SaveReplacement(Sale s, string content, string taxInfo, string reason, User admin)
    {
        if (admin.Role != Roles.Administrator) throw new BusinessRuleException("A replacement receipt needs administrator verification.");
        if (string.IsNullOrWhiteSpace(reason)) throw new BusinessRuleException("A modification reason is required.");
        return ReceiptRepository.Save(s.SaleId, s.InvoiceNo, "Replacement", null, taxInfo, content, true, "Replacement issued", reason.Trim(), admin.UserId);
    }

    public void MarkPrinted(Sale s, string content, string taxInfo, bool duplicate) { /* print status is tracked by the Generated/Reprinted rows */ }

    /// <summary>Email / SMS delivery. A read-only snapshot is stored locally; plug a real mail/SMS provider in here.</summary>
    public string SendDigital(Sale s, string format, string destination, string taxInfo, string content)
    {
        if (format == "Email PDF")
        {
            if (!Regex.IsMatch(destination ?? "", @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) throw new BusinessRuleException("Enter a valid email address.");
        }
        else
        {
            var digits = Regex.Replace(destination ?? "", @"[\s\-()+]", "");
            if (!Regex.IsMatch(digits, @"^\d{10,13}$")) throw new BusinessRuleException("Enter a valid mobile number (10 to 13 digits).");
        }

        var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SalesInventory", "Receipts");
        Directory.CreateDirectory(dir);
        var path = Path.Combine(dir, s.InvoiceNo + ".txt");
        if (File.Exists(path)) File.SetAttributes(path, FileAttributes.Normal);
        File.WriteAllText(path, content);
        File.SetAttributes(path, FileAttributes.ReadOnly);

        ReceiptRepository.Save(s.SaleId, s.InvoiceNo, format, destination.Trim(), taxInfo, content, false, "Sent (snapshot saved)", null, Session.Current.UserId);
        return path;
    }
}
