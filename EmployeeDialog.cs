using System.ComponentModel;

namespace EMS;

public partial class EmployeeDialog : Form
{
    readonly int empId;

    public EmployeeDialog() : this(0) { }

    public EmployeeDialog(int id)
    {
        InitializeComponent();
        empId = id;
        Text = id == 0 ? "Add Employee" : "Edit Employee";
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

        Theme.Run(() =>
        {
            cboDept.DisplayMember = "dept_name";
            cboDept.ValueMember = "dept_id";
            cboDept.DataSource = Db.Query("SELECT dept_id, dept_name FROM departments ORDER BY dept_name");
            if (empId == 0) return;
            var t = Db.Query("SELECT * FROM employees WHERE emp_id=@id", ("@id", empId));
            if (t.Rows.Count == 0) return;
            var r = t.Rows[0];
            txtFirst.Text = r["first_name"].ToString();
            txtLast.Text = r["last_name"].ToString();
            cboDept.SelectedValue = Convert.ToInt32(r["dept_id"]);
            txtPosition.Text = r["position"].ToString();
        });
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        string f = txtFirst.Text.Trim(), l = txtLast.Text.Trim();
        if (f == "" || l == "" || cboDept.SelectedValue == null)
        {
            MessageBox.Show("First name, last name and department are required.");
            return;
        }
        Theme.Run(() =>
        {
            if (empId == 0)
                Db.Exec("INSERT INTO employees(first_name,last_name,dept_id,`position`,date_hired) VALUES(@f,@l,@d,@p,CURDATE())",
                    ("@f", f), ("@l", l), ("@d", cboDept.SelectedValue), ("@p", txtPosition.Text.Trim()));
            else
                Db.Exec("UPDATE employees SET first_name=@f,last_name=@l,dept_id=@d,`position`=@p WHERE emp_id=@id",
                    ("@f", f), ("@l", l), ("@d", cboDept.SelectedValue), ("@p", txtPosition.Text.Trim()), ("@id", empId));
            DialogResult = DialogResult.OK;
        });
    }
}
