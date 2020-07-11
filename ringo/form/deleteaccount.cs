using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ringo
{
    public partial class delete : Form
    {
        public static string connectionstr = @"Data Source=.;Initial Catalog=ringodb;Integrated Security=True";
        client fm1 = null;
        public delete(client fm)
        {
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = System.Globalization.CultureInfo.InstalledUICulture;
            InitializeComponent();
            fm1 = fm;
            label_code.Text = randomcode.code();
            button_submit.Enabled = false;
            this.dateTimePicker1.Value = DateTime.Now;
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

        private void button_submit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(forgotpw.connectionstr);
            conn.Open();
            String sql = "select * from [dbo].[user] where uname='" + text_un.Text + "'and upw='"+text_pw.Text+"'and uphone='" + text_phone.Text + "'and uemail='" + text_email.Text + "'and uredate='"+dateTimePicker1.Value+"'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Sure to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqluid = "select * from [dbo].[user] where uname='" + text_un.Text + "'";
                    SqlCommand finduid = new SqlCommand(sqluid, conn);
                    SqlDataReader uidread = finduid.ExecuteReader();
                    uidread.Read();
                    string uid = uidread["uid"].ToString().Trim();
                    uidread.Close();
                    SqlCommand cmd1 = conn.CreateCommand();
                    cmd1.CommandText ="delete from [dbo].[active] where uid='" + uid + "'";
                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd2 = conn.CreateCommand();
                    cmd2.CommandText = "delete from [dbo].[user] where uname='" + text_un.Text + "'";
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Succeeded!");
                    string un = text_un.Text;
                    this.Close();
                    fm1.Close();
                    login form = new login();
                    form.Show();
                }
            }
            else
                warn.Visible = true;
        }
        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void delete_Load(object sender, EventArgs e)
        {
        }
    }
}
