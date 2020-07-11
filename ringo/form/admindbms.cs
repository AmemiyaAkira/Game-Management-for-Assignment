using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ringo
{
    public partial class admindbms : Form
    {
        public static string connectionstr = @"Data Source=.;Initial Catalog=ringodb;Integrated Security=True";
        public admindbms(string un)
        {
            InitializeComponent();
            username.Text = un;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            SqlConnection conn = new SqlConnection(connectionstr);
            conn.Open();
            string myself = "select * from [dbo].[admin] where aname='" + username.Text + "'";
            SqlCommand me = new SqlCommand(myself, conn);
            SqlDataReader myinfo = me.ExecuteReader();
            myinfo.Read();
            string position = myinfo["apstn"].ToString().Trim();
            if (position == "0")
            {
                adminmanage.Visible = false;
                admindata.Visible = false;
                button_deleteadmin.Visible = false;
                button_addnewadmin.Visible = false;
                button_setleader.Visible = false;
                adminsearch.Visible = false;
                searchadmin.Visible = false;
            }
            if (position == "1")
            {
                adminmanage.Visible = true;
                admindata.Visible = true;
                button_deleteadmin.Visible = true;
                button_addnewadmin.Visible = true;
                button_setleader.Visible = true;
                adminsearch.Visible = true;
                searchadmin.Visible = true;
            }
            myinfo.Close();

            string sqla = "select * from [dbo].[admin] order by aid asc";
            SqlCommand admin = new SqlCommand(sqla, conn);
            SqlDataAdapter asda = new SqlDataAdapter(admin);
            DataSet ads = new DataSet();
            asda.Fill(ads, "admin");
            admindata.DataSource = ads;
            admindata.DataMember = "admin";
            admindata.Columns[0].HeaderText = "AID";
            admindata.Columns[1].HeaderText = "Username";
            admindata.Columns[2].HeaderText = "Password";
            admindata.Columns[3].HeaderText = "Position";
            admindata.ClearSelection();

            string sqlu = "select * from [dbo].[user] order by uid asc";
            SqlCommand user = new SqlCommand(sqlu, conn);
            SqlDataAdapter usda = new SqlDataAdapter(user);
            DataSet uds = new DataSet();
            usda.Fill(uds, "user");
            userdata.DataSource = uds;
            userdata.DataMember = "user";
            userdata.Columns[0].HeaderText = "UID";
            userdata.Columns[1].HeaderText = "Username";
            userdata.Columns[2].HeaderText = "Password";
            userdata.Columns[3].HeaderText = "Status";
            userdata.Columns[4].HeaderText = "Phone number";
            userdata.Columns[5].HeaderText = "E-mail address";
            userdata.Columns[6].HeaderText = "Register date";
            userdata.ClearSelection();

            string sqlg = "select * from [dbo].[game] order by gid asc ";
            SqlCommand game = new SqlCommand(sqlg, conn);
            SqlDataAdapter gda = new SqlDataAdapter(game);
            DataSet gds = new DataSet();
            gda.Fill(gds, "game");
            gamedata.DataSource = gds;
            gamedata.DataMember = "game";
            gamedata.Columns[0].HeaderText = "GID";
            gamedata.Columns[1].HeaderText = "Game name";
            gamedata.ClearSelection();

            conn.Close();
        }
        private void adminums_Load(object sender, EventArgs e)
        {
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sure to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                System.Environment.Exit(0);
        }
        private void changeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                login form = new login();
                form.Show();
                this.Hide();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label11.Text = System.DateTime.Now.ToString();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright © 2020 Akira1018(Zhang Wen)", "Copyright");
        }
        private void button_banuser_Click(object sender, EventArgs e)
        {
            string uid = userdata.CurrentRow.Cells[0].Value.ToString();
            SqlConnection conn = new SqlConnection(admindbms.connectionstr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            if (userdata.CurrentRow.Cells[3].Value.ToString() == "0")
            {
                DialogResult result = MessageBox.Show("Sure to ban?", "Ban", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cmd.CommandText = "update [dbo].[user] set uban= 1 where uid='" + uid + "'";
                    cmd.ExecuteNonQuery();
                    string sqlu = "select * from [dbo].[user] order by uid asc";
                    SqlCommand user = new SqlCommand(sqlu, conn);
                    SqlDataAdapter usda = new SqlDataAdapter(user);
                    DataSet uds = new DataSet();
                    usda.Fill(uds, "user");
                    userdata.DataSource = uds;
                    userdata.DataMember = "user";
                    userdata.Columns[0].HeaderText = "UID";
                    userdata.Columns[1].HeaderText = "Username";
                    userdata.Columns[2].HeaderText = "Password";
                    userdata.Columns[3].HeaderText = "Status";
                    userdata.Columns[4].HeaderText = "Phone number";
                    userdata.Columns[5].HeaderText = "E-mail address";
                    userdata.Columns[6].HeaderText = "Register date";
                    userdata.ClearSelection();
                    conn.Close();
                }
            }
            if (userdata.CurrentRow.Cells[3].Value.ToString() == "1")
            {
                DialogResult result = MessageBox.Show("Sure to unban?", "Unban", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cmd.CommandText = "update [dbo].[user] set uban= 0 where uid='" + uid +"'";
                    cmd.ExecuteNonQuery();
                    string sqlu = "select * from [dbo].[user] order by uid asc";
                    SqlCommand user = new SqlCommand(sqlu, conn);
                    SqlDataAdapter usda = new SqlDataAdapter(user);
                    DataSet uds = new DataSet();
                    usda.Fill(uds, "user");
                    userdata.DataSource = uds;
                    userdata.DataMember = "user";
                    userdata.Columns[0].HeaderText = "UID";
                    userdata.Columns[1].HeaderText = "Username";
                    userdata.Columns[2].HeaderText = "Password";
                    userdata.Columns[3].HeaderText = "Status";
                    userdata.Columns[4].HeaderText = "Phone number";
                    userdata.Columns[5].HeaderText = "E-mail address";
                    userdata.Columns[6].HeaderText = "Register date";
                    userdata.ClearSelection();
                    conn.Close();
                }
            }
        }
        private void button_deleteadmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sure to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string aid = admindata.CurrentRow.Cells[0].Value.ToString();
                SqlConnection conn = new SqlConnection(admindbms.connectionstr);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "delete from [dbo].[admin] where aid='" + aid + "'";
                cmd.ExecuteNonQuery();
                string sqla = "select * from [dbo].[admin] order by aid asc ";
                SqlCommand admin = new SqlCommand(sqla, conn);
                SqlDataAdapter adminda = new SqlDataAdapter(admin);
                DataSet ads = new DataSet();
                adminda.Fill(ads, "admin");
                admindata.DataSource = ads;
                admindata.DataMember = "admin";
                admindata.Columns[0].HeaderText = "AID";
                admindata.Columns[1].HeaderText = "Username";
                admindata.Columns[2].HeaderText = "Password";
                admindata.Columns[3].HeaderText = "Position";
                admindata.ClearSelection();
                conn.Close();
            }
        }
        private void admindata_SelectionChanged(object sender, EventArgs e)
        {
            if(admindata.SelectedRows.Count>0)
            {
                string aid = this.admindata.CurrentRow.Cells[0].Value.ToString();
                SqlConnection conn = new SqlConnection(connectionstr);
                conn.Open();
                string myself = "select * from [dbo].[admin] where aname='" + username.Text + "'";
                SqlCommand me = new SqlCommand(myself, conn);
                SqlDataReader myinfo = me.ExecuteReader();
                myinfo.Read();
                string myposition = myinfo["apstn"].ToString().Trim();
                myinfo.Close();
                string sql = "select * from [dbo].[admin] where aid='" + aid + "'";
                SqlCommand admin = new SqlCommand(sql, conn);
                SqlDataReader admindr = admin.ExecuteReader();
                admindr.Read();
                string position = admindr["apstn"].ToString().Trim();
                admindr.Close();
                if(myposition==position)
                {
                    button_deleteadmin.Enabled = false;
                    button_setleader.Enabled = false;
                }
                else
                {
                    button_deleteadmin.Enabled = true;
                    button_setleader.Enabled = true;
                }
                conn.Close();
            }
        }
        private void button_addgame_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(register.connectionstr);
            conn.Open();
            string sql = String.Format("insert into [dbo].[game](gname) values('{0}')", text_addgame.Text );
            SqlCommand cmd = new SqlCommand(sql, conn);
            int j = cmd.ExecuteNonQuery();
            if (j > 0)
            {
                MessageBox.Show("Succeeded!");
                this.DialogResult = DialogResult.Retry;
                conn.Close();
            }
            string sqlg = "select * from [dbo].[game] order by gid asc ";
            SqlCommand game = new SqlCommand(sqlg, conn);
            SqlDataAdapter gda = new SqlDataAdapter(game);
            DataSet gds = new DataSet();
            gda.Fill(gds, "game");
            gamedata.DataSource = gds;
            gamedata.DataMember = "game";
            gamedata.Columns[0].HeaderText = "GID";
            gamedata.Columns[1].HeaderText = "Game name";
            gamedata.ClearSelection();
        }
        private void text_addgame_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(register.connectionstr);
            conn.Open();
            string sql = String.Format("select gname from [dbo].[game] where gname = '{0}'", text_addgame.Text);
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader datareader = command.ExecuteReader();
            int i;
            for (i = 0; datareader.Read(); i++)
            {
            }
            if (i > 0)
                button_addgame.Enabled = false;
            else
            {
                button_addgame.Enabled = true;
            }
            if (text_addgame.Text == "")
                button_addgame.Enabled = false;
        }
        private void button_addnewadmin_Click(object sender, EventArgs e)
        {
            button_confirminfo.Visible = true;
            text_un.Visible = true;
            text_pw.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }
        private void button_setleader_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string aid = admindata.CurrentRow.Cells[0].Value.ToString();
                SqlConnection conn = new SqlConnection(admindbms.connectionstr);
                conn.Open();
                string myself = "select * from [dbo].[admin] where aname='" + username.Text + "'";
                SqlCommand me = new SqlCommand(myself, conn);
                SqlDataReader myinfo = me.ExecuteReader();
                myinfo.Read();
                string myaid = myinfo["aid"].ToString().Trim();
                myinfo.Close();
                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandText = "update [dbo].[admin] set apstn= 0 where aid='" + myaid + "'";
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandText = "update [dbo].[admin] set apstn= 1 where aid='" + aid + "'";
                cmd2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Re-login?(If not, please do it later on.)", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    login form = new login();
                    form.Show();
                    this.Hide();
                }
            }
        }
        private void button_deletegame_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sure to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string gid = gamedata.CurrentRow.Cells[0].Value.ToString();
                SqlConnection conn = new SqlConnection(admindbms.connectionstr);
                conn.Open();
                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandText = "delete from [dbo].[active] where gid='" + gid + "'";
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandText = "delete from [dbo].[game] where gid='" + gid + "'";
                cmd2.ExecuteNonQuery();
                string sqlg = "select * from [dbo].[game] order by gid asc ";
                SqlCommand game = new SqlCommand(sqlg, conn);
                SqlDataAdapter gda = new SqlDataAdapter(game);
                DataSet gds = new DataSet();
                gda.Fill(gds, "game");
                gamedata.DataSource = gds;
                gamedata.DataMember = "game";
                gamedata.Columns[0].HeaderText = "GID";
                gamedata.Columns[1].HeaderText = "Game name";
                gamedata.ClearSelection();
                conn.Close();
            }
        }
        private void button_confirminfo_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(register.connectionstr);
            conn.Open();
            string sql = String.Format("insert into [dbo].[admin](aname,apw,apstn) values('{0}','{1}','{2}')", text_un.Text, text_pw.Text, 0);
            SqlCommand cmd = new SqlCommand(sql, conn);
            int j = cmd.ExecuteNonQuery();
            if (j > 0)
            {
                MessageBox.Show("Succeeded!");
                button_confirminfo.Visible = false;
                text_un.Visible = false;
                text_pw.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                string sqla = "select * from [dbo].[admin] order by aid asc ";
                SqlCommand admin = new SqlCommand(sqla, conn);
                SqlDataAdapter adminda = new SqlDataAdapter(admin);
                DataSet ads = new DataSet();
                adminda.Fill(ads, "admin");
                admindata.DataSource = ads;
                admindata.DataMember = "admin";
                admindata.Columns[0].HeaderText = "AID";
                admindata.Columns[1].HeaderText = "Username";
                admindata.Columns[2].HeaderText = "Password";
                admindata.Columns[3].HeaderText = "Position";
                admindata.ClearSelection();
                conn.Close();
            }
        }
        private void text_un_TextChanged(object sender, EventArgs e)
        {
            if (text_un.Text == "")
                button_confirminfo.Enabled = false;
            else
                button_confirminfo.Enabled = true;
            int lenun = System.Text.Encoding.Default.GetByteCount(text_un.Text);
            Regex number = new Regex(@"^[0-9]+$");//仅数字的正则表达式
            Regex letter = new Regex(@"^[A-Za-z]+$");//仅字母的正则表达式
            if ((lenun < 8 || lenun > 16) && (!number.IsMatch(text_un.Text) || !letter.IsMatch(text_un.Text) || !text_un.Text.Contains("_")) && text_un.Text != "")
                button_confirminfo.Enabled = false;
            else
                button_confirminfo.Enabled = true;
            SqlConnection conn = new SqlConnection(register.connectionstr);
            conn.Open();
            string sql = String.Format("select aname from [dbo].[admin] where aname = '{0}'", text_un.Text);
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader datareader = command.ExecuteReader();
            int i;
            for (i = 0; datareader.Read(); i++)
            {
            }
            if (i > 0)
                button_confirminfo.Enabled = false;
            else
                button_confirminfo.Enabled = true;
            conn.Close();
        }
        private void text_pw_TextChanged(object sender, EventArgs e)
        {
            if (text_pw.Text == "")
                button_confirminfo.Enabled = false;
            else
                button_confirminfo.Enabled = true;
            int  lenpw = System.Text.Encoding.Default.GetByteCount(text_pw.Text);
            Regex number = new Regex(@"^[0-9]+$");//仅数字的正则表达式
            Regex letter = new Regex(@"^[A-Za-z]+$");//仅字母的正则表达式
            if ((lenpw < 8 || lenpw > 16) && (!number.IsMatch(text_pw.Text) || !letter.IsMatch(text_pw.Text)) && text_pw.Text != "")
                button_confirminfo.Enabled = false;
            else
                button_confirminfo.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(admindbms.connectionstr);
            conn.Open();
            string myself = "select * from [dbo].[user] where aname='" + username.Text + "'";
        }

        private void searchpic_Click(object sender, EventArgs e)
        {
            if(table.SelectedIndex==0)//用户
            {
                int row =userdata.Rows.Count;
                int cell = userdata.Rows[1].Cells.Count;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < cell; j++)
                    {
                        if (search.Text == userdata.Rows[i].Cells[j].Value.ToString())
                        {
                            this.userdata.CurrentCell = this.userdata[j, i];
                            return;
                        }
                    }
                }
            }
            if(table.SelectedIndex==1)//游戏
            {
                int row = gamedata.Rows.Count;
                int cell = gamedata.Rows[1].Cells.Count;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < cell; j++)
                    {
                        if (search.Text == gamedata.Rows[i].Cells[j].Value.ToString())
                        {
                            this.gamedata.CurrentCell = this.gamedata[j, i];
                            return;
                        }
                    }
                }
            }
        }

        private void searchadmin_Click(object sender, EventArgs e)
        {
            int row = admindata.Rows.Count;
            int cell = admindata.Rows[1].Cells.Count;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cell; j++)
                {
                    if (adminsearch.Text == admindata.Rows[i].Cells[j].Value.ToString())
                    {
                        this.admindata.CurrentCell = this.admindata[j, i];
                        return;
                    }
                }
            }
        }
    }
}
