using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace ringo
{
    public partial class login : Form
    {
        public static string connectionstr = @"Data Source=.;Initial Catalog=ringodb;Integrated Security=True";
        public login()
        {
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = System.Globalization.CultureInfo.InstalledUICulture;
            InitializeComponent();
        }
        private void login_Load(object sender, EventArgs e)
        {
            label_code.Text = randomcode.code();
            button_login.Enabled = false;
            string lang = System.Globalization.CultureInfo.InstalledUICulture.LCID.ToString();//采用语言区域代码
            switch (lang)
            {
                case "1033": //英语（美国）区域代码
                    cb_lang.Text = "English";
                    break;
                case "2052"://中文（中国）区域代码
                    cb_lang.Text = "简体中文(Chinese Simplified)";
                    break;
                case "1028"://中文（台湾）区域代码
                    cb_lang.Text = "正體/繁體中文(Chinese Traditional)";
                    break;
                case "3076"://中文（香港）区域代码
                    cb_lang.Text = "正體/繁體中文(Chinese Traditional)";
                    break;
                case "5124"://中文（澳门）区域代码
                    cb_lang.Text = "正體/繁體中文(Chinese Traditional)";
                    break;
                case "4100"://中文（新加坡）区域代码
                    cb_lang.Text = "正體/繁體中文(Chinese Traditional)";
                    break;
                case "1041"://日语区域代码
                    cb_lang.Text = "日本語(Japanese)";
                    break;
                default:
                    cb_lang.Text = "English";
                    break;
            }
        }
        private void cb_lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_lang.SelectedItem.ToString()) //获取选择的内容
            {
                case "English":
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case "简体中文(Chinese Simplified)":
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-Hans");
                    break;
                case "正體/繁體中文(Chinese Traditional)":
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-Hant");
                    break;
                case "日本語(Japanese)":
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ja");
                    break;
            }
            System.Resources.ResourceManager lang = new System.Resources.ResourceManager(typeof(login));
            this.Text = lang.GetString("$this.Text");
            username.Text = lang.GetString("username.Text");
            password.Text = lang.GetString("password.Text");
            button_login.Text = lang.GetString("button_login.Text");
            button_register.Text = lang.GetString("button_register.Text");
            choose.Text = lang.GetString("choose.Text");
            rb_admin.Text = lang.GetString("rb_admin.Text");
            rb_user.Text = lang.GetString("rb_user.Text");
            code.Text = lang.GetString("code.Text");
            link_forgotpw.Text = lang.GetString("link_forgotpw.Text");
            button_refresh.Text = lang.GetString("button_refresh.Text");
            button_exit.Text = lang.GetString("button_exit.Text");
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String un = text_un.Text;       //获取账号密码内容
            String pw = text_pw.Text;
            if (rb_admin.Checked != true && rb_user.Checked != true)
            {
                MessageBox.Show("Invalid account type!", "ERROR");
                label_code.Text = randomcode.code();
                text_code.Text = null;
                button_login.Enabled = false;
            }
            if (rb_admin.Checked == true)
            {
                SqlConnection conn = new SqlConnection(login.connectionstr);
                conn.Open();
                String sqla = "select aname,apw from [dbo].[admin] where aname='" + un + "'and apw='" + pw + "'";
                SqlDataAdapter adp = new SqlDataAdapter(sqla, conn);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Welcome");
                    admindbms form = new admindbms(un);     //跳转到管理系统
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!", "ERROR");
                    label_code.Text = randomcode.code();
                    text_code.Text = null;
                }
            }
            if (rb_user.Checked == true)  //验证用户信息方法相同
            {
                SqlConnection conn = new SqlConnection(login.connectionstr);
                conn.Open();
                String sqlu = "select uname,upw from [user] where uname='" + un + "'and upw='" + pw + "'";
                SqlDataAdapter adp = new SqlDataAdapter(sqlu, conn);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Welcome");
                    client form = new client(un);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!", "ERROR");
                    label_code.Text = randomcode.code();
                    text_code.Text = null;
                }
            }
        }
        private void button_register_Click(object sender, EventArgs e)
        {
            register form = new register();
            form.Show();
            this.Hide();
        }
        private void link_forgotpw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotpw form = new forgotpw();
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
                button_login.Enabled = true;
            }
            if (text_code.Text == "")
                identify.Text = "";
        }
        private void button_refresh_Click(object sender, EventArgs e)
        {
            label_code.Text = randomcode.code();
            text_code.Text = null;
            button_login.Enabled = false;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                System.Environment.Exit(0);
        }

        private void text_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
