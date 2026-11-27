
using Microsoft.Data.SqlClient;
using System.Data;

namespace SalesInventory.BusinessLogic.Repository;

public static class ReceiptRepository
{
    public static int Save(int saleId, string invoiceNo, string format, string destination, string taxInfo, string content,
        bool isDuplicate, string status, string note, int userId) =>
        Db.Val<int>(Db.Query("dbo.spReceiptSave",
            Db.P("@SaleId", saleId), Db.P("@InvoiceNo", invoiceNo), Db.P("@OutputFormat", format), Db.P("@Destination", destination),
            Db.P("@TaxInfo", taxInfo), Db.P("@Content", content), Db.P("@IsDuplicate", isDuplicate),
            Db.P("@DeliveryStatus", status), Db.P("@Note", note), Db.P("@CreatedBy", userId)).Rows[0], "ReceiptId");

    public static DataTable List(string search, bool duplicatesOnly) =>
        Db.Query("dbo.spReceiptList", Db.P("@Search", string.IsNullOrWhiteSpace(search) ? null : search.Trim()), Db.P("@DuplicatesOnly", duplicatesOnly));

    public static string OriginalTaxInfo(int saleId)
    {
        var dt = Db.Query("dbo.spReceiptOriginalTax", Db.P("@SaleId", saleId));
        return dt.Rows.Count == 0 ? null : Db.Val<string>(dt.Rows[0], "TaxInfo");
    }
}
