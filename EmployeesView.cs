using System.ComponentModel;

namespace EMS;

public partial class EmployeesView : UserControl
{
    int ready;

    public EmployeesView()
    {
        InitializeComponent();
    }

    private void EmployeesView_Load(object sender, EventArgs e)
    {
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
        dgvEmployees.AutoGenerateColumns = false;
        Theme.StyleGrid(dgvEmployees);
        Theme.Run(() =>
        {
            foreach (string name in new[] { "Marketing", "Customer Service" })
                Db.Exec("INSERT INTO departments(dept_name, location) SELECT @n, 'Main Office' FROM DUAL " +
                        "WHERE NOT EXISTS (SELECT 1 FROM departments WHERE dept_name=@n)", ("@n", name));
            LoadFilters();
            LoadData();
        });
    }

    void LoadFilters()
    {
        ready = 0;
        object keepDept = cboDeptFilter.SelectedValue;
        string keepPos = cboPosFilter.Text;

        var dt = Db.Query("SELECT dept_id, dept_name FROM departments ORDER BY dept_name");
        var allD = dt.NewRow();
        allD["dept_id"] = 0;
        allD["dept_name"] = "All Departments";
        dt.Rows.InsertAt(allD, 0);
        cboDeptFilter.DisplayMember = "dept_name";
        cboDeptFilter.ValueMember = "dept_id";
        cboDeptFilter.DataSource = dt;

        var pt = Db.Query("SELECT DISTINCT `position` FROM employees WHERE `position` IS NOT NULL AND `position`<>'' ORDER BY `position`");
        var allP = pt.NewRow();
        allP["position"] = "All Positions";
        pt.Rows.InsertAt(allP, 0);
        cboPosFilter.DisplayMember = "position";
        cboPosFilter.ValueMember = "position";
        cboPosFilter.DataSource = pt;

        if (keepDept != null) cboDeptFilter.SelectedValue = keepDept;
        if (keepPos != "") cboPosFilter.Text = keepPos;
        ready = 1;
    }

    void LoadData()
    {
        string like = "%" + txtSearch.Text.Trim() + "%";
        int dept = cboDeptFilter.SelectedValue == null ? 0 : Convert.ToInt32(cboDeptFilter.SelectedValue);
        string pos = cboPosFilter.SelectedIndex > 0 ? cboPosFilter.Text : "";
        dgvEmployees.DataSource = Db.Query(
            "SELECT e.emp_id, CONCAT(e.first_name,' ',e.last_name) AS full_name, d.dept_name, e.`position` " +
            "FROM employees e LEFT JOIN departments d ON d.dept_id=e.dept_id " +
            "WHERE (CONCAT(e.first_name,' ',e.last_name) LIKE @l OR d.dept_name LIKE @l) " +
            "AND (@d=0 OR e.dept_id=@d) AND (@p='' OR e.`position`=@p) ORDER BY e.first_name",
            ("@l", like), ("@d", dept), ("@p", pos));
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        if (ready == 0) return;
        Theme.Run(LoadData);
    }

    private void filter_Changed(object sender, EventArgs e)
    {
        if (ready == 0) return;
        Theme.Run(LoadData);
    }

    void Refresh2()
    {
        LoadFilters();
        LoadData();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using var d = new EmployeeDialog();
        if (d.ShowDialog() == DialogResult.OK) Theme.Run(Refresh2);
    }

    private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        int id = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells["colId"].Value);
        string c = dgvEmployees.Columns[e.ColumnIndex].Name;
        if (c == "colEdit")
        {
            using var d = new EmployeeDialog(id);
            if (d.ShowDialog() == DialogResult.OK) Theme.Run(Refresh2);
        }
        else if (c == "colDelete")
        {
            if (MessageBox.Show("Delete this employee and their attendance records?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            Theme.Run(() =>
            {
                Db.Exec("DELETE FROM employees WHERE emp_id=@id", ("@id", id));
                Refresh2();
            });
        }
    }
}