using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ringo
{
    public partial class forgotpw : Form
    {
        public static string connectionstr =@"Data Source=.;Initial Catalog=ringodb;Integrated Security=True";
        public forgotpw()
        {
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = System.Globalization.CultureInfo.InstalledUICulture;
            InitializeComponent();

            notice.Visible = false;
            label_newpw.Visible = false;
            tip3.Visible = false;
        }
        private void forgotpw_Load(object sender, EventArgs e)
        {
            label_code.Text = randomcode.code();
            button_submit.Enabled = false;
        }
        private void button_fresh_Click(object sender, EventArgs e)
        {
            label_code.Text = randomcode.code();
            text_code.Text = null;
            button_submit.Enabled = false;
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
        private void button_return_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
            this.Hide();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(forgotpw.connectionstr);
            conn.Open();
            String sql = "select uname,upw from [dbo].[user] where uname='" + text_un.Text + "'and uphone='" + text_phone.Text + "'and uemail='" + text_email.Text + "'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                string newpw = "";//验证码字符串
                Random ran = new Random();
                for (int i = 0; i < 8; i++) //随机生成8位数字验证码
                {
                    int n = ran.Next(9);
                    newpw += n;
                }
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "update [dbo].[user] set upw='" + newpw + "'where uname='" + text_un.Text + "'";
                cmd.ExecuteNonQuery();
                label_newpw.Text = newpw;
                notice.Visible = true;
                label_newpw.Visible = true;
                tip3.Visible = true;
                text_code.Text = null;
                text_email.Text = null;
                text_phone.Text = null;
                text_un.Text = null;
            }
            else
                MessageBox.Show("Incorrect personal information!", "Failed!");
        }

        private void text_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
