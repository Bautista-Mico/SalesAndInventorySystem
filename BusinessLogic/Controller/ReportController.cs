using SalesInventory.BusinessLogic.Repository;
using SalesInventory.Model;
using System.Data;
using System.Text;

namespace SalesInventory.BusinessLogic.Controller;

public class ReportDef
{
    public string Name { get; set; }
    public string Proc { get; set; }
    public string LabelCol { get; set; }
    public string ValueCol { get; set; }
    public bool UsesCashier { get; set; }
    public bool NeedsAdminCredential { get; set; }
    public bool AdminOnly { get; set; }
    public override string ToString() => Name;
}

public class ReportResult
{
    public ReportDef Def { get; set; }
    public DataTable Table { get; set; }
}

public class ReportController
{
    public List<ReportDef> Available()
    {
        var all = new List<ReportDef>
        {
            new() { Name = "Sales Revenue", Proc = "spReportDailySales", LabelCol = "SaleDate", ValueCol = "NetSales", UsesCashier = true },
            new() { Name = "Payment Mode Ratio", Proc = "spReportPaymentModes", LabelCol = "PaymentMode", ValueCol = "Amount", UsesCashier = true },
            new() { Name = "Cash Drawer Reconciliation", Proc = "spReportCashDrawer", LabelCol = "Cashier", ValueCol = "ExpectedCash", UsesCashier = true },
            new() { Name = "Stock Variance", Proc = "spReportStockVariance", LabelCol = "SKU", ValueCol = "ValueImpact" },
            new() { Name = "Top Selling Products", Proc = "spReportTopProducts", LabelCol = "ProductName", ValueCol = "Revenue", UsesCashier = true },
            new() { Name = "Inventory Valuation", Proc = "spReportInventoryValuation", LabelCol = "Category", ValueCol = "InventoryValue" },
            new() { Name = "Tax Compliance", Proc = "spReportTax", LabelCol = "SaleDate", ValueCol = "VatAmount", NeedsAdminCredential = true },
            new() { Name = "Void Volumes by Cashier", Proc = "spReportVoids", LabelCol = "Cashier", ValueCol = "VoidedAmount", AdminOnly = true, NeedsAdminCredential = true },
            new() { Name = "Gateway Token Cross-check", Proc = "spReportPayments", LabelCol = "InvoiceNo", ValueCol = "Amount", AdminOnly = true, NeedsAdminCredential = true },
        };
        return all.Where(r => !r.AdminOnly || Session.InRole(Roles.Administrator)).ToList();
    }

    public ReportResult Run(ReportDef def, DateTime from, DateTime to, int? cashierId)
    {
        if (!Permissions.CanViewReports) throw new BusinessRuleException("You do not have permission to view reports.");
        if (from.Date > to.Date) throw new BusinessRuleException("The Start Date cannot be after the End Date.");
        var table = ReportRepository.Run(def.Proc, from, to, cashierId);
        if (table.Rows.Count == 0) throw new BusinessRuleException("No matching ledger records were found for the selected filters.");
        return new ReportResult { Def = def, Table = table };
    }

    public List<User> Cashiers() => UserRepository.GetAll(null).Where(u => u.Role == Roles.Cashier).ToList();

    public DashboardSummary Dashboard() => ReportRepository.Dashboard();

    public void ExportCsv(DataTable table, string path)
    {
        if (table == null || table.Rows.Count == 0) throw new BusinessRuleException("There is no report data to export.");
        string Esc(object v)
        {
            var s = v == null || v == DBNull.Value ? "" : Convert.ToString(v, System.Globalization.CultureInfo.InvariantCulture);
            return s.Contains(',') || s.Contains('"') || s.Contains('\n') ? "\"" + s.Replace("\"", "\"\"") + "\"" : s;
        }
        var sb = new StringBuilder();
        sb.AppendLine(string.Join(",", table.Columns.Cast<DataColumn>().Select(c => Esc(c.ColumnName))));
        foreach (DataRow r in table.Rows) sb.AppendLine(string.Join(",", r.ItemArray.Select(Esc)));
        File.WriteAllText(path, sb.ToString(), new UTF8Encoding(true));
    }
}
