using Microsoft.Data.SqlClient;
using SalesInventory.Model;
using System.Data;

namespace SalesInventory.BusinessLogic.Repository;

public static class UserRepository
{
    public static User GetByLogin(string login)
    {
        var dt = Db.Query("dbo.spUserLogin", Db.P("@Login", login));
        return dt.Rows.Count == 0 ? null : Map(dt.Rows[0]);
    }

    public static List<User> GetAll(string search) =>
        Db.Query("dbo.spUserGetAll", Db.P("@Search", string.IsNullOrWhiteSpace(search) ? null : search.Trim()))
          .Rows.Cast<DataRow>().Select(Map).ToList();

    public static (int Attempts, bool Locked) RecordFailed(int userId, int max, int minutes)
    {
        var dt = Db.Query("dbo.spUserRecordFailedLogin", Db.P("@UserId", userId), Db.P("@MaxAttempts", max), Db.P("@LockMinutes", minutes));
        var r = dt.Rows[0];
        return (Db.Val<int>(r, "FailedAttempts"), Db.Val<bool>(r, "IsLocked"));
    }

    public static void RecordSuccess(int userId) => Db.Query("dbo.spUserRecordSuccess", Db.P("@UserId", userId));

    public static int Count() => Db.Val<int>(Db.Query("dbo.spUserCount").Rows[0], "Total");

    public static int Save(User u, string passwordHash)
    {
        var dt = Db.Query("dbo.spUserSave",
            Db.P("@UserId", u.UserId == 0 ? (object)null : u.UserId),
            Db.P("@Username", u.Username), Db.P("@Email", u.Email), Db.P("@FullName", u.FullName),
            Db.P("@Role", u.Role), Db.P("@IsActive", u.IsActive), Db.P("@PasswordHash", passwordHash));
        return Db.Val<int>(dt.Rows[0], "UserId");
    }

    public static void SetPassword(int userId, string hash) =>
        Db.Query("dbo.spUserSetPassword", Db.P("@UserId", userId), Db.P("@PasswordHash", hash));

    public static void Audit(int? userId, string action, string details) =>
        Db.Query("dbo.spAuditLogAdd", Db.P("@UserId", userId), Db.P("@Action", action), Db.P("@Details", details));

    private static User Map(DataRow r) => new()
    {
        UserId = Db.Val<int>(r, "UserId"),
        Username = Db.Val<string>(r, "Username"),
        Email = Db.Val<string>(r, "Email"),
        FullName = Db.Val<string>(r, "FullName"),
        PasswordHash = Db.Val<string>(r, "PasswordHash"),
        Role = Db.Val<string>(r, "Role"),
        IsActive = Db.Val<bool>(r, "IsActive"),
        FailedAttempts = Db.Val<int>(r, "FailedAttempts"),
        IsLocked = Db.Val<bool>(r, "IsLocked"),
        LockoutEnd = Db.Val<DateTime?>(r, "LockoutEnd"),
        LastLoginAt = Db.Val<DateTime?>(r, "LastLoginAt")
    };
}
