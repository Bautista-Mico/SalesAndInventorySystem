namespace SalesInventory.UI;

/// <summary>Round "LOGO" placeholder shown on the login screen (own file so the designer can host it).</summary>
public class LogoBadge : Control
{
    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        using var b = new SolidBrush(Color.FromArgb(226, 232, 240));
        e.Graphics.FillEllipse(b, 0, 0, Width - 1, Height - 1);
        TextRenderer.DrawText(e.Graphics, "LOGO", new Font("Segoe UI", 10f, FontStyle.Bold), ClientRectangle, Theme.Slate,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}
