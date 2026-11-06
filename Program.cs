namespace EMS;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        while (true)
        {
            using (var login = new LoginForm())
            {
                if (login.ShowDialog() != DialogResult.OK) return;
            }
            var main = new MainForm();
            Application.Run(main);
            if (main.LoggedOut == 0) return;
        }
    }
}
