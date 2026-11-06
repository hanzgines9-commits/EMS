using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;

namespace EMS;

public partial class ReportsView : UserControl
{
    int selEmp;
    string selName = "";
    ReportData snap;

    public ReportsView()
    {
        InitializeComponent();
    }

    private void ReportsView_Load(object sender, EventArgs e)
    {
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
        Theme.StyleGrid(dgvList);
        dtpFrom.Value = new DateTime(DateTime.Today.Year, 1, 1);
        dtpTo.Value = DateTime.Today;
        Theme.Run(LoadReport);
    }

    void LoadReport()
    {
        DateTime f = dtpFrom.Value.Date, t = dtpTo.Value.Date;
        var s = Db.Query(
            "SELECT COUNT(*) AS total, SUM(status IN ('Present','Late')) AS ok, SUM(status='Late') AS late, " +
            "SUM(status='Absent') AS absent, SUM(status='On Leave') AS leave_days " +
            "FROM attendance WHERE log_date BETWEEN @f AND @t AND (@e=0 OR emp_id=@e)", ("@f", f), ("@t", t), ("@e", selEmp)).Rows[0];
        double total = Db.Num(s["total"]), ok = Db.Num(s["ok"]);
        lblAvgValue.Text = (total > 0 ? Math.Round(100 * ok / total, 1) : 0) + "%";
        lblLateTotalValue.Text = Db.Num(s["late"]).ToString("0");
        lblAbsentValue.Text = Db.Num(s["absent"]).ToString("0");
        lblLeaveDaysValue.Text = Db.Num(s["leave_days"]).ToString("0");

        var m = Db.Query(
            "SELECT DATE_FORMAT(log_date,'%Y-%m') AS ym, 100*SUM(status IN ('Present','Late'))/COUNT(*) AS rate " +
            "FROM attendance WHERE log_date BETWEEN @f AND @t AND (@e=0 OR emp_id=@e) GROUP BY ym ORDER BY ym", ("@f", f), ("@t", t), ("@e", selEmp));
        lblChartTitle.Text = selEmp == 0 ? "Monthly Attendance Rate (%)" : "Monthly Attendance Rate (%) - " + selName;
        int n = m.Rows.Count;
        string fmt = (n == 0 || m.Rows[0]["ym"].ToString().Substring(0, 4) == m.Rows[n - 1]["ym"].ToString().Substring(0, 4)) ? "MMM" : "MMM yy";
        var labels = new string[n];
        var vals = new double[n];
        for (int i = 0; i < n; i++)
        {
            string ym = m.Rows[i]["ym"].ToString();
            labels[i] = new DateTime(int.Parse(ym.Substring(0, 4)), int.Parse(ym.Substring(5, 2)), 1).ToString(fmt);
            vals[i] = Math.Round(Db.Num(m.Rows[i]["rate"]), 1);
        }
        chart.SetData(labels, vals);

        dgvList.DataSource = Db.Query(
            "SELECT e.emp_id AS `ID`, CONCAT(e.first_name,' ',e.last_name) AS `EMPLOYEE`, " +
            "SUM(a.status='Present') AS `PRESENT`, SUM(a.status='Late') AS `LATE`, " +
            "SUM(a.status='Absent') AS `ABSENT`, SUM(a.status='On Leave') AS `ON LEAVE`, " +
            "CONCAT(ROUND(100*SUM(a.status IN ('Present','Late'))/COUNT(*),1),'%') AS `AVG ATTENDANCE` " +
            "FROM attendance a JOIN employees e ON e.emp_id=a.emp_id WHERE a.log_date BETWEEN @f AND @t " +
            "GROUP BY e.emp_id, e.first_name, e.last_name ORDER BY e.first_name", ("@f", f), ("@t", t));

        snap = new ReportData
        {
            Subject = selEmp == 0 ? "All Employees" : selName,
            From = f,
            To = t,
            Avg = lblAvgValue.Text,
            Late = lblLateTotalValue.Text,
            Absent = lblAbsentValue.Text,
            Leave = lblLeaveDaysValue.Text,
            Labels = labels,
            Values = vals,
            List = (DataTable)dgvList.DataSource
        };
    }

    private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        selEmp = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[0].Value);
        selName = Convert.ToString(dgvList.Rows[e.RowIndex].Cells[1].Value);
        Theme.Run(LoadReport);
    }

    private void btnGenerate_Click(object sender, EventArgs e)
    {
        selEmp = 0;
        selName = "";
        Theme.Run(LoadReport);
    }

    private void btnPdf_Click(object sender, EventArgs e)
    {
        if (snap == null) return;
        using var dlg = new SaveFileDialog
        {
            Filter = "PDF file (*.pdf)|*.pdf",
            FileName = "attendance_report_" + DateTime.Now.ToString("yyyyMMdd") + ".pdf"
        };
        if (dlg.ShowDialog() != DialogResult.OK) return;
        Theme.Run(() =>
        {
            PrintDocument doc = new ReportPrinter(snap).Build();
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            if (doc.PrinterSettings.IsValid == false)
            {
                MessageBox.Show("The 'Microsoft Print to PDF' printer was not found. Enable it in Windows Optional Features, or use the Print button.");
                return;
            }
            doc.PrinterSettings.PrintToFile = true;
            doc.PrinterSettings.PrintFileName = dlg.FileName;
            ReportPrinter.ApplyLongBond(doc);
            doc.Print();
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(dlg.FileName) { UseShellExecute = true });
        });
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
        if (snap == null) return;
        Theme.Run(() =>
        {
            PrintDocument doc = new ReportPrinter(snap).Build();
            using var dlg = new PrintDialog { Document = doc, UseEXDialog = true };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            ReportPrinter.ApplyLongBond(doc);
            doc.Print();
        });
    }
}
