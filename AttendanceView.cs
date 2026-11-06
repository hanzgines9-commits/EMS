using System.ComponentModel;

namespace EMS;

public partial class AttendanceView : UserControl
{
    public AttendanceView()
    {
        InitializeComponent();
    }

    private void AttendanceView_Load(object sender, EventArgs e)
    {
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
        Theme.StyleGrid(dgvAttendance);
        Theme.ColorStatus(dgvAttendance);
        if (Session.Role != "admin")
        {
            btnLeave.Visible = false;
            btnAbsent.Visible = false;
        }
        Theme.Run(() =>
        {
            cboEmployee.DisplayMember = "full_name";
            cboEmployee.ValueMember = "emp_id";
            cboEmployee.DataSource = Db.Query("SELECT emp_id, CONCAT(first_name,' ',last_name) AS full_name FROM employees WHERE status='Active' ORDER BY first_name");
            dtpDate.Value = DateTime.Today;
            LoadGrid();
        });
    }

    int Selected()
    {
        return cboEmployee.SelectedValue == null ? 0 : Convert.ToInt32(cboEmployee.SelectedValue);
    }

    void LoadGrid()
    {
        dgvAttendance.DataSource = Db.Query(
            "SELECT CONCAT(e.first_name,' ',e.last_name) AS `EMPLOYEE NAME`, " +
            "DATE_FORMAT(a.log_date,'%Y-%m-%d') AS `DATE`, " +
            "IFNULL(TIME_FORMAT(a.time_in,'%h:%i %p'),'\u2014') AS `TIME IN`, " +
            "IFNULL(TIME_FORMAT(a.time_out,'%h:%i %p'),'\u2014') AS `TIME OUT`, " +
            "a.status AS `STATUS` FROM attendance a JOIN employees e ON e.emp_id=a.emp_id " +
            "WHERE a.log_date=@d ORDER BY e.first_name", ("@d", dtpDate.Value.Date));
    }

    private void dtpDate_ValueChanged(object sender, EventArgs e)
    {
        if (cboEmployee.DataSource == null) return;
        Theme.Run(LoadGrid);
    }

    // On Time = "Present", Late = "Late". Time in is set to now.
    void TimeIn(string status)
    {
        Theme.Run(() =>
        {
            int id = Selected();
            if (id == 0) return;
            DateTime now = DateTime.Now;
            TimeSpan t = new TimeSpan(now.Hour, now.Minute, now.Second);
            Db.Exec("INSERT INTO attendance(emp_id,log_date,time_in,status) VALUES(@e,@d,@t,@s) " +
                    "ON DUPLICATE KEY UPDATE status=@s, time_in=IFNULL(time_in,@t)",
                ("@e", id), ("@d", now.Date), ("@t", t), ("@s", status));
            lblMsg.Text = "Saved: " + (status == "Present" ? "On Time" : "Late") + ".";
            dtpDate.Value = now.Date;
            LoadGrid();
        });
    }

    void Mark(string status)
    {
        Theme.Run(() =>
        {
            int id = Selected();
            if (id == 0) return;
            Db.Exec("INSERT INTO attendance(emp_id,log_date,status) VALUES(@e,@d,@s) ON DUPLICATE KEY UPDATE status=@s, time_in=NULL, time_out=NULL",
                ("@e", id), ("@d", DateTime.Today), ("@s", status));
            lblMsg.Text = "Saved: " + status + ".";
            dtpDate.Value = DateTime.Today;
            LoadGrid();
        });
    }

    private void btnOnTime_Click(object sender, EventArgs e) { TimeIn("Present"); }
    private void btnLate_Click(object sender, EventArgs e) { TimeIn("Late"); }
    private void btnLeave_Click(object sender, EventArgs e) { Mark("On Leave"); }
    private void btnAbsent_Click(object sender, EventArgs e) { Mark("Absent"); }

    private void btnCheckOut_Click(object sender, EventArgs e)
    {
        Theme.Run(() =>
        {
            int id = Selected();
            if (id == 0) return;
            DateTime now = DateTime.Now;
            TimeSpan t = new TimeSpan(now.Hour, now.Minute, now.Second);
            int n = Db.Exec("UPDATE attendance SET time_out=@t WHERE emp_id=@e AND log_date=@d AND time_in IS NOT NULL AND time_out IS NULL",
                ("@t", t), ("@e", id), ("@d", now.Date));
            if (n == 0) { lblMsg.Text = "No open time-in found for today."; return; }
            lblMsg.Text = "Checked out.";
            dtpDate.Value = now.Date;
            LoadGrid();
        });
    }
}
