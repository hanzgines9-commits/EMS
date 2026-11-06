using System.Data;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;

namespace EMS;

public static class Config
{
    // Edit Uid / Pwd to match your MySQL server.
    public const string ConnectionString =
        "Server=localhost;Port=3306;Database=ems_db;Uid=root;Pwd=09554461803;SslMode=None;AllowPublicKeyRetrieval=True;";
}

public static class Db
{
    static MySqlCommand Make(MySqlConnection c, string sql, (string, object)[] p)
    {
        var cmd = new MySqlCommand(sql, c);
        foreach (var (n, v) in p) cmd.Parameters.AddWithValue(n, v ?? DBNull.Value);
        return cmd;
    }

    public static DataTable Query(string sql, params (string, object)[] p)
    {
        using var c = new MySqlConnection(Config.ConnectionString);
        using var cmd = Make(c, sql, p);
        using var a = new MySqlDataAdapter(cmd);
        var t = new DataTable();
        a.Fill(t);
        return t;
    }

    public static object Scalar(string sql, params (string, object)[] p)
    {
        using var c = new MySqlConnection(Config.ConnectionString);
        c.Open();
        using var cmd = Make(c, sql, p);
        return cmd.ExecuteScalar();
    }

    public static int Exec(string sql, params (string, object)[] p)
    {
        using var c = new MySqlConnection(Config.ConnectionString);
        c.Open();
        using var cmd = Make(c, sql, p);
        return cmd.ExecuteNonQuery();
    }

    public static double Num(object o)
    {
        if (o == null || o == DBNull.Value) return 0;
        return Convert.ToDouble(o);
    }
}

public static class Session
{
    public static int UserId;
    public static string Username = "";
    public static string Role = "";

    public static string Hash(string s)
    {
        using var h = SHA256.Create();
        return Convert.ToHexString(h.ComputeHash(Encoding.UTF8.GetBytes(s))).ToLower();
    }

    // returns 1 on success, 0 on failure
    public static int Login(string user, string pass)
    {
        var t = Db.Query("SELECT user_id, username, role FROM users WHERE username=@u AND password=@p",
            ("@u", user), ("@p", Hash(pass)));
        if (t.Rows.Count == 0) return 0;
        UserId = Convert.ToInt32(t.Rows[0]["user_id"]);
        Username = t.Rows[0]["username"].ToString();
        Role = t.Rows[0]["role"].ToString();
        return 1;
    }
}
