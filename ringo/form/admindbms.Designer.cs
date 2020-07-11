namespace ringo
{
    partial class admindbms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admindbms));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usermanage = new System.Windows.Forms.Label();
            this.gamemanage = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gamedata = new System.Windows.Forms.DataGridView();
            this.userdata = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.Label();
            this.text_addgame = new System.Windows.Forms.TextBox();
            this.button_addgame = new System.Windows.Forms.Button();
            this.admindata = new System.Windows.Forms.DataGridView();
            this.adminmanage = new System.Windows.Forms.Label();
            this.button_deleteadmin = new System.Windows.Forms.Button();
            this.button_banuser = new System.Windows.Forms.Button();
            this.button_addnewadmin = new System.Windows.Forms.Button();
            this.button_setleader = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.text_un = new System.Windows.Forms.TextBox();
            this.text_pw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_confirminfo = new System.Windows.Forms.Button();
            this.button_deletegame = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.ComboBox();
            this.searchpic = new System.Windows.Forms.PictureBox();
            this.searchadmin = new System.Windows.Forms.PictureBox();
            this.adminsearch = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamedata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admindata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchadmin)).BeginInit();
            this.SuspendLayout();
            // 
            // usermanage
            // 
            resources.ApplyResources(this.usermanage, "usermanage");
            this.usermanage.BackColor = System.Drawing.Color.Transparent;
            this.usermanage.Name = "usermanage";
            // 
            // gamemanage
            // 
            resources.ApplyResources(this.gamemanage, "gamemanage");
            this.gamemanage.BackColor = System.Drawing.Color.Transparent;
            this.gamemanage.Name = "gamemanage";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
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
            this.changeAccountToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            // 
            // changeAccountToolStripMenuItem
            // 
            resources.ApplyResources(this.changeAccountToolStripMenuItem, "changeAccountToolStripMenuItem");
            this.changeAccountToolStripMenuItem.Name = "changeAccountToolStripMenuItem";
            this.changeAccountToolStripMenuItem.Click += new System.EventHandler(this.changeAccountToolStripMenuItem_Click);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gamedata
            // 
            resources.ApplyResources(this.gamedata, "gamedata");
            this.gamedata.AllowUserToAddRows = false;
            this.gamedata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gamedata.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gamedata.Name = "gamedata";
            this.gamedata.ReadOnly = true;
            this.gamedata.RowHeadersVisible = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gamedata.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gamedata.RowTemplate.Height = 30;
            this.gamedata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // userdata
            // 
            resources.ApplyResources(this.userdata, "userdata");
            this.userdata.AllowUserToAddRows = false;
            this.userdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.userdata.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.userdata.Name = "userdata";
            this.userdata.ReadOnly = true;
            this.userdata.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.userdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.userdata.RowTemplate.Height = 31;
            this.userdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // username
            // 
            resources.ApplyResources(this.username, "username");
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Name = "username";
            // 
            // text_addgame
            // 
            resources.ApplyResources(this.text_addgame, "text_addgame");
            this.text_addgame.Name = "text_addgame";
            this.text_addgame.TextChanged += new System.EventHandler(this.text_addgame_TextChanged);
            // 
            // button_addgame
            // 
            resources.ApplyResources(this.button_addgame, "button_addgame");
            this.button_addgame.BackColor = System.Drawing.Color.Transparent;
            this.button_addgame.Name = "button_addgame";
            this.button_addgame.UseVisualStyleBackColor = false;
            this.button_addgame.Click += new System.EventHandler(this.button_addgame_Click);
            // 
            // admindata
            // 
            resources.ApplyResources(this.admindata, "admindata");
            this.admindata.AllowUserToAddRows = false;
            this.admindata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.admindata.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.admindata.Name = "admindata";
            this.admindata.ReadOnly = true;
            this.admindata.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.admindata.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.admindata.RowTemplate.Height = 30;
            this.admindata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.admindata.SelectionChanged += new System.EventHandler(this.admindata_SelectionChanged);
            // 
            // adminmanage
            // 
            resources.ApplyResources(this.adminmanage, "adminmanage");
            this.adminmanage.BackColor = System.Drawing.Color.Transparent;
            this.adminmanage.Name = "adminmanage";
            // 
            // button_deleteadmin
            // 
            resources.ApplyResources(this.button_deleteadmin, "button_deleteadmin");
            this.button_deleteadmin.BackColor = System.Drawing.Color.Transparent;
            this.button_deleteadmin.Name = "button_deleteadmin";
            this.button_deleteadmin.UseVisualStyleBackColor = false;
            this.button_deleteadmin.Click += new System.EventHandler(this.button_deleteadmin_Click);
            // 
            // button_banuser
            // 
            resources.ApplyResources(this.button_banuser, "button_banuser");
            this.button_banuser.BackColor = System.Drawing.Color.Transparent;
            this.button_banuser.Name = "button_banuser";
            this.button_banuser.UseVisualStyleBackColor = false;
            this.button_banuser.Click += new System.EventHandler(this.button_banuser_Click);
            // 
            // button_addnewadmin
            // 
            resources.ApplyResources(this.button_addnewadmin, "button_addnewadmin");
            this.button_addnewadmin.BackColor = System.Drawing.Color.Transparent;
            this.button_addnewadmin.Name = "button_addnewadmin";
            this.button_addnewadmin.UseVisualStyleBackColor = false;
            this.button_addnewadmin.Click += new System.EventHandler(this.button_addnewadmin_Click);
            // 
            // button_setleader
            // 
            resources.ApplyResources(this.button_setleader, "button_setleader");
            this.button_setleader.BackColor = System.Drawing.Color.Transparent;
            this.button_setleader.Name = "button_setleader";
            this.button_setleader.UseVisualStyleBackColor = false;
            this.button_setleader.Click += new System.EventHandler(this.button_setleader_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Name = "label11";
            // 
            // text_un
            // 
            resources.ApplyResources(this.text_un, "text_un");
            this.text_un.Name = "text_un";
            this.text_un.TextChanged += new System.EventHandler(this.text_un_TextChanged);
            // 
            // text_pw
            // 
            resources.ApplyResources(this.text_pw, "text_pw");
            this.text_pw.Name = "text_pw";
            this.text_pw.TextChanged += new System.EventHandler(this.text_pw_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // button_confirminfo
            // 
            resources.ApplyResources(this.button_confirminfo, "button_confirminfo");
            this.button_confirminfo.BackColor = System.Drawing.Color.Transparent;
            this.button_confirminfo.Name = "button_confirminfo";
            this.button_confirminfo.UseVisualStyleBackColor = false;
            this.button_confirminfo.Click += new System.EventHandler(this.button_confirminfo_Click);
            // 
            // button_deletegame
            // 
            resources.ApplyResources(this.button_deletegame, "button_deletegame");
            this.button_deletegame.BackColor = System.Drawing.Color.Transparent;
            this.button_deletegame.Name = "button_deletegame";
            this.button_deletegame.UseVisualStyleBackColor = false;
            this.button_deletegame.Click += new System.EventHandler(this.button_deletegame_Click);
            // 
            // search
            // 
            resources.ApplyResources(this.search, "search");
            this.search.Name = "search";
            // 
            // table
            // 
            resources.ApplyResources(this.table, "table");
            this.table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.table.FormattingEnabled = true;
            this.table.Items.AddRange(new object[] {
            resources.GetString("table.Items"),
            resources.GetString("table.Items1")});
            this.table.Name = "table";
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
            // searchadmin
            // 
            resources.ApplyResources(this.searchadmin, "searchadmin");
            this.searchadmin.BackColor = System.Drawing.Color.Transparent;
            this.searchadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchadmin.Name = "searchadmin";
            this.searchadmin.TabStop = false;
            this.searchadmin.Click += new System.EventHandler(this.searchadmin_Click);
            // 
            // adminsearch
            // 
            resources.ApplyResources(this.adminsearch, "adminsearch");
            this.adminsearch.Name = "adminsearch";
            // 
            // admindbms
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.searchadmin);
            this.Controls.Add(this.adminsearch);
            this.Controls.Add(this.searchpic);
            this.Controls.Add(this.table);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button_deletegame);
            this.Controls.Add(this.button_confirminfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_pw);
            this.Controls.Add(this.text_un);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button_setleader);
            this.Controls.Add(this.button_addnewadmin);
            this.Controls.Add(this.button_banuser);
            this.Controls.Add(this.button_deleteadmin);
            this.Controls.Add(this.admindata);
            this.Controls.Add(this.adminmanage);
            this.Controls.Add(this.button_addgame);
            this.Controls.Add(this.text_addgame);
            this.Controls.Add(this.username);
            this.Controls.Add(this.userdata);
            this.Controls.Add(this.gamedata);
            this.Controls.Add(this.gamemanage);
            this.Controls.Add(this.usermanage);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "admindbms";
            this.Load += new System.EventHandler(this.adminums_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamedata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admindata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchadmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usermanage;
        private System.Windows.Forms.Label gamemanage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView gamedata;
        private System.Windows.Forms.DataGridView userdata;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox text_addgame;
        private System.Windows.Forms.Button button_addgame;
        private System.Windows.Forms.DataGridView admindata;
        private System.Windows.Forms.Label adminmanage;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button_deleteadmin;
        private System.Windows.Forms.Button button_banuser;
        private System.Windows.Forms.Button button_addnewadmin;
        private System.Windows.Forms.Button button_setleader;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_un;
        private System.Windows.Forms.TextBox text_pw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_confirminfo;
        private System.Windows.Forms.Button button_deletegame;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ComboBox table;
        private System.Windows.Forms.PictureBox searchpic;
        private System.Windows.Forms.PictureBox searchadmin;
        private System.Windows.Forms.TextBox adminsearch;
    }
}