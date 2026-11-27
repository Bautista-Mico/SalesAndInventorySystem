using Microsoft.Data.SqlClient;
using SalesInventory.Model;
using System.Data;

namespace SalesInventory.BusinessLogic.Repository;

public static class StockRepository
{
    /// <summary>Posts every line of a batch in ONE transaction: all lines are saved or none are.</summary>
    public static void AdjustBatch(IEnumerable<StockLine> lines, int userId, int? approvedBy, decimal approvalLimit)
    {
        using var con = Db.Open();
        using var tx = con.BeginTransaction();
        try
        {
            foreach (var l in lines)
            {
                Db.Query(con, tx, "dbo.spStockAdjust",
                    Db.P("@ProductId", l.ProductId), Db.P("@ActionType", l.ActionType), Db.P("@Quantity", l.Quantity),
                    Db.P("@Location", l.Location), Db.P("@Reference", l.Reference), Db.P("@Reason", l.Reason),
                    Db.P("@UserId", userId), Db.P("@ApprovedBy", approvedBy), Db.P("@ApprovalLimit", approvalLimit));
            }
            tx.Commit();
        }
        catch
        {
            try { tx.Rollback(); } catch { /* the server may already have rolled back (XACT_ABORT) */ }
            throw;
        }
    }

    public static DataTable Ledger(DateTime? from, DateTime? to, string search, string actionType) =>
        Db.Query("dbo.spStockLedger",
            Db.P("@From", from?.Date), Db.P("@To", to?.Date),
            Db.P("@Search", string.IsNullOrWhiteSpace(search) ? null : search.Trim()),
            Db.P("@ActionType", string.IsNullOrWhiteSpace(actionType) ? null : actionType));
}
