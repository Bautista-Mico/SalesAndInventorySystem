namespace SalesInventory.UI;

/// <summary>Minimal GDI+ bar chart (no extra packages needed).</summary>
public class BarChartPanel : Panel
{
    private readonly List<(string Label, decimal Value)> _data = new();
    private string _caption = "";

    public BarChartPanel() { DoubleBuffered = true; BackColor = Color.White; }

    public void SetData(DataTable table, string labelCol, string valueCol, string caption)
    {
        _data.Clear(); _caption = caption;
        if (table != null && table.Columns.Contains(labelCol) && table.Columns.Contains(valueCol))
            foreach (var r in table.Rows.Cast<DataRow>().Take(15))
            {
                var label = r[labelCol] is DateTime d ? d.ToString("MM/dd") : Convert.ToString(r[labelCol]);
                _data.Add((label, r[valueCol] == DBNull.Value ? 0 : Convert.ToDecimal(r[valueCol])));
            }
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics; g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        using var small = new Font("Segoe UI", 8f);
        g.DrawString(_caption, Theme.Bold, new SolidBrush(Theme.Navy), 12, 8);
        if (_data.Count == 0) { g.DrawString("Generate a report to see the chart.", Theme.Base, new SolidBrush(Theme.Slate), 12, 40); return; }

        var area = new Rectangle(16, 40, Width - 32, Height - 90);
        var max = Math.Max(_data.Max(d => Math.Abs(d.Value)), 1m);
        var slot = (float)area.Width / _data.Count;
        var barW = Math.Max(6f, slot * 0.6f);
        using var axis = new Pen(Theme.Border);
        g.DrawLine(axis, area.Left, area.Bottom, area.Right, area.Bottom);
        for (int i = 0; i < _data.Count; i++)
        {
            var h = (float)(Math.Abs(_data[i].Value) / max) * (area.Height - 18);
            var x = area.Left + i * slot + (slot - barW) / 2;
            using (var b = new SolidBrush(i % 2 == 0 ? Theme.Slate : Theme.SlateDark)) g.FillRectangle(b, x, area.Bottom - h, barW, h);
            var val = _data[i].Value.ToString("N0");
            var vs = g.MeasureString(val, small);
            g.DrawString(val, small, Brushes.Black, x + barW / 2 - vs.Width / 2, area.Bottom - h - 14);
            var lab = _data[i].Label.Length > 9 ? _data[i].Label.Substring(0, 9) + "." : _data[i].Label;
            var ls = g.MeasureString(lab, small);
            g.DrawString(lab, small, new SolidBrush(Theme.SlateDark), x + barW / 2 - ls.Width / 2, area.Bottom + 4);
        }
    }
}
