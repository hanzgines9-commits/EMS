using System.Data;
using System.Drawing.Printing;

namespace EMS;

public class ReportData
{
    public string Subject = "";
    public DateTime From, To;
    public string Avg = "", Late = "", Absent = "", Leave = "";
    public string[] Labels = new string[0];
    public double[] Values = new double[0];
    public DataTable List = new DataTable();
}

// Draws the attendance report on long bond paper (8.5 x 13 in), multi-page.
public class ReportPrinter
{
    readonly ReportData d;
    int row, pageNo;

    public ReportPrinter(ReportData data) { d = data; }

    public PrintDocument Build()
    {
        var doc = new PrintDocument();
        doc.DocumentName = "Attendance Report";
        doc.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
        doc.BeginPrint += (s, e) => { row = 0; pageNo = 0; };
        doc.PrintPage += OnPage;
        return doc;
    }

    // Call after the printer is chosen.
    public static void ApplyLongBond(PrintDocument doc)
    {
        PaperSize pick = null;
        foreach (PaperSize p in doc.PrinterSettings.PaperSizes)
        {
            if (p.Kind == PaperKind.Folio || (Math.Abs(p.Width - 850) < 5 && Math.Abs(p.Height - 1300) < 5))
            {
                pick = p;
                break;
            }
        }
        doc.DefaultPageSettings.PaperSize = pick ?? new PaperSize("Long Bond", 850, 1300);
        doc.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
    }

    void OnPage(object sender, PrintPageEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
        pageNo++;

        int L = 50, W = e.PageBounds.Width - 100, bottom = e.PageBounds.Height - 170, y = 50;
        using var fTitle = new Font("Segoe UI", 18F, FontStyle.Bold);
        using var fH = new Font("Segoe UI", 11F, FontStyle.Bold);
        using var fB = new Font("Segoe UI", 9.5F);
        using var fBold = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        using var fBig = new Font("Segoe UI", 20F, FontStyle.Bold);
        using var fSmall = new Font("Segoe UI", 8F);
        using var bPrimary = new SolidBrush(Theme.Primary);
        using var bBody = new SolidBrush(Theme.Body);
        using var bCap = new SolidBrush(Theme.Caption);
        using var bWhite = new SolidBrush(Color.White);
        using var bShade = new SolidBrush(Theme.Page);
        using var pLine = new Pen(Theme.Border);
        using var pPrimary = new Pen(Theme.Primary, 2F);
        using var center = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
        using var left = new StringFormat { LineAlignment = StringAlignment.Center };

        if (pageNo == 1)
        {
            g.DrawString("EMPLOYEE ATTENDANCE REPORT", fTitle, bPrimary, L, y); y += 34;
            g.DrawString("Employee Monitoring System", fB, bCap, L, y); y += 22;
            g.DrawLine(pPrimary, L, y, L + W, y); y += 12;
            g.DrawString("Period: " + d.From.ToString("MMMM d, yyyy") + " to " + d.To.ToString("MMMM d, yyyy"), fB, bBody, L, y); y += 20;
            g.DrawString("Subject: " + d.Subject, fB, bBody, L, y); y += 20;
            g.DrawString("Generated: " + DateTime.Now.ToString("MMMM d, yyyy h:mm tt") + " by " + Session.Username, fB, bBody, L, y); y += 34;

            string[] vals = { d.Avg, d.Late, d.Absent, d.Leave };
            string[] caps = { "Avg. Attendance", "Total Late", "Total Absences", "Leave Days" };
            int bw = (W - 30) / 4;
            for (int i = 0; i < 4; i++)
            {
                var r = new Rectangle(L + i * (bw + 10), y, bw, 70);
                g.FillRectangle(bShade, r);
                g.DrawRectangle(pLine, r);
                g.DrawString(vals[i], fBig, bPrimary, new RectangleF(r.X, r.Y + 6, r.Width, 36), center);
                g.DrawString(caps[i], fSmall, bCap, new RectangleF(r.X, r.Y + 44, r.Width, 20), center);
            }
            y += 100;

            g.DrawString("Monthly Attendance Rate", fH, bPrimary, L, y); y += 28;
            int n = Math.Min(d.Labels.Length, d.Values.Length);
            if (n == 0) { g.DrawString("No attendance records in this period.", fB, bCap, L, y); y += 24; }
            for (int i = 0; i < n; i++)
            {
                g.DrawString(d.Labels[i], fB, bBody, new RectangleF(L, y, 70, 20), left);
                float bwid = (float)((W - 160) * Math.Min(Math.Max(d.Values[i], 0), 100) / 100);
                g.FillRectangle(bPrimary, L + 70, y + 3, bwid, 14);
                g.DrawString(d.Values[i].ToString("0.#") + "%", fBold, bBody, L + 76 + bwid, y + 2);
                y += 24;
            }
            y += 20;
        }
        else
        {
            g.DrawString("Employee Attendance Report (continued)", fH, bPrimary, L, y); y += 36;
        }

        g.DrawString("Per-Employee Attendance", fH, bPrimary, L, y); y += 28;
        double[] cw = { 0.07, 0.33, 0.12, 0.12, 0.12, 0.12, 0.12 };
        string[] hd = { "ID", "EMPLOYEE", "PRESENT", "LATE", "ABSENT", "ON LEAVE", "AVG %" };
        int[] cx = new int[8];
        cx[0] = L;
        for (int i = 0; i < 7; i++) cx[i + 1] = cx[i] + (int)(W * cw[i]);

        g.FillRectangle(bPrimary, L, y, W, 26);
        for (int i = 0; i < 7; i++)
            g.DrawString(hd[i], fBold, bWhite, new RectangleF(cx[i] + (i == 1 ? 6 : 0), y, cx[i + 1] - cx[i], 26), i == 1 ? left : center);
        y += 26;

        int cols = Math.Min(7, d.List.Columns.Count);
        while (row < d.List.Rows.Count)
        {
            if (y + 24 > bottom) { e.HasMorePages = true; break; }
            if (row % 2 == 1) g.FillRectangle(bShade, L, y, W, 24);
            for (int i = 0; i < cols; i++)
                g.DrawString(Convert.ToString(d.List.Rows[row][i]), fB, bBody,
                    new RectangleF(cx[i] + (i == 1 ? 6 : 0), y, cx[i + 1] - cx[i], 24), i == 1 ? left : center);
            g.DrawLine(pLine, L, y + 24, L + W, y + 24);
            row++;
            y += 24;
        }

        if (row >= d.List.Rows.Count)
        {
            int sy = e.PageBounds.Height - 130;
            g.DrawLine(Pens.Black, L, sy, L + 220, sy);
            g.DrawString("Prepared by: " + Session.Username, fB, bBody, L, sy + 4);
            g.DrawLine(Pens.Black, L + W - 220, sy, L + W, sy);
            g.DrawString("Noted by", fB, bBody, L + W - 220, sy + 4);
        }
        g.DrawString("Page " + pageNo, fSmall, bCap, L, e.PageBounds.Height - 60);
    }
}
