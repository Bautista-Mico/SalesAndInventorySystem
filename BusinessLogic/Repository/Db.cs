using Microsoft.Data.SqlClient;
using SalesInventory.Model;
using System.Data;
using System.Text.Json;

namespace SalesInventory.BusinessLogic.Repository;

/// <summary>Thin ADO.NET helper. All data access goes through stored procedures in the DB project.</summary>
public static class Db
{
    private const string DefaultConnectionString =
        @"Server=(localdb)\MSSQLLocalDB;Database=SalesInventoryDB;Trusted_Connection=True;TrustServerCertificate=True;";

    private static string _cs;

    /// <summary>Order: SALESINV_CONNSTR environment variable, dbconfig.json next to the .exe, then LocalDB default.</summary>
    public static string ConnectionString
    {
        get
        {
            if (_cs != null) return _cs;
            var env = Environment.GetEnvironmentVariable("SALESINV_CONNSTR");
            if (!string.IsNullOrWhiteSpace(env)) return _cs = env;

            var file = Path.Combine(AppContext.BaseDirectory, "dbconfig.json");
            if (File.Exists(file))
            {
                using var doc = JsonDocument.Parse(File.ReadAllText(file));
                if (doc.RootElement.TryGetProperty("ConnectionString", out var v) && !string.IsNullOrWhiteSpace(v.GetString()))
                    return _cs = v.GetString();
            }
            return _cs = DefaultConnectionString;
        }
        set => _cs = value;
    }

    public static SqlConnection Open()
    {
        var c = new SqlConnection(ConnectionString);
        c.Open();
        return c;
    }

    public static SqlParameter P(string name, object value) => new SqlParameter(name, value ?? DBNull.Value);

    public static DataTable Query(string proc, params SqlParameter[] ps) => Query(null, null, proc, ps);

    /// <summary>Runs a stored procedure and returns its first result set. THROW errors (50000+) become BusinessRuleException.</summary>
    public static DataTable Query(SqlConnection con, SqlTransaction tx, string proc, params SqlParameter[] ps)
    {
        var own = con == null;
        try
        {
            if (own) con = Open();
            using var cmd = new SqlCommand(proc, con, tx) { CommandType = CommandType.StoredProcedure, CommandTimeout = 60 };
            if (ps != null && ps.Length > 0) cmd.Parameters.AddRange(ps);
            var dt = new DataTable();
            using var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        catch (SqlException ex) when (ex.Number >= 50000)
        {
            throw new BusinessRuleException(ex.Message, ex);
        }
        finally
        {
            if (own) con?.Dispose();
        }
    }

    public static T Val<T>(DataRow r, string col)
    {
        if (!r.Table.Columns.Contains(col)) return default;
        var v = r[col];
        if (v == DBNull.Value) return default;
        var t = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);
        return (T)Convert.ChangeType(v, t);
    }
}
