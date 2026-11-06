using System.ComponentModel;

namespace EMS;

public partial class MainForm : Form
{
    public int LoggedOut;
    Button active;

    public MainForm()
    {
        InitializeComponent();
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

        lblUserName.Text = Session.Username + " (" + Session.Role + ")";
        lblAvatar.Text = Session.Username.Substring(0, Math.Min(2, Session.Username.Length)).ToUpper();

        Button[] all = { btnNavDashboard, btnNavEmployees, btnNavAttendance, btnNavReports, btnNavUsers };
        Button[] allowed = Session.Role == "admin"
            ? all
            : new[] { btnNavAttendance, btnNavReports };
        int ny = 90;
        foreach (var b in all)
        {
            if (Array.IndexOf(allowed, b) < 0) { b.Visible = false; continue; }
            b.Top = ny;
            ny += 46;
        }

        if (Session.Role == "admin") ShowView("Dashboard", btnNavDashboard);
        else ShowView("Attendance", btnNavAttendance);
    }

    void ShowView(string name, Button src)
    {
        UserControl v;
        switch (name)
        {
            case "Employees": v = new EmployeesView(); lblTitle.Text = "Employee Records"; break;
            case "Attendance": v = new AttendanceView(); lblTitle.Text = "Attendance"; break;
            case "Reports": v = new ReportsView(); lblTitle.Text = "Reports"; break;
            case "Users": v = new UsersView(); lblTitle.Text = "User Management"; break;
            default: v = new DashboardView(); lblTitle.Text = "Dashboard"; break;
        }
        while (pnlContent.Controls.Count > 0) pnlContent.Controls[0].Dispose();
        v.Dock = DockStyle.Fill;
        pnlContent.Controls.Add(v);
        if (active != null) active.BackColor = Theme.Side;
        active = src;
        active.BackColor = Theme.Primary;
    }

    private void Nav_Click(object sender, EventArgs e)
    {
        var b = (Button)sender;
        ShowView((string)b.Tag, b);
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        LoggedOut = 1;
        Close();
    }
}
