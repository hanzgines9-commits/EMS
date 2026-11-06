namespace EMS;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        if (txtUser.Text.Trim() == "" || txtPass.Text == "")
        {
            lblError.Text = "Enter username and password.";
            return;
        }
        try
        {
            if (Session.Login(txtUser.Text.Trim(), txtPass.Text) == 1)
                DialogResult = DialogResult.OK;
            else
                lblError.Text = "Invalid username or password.";
        }
        catch (Exception ex)
        {
            lblError.Text = "Database error: " + ex.Message;
        }
    }
}
