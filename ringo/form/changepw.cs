using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ringo
{
    public partial class changepw : Form
    {
        public static string connectionstr = @"Data Source=.;Initial Catalog=ringodb;Integrated Security=True";
        public changepw()
        {
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = System.Globalization.CultureInfo.InstalledUICulture;
            InitializeComponent();
            label_code.Text = randomcode.code();
            button_submit.Enabled = false;
        }
        private void button_submit_Click(object sender, EventArgs e)
        {
            if (text_un.Text == "")
                username.ForeColor = Color.FromArgb(255, 0, 0);
            else
                username.ForeColor = Color.FromArgb(255, 255, 255);
            if (text_oldpw.Text == "")
                oldpw.ForeColor = Color.FromArgb(255, 0, 0);
            else
                oldpw.ForeColor = Color.FromArgb(255, 255, 255);
            if (text_newpw.Text == "")
                newpw.ForeColor = Color.FromArgb(255, 0, 0);
            else
                newpw.ForeColor = Color.FromArgb(255, 255, 255);
            if (text_confirmpw.Text == "")
                confirmpw.ForeColor = Color.FromArgb(255, 0, 0);
            else
                confirmpw.ForeColor = Color.FromArgb(255, 255, 255);
            if (text_confirmpw.Text != text_newpw.Text)
                confirmpw.ForeColor = Color.FromArgb(255, 0, 0);
            else
                confirmpw.ForeColor = Color.FromArgb(255, 255, 255);
            int lennewpw = System.Text.Encoding.Default.GetByteCount(text_newpw.Text);
            Regex number = new Regex(@"^[0-9]+$");//仅数字的正则表达式
            Regex letter = new Regex(@"^[A-Za-z]+$");//仅字母的正则表达式
            if ((lennewpw < 8 || lennewpw > 16) && ((!number.IsMatch(text_newpw.Text)) || (!letter.IsMatch(text_newpw.Text))) && text_newpw.Text != "")
                MessageBox.Show("Invaild new password!");
            else
            {
                SqlConnection conn = new SqlConnection(changepw.connectionstr);
                conn.Open();
                String sql = "select uname,upw from [dbo].[user] where uname='" + text_un.Text + "'and upw='" + text_oldpw.Text + "'";
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "update [dbo].[user] set upw='" + text_newpw + "'where uname='" + text_un.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succeeded!");
                    this.Hide();
                }
                else
                    MessageBox.Show("Incorrect username or old password!");
            }
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
        private void text_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
