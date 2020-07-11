namespace ringo
{
    partial class client
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client));
            this.gamelist = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_phone = new System.Windows.Forms.Button();
            this.button_email = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.button_active = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.normal = new System.Windows.Forms.Label();
            this.banned = new System.Windows.Forms.Label();
            this.text_phone = new System.Windows.Forms.TextBox();
            this.text_email = new System.Windows.Forms.TextBox();
            this.button_confirm1 = new System.Windows.Forms.Button();
            this.button_confirm2 = new System.Windows.Forms.Button();
            this.phonechanged = new System.Windows.Forms.Label();
            this.emailchanged = new System.Windows.Forms.Label();
            this.button_pw = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.text_search = new System.Windows.Forms.TextBox();
            this.searchpic = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchpic)).BeginInit();
            this.SuspendLayout();
            // 
            // gamelist
            // 
            resources.ApplyResources(this.gamelist, "gamelist");
            this.gamelist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.gamelist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamelist.ForeColor = System.Drawing.Color.White;
            this.gamelist.FormattingEnabled = true;
            this.gamelist.Name = "gamelist";
            this.gamelist.SelectedIndexChanged += new System.EventHandler(this.gamelist_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            resources.ApplyResources(this.accountToolStripMenuItem, "accountToolStripMenuItem");
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchAccountToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            // 
            // switchAccountToolStripMenuItem
            // 
            resources.ApplyResources(this.switchAccountToolStripMenuItem, "switchAccountToolStripMenuItem");
            this.switchAccountToolStripMenuItem.Name = "switchAccountToolStripMenuItem";
            this.switchAccountToolStripMenuItem.Click += new System.EventHandler(this.switchTheUserToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            resources.ApplyResources(this.logOutToolStripMenuItem, "logOutToolStripMenuItem");
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_phone
            // 
            resources.ApplyResources(this.button_phone, "button_phone");
            this.button_phone.BackColor = System.Drawing.Color.Transparent;
            this.button_phone.Name = "button_phone";
            this.button_phone.UseVisualStyleBackColor = false;
            this.button_phone.Click += new System.EventHandler(this.button_phone_Click);
            // 
            // button_email
            // 
            resources.ApplyResources(this.button_email, "button_email");
            this.button_email.BackColor = System.Drawing.Color.Transparent;
            this.button_email.Name = "button_email";
            this.button_email.UseVisualStyleBackColor = false;
            this.button_email.Click += new System.EventHandler(this.button_email_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // status
            // 
            resources.ApplyResources(this.status, "status");
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Name = "status";
            // 
            // button_active
            // 
            resources.ApplyResources(this.button_active, "button_active");
            this.button_active.BackColor = System.Drawing.Color.Transparent;
            this.button_active.Name = "button_active";
            this.button_active.UseVisualStyleBackColor = false;
            this.button_active.Click += new System.EventHandler(this.button_active_Click);
            // 
            // label_username
            // 
            resources.ApplyResources(this.label_username, "label_username");
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Name = "label_username";
            // 
            // normal
            // 
            resources.ApplyResources(this.normal, "normal");
            this.normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.normal.ForeColor = System.Drawing.Color.Black;
            this.normal.Name = "normal";
            // 
            // banned
            // 
            resources.ApplyResources(this.banned, "banned");
            this.banned.BackColor = System.Drawing.Color.Red;
            this.banned.ForeColor = System.Drawing.Color.White;
            this.banned.Name = "banned";
            // 
            // text_phone
            // 
            resources.ApplyResources(this.text_phone, "text_phone");
            this.text_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.text_phone.ForeColor = System.Drawing.Color.White;
            this.text_phone.Name = "text_phone";
            // 
            // text_email
            // 
            resources.ApplyResources(this.text_email, "text_email");
            this.text_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.text_email.ForeColor = System.Drawing.Color.White;
            this.text_email.Name = "text_email";
            // 
            // button_confirm1
            // 
            resources.ApplyResources(this.button_confirm1, "button_confirm1");
            this.button_confirm1.BackColor = System.Drawing.Color.Transparent;
            this.button_confirm1.Name = "button_confirm1";
            this.button_confirm1.UseVisualStyleBackColor = false;
            this.button_confirm1.Click += new System.EventHandler(this.button_confirm1_Click);
            // 
            // button_confirm2
            // 
            resources.ApplyResources(this.button_confirm2, "button_confirm2");
            this.button_confirm2.BackColor = System.Drawing.Color.Transparent;
            this.button_confirm2.Name = "button_confirm2";
            this.button_confirm2.UseVisualStyleBackColor = false;
            this.button_confirm2.Click += new System.EventHandler(this.button_confirm2_Click);
            // 
            // phonechanged
            // 
            resources.ApplyResources(this.phonechanged, "phonechanged");
            this.phonechanged.BackColor = System.Drawing.Color.Transparent;
            this.phonechanged.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.phonechanged.Name = "phonechanged";
            // 
            // emailchanged
            // 
            resources.ApplyResources(this.emailchanged, "emailchanged");
            this.emailchanged.BackColor = System.Drawing.Color.Transparent;
            this.emailchanged.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.emailchanged.Name = "emailchanged";
            // 
            // button_pw
            // 
            resources.ApplyResources(this.button_pw, "button_pw");
            this.button_pw.BackColor = System.Drawing.Color.Transparent;
            this.button_pw.Name = "button_pw";
            this.button_pw.UseVisualStyleBackColor = false;
            this.button_pw.Click += new System.EventHandler(this.button_pw_Click);
            // 
            // button_delete
            // 
            resources.ApplyResources(this.button_delete, "button_delete");
            this.button_delete.BackColor = System.Drawing.Color.Transparent;
            this.button_delete.Name = "button_delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // text_search
            // 
            resources.ApplyResources(this.text_search, "text_search");
            this.text_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.text_search.ForeColor = System.Drawing.Color.Transparent;
            this.text_search.Name = "text_search";
            this.text_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_search_MouseClick);
            // 
            // searchpic
            // 
            resources.ApplyResources(this.searchpic, "searchpic");
            this.searchpic.BackColor = System.Drawing.Color.Transparent;
            this.searchpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchpic.Name = "searchpic";
            this.searchpic.TabStop = false;
            this.searchpic.Click += new System.EventHandler(this.searchpic_Click);
            // 
            // client
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.searchpic);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_pw);
            this.Controls.Add(this.emailchanged);
            this.Controls.Add(this.phonechanged);
            this.Controls.Add(this.button_confirm2);
            this.Controls.Add(this.button_confirm1);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.text_phone);
            this.Controls.Add(this.banned);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_active);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_email);
            this.Controls.Add(this.button_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gamelist);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "client";
            this.Load += new System.EventHandler(this.client_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox gamelist;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_phone;
        private System.Windows.Forms.Button button_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button_active;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label normal;
        private System.Windows.Forms.Label banned;
        private System.Windows.Forms.TextBox text_phone;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Button button_confirm1;
        private System.Windows.Forms.Button button_confirm2;
        private System.Windows.Forms.Label phonechanged;
        private System.Windows.Forms.Label emailchanged;
        private System.Windows.Forms.Button button_pw;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.PictureBox searchpic;
    }
}