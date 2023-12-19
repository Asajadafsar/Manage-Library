namespace manage_library
{
    partial class Mainuser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainuser));
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debtBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.idLB = new System.Windows.Forms.Label();
            this.usernameLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.admintxt = new System.Windows.Forms.Label();
            this.FullnameLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneLb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailLb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NationalidLB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CityLb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressLb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AgeLb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GenderLb = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataLb = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qustionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.depositsToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(800, 28);
            this.menu1.TabIndex = 17;
            this.menu1.Text = "menu1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.usersToolStripMenuItem.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.usersToolStripMenuItem.Text = "Edit Profile";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.booksToolStripMenuItem.Text = "Search Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // depositsToolStripMenuItem
            // 
            this.depositsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debtBookToolStripMenuItem,
            this.returnBooksToolStripMenuItem});
            this.depositsToolStripMenuItem.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.depositsToolStripMenuItem.Name = "depositsToolStripMenuItem";
            this.depositsToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.depositsToolStripMenuItem.Text = "deposits";
            // 
            // debtBookToolStripMenuItem
            // 
            this.debtBookToolStripMenuItem.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.debtBookToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.debtBookToolStripMenuItem.Name = "debtBookToolStripMenuItem";
            this.debtBookToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.debtBookToolStripMenuItem.Text = "Debt Book";
            this.debtBookToolStripMenuItem.Click += new System.EventHandler(this.debtBookToolStripMenuItem_Click);
            // 
            // returnBooksToolStripMenuItem
            // 
            this.returnBooksToolStripMenuItem.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.returnBooksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.returnBooksToolStripMenuItem.Text = "Return Books";
            this.returnBooksToolStripMenuItem.Click += new System.EventHandler(this.returnBooksToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(26, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idLB
            // 
            this.idLB.AutoSize = true;
            this.idLB.BackColor = System.Drawing.Color.Transparent;
            this.idLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLB.ForeColor = System.Drawing.Color.SpringGreen;
            this.idLB.Location = new System.Drawing.Point(142, 128);
            this.idLB.Name = "idLB";
            this.idLB.Size = new System.Drawing.Size(29, 25);
            this.idLB.TabIndex = 24;
            this.idLB.Text = "id";
            // 
            // usernameLb
            // 
            this.usernameLb.AutoSize = true;
            this.usernameLb.BackColor = System.Drawing.Color.Transparent;
            this.usernameLb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLb.ForeColor = System.Drawing.Color.SpringGreen;
            this.usernameLb.Location = new System.Drawing.Point(240, 94);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(99, 25);
            this.usernameLb.TabIndex = 23;
            this.usernameLb.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "id:";
            // 
            // admintxt
            // 
            this.admintxt.AutoSize = true;
            this.admintxt.BackColor = System.Drawing.Color.Transparent;
            this.admintxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admintxt.ForeColor = System.Drawing.Color.White;
            this.admintxt.Location = new System.Drawing.Point(97, 84);
            this.admintxt.Name = "admintxt";
            this.admintxt.Size = new System.Drawing.Size(149, 37);
            this.admintxt.TabIndex = 21;
            this.admintxt.Text = "username:";
            // 
            // FullnameLB
            // 
            this.FullnameLB.AutoSize = true;
            this.FullnameLB.BackColor = System.Drawing.Color.Transparent;
            this.FullnameLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullnameLB.ForeColor = System.Drawing.Color.SpringGreen;
            this.FullnameLB.Location = new System.Drawing.Point(242, 166);
            this.FullnameLB.Name = "FullnameLB";
            this.FullnameLB.Size = new System.Drawing.Size(93, 25);
            this.FullnameLB.TabIndex = 26;
            this.FullnameLB.Text = "Fullname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(99, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 37);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fullname:";
            // 
            // PhoneLb
            // 
            this.PhoneLb.AutoSize = true;
            this.PhoneLb.BackColor = System.Drawing.Color.Transparent;
            this.PhoneLb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLb.ForeColor = System.Drawing.Color.SpringGreen;
            this.PhoneLb.Location = new System.Drawing.Point(210, 204);
            this.PhoneLb.Name = "PhoneLb";
            this.PhoneLb.Size = new System.Drawing.Size(69, 25);
            this.PhoneLb.TabIndex = 28;
            this.PhoneLb.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(99, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 37);
            this.label4.TabIndex = 27;
            this.label4.Text = "Phone:";
            // 
            // EmailLb
            // 
            this.EmailLb.AutoSize = true;
            this.EmailLb.BackColor = System.Drawing.Color.Transparent;
            this.EmailLb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLb.ForeColor = System.Drawing.Color.SpringGreen;
            this.EmailLb.Location = new System.Drawing.Point(495, 91);
            this.EmailLb.Name = "EmailLb";
            this.EmailLb.Size = new System.Drawing.Size(59, 25);
            this.EmailLb.TabIndex = 30;
            this.EmailLb.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(409, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 37);
            this.label5.TabIndex = 29;
            this.label5.Text = "Email:";
            // 
            // NationalidLB
            // 
            this.NationalidLB.AutoSize = true;
            this.NationalidLB.BackColor = System.Drawing.Color.Transparent;
            this.NationalidLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalidLB.ForeColor = System.Drawing.Color.SpringGreen;
            this.NationalidLB.Location = new System.Drawing.Point(552, 141);
            this.NationalidLB.Name = "NationalidLB";
            this.NationalidLB.Size = new System.Drawing.Size(105, 25);
            this.NationalidLB.TabIndex = 32;
            this.NationalidLB.Text = "Nationalid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(399, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 37);
            this.label7.TabIndex = 31;
            this.label7.Text = "Nationalid:";
            // 
            // CityLb
            // 
            this.CityLb.AutoSize = true;
            this.CityLb.BackColor = System.Drawing.Color.Transparent;
            this.CityLb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLb.ForeColor = System.Drawing.Color.SpringGreen;
            this.CityLb.Location = new System.Drawing.Point(471, 188);
            this.CityLb.Name = "CityLb";
            this.CityLb.Size = new System.Drawing.Size(46, 25);
            this.CityLb.TabIndex = 34;
            this.CityLb.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(399, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 37);
            this.label6.TabIndex = 33;
            this.label6.Text = "City:";
            // 
            // AddressLb
            // 
            this.AddressLb.AutoSize = true;
            this.AddressLb.BackColor = System.Drawing.Color.Transparent;
            this.AddressLb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLb.ForeColor = System.Drawing.Color.SpringGreen;
            this.AddressLb.Location = new System.Drawing.Point(232, 257);
            this.AddressLb.Name = "AddressLb";
            this.AddressLb.Size = new System.Drawing.Size(83, 25);
            this.AddressLb.TabIndex = 36;
            this.AddressLb.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(99, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 37);
            this.label8.TabIndex = 35;
            this.label8.Text = "Address:";
            // 
            // AgeLb
            // 
            this.AgeLb.AutoSize = true;
            this.AgeLb.BackColor = System.Drawing.Color.Transparent;
            this.AgeLb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLb.ForeColor = System.Drawing.Color.SpringGreen;
            this.AgeLb.Location = new System.Drawing.Point(451, 253);
            this.AgeLb.Name = "AgeLb";
            this.AgeLb.Size = new System.Drawing.Size(47, 25);
            this.AgeLb.TabIndex = 38;
            this.AgeLb.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(376, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 37);
            this.label9.TabIndex = 37;
            this.label9.Text = "Age:";
            // 
            // GenderLb
            // 
            this.GenderLb.AutoSize = true;
            this.GenderLb.BackColor = System.Drawing.Color.Transparent;
            this.GenderLb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLb.ForeColor = System.Drawing.Color.SpringGreen;
            this.GenderLb.Location = new System.Drawing.Point(212, 307);
            this.GenderLb.Name = "GenderLb";
            this.GenderLb.Size = new System.Drawing.Size(78, 25);
            this.GenderLb.TabIndex = 40;
            this.GenderLb.Text = "Gender";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(99, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 37);
            this.label11.TabIndex = 39;
            this.label11.Text = "Gender:";
            // 
            // dataLb
            // 
            this.dataLb.AutoSize = true;
            this.dataLb.BackColor = System.Drawing.Color.Transparent;
            this.dataLb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLb.ForeColor = System.Drawing.Color.SpringGreen;
            this.dataLb.Location = new System.Drawing.Point(517, 353);
            this.dataLb.Name = "dataLb";
            this.dataLb.Size = new System.Drawing.Size(185, 25);
            this.dataLb.TabIndex = 44;
            this.dataLb.Text = "DateOfMembership";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(240, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(277, 37);
            this.label13.TabIndex = 43;
            this.label13.Text = "DateOfMembership:";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qustionToolStripMenuItem});
            this.systemToolStripMenuItem.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.systemToolStripMenuItem.Text = "system";
            // 
            // qustionToolStripMenuItem
            // 
            this.qustionToolStripMenuItem.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.qustionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.qustionToolStripMenuItem.Name = "qustionToolStripMenuItem";
            this.qustionToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.qustionToolStripMenuItem.Text = "Qustion";
            this.qustionToolStripMenuItem.Click += new System.EventHandler(this.qustionToolStripMenuItem_Click);
            // 
            // Mainuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataLb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.GenderLb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AgeLb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AddressLb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CityLb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NationalidLB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmailLb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FullnameLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idLB);
            this.Controls.Add(this.usernameLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admintxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainuser";
            this.Text = "Mainuser";
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label idLB;
        private System.Windows.Forms.Label usernameLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label admintxt;
        private System.Windows.Forms.Label FullnameLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PhoneLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EmailLb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NationalidLB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CityLb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AddressLb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label AgeLb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label GenderLb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label dataLb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem debtBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qustionToolStripMenuItem;
    }
}