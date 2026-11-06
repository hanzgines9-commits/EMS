namespace EMS;

// Simple bar chart control (0-100 scale). Appears in the Visual Studio Toolbox after a build.
public class BarChart : Control
{
    string[] labels = new string[0];
    double[] values = new double[0];

    public BarChart()
    {
        DoubleBuffered = true;
        ResizeRedraw = true;
        BackColor = Color.White;
    }

    public void SetData(string[] l, double[] v)
    {
        labels = l;
        values = v;
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        var plot = new Rectangle(36, 14, Math.Max(10, Width - 46), Math.Max(10, Height - 46));
        using var grid = new Pen(Theme.Border);
        using var txt = new SolidBrush(Theme.Caption);
        using var bar = new SolidBrush(Theme.Primary);
        using var val = new SolidBrush(Theme.Body);

        for (int i = 0; i <= 4; i++)
        {
            int y = plot.Bottom - plot.Height * i / 4;
            g.DrawLine(grid, plot.Left, y, plot.Right, y);
            g.DrawString((25 * i).ToString(), Font, txt, 4, y - 8);
        }

        int n = Math.Min(labels.Length, values.Length);
        if (n == 0) return;
        float slot = (float)plot.Width / n;
        float bw = slot * 0.55f;
        for (int i = 0; i < n; i++)
        {
            float h = (float)(plot.Height * Math.Min(Math.Max(values[i], 0), 100) / 100);
            float x = plot.Left + slot * i + (slot - bw) / 2;
            g.FillRectangle(bar, x, plot.Bottom - h, bw, h);
            SizeF ls = g.MeasureString(labels[i], Font);
            g.DrawString(labels[i], Font, txt, x + bw / 2 - ls.Width / 2, plot.Bottom + 4);
            string v = values[i].ToString("0.#");
            SizeF vs = g.MeasureString(v, Font);
            g.DrawString(v, Font, val, x + bw / 2 - vs.Width / 2, plot.Bottom - h - vs.Height);
        }
    }
}
