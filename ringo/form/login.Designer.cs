namespace ringo
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.text_pw = new System.Windows.Forms.TextBox();
            this.text_un = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.Label();
            this.rb_user = new System.Windows.Forms.RadioButton();
            this.rb_admin = new System.Windows.Forms.RadioButton();
            this.button_login = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.text_code = new System.Windows.Forms.TextBox();
            this.identify = new System.Windows.Forms.Label();
            this.label_code = new System.Windows.Forms.Label();
            this.choose = new System.Windows.Forms.Label();
            this.cb_lang = new System.Windows.Forms.ComboBox();
            this.link_forgotpw = new System.Windows.Forms.LinkLabel();
            this.button_refresh = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_pw
            // 
            resources.ApplyResources(this.text_pw, "text_pw");
            this.text_pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.text_pw.ForeColor = System.Drawing.Color.White;
            this.text_pw.Name = "text_pw";
            this.text_pw.UseSystemPasswordChar = true;
            // 
            // text_un
            // 
            resources.ApplyResources(this.text_un, "text_un");
            this.text_un.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.text_un.ForeColor = System.Drawing.Color.White;
            this.text_un.Name = "text_un";
            // 
            // code
            // 
            resources.ApplyResources(this.code, "code");
            this.code.BackColor = System.Drawing.Color.Transparent;
            this.code.ForeColor = System.Drawing.Color.White;
            this.code.Name = "code";
            // 
            // rb_user
            // 
            resources.ApplyResources(this.rb_user, "rb_user");
            this.rb_user.BackColor = System.Drawing.Color.Transparent;
            this.rb_user.ForeColor = System.Drawing.Color.White;
            this.rb_user.Name = "rb_user";
            this.rb_user.TabStop = true;
            this.rb_user.UseVisualStyleBackColor = false;
            // 
            // rb_admin
            // 
            resources.ApplyResources(this.rb_admin, "rb_admin");
            this.rb_admin.BackColor = System.Drawing.Color.Transparent;
            this.rb_admin.Name = "rb_admin";
            this.rb_admin.TabStop = true;
            this.rb_admin.UseVisualStyleBackColor = false;
            // 
            // button_login
            // 
            resources.ApplyResources(this.button_login, "button_login");
            this.button_login.BackColor = System.Drawing.Color.Transparent;
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.Name = "button_login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_register
            // 
            resources.ApplyResources(this.button_register, "button_register");
            this.button_register.BackColor = System.Drawing.Color.Transparent;
            this.button_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_register.Name = "button_register";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // text_code
            // 
            resources.ApplyResources(this.text_code, "text_code");
            this.text_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.text_code.ForeColor = System.Drawing.Color.White;
            this.text_code.Name = "text_code";
            this.text_code.TextChanged += new System.EventHandler(this.text_code_TextChanged);
            this.text_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_code_KeyPress);
            // 
            // identify
            // 
            resources.ApplyResources(this.identify, "identify");
            this.identify.BackColor = System.Drawing.Color.Transparent;
            this.identify.Name = "identify";
            // 
            // label_code
            // 
            resources.ApplyResources(this.label_code, "label_code");
            this.label_code.BackColor = System.Drawing.Color.White;
            this.label_code.ForeColor = System.Drawing.Color.Black;
            this.label_code.Name = "label_code";
            // 
            // choose
            // 
            resources.ApplyResources(this.choose, "choose");
            this.choose.BackColor = System.Drawing.Color.Transparent;
            this.choose.Name = "choose";
            // 
            // cb_lang
            // 
            resources.ApplyResources(this.cb_lang, "cb_lang");
            this.cb_lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lang.FormattingEnabled = true;
            this.cb_lang.Items.AddRange(new object[] {
            resources.GetString("cb_lang.Items"),
            resources.GetString("cb_lang.Items1"),
            resources.GetString("cb_lang.Items2"),
            resources.GetString("cb_lang.Items3")});
            this.cb_lang.Name = "cb_lang";
            this.cb_lang.SelectedIndexChanged += new System.EventHandler(this.cb_lang_SelectedIndexChanged);
            // 
            // link_forgotpw
            // 
            resources.ApplyResources(this.link_forgotpw, "link_forgotpw");
            this.link_forgotpw.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.link_forgotpw.BackColor = System.Drawing.Color.Transparent;
            this.link_forgotpw.LinkColor = System.Drawing.Color.White;
            this.link_forgotpw.Name = "link_forgotpw";
            this.link_forgotpw.TabStop = true;
            this.link_forgotpw.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.link_forgotpw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_forgotpw_LinkClicked);
            // 
            // button_refresh
            // 
            resources.ApplyResources(this.button_refresh, "button_refresh");
            this.button_refresh.BackColor = System.Drawing.Color.Transparent;
            this.button_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // username
            // 
            resources.ApplyResources(this.username, "username");
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Name = "username";
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Name = "password";
            // 
            // button_exit
            // 
            resources.ApplyResources(this.button_exit, "button_exit");
            this.button_exit.BackColor = System.Drawing.Color.Transparent;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Name = "button_exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.link_forgotpw);
            this.Controls.Add(this.cb_lang);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.label_code);
            this.Controls.Add(this.identify);
            this.Controls.Add(this.text_code);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.rb_admin);
            this.Controls.Add(this.rb_user);
            this.Controls.Add(this.code);
            this.Controls.Add(this.text_pw);
            this.Controls.Add(this.text_un);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_pw;
        private System.Windows.Forms.TextBox text_un;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.RadioButton rb_user;
        private System.Windows.Forms.RadioButton rb_admin;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label identify;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.Label choose;
        private System.Windows.Forms.ComboBox cb_lang;
        private System.Windows.Forms.LinkLabel link_forgotpw;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.TextBox text_code;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button button_exit;
    }
}