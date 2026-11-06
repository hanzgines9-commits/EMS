namespace EMS;

public static class Theme
{
    public static readonly Color Primary = Color.FromArgb(0, 48, 135);
    public static readonly Color Secondary = Color.FromArgb(0, 112, 186);
    public static readonly Color Success = Color.FromArgb(16, 185, 129);
    public static readonly Color Warning = Color.FromArgb(245, 158, 11);
    public static readonly Color Danger = Color.FromArgb(239, 68, 68);
    public static readonly Color Body = Color.FromArgb(71, 85, 105);
    public static readonly Color Caption = Color.FromArgb(148, 163, 184);
    public static readonly Color Border = Color.FromArgb(203, 213, 225);
    public static readonly Color Page = Color.FromArgb(241, 245, 249);
    public static readonly Color Side = Color.FromArgb(11, 31, 75);

    static readonly Font BoldFont = new Font("Segoe UI", 9.5F, FontStyle.Bold);
    static readonly Font BodyFont = new Font("Segoe UI", 10F);

    public static void Run(Action a)
    {
        try { a(); }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    public static Color StatusColor(string s)
    {
        switch (s)
        {
            case "Present":
            case "Active": return Success;
            case "Late":
            case "On Leave": return Warning;
            case "Absent":
            case "Inactive": return Danger;
            default: return Body;
        }
    }

    public static void StyleGrid(DataGridView g)
    {
        g.EnableHeadersVisualStyles = false;
        g.BackgroundColor = Color.White;
        g.BorderStyle = BorderStyle.None;
        g.GridColor = Border;
        g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        g.ColumnHeadersHeight = 38;
        g.ColumnHeadersDefaultCellStyle.BackColor = Primary;
        g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Primary;
        g.ColumnHeadersDefaultCellStyle.Font = BoldFont;
        g.DefaultCellStyle.Font = BodyFont;
        g.DefaultCellStyle.ForeColor = Body;
        g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
        g.DefaultCellStyle.SelectionForeColor = Body;
        g.RowTemplate.Height = 34;
        g.RowHeadersVisible = false;
        g.AllowUserToAddRows = false;
        g.AllowUserToDeleteRows = false;
        g.ReadOnly = true;
        g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    // Colors any column whose header is "STATUS".
    public static void ColorStatus(DataGridView g)
    {
        g.CellFormatting += (s, e) =>
        {
            if (e.RowIndex < 0 || e.Value == null) return;
            if (g.Columns[e.ColumnIndex].HeaderText != "STATUS") return;
            e.CellStyle.ForeColor = StatusColor(Convert.ToString(e.Value));
            e.CellStyle.Font = BoldFont;
        };
    }
}
