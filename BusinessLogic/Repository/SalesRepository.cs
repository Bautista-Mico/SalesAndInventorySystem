using Microsoft.Data.SqlClient;
using SalesInventory.Model;
using System.Data;

namespace SalesInventory.BusinessLogic.Repository;

public static class SalesRepository
{
    public static (int SaleId, string InvoiceNo) Complete(int cashierId, string customerType, string customerRef, decimal discountPercent,
        string paymentMode, string paymentRef, decimal? cashTendered, int? overrideApprovedBy, IEnumerable<CartLine> lines)
    {
        var tvp = new DataTable();
        tvp.Columns.Add("ProductId", typeof(int));
        tvp.Columns.Add("Quantity", typeof(int));
        tvp.Columns.Add("OverridePrice", typeof(decimal));
        foreach (var l in lines)
            tvp.Rows.Add(l.ProductId, l.Quantity, l.OverridePrice.HasValue ? (object)l.OverridePrice.Value : DBNull.Value);

        var items = new SqlParameter("@Items", SqlDbType.Structured) { TypeName = "dbo.SaleItemType", Value = tvp };
        var saleId = new SqlParameter("@SaleId", SqlDbType.Int) { Direction = ParameterDirection.Output };
        var invoice = new SqlParameter("@InvoiceNo", SqlDbType.NVarChar, 30) { Direction = ParameterDirection.Output };

        Db.Query("dbo.spSaleComplete",
            Db.P("@CashierId", cashierId), Db.P("@CustomerType", customerType), Db.P("@CustomerRef", customerRef),
            Db.P("@DiscountPercent", discountPercent), Db.P("@PaymentMode", paymentMode), Db.P("@PaymentRef", paymentRef),
            Db.P("@CashTendered", cashTendered), Db.P("@OverrideApprovedBy", overrideApprovedBy),
            items, saleId, invoice);
        return ((int)saleId.Value, (string)invoice.Value);
    }

    public static void Void(int saleId, int approvedBy, string reason) =>
        Db.Query("dbo.spSaleVoid", Db.P("@SaleId", saleId), Db.P("@ApprovedBy", approvedBy), Db.P("@Reason", reason));

    public static Sale GetSale(int saleId)
    {
        var h = Db.Query("dbo.spSaleGet", Db.P("@SaleId", saleId));
        if (h.Rows.Count == 0) return null;
        var r = h.Rows[0];
        var sale = new Sale
        {
            SaleId = Db.Val<int>(r, "SaleId"),
            InvoiceNo = Db.Val<string>(r, "InvoiceNo"),
            SaleDate = Db.Val<DateTime>(r, "SaleDate"),
            CashierId = Db.Val<int>(r, "CashierId"),
            CashierName = Db.Val<string>(r, "CashierName"),
            CustomerType = Db.Val<string>(r, "CustomerType"),
            CustomerRef = Db.Val<string>(r, "CustomerRef"),
            Subtotal = Db.Val<decimal>(r, "Subtotal"),
            DiscountPercent = Db.Val<decimal>(r, "DiscountPercent"),
            DiscountAmount = Db.Val<decimal>(r, "DiscountAmount"),
            VatAmount = Db.Val<decimal>(r, "VatAmount"),
            TotalAmount = Db.Val<decimal>(r, "TotalAmount"),
            PaymentMode = Db.Val<string>(r, "PaymentMode"),
            PaymentRef = Db.Val<string>(r, "PaymentRef"),
            CashTendered = Db.Val<decimal?>(r, "CashTendered"),
            ChangeDue = Db.Val<decimal?>(r, "ChangeDue"),
            Status = Db.Val<string>(r, "Status"),
            VoidReason = Db.Val<string>(r, "VoidReason")
        };
        sale.Items = Db.Query("dbo.spSaleGetItems", Db.P("@SaleId", saleId)).Rows.Cast<DataRow>().Select(i => new SaleItem
        {
            ProductId = Db.Val<int>(i, "ProductId"),
            SKU = Db.Val<string>(i, "SKU"),
            ProductName = Db.Val<string>(i, "ProductName"),
            Quantity = Db.Val<int>(i, "Quantity"),
            UnitPrice = Db.Val<decimal>(i, "UnitPrice"),
            DiscountAmount = Db.Val<decimal>(i, "DiscountAmount"),
            LineTotal = Db.Val<decimal>(i, "LineTotal"),
            VatAmount = Db.Val<decimal>(i, "VatAmount")
        }).ToList();
        return sale;
    }

    public static DataTable Search(string search, DateTime? from, DateTime? to, string status, int? cashierId) =>
        Db.Query("dbo.spSaleSearch",
            Db.P("@Search", string.IsNullOrWhiteSpace(search) ? null : search.Trim()),
            Db.P("@From", from?.Date), Db.P("@To", to?.Date),
            Db.P("@Status", string.IsNullOrWhiteSpace(status) ? null : status), Db.P("@CashierId", cashierId));

    // ----- suspended (held) transactions -----
    public static int Suspend(int cashierId, string customerType, string customerRef, string json) =>
        Db.Val<int>(Db.Query("dbo.spSuspendSave", Db.P("@CashierId", cashierId), Db.P("@CustomerType", customerType),
            Db.P("@CustomerRef", customerRef), Db.P("@CartJson", json)).Rows[0], "SuspendedId");

    public static DataTable Suspended(int cashierId) => Db.Query("dbo.spSuspendList", Db.P("@CashierId", cashierId));

    public static void DeleteSuspended(int id) => Db.Query("dbo.spSuspendDelete", Db.P("@SuspendedId", id));
}
