namespace manage_library
{
    partial class tab_admin_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tab_admin_user));
            this.tab = new System.Windows.Forms.TabControl();
            this.admin = new System.Windows.Forms.TabPage();
            this.lbclick = new System.Windows.Forms.Label();
            this.boxuser = new System.Windows.Forms.TextBox();
            this.boxpass = new System.Windows.Forms.TextBox();
            this.btnlog = new System.Windows.Forms.Button();
            this.admintxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.TabPage();
            this.back = new System.Windows.Forms.PictureBox();
            this.clicklb = new System.Windows.Forms.Label();
            this.logbtn = new System.Windows.Forms.Button();
            this.userbox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.admin);
            this.tab.Controls.Add(this.user);
            this.tab.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(-2, -2);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(805, 451);
            this.tab.TabIndex = 0;
            // 
            // admin
            // 
            this.admin.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.admin.Controls.Add(this.lbclick);
            this.admin.Controls.Add(this.boxuser);
            this.admin.Controls.Add(this.boxpass);
            this.admin.Controls.Add(this.btnlog);
            this.admin.Controls.Add(this.admintxt);
            this.admin.Controls.Add(this.pictureBox1);
            this.admin.Location = new System.Drawing.Point(4, 31);
            this.admin.Name = "admin";
            this.admin.Padding = new System.Windows.Forms.Padding(3);
            this.admin.Size = new System.Drawing.Size(797, 416);
            this.admin.TabIndex = 0;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // lbclick
            // 
            this.lbclick.AutoSize = true;
            this.lbclick.BackColor = System.Drawing.Color.Transparent;
            this.lbclick.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclick.ForeColor = System.Drawing.Color.White;
            this.lbclick.Location = new System.Drawing.Point(96, 324);
            this.lbclick.Name = "lbclick";
            this.lbclick.Size = new System.Drawing.Size(127, 30);
            this.lbclick.TabIndex = 15;
            this.lbclick.Text = "User-library";
            this.lbclick.Click += new System.EventHandler(this.lbclick_Click);
            // 
            // boxuser
            // 
            this.boxuser.BackColor = System.Drawing.Color.BlueViolet;
            this.boxuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxuser.Font = new System.Drawing.Font("Pinar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxuser.ForeColor = System.Drawing.Color.White;
            this.boxuser.Location = new System.Drawing.Point(26, 143);
            this.boxuser.Multiline = true;
            this.boxuser.Name = "boxuser";
            this.boxuser.Size = new System.Drawing.Size(274, 33);
            this.boxuser.TabIndex = 14;
            this.boxuser.Tag = "boxuser";
            this.boxuser.Text = "          username";
            // 
            // boxpass
            // 
            this.boxpass.BackColor = System.Drawing.Color.BlueViolet;
            this.boxpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxpass.Font = new System.Drawing.Font("Pinar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxpass.ForeColor = System.Drawing.Color.White;
            this.boxpass.Location = new System.Drawing.Point(26, 197);
            this.boxpass.Multiline = true;
            this.boxpass.Name = "boxpass";
            this.boxpass.Size = new System.Drawing.Size(274, 33);
            this.boxpass.TabIndex = 13;
            this.boxpass.Tag = "boxpass";
            this.boxpass.Text = "         password";
            // 
            // btnlog
            // 
            this.btnlog.BackColor = System.Drawing.Color.White;
            this.btnlog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlog.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnlog.Location = new System.Drawing.Point(29, 285);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(271, 36);
            this.btnlog.TabIndex = 12;
            this.btnlog.Text = "Login";
            this.btnlog.UseVisualStyleBackColor = false;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // admintxt
            // 
            this.admintxt.AutoSize = true;
            this.admintxt.BackColor = System.Drawing.Color.Transparent;
            this.admintxt.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admintxt.ForeColor = System.Drawing.Color.White;
            this.admintxt.Location = new System.Drawing.Point(18, 75);
            this.admintxt.Name = "admintxt";
            this.admintxt.Size = new System.Drawing.Size(171, 65);
            this.admintxt.TabIndex = 11;
            this.admintxt.Text = "admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::manage_library.Properties.Resources._2;
            this.pictureBox1.Image = global::manage_library.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(360, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // user
            // 
            this.user.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.user.Controls.Add(this.back);
            this.user.Controls.Add(this.clicklb);
            this.user.Controls.Add(this.logbtn);
            this.user.Controls.Add(this.userbox);
            this.user.Controls.Add(this.passbox);
            this.user.Controls.Add(this.usertxt);
            this.user.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(4, 31);
            this.user.Name = "user";
            this.user.Padding = new System.Windows.Forms.Padding(3);
            this.user.Size = new System.Drawing.Size(797, 416);
            this.user.TabIndex = 1;
            this.user.Text = "User";
            this.user.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.BackgroundImage = global::manage_library.Properties.Resources._2;
            this.back.Image = global::manage_library.Properties.Resources.background;
            this.back.Location = new System.Drawing.Point(378, -31);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(437, 469);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 13;
            this.back.TabStop = false;
            // 
            // clicklb
            // 
            this.clicklb.AutoSize = true;
            this.clicklb.BackColor = System.Drawing.Color.Transparent;
            this.clicklb.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clicklb.ForeColor = System.Drawing.Color.White;
            this.clicklb.Location = new System.Drawing.Point(118, 302);
            this.clicklb.Name = "clicklb";
            this.clicklb.Size = new System.Drawing.Size(127, 30);
            this.clicklb.TabIndex = 12;
            this.clicklb.Text = "User-library";
            this.clicklb.Click += new System.EventHandler(this.clicklb_Click);
            // 
            // logbtn
            // 
            this.logbtn.BackColor = System.Drawing.Color.White;
            this.logbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.logbtn.Location = new System.Drawing.Point(35, 263);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(271, 36);
            this.logbtn.TabIndex = 11;
            this.logbtn.Text = "Login";
            this.logbtn.UseVisualStyleBackColor = false;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // userbox
            // 
            this.userbox.BackColor = System.Drawing.Color.BlueViolet;
            this.userbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userbox.Font = new System.Drawing.Font("Saba", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbox.ForeColor = System.Drawing.Color.White;
            this.userbox.Location = new System.Drawing.Point(35, 148);
            this.userbox.Multiline = true;
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(274, 33);
            this.userbox.TabIndex = 10;
            this.userbox.Tag = "";
            this.userbox.Text = "          username";
            // 
            // passbox
            // 
            this.passbox.BackColor = System.Drawing.Color.BlueViolet;
            this.passbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passbox.Font = new System.Drawing.Font("Saba", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbox.ForeColor = System.Drawing.Color.White;
            this.passbox.Location = new System.Drawing.Point(38, 197);
            this.passbox.Multiline = true;
            this.passbox.Name = "passbox";
            this.passbox.PasswordChar = '*';
            this.passbox.Size = new System.Drawing.Size(274, 33);
            this.passbox.TabIndex = 9;
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.BackColor = System.Drawing.Color.Transparent;
            this.usertxt.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.ForeColor = System.Drawing.Color.White;
            this.usertxt.Location = new System.Drawing.Point(24, 80);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(129, 65);
            this.usertxt.TabIndex = 2;
            this.usertxt.Text = "User";
            // 
            // tab_admin_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.ClientSize = new System.Drawing.Size(794, 442);
            this.Controls.Add(this.tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tab_admin_user";
            this.Text = "Login";
            this.tab.ResumeLayout(false);
            this.admin.ResumeLayout(false);
            this.admin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.user.ResumeLayout(false);
            this.user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage admin;
        private System.Windows.Forms.TabPage user;
        private System.Windows.Forms.Label lbclick;
        private System.Windows.Forms.TextBox boxuser;
        private System.Windows.Forms.TextBox boxpass;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Label admintxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usertxt;
        private System.Windows.Forms.TextBox userbox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Label clicklb;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.PictureBox back;
    }
}