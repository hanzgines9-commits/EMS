using System.ComponentModel;

namespace EMS;

public partial class DashboardView : UserControl
{
    public DashboardView()
    {
        InitializeComponent();
    }

    private void DashboardView_Load(object sender, EventArgs e)
    {
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
        Theme.StyleGrid(dgvRank);
        dgvRank.CellFormatting += (s, ev) =>
        {
            if (ev.RowIndex < 0 || ev.Value == null) return;
            string h = dgvRank.Columns[ev.ColumnIndex].HeaderText;
            if (h == "ON TIME") ev.CellStyle.ForeColor = Theme.Success;
            else if (h == "LATE") ev.CellStyle.ForeColor = Theme.Warning;
            else if (h == "ABSENT") ev.CellStyle.ForeColor = Theme.Danger;
        };
        Theme.Run(() =>
        {
            lblTotalValue.Text = Db.Scalar("SELECT COUNT(*) FROM employees").ToString();
            lblPresentValue.Text = Db.Scalar("SELECT COUNT(*) FROM attendance WHERE log_date=CURDATE() AND status IN ('Present','Late')").ToString();
            lblLeaveValue.Text = Db.Scalar("SELECT COUNT(*) FROM attendance WHERE log_date=CURDATE() AND status='On Leave'").ToString();
            lblLateValue.Text = Db.Scalar("SELECT COUNT(*) FROM attendance WHERE log_date=CURDATE() AND status='Late'").ToString();
            cboPeriod.SelectedIndex = 1;
        });
    }

    private void cboPeriod_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
        Theme.Run(LoadRank);
    }

    void LoadRank()
    {
        DateTime d2 = DateTime.Today, d1;
        switch (cboPeriod.SelectedIndex)
        {
            case 0: d1 = new DateTime(d2.Year, d2.Month, 1); break;
            case 2: d1 = new DateTime(2000, 1, 1); break;
            default: d1 = new DateTime(d2.Year, 1, 1); break;
        }
        var t = Db.Query(
            "SELECT CONCAT(e.first_name,' ',e.last_name) AS `EMPLOYEE`, " +
            "IFNULL(SUM(a.status='Present'),0) AS `ON TIME`, IFNULL(SUM(a.status='Late'),0) AS `LATE`, " +
            "IFNULL(SUM(a.status='On Leave'),0) AS `ON LEAVE`, IFNULL(SUM(a.status='Absent'),0) AS `ABSENT` " +
            "FROM employees e LEFT JOIN attendance a ON a.emp_id=e.emp_id AND a.log_date BETWEEN @f AND @t " +
            "WHERE e.status='Active' GROUP BY e.emp_id, e.first_name, e.last_name " +
            "ORDER BY `ON TIME` DESC, `LATE` ASC, e.first_name", ("@f", d1), ("@t", d2));
        var rk = t.Columns.Add("RANK", typeof(int));
        rk.SetOrdinal(0);
        for (int i = 0; i < t.Rows.Count; i++) t.Rows[i]["RANK"] = i + 1;
        dgvRank.DataSource = t;
    }
}
