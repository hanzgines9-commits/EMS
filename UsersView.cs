using System.ComponentModel;

namespace EMS;

public partial class UsersView : UserControl
{
    public UsersView()
    {
        InitializeComponent();
    }

    private void UsersView_Load(object sender, EventArgs e)
    {
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
        Theme.StyleGrid(dgvUsers);
        cboRole.SelectedIndex = 1;
        Theme.Run(LoadData);
    }

    void LoadData()
    {
        dgvUsers.DataSource = Db.Query("SELECT user_id AS `ID`, username AS `USERNAME`, role AS `ROLE` FROM users ORDER BY user_id");
    }

    private void btnAddUser_Click(object sender, EventArgs e)
    {
        string u = txtUsername.Text.Trim(), p = txtPassword.Text;
        if (u == "" || p == "" || cboRole.Text == "")
        {
            MessageBox.Show("Fill in username, password and role.");
            return;
        }
        Theme.Run(() =>
        {
            Db.Exec("INSERT INTO users(username,password,role) VALUES(@u,@p,@r)", ("@u", u), ("@p", Session.Hash(p)), ("@r", cboRole.Text));
            txtUsername.Clear();
            txtPassword.Clear();
            LoadData();
        });
    }

    private void btnDeleteUser_Click(object sender, EventArgs e)
    {
        if (dgvUsers.CurrentRow == null) return;
        int id = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);
        if (id == Session.UserId)
        {
            MessageBox.Show("You cannot delete your own account.");
            return;
        }
        if (MessageBox.Show("Delete user #" + id + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
        Theme.Run(() =>
        {
            Db.Exec("DELETE FROM users WHERE user_id=@id", ("@id", id));
            LoadData();
        });
    }
}
