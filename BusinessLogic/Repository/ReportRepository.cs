
using Microsoft.Data.SqlClient;
using SalesInventory.Model;
using System.Data;

namespace SalesInventory.BusinessLogic.Repository;

public static class ReportRepository
{
    /// <summary>All report procedures share the signature (@From, @To, @CashierId).</summary>
    public static DataTable Run(string proc, DateTime from, DateTime to, int? cashierId) =>
        Db.Query("dbo." + proc, Db.P("@From", from.Date), Db.P("@To", to.Date), Db.P("@CashierId", cashierId));

    public static DashboardSummary Dashboard()
    {
        var r = Db.Query("dbo.spDashboardSummary").Rows[0];
        return new DashboardSummary
        {
            TodaySales = Db.Val<decimal>(r, "TodaySales"),
            TodayTransactions = Db.Val<int>(r, "TodayTransactions"),
            ActiveProducts = Db.Val<int>(r, "ActiveProducts"),
            LowStockItems = Db.Val<int>(r, "LowStockItems"),
            InventoryValue = Db.Val<decimal>(r, "InventoryValue")
        };
    }
}
