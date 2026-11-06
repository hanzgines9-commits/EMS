using System.ComponentModel;

namespace EMS;

public partial class AuditView : UserControl
{
    public AuditView()
    {
        InitializeComponent();
    }

    private void AuditView_Load(object sender, EventArgs e)
    {
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
        Theme.StyleGrid(dgvAudit);
        Theme.Run(LoadData);
    }

    void LoadData()
    {
        dgvAudit.DataSource = Db.Query(
            "SELECT l.log_id AS `ID`, IFNULL(u.username,'\u2014') AS `USER`, l.action AS `ACTION`, " +
            "DATE_FORMAT(l.log_timestamp,'%Y-%m-%d %H:%i:%s') AS `TIMESTAMP` " +
            "FROM audit_logs l LEFT JOIN users u ON u.user_id=l.user_id ORDER BY l.log_id DESC LIMIT 300");
    }

    private void btnRefresh_Click(object sender, EventArgs e) { Theme.Run(LoadData); }
}
