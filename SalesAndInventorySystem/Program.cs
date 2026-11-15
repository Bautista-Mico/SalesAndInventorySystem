using UI;

namespace SalesInventory.UI;

internal static class Program
{
    public static string LoginNotice;

    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        try
        {
            Cursor.Current = Cursors.WaitCursor;
            DbSetup.EnsureDatabase(Path.Combine(AppContext.BaseDirectory, "DB"));
        }
        catch (Exception ex)
        {
            MessageBox.Show("The database could not be prepared.\n\n" + ex.Message +
                "\n\nCheck dbconfig.json (next to the .exe) or the SALESINV_CONNSTR environment variable.",
                "Database setup failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        finally { Cursor.Current = Cursors.Default; }

        while (true)
        {
            using var login = new LoginForm();
            if (login.ShowDialog() != DialogResult.OK) break;
            using var main = new MainForm();
            main.ShowDialog();
            if (!main.LogoutRequested) break;
        }
    }
}

/// <summary>Remembers only the username (never the password) for the "Remember me" box.</summary>
public static class Prefs
{
    private static string FilePath
    {
        get
        {
            var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SalesInventory");
            Directory.CreateDirectory(dir);
            return Path.Combine(dir, "remember.txt");
        }
    }
    public static string Remembered() { try { return File.Exists(FilePath) ? File.ReadAllText(FilePath).Trim() : ""; } catch { return ""; } }
    public static void Remember(string username) { try { File.WriteAllText(FilePath, username ?? ""); } catch { } }
    public static void Forget() { try { if (File.Exists(FilePath)) File.Delete(FilePath); } catch { } }
}