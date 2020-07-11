namespace ringo
{
    partial class forgotpw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotpw));
            this.tip = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.text_un = new System.Windows.Forms.TextBox();
            this.text_phone = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.text_code = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.Label();
            this.identify = new System.Windows.Forms.Label();
            this.label_code = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.tip1 = new System.Windows.Forms.Label();
            this.notice = new System.Windows.Forms.Label();
            this.label_newpw = new System.Windows.Forms.Label();
            this.tip3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tip
            // 
            resources.ApplyResources(this.tip, "tip");
            this.tip.BackColor = System.Drawing.Color.Transparent;
            this.tip.Name = "tip";
            // 
            // username
            // 
            resources.ApplyResources(this.username, "username");
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Name = "username";
            // 
            // text_un
            // 
            this.text_un.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(37)))));
            resources.ApplyResources(this.text_un, "text_un");
            this.text_un.ForeColor = System.Drawing.Color.White;
            this.text_un.Name = "text_un";
            // 
            // text_phone
            // 
            this.text_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(37)))));
            resources.ApplyResources(this.text_phone, "text_phone");
            this.text_phone.ForeColor = System.Drawing.Color.White;
            this.text_phone.Name = "text_phone";
            this.text_phone.UseSystemPasswordChar = true;
            // 
            // phone
            // 
            resources.ApplyResources(this.phone, "phone");
            this.phone.BackColor = System.Drawing.Color.Transparent;
            this.phone.ForeColor = System.Drawing.Color.White;
            this.phone.Name = "phone";
            // 
            // text_email
            // 
            this.text_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(37)))));
            this.text_email.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.text_email, "text_email");
            this.text_email.Name = "text_email";
            // 
            // email
            // 
            resources.ApplyResources(this.email, "email");
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Name = "email";
            // 
            // text_code
            // 
            this.text_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(37)))));
            resources.ApplyResources(this.text_code, "text_code");
            this.text_code.ForeColor = System.Drawing.Color.White;
            this.text_code.Name = "text_code";
            this.text_code.UseSystemPasswordChar = true;
            this.text_code.TextChanged += new System.EventHandler(this.text_code_TextChanged);
            this.text_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_code_KeyPress);
            // 
            // code
            // 
            resources.ApplyResources(this.code, "code");
            this.code.BackColor = System.Drawing.Color.Transparent;
            this.code.ForeColor = System.Drawing.Color.White;
            this.code.Name = "code";
            // 
            // identify
            // 
            this.identify.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.identify, "identify");
            this.identify.Name = "identify";
            // 
            // label_code
            // 
            this.label_code.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label_code, "label_code");
            this.label_code.ForeColor = System.Drawing.Color.Black;
            this.label_code.Name = "label_code";
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.Transparent;
            this.button_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button_refresh, "button_refresh");
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_fresh_Click);
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.Transparent;
            this.button_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button_submit, "button_submit");
            this.button_submit.Name = "button_submit";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // button_return
            // 
            this.button_return.BackColor = System.Drawing.Color.Transparent;
            this.button_return.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button_return, "button_return");
            this.button_return.Name = "button_return";
            this.button_return.UseVisualStyleBackColor = false;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // tip1
            // 
            this.tip1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tip1, "tip1");
            this.tip1.Name = "tip1";
            // 
            // notice
            // 
            resources.ApplyResources(this.notice, "notice");
            this.notice.BackColor = System.Drawing.Color.Transparent;
            this.notice.Name = "notice";
            // 
            // label_newpw
            // 
            resources.ApplyResources(this.label_newpw, "label_newpw");
            this.label_newpw.BackColor = System.Drawing.Color.Transparent;
            this.label_newpw.Name = "label_newpw";
            // 
            // tip3
            // 
            resources.ApplyResources(this.tip3, "tip3");
            this.tip3.BackColor = System.Drawing.Color.Transparent;
            this.tip3.Name = "tip3";
            // 
            // forgotpw
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.tip3);
            this.Controls.Add(this.label_newpw);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.tip1);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label_code);
            this.Controls.Add(this.identify);
            this.Controls.Add(this.text_code);
            this.Controls.Add(this.code);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.email);
            this.Controls.Add(this.text_phone);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.text_un);
            this.Controls.Add(this.username);
            this.Controls.Add(this.tip);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "forgotpw";
            this.Load += new System.EventHandler(this.forgotpw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox text_un;
        private System.Windows.Forms.TextBox text_phone;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox text_code;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.Label identify;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Label tip1;
        private System.Windows.Forms.Label notice;
        private System.Windows.Forms.Label label_newpw;
        private System.Windows.Forms.Label tip3;
    }
}