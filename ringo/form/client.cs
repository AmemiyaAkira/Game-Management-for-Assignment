using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ringo
{
    public partial class client : Form
    {
        string username;
        public static string connectionstr = @"Data Source=.;Initial Catalog=ringodb;Integrated Security=True";
        public client(string un)
        {
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = System.Globalization.CultureInfo.InstalledUICulture;
            InitializeComponent();

            username = un;
            label_username.Text = username;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            text_phone.Visible = false;
            text_email.Visible = false;
            button_confirm1.Visible = false;
            button_confirm2.Visible = false;
            phonechanged.Visible = false;
            emailchanged.Visible = false;
            normal.Visible = false;
            banned.Visible = false;

            SqlConnection conn = new SqlConnection(connectionstr);//创建数据库链接
            conn.Open();
            SqlCommand game = new SqlCommand("select * from [dbo].[game]", conn);
            SqlDataReader gamedr = game.ExecuteReader();
            while (gamedr.Read())
                gamelist.Items.Add(gamedr["gname"].ToString().Trim());
            gamedr.Close();
            string sqlu = "select * from [dbo].[user] where uname='" + username + "'";
            SqlCommand user = new SqlCommand(sqlu, conn);
            SqlDataReader userdr = user.ExecuteReader();
            userdr.Read();
            string bannedornot = userdr["uban"].ToString().Trim();
            if (bannedornot == "0")
                normal.Visible = true;
            if (bannedornot == "1")
            {
                banned.Visible = true;
                button_delete.Enabled = false;
            }
            userdr.Close();
            conn.Close();
        }
        private void switchTheUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                login form = new login();
                form.Show();
                this.Hide();
            }
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sure to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                System.Environment.Exit(0);
        }
        private void client_Load(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = System.DateTime.Now.ToString();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright © 2020 Akira1018(Zhang Wen)", "Copyright");
        }
        private void button_active_Click(object sender, EventArgs e)
        {
            int gid = gamelist.SelectedIndex + 1;
            SqlConnection conn = new SqlConnection(connectionstr);//创建数据库链接
            conn.Open();
            string sqlu = "select * from [dbo].[user] where uname='" + username + "'";
            SqlCommand user = new SqlCommand(sqlu, conn);
            SqlDataReader userdr = user.ExecuteReader();
            userdr.Read();
            int uid = Convert.ToInt32(userdr["uid"]);
            userdr.Close();
            string newac = String.Format("insert into [dbo].[active](gid,uid) values('{0}','{1}')", gid, uid);
            SqlCommand cmd = new SqlCommand(newac, conn);
            int j = cmd.ExecuteNonQuery();
            if (j > 0)
                MessageBox.Show("Succeeded!");
        }
        private void button_email_Click(object sender, EventArgs e)
        {
            text_email.Visible = true;
            button_confirm2.Visible = true;
        }
        private void button_phone_Click(object sender, EventArgs e)
        {
            text_phone.Visible = true;
            button_confirm1.Visible = true;
        }
        private void button_confirm1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionstr);//创建数据库链接
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            if (text_phone.Text != "")
            {
                cmd.CommandText = "update [dbo].[user] set uphone='" + text_phone.Text + "'where uname='" + username + "'";
                cmd.ExecuteNonQuery();
                phonechanged.Visible = true;
                text_phone.Text = "";
                conn.Close();
            }
        }
        private void button_confirm2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionstr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            if (text_email.Text != "")
            {
                cmd.CommandText = "update [dbo].[user] set uemail='" + text_email.Text + "'where uname='" + username + "'";
                cmd.ExecuteNonQuery();
                emailchanged.Visible = true;
                text_email.Text = "";
                conn.Close();
            }
        }
        private void button_pw_Click(object sender, EventArgs e)
        {
            changepw form = new changepw();
            form.Show();
        }
        private void searchpic_Click(object sender, EventArgs e)
        {
            int index = gamelist.Items.IndexOf(text_search.Text);
            gamelist.TopIndex = index;
            gamelist.SelectedIndex = index;
        }
        private void text_search_MouseClick(object sender, MouseEventArgs e)
        {
            if (text_search.Text == "Search...")
                text_search.Text = "";
        }
        private void gamelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gamelist.SelectedIndex != -1)
            {
                int gid = this.gamelist.SelectedIndex + 1;
                SqlConnection conn = new SqlConnection(connectionstr);
                conn.Open();
                string sql = "select * from [dbo].[user] where uname='" + username + "'";
                SqlCommand user = new SqlCommand(sql, conn);
                SqlDataReader userdr = user.ExecuteReader();
                userdr.Read();
                string uid = userdr["uid"].ToString().Trim();
                userdr.Close();
                string sqlac = "select * from [dbo].[active] where gid='" + gid + "' and uid ='" + uid + "'";
                SqlCommand command = new SqlCommand(sqlac, conn);
                SqlDataReader acdr = command.ExecuteReader();
                int i;
                for (i = 0; acdr.Read(); i++)
                {
                }
                if (i > 0)
                    button_active.Enabled = false;
                else
                    button_active.Enabled = true;
                acdr.Close();
                conn.Close();
            }
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            delete fm2 = new delete(this);
            fm2.Show();
        }
    }
}