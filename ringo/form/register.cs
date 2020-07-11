using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ringo
{
    public partial class register : Form
    {
        public static string connectionstr = @"Data Source=.;Initial Catalog=ringodb;Integrated Security=True";
        public register()
        {
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = System.Globalization.CultureInfo.InstalledUICulture;
            InitializeComponent();

            button_submit.Enabled = false;
            label_code.Text = randomcode.code();
            warn1.Visible = false;
            warn2.Visible = false;
            warn3.Visible = false;
        }
        protected void button_submit_Click(object sender, EventArgs e)//以插入表现注册新账号
        {
            if (text_un.Text == "")
                username.ForeColor = Color.FromArgb(255, 0, 0);
            else
                username.ForeColor = Color.FromArgb(255, 255, 255);
            if (text_pw.Text == "")
                password.ForeColor = Color.FromArgb(255, 0, 0);
            else
                password.ForeColor = Color.FromArgb(255, 255, 255);
            if (text_confirmpw.Text == "")
                confirmpw.ForeColor = Color.FromArgb(255, 0, 0);
            else
                confirmpw.ForeColor = Color.FromArgb(255, 255, 255);
            if (text_phone.Text == "")
                phone.ForeColor = Color.FromArgb(255, 0, 0);
            else
                phone.ForeColor = Color.FromArgb(255, 255, 255);
            if (text_confirmpw.Text != text_pw.Text)
                confirmpw.ForeColor = Color.FromArgb(255, 0, 0);

            int lenun, lenpw;
            lenun = System.Text.Encoding.Default.GetByteCount(text_un.Text);
            lenpw = System.Text.Encoding.Default.GetByteCount(text_pw.Text);
            Regex number = new Regex(@"^[0-9]+$");//仅数字的正则表达式
            Regex letter = new Regex(@"^[A-Za-z]+$");//仅字母的正则表达式
            if ((lenun < 8 || lenun > 16) && (!number.IsMatch(text_un.Text) || !letter.IsMatch(text_un.Text) || !text_un.Text.Contains("_")) && text_un.Text != "")
                warn2.Visible = true;
            else
                warn2.Visible = false;
            if ((lenpw < 8 || lenpw > 16) && (!number.IsMatch(text_pw.Text) || !letter.IsMatch(text_pw.Text)) && text_pw.Text != "")
                warn2.Visible = true;
            else
                warn2.Visible = false;
            if ((!number.IsMatch(text_phone.Text)) && text_phone.Text != "")
                warn3.Visible = true;
            else
                warn3.Visible = false;
            if (!text_email.Text.Contains("@") && text_email.Text != "")
                warn3.Visible = true;
            else
                warn3.Visible = false;

            if (username.ForeColor != Color.FromArgb(255, 0, 0) && password.ForeColor != Color.FromArgb(255, 0, 0) && confirmpw.ForeColor != Color.FromArgb(255, 0, 0) && phone.ForeColor != Color.FromArgb(255, 0, 0) && warn2.Visible == false && warn3.Visible == false)
            {
                SqlConnection conn = new SqlConnection(register.connectionstr);
                conn.Open();
                string sql = String.Format("select uname from [dbo].[user] where uname = '{0}'", text_un.Text);
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader datareader = command.ExecuteReader();
                int i;
                for (i = 0; datareader.Read(); i++)
                {
                }
                if (i > 0)
                    warn1.Visible = true;
                else//未注册，检查填写邮箱，向数据表中插入相应的用户名和密码
                {
                    datareader.Close();
                    string newuser = String.Format("insert into [dbo].[user](uname,upw,uban,uphone,uemail,uredate) values('{0}','{1}','{2}','{3}','{4}','{5}')", text_un.Text, text_pw.Text, 0, text_phone.Text, text_email.Text, DateTime.Now.ToShortDateString().ToString());
                    SqlCommand cmd = new SqlCommand(newuser, conn);
                    int j = cmd.ExecuteNonQuery();
                    if (j > 0)
                    {
                        MessageBox.Show("Welcome");
                        this.DialogResult = DialogResult.Retry;
                        conn.Close();
                        login form = new login();
                        form.Show();
                        this.Hide();
                    }
                }
            }
            label_code.Text = randomcode.code();
            text_code.Text = "";
            button_submit.Enabled = false;
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            text_un.Text = "";
            text_pw.Text = "";
            text_confirmpw.Text = "";
            text_phone.Text = "";
            text_email.Text = "";
            text_code.Text = "";
            label_code.Text = randomcode.code();
            button_submit.Enabled = false;
        }
        private void button_return_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
            this.Hide();
        }
        private void text_code_TextChanged(object sender, EventArgs e)
        {
            if (text_code.Text != label_code.Text)
            {
                identify.Text = "×";
                identify.ForeColor = Color.FromArgb(255, 0, 0);
            }
            if (text_code.Text == label_code.Text)
            {
                identify.Text = "√";
                identify.ForeColor = Color.FromArgb(0, 255, 0);
                button_submit.Enabled = true;
            }
            if (text_code.Text == "")
                identify.Text = "";
        }
        private void button_refresh_Click(object sender, EventArgs e)
        {
            label_code.Text = randomcode.code();
            text_code.Text = "";
            button_submit.Enabled = false;
        }

        private void text_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
