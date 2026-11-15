using System.Data;
using System.Globalization;

namespace SalesInventory.UI;

/// <summary>Slate palette taken from the wireframes in the design PDF.</summary>
public static class Theme
{
    public static readonly Color Bg = Color.FromArgb(248, 250, 252);
    public static readonly Color Border = Color.FromArgb(203, 213, 225);
    public static readonly Color Muted = Color.FromArgb(148, 163, 184);
    public static readonly Color Slate = Color.FromArgb(100, 116, 139);
    public static readonly Color SlateDark = Color.FromArgb(71, 85, 105);
    public static readonly Color Navy = Color.FromArgb(30, 41, 59);
    public static readonly Color Ink = Color.FromArgb(17, 24, 39);
    public static readonly Color Light = Color.FromArgb(226, 232, 240);
    public static readonly Color Accent = Color.FromArgb(37, 99, 235);
    public static readonly Color Danger = Color.FromArgb(220, 38, 38);
    public static readonly Color Success = Color.FromArgb(22, 163, 74);
    public static readonly Color Warn = Color.FromArgb(254, 243, 199);

    public static readonly Font Base = new("Segoe UI", 10f);
    public static readonly Font Bold = new("Segoe UI", 10f, FontStyle.Bold);
    public static readonly Font H1 = new("Segoe UI", 20f, FontStyle.Bold);
    public static readonly Font H2 = new("Segoe UI", 13f, FontStyle.Bold);
    public static readonly Font Big = new("Segoe UI", 22f, FontStyle.Bold);
}

public static class Ui
{
    public static bool InDesigner => System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;

    public static Button Btn(string text, Color back, Color fore, EventHandler click, int w = 140, int h = 40)
    {
        var b = new Button
        {
            Text = text,
            BackColor = back,
            ForeColor = fore,
            FlatStyle = FlatStyle.Flat,
            Width = w,
            Height = h,
            Font = Theme.Bold,
            Cursor = Cursors.Hand,
            UseVisualStyleBackColor = false,
            Margin = new Padding(0, 4, 10, 4)
        };
        b.FlatAppearance.BorderSize = 0;
        if (click != null) b.Click += click;
        return b;
    }

    public static Button Primary(string t, EventHandler c, int w = 140) => Btn(t, Theme.SlateDark, Color.White, c, w);
    public static Button Dark(string t, EventHandler c, int w = 140) => Btn(t, Theme.Ink, Color.White, c, w);
    public static Button Ghost(string t, EventHandler c, int w = 140) => Btn(t, Theme.Light, Theme.Navy, c, w);
    public static Button Danger(string t, EventHandler c, int w = 140) => Btn(t, Theme.Danger, Color.White, c, w);

    public static TextBox Input(string placeholder = "", int w = 220) =>
        new() { PlaceholderText = placeholder, Width = w, Font = Theme.Base, BorderStyle = BorderStyle.FixedSingle, Margin = new Padding(0, 6, 10, 6) };

    public static Label Lbl(string text, Font font = null, Color? color = null) =>
        new() { Text = text, AutoSize = true, Font = font ?? Theme.Base, ForeColor = color ?? Theme.Navy, Margin = new Padding(0, 8, 8, 0), BackColor = Color.Transparent };

    public static ComboBox Combo(int w = 200, params object[] items)
    {
        var c = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = w, Font = Theme.Base, Margin = new Padding(0, 6, 10, 6) };
        if (items.Length > 0) { c.Items.AddRange(items); c.SelectedIndex = 0; }
        return c;
    }

    public static Panel Card() => new() { BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle, Padding = new Padding(12), Dock = DockStyle.Fill };

    public static FlowLayoutPanel Bar(params Control[] controls)
    {
        var f = new FlowLayoutPanel { Dock = DockStyle.Fill, WrapContents = false, BackColor = Color.Transparent, Padding = new Padding(0, 2, 0, 2) };
        f.Controls.AddRange(controls);
        return f;
    }

    /// <summary>Stacks controls vertically: height > 0 = fixed px, 0 = fill remaining space.</summary>
    public static TableLayoutPanel Rows(params (Control Ctl, float Height)[] rows)
    {
        var t = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = rows.Length, BackColor = Color.Transparent };
        t.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        foreach (var (c, h) in rows)
        {
            t.RowStyles.Add(h == 0 ? new RowStyle(SizeType.Percent, 100) : new RowStyle(SizeType.Absolute, h));
            c.Dock = DockStyle.Fill;
            t.Controls.Add(c);
        }
        return t;
    }

    public static DataGridView Grid()
    {
        var g = new DataGridView
        {
            Dock = DockStyle.Fill,
            ReadOnly = true,
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,
            AllowUserToResizeRows = false,
            RowHeadersVisible = false,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            MultiSelect = false,
            BorderStyle = BorderStyle.FixedSingle,
            BackgroundColor = Color.White,
            GridColor = Theme.Light,
            Font = Theme.Base,
            EnableHeadersVisualStyles = false,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        };
        g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        g.ColumnHeadersHeight = 38;
        g.RowTemplate.Height = 32;
        g.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(203, 213, 225);
        g.ColumnHeadersDefaultCellStyle.ForeColor = Theme.Navy;
        g.ColumnHeadersDefaultCellStyle.Font = Theme.Bold;
        g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(203, 213, 225);
        g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 219, 254);
        g.DefaultCellStyle.SelectionForeColor = Theme.Navy;
        g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
        return g;
    }

    public static void Col(DataGridView g, string header, string prop, string fmt = null, float weight = 1f, bool right = false)
    {
        var c = new DataGridViewTextBoxColumn { HeaderText = header, DataPropertyName = prop, FillWeight = weight * 100, SortMode = DataGridViewColumnSortMode.NotSortable };
        if (fmt != null) c.DefaultCellStyle.Format = fmt;
        if (right) c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        g.Columns.Add(c);
    }

    public static string Money(decimal d) => "₱" + d.ToString("N2", CultureInfo.CurrentCulture);

    public static void Info(string m) => MessageBox.Show(m, "Sales & Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
    public static void Warn(string m) => MessageBox.Show(m, "Sales & Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    public static void Error(string m) => MessageBox.Show(m, "Sales & Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
    public static bool Confirm(string m) => MessageBox.Show(m, "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

    /// <summary>Runs a UI action; business-rule messages are shown as warnings, anything else as an error.</summary>
    public static void Guard(Action a)
    {
        try { a(); }
        catch (BusinessRuleException ex) { Warn(ex.Message); }
        catch (Exception ex) { Error("Something went wrong: " + ex.Message); }
    }

    public static bool TryMoney(string text, out decimal value) =>
        decimal.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, out value);

    public static DataTable ProductTable(IEnumerable<Product> list)
    {
        var t = new DataTable();
        t.Columns.Add("Id", typeof(int)); t.Columns.Add("SKU"); t.Columns.Add("Product"); t.Columns.Add("Category");
        t.Columns.Add("Price", typeof(string)); t.Columns.Add("In stock", typeof(int));
        foreach (var p in list) t.Rows.Add(p.ProductId, p.SKU, p.Name, p.CategoryName, Money(p.SellingPrice), p.QtyOnHand);
        return t;
    }
}

public class BasePage : UserControl
{
    protected BasePage()
    {
        Dock = DockStyle.Fill; BackColor = Theme.Bg; Font = Theme.Base; Padding = new Padding(20);
    }
    public virtual string PageTitle => "";
    public virtual void OnActivated() { }
}