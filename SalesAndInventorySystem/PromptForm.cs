namespace SalesInventory.UI;

/// <summary>Small modal prompt for one value (text, money or password).</summary>
public partial class PromptForm : Form
{
    public string Value => txtValue.Text;

    public PromptForm() : this("", "", null, false) { }

    private PromptForm(string title, string label, string initial, bool password)
    {
        InitializeComponent();
        Text = title;
        lblPrompt.Text = label;
        txtValue.Text = initial ?? "";
        txtValue.UseSystemPasswordChar = password;
    }

    public static string Ask(IWin32Window owner, string title, string label, string initial = "", bool password = false)
    {
        using var f = new PromptForm(title, label, initial, password);
        return f.ShowDialog(owner) == DialogResult.OK ? f.Value : null;
    }
}
