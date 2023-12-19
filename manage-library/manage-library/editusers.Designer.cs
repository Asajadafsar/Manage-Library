namespace manage_library
{
    partial class editusers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editusers));
            this.userlb = new System.Windows.Forms.Label();
            this.usertx = new System.Windows.Forms.TextBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.datlb = new System.Windows.Forms.Label();
            this.genderlb = new System.Windows.Forms.Label();
            this.agelb = new System.Windows.Forms.Label();
            this.addresslb = new System.Windows.Forms.Label();
            this.citylb = new System.Windows.Forms.Label();
            this.nationalidtx = new System.Windows.Forms.TextBox();
            this.Nationalidlb = new System.Windows.Forms.Label();
            this.emailtx = new System.Windows.Forms.TextBox();
            this.emaillb = new System.Windows.Forms.Label();
            this.phonetx = new System.Windows.Forms.TextBox();
            this.phonelb = new System.Windows.Forms.Label();
            this.fulltx = new System.Windows.Forms.TextBox();
            this.fulllb = new System.Windows.Forms.Label();
            this.citytx = new System.Windows.Forms.TextBox();
            this.agetx = new System.Windows.Forms.TextBox();
            this.gendertx = new System.Windows.Forms.TextBox();
            this.datatx = new System.Windows.Forms.TextBox();
            this.rtltx = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.passtx = new System.Windows.Forms.TextBox();
            this.passlb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userlb
            // 
            this.userlb.AutoSize = true;
            this.userlb.BackColor = System.Drawing.Color.Transparent;
            this.userlb.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlb.ForeColor = System.Drawing.Color.White;
            this.userlb.Location = new System.Drawing.Point(151, 24);
            this.userlb.Name = "userlb";
            this.userlb.Size = new System.Drawing.Size(149, 37);
            this.userlb.TabIndex = 26;
            this.userlb.Text = "username:";
            // 
            // usertx
            // 
            this.usertx.Location = new System.Drawing.Point(306, 36);
            this.usertx.Name = "usertx";
            this.usertx.Size = new System.Drawing.Size(164, 20);
            this.usertx.TabIndex = 25;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Tomato;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletebtn.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(481, 25);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(127, 40);
            this.deletebtn.TabIndex = 24;
            this.deletebtn.Text = "serach";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Tomato;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(516, 312);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(127, 40);
            this.save.TabIndex = 74;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // datlb
            // 
            this.datlb.AutoSize = true;
            this.datlb.BackColor = System.Drawing.Color.Transparent;
            this.datlb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datlb.ForeColor = System.Drawing.Color.White;
            this.datlb.Location = new System.Drawing.Point(31, 306);
            this.datlb.Name = "datlb";
            this.datlb.Size = new System.Drawing.Size(212, 26);
            this.datlb.TabIndex = 68;
            this.datlb.Text = "DateOfMembership:";
            // 
            // genderlb
            // 
            this.genderlb.AutoSize = true;
            this.genderlb.BackColor = System.Drawing.Color.Transparent;
            this.genderlb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlb.ForeColor = System.Drawing.Color.White;
            this.genderlb.Location = new System.Drawing.Point(31, 266);
            this.genderlb.Name = "genderlb";
            this.genderlb.Size = new System.Drawing.Size(90, 26);
            this.genderlb.TabIndex = 67;
            this.genderlb.Text = "Gender:";
            // 
            // agelb
            // 
            this.agelb.AutoSize = true;
            this.agelb.BackColor = System.Drawing.Color.Transparent;
            this.agelb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agelb.ForeColor = System.Drawing.Color.White;
            this.agelb.Location = new System.Drawing.Point(33, 182);
            this.agelb.Name = "agelb";
            this.agelb.Size = new System.Drawing.Size(54, 26);
            this.agelb.TabIndex = 66;
            this.agelb.Text = "age:";
            // 
            // addresslb
            // 
            this.addresslb.AutoSize = true;
            this.addresslb.BackColor = System.Drawing.Color.Transparent;
            this.addresslb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslb.ForeColor = System.Drawing.Color.White;
            this.addresslb.Location = new System.Drawing.Point(309, 223);
            this.addresslb.Name = "addresslb";
            this.addresslb.Size = new System.Drawing.Size(97, 26);
            this.addresslb.TabIndex = 65;
            this.addresslb.Text = "address:";
            // 
            // citylb
            // 
            this.citylb.AutoSize = true;
            this.citylb.BackColor = System.Drawing.Color.Transparent;
            this.citylb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citylb.ForeColor = System.Drawing.Color.White;
            this.citylb.Location = new System.Drawing.Point(31, 223);
            this.citylb.Name = "citylb";
            this.citylb.Size = new System.Drawing.Size(56, 26);
            this.citylb.TabIndex = 64;
            this.citylb.Text = "City:";
            // 
            // nationalidtx
            // 
            this.nationalidtx.Location = new System.Drawing.Point(419, 199);
            this.nationalidtx.Name = "nationalidtx";
            this.nationalidtx.Size = new System.Drawing.Size(164, 20);
            this.nationalidtx.TabIndex = 63;
            // 
            // Nationalidlb
            // 
            this.Nationalidlb.AutoSize = true;
            this.Nationalidlb.BackColor = System.Drawing.Color.Transparent;
            this.Nationalidlb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nationalidlb.ForeColor = System.Drawing.Color.White;
            this.Nationalidlb.Location = new System.Drawing.Point(295, 197);
            this.Nationalidlb.Name = "Nationalidlb";
            this.Nationalidlb.Size = new System.Drawing.Size(118, 26);
            this.Nationalidlb.TabIndex = 62;
            this.Nationalidlb.Text = "Nationalid:";
            // 
            // emailtx
            // 
            this.emailtx.Location = new System.Drawing.Point(421, 167);
            this.emailtx.Name = "emailtx";
            this.emailtx.Size = new System.Drawing.Size(164, 20);
            this.emailtx.TabIndex = 61;
            // 
            // emaillb
            // 
            this.emaillb.AutoSize = true;
            this.emaillb.BackColor = System.Drawing.Color.Transparent;
            this.emaillb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillb.ForeColor = System.Drawing.Color.White;
            this.emaillb.Location = new System.Drawing.Point(344, 167);
            this.emaillb.Name = "emaillb";
            this.emaillb.Size = new System.Drawing.Size(71, 26);
            this.emaillb.TabIndex = 60;
            this.emaillb.Text = "email:";
            // 
            // phonetx
            // 
            this.phonetx.Location = new System.Drawing.Point(421, 141);
            this.phonetx.Name = "phonetx";
            this.phonetx.Size = new System.Drawing.Size(164, 20);
            this.phonetx.TabIndex = 59;
            // 
            // phonelb
            // 
            this.phonelb.AutoSize = true;
            this.phonelb.BackColor = System.Drawing.Color.Transparent;
            this.phonelb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelb.ForeColor = System.Drawing.Color.White;
            this.phonelb.Location = new System.Drawing.Point(337, 141);
            this.phonelb.Name = "phonelb";
            this.phonelb.Size = new System.Drawing.Size(78, 26);
            this.phonelb.TabIndex = 58;
            this.phonelb.Text = "phone:";
            // 
            // fulltx
            // 
            this.fulltx.Location = new System.Drawing.Point(419, 104);
            this.fulltx.Name = "fulltx";
            this.fulltx.Size = new System.Drawing.Size(164, 20);
            this.fulltx.TabIndex = 57;
            // 
            // fulllb
            // 
            this.fulllb.AutoSize = true;
            this.fulllb.BackColor = System.Drawing.Color.Transparent;
            this.fulllb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fulllb.ForeColor = System.Drawing.Color.White;
            this.fulllb.Location = new System.Drawing.Point(309, 98);
            this.fulllb.Name = "fulllb";
            this.fulllb.Size = new System.Drawing.Size(104, 26);
            this.fulllb.TabIndex = 56;
            this.fulllb.Text = "fullname:";
            // 
            // citytx
            // 
            this.citytx.Location = new System.Drawing.Point(93, 228);
            this.citytx.Name = "citytx";
            this.citytx.Size = new System.Drawing.Size(164, 20);
            this.citytx.TabIndex = 75;
            // 
            // agetx
            // 
            this.agetx.Location = new System.Drawing.Point(93, 188);
            this.agetx.Name = "agetx";
            this.agetx.Size = new System.Drawing.Size(164, 20);
            this.agetx.TabIndex = 76;
            // 
            // gendertx
            // 
            this.gendertx.Location = new System.Drawing.Point(127, 272);
            this.gendertx.Name = "gendertx";
            this.gendertx.Size = new System.Drawing.Size(164, 20);
            this.gendertx.TabIndex = 77;
            // 
            // datatx
            // 
            this.datatx.Location = new System.Drawing.Point(251, 312);
            this.datatx.Name = "datatx";
            this.datatx.Size = new System.Drawing.Size(244, 20);
            this.datatx.TabIndex = 78;
            // 
            // rtltx
            // 
            this.rtltx.Location = new System.Drawing.Point(412, 229);
            this.rtltx.Multiline = true;
            this.rtltx.Name = "rtltx";
            this.rtltx.Size = new System.Drawing.Size(164, 63);
            this.rtltx.TabIndex = 79;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Tomato;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(38, 365);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(127, 40);
            this.back.TabIndex = 80;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // passtx
            // 
            this.passtx.Location = new System.Drawing.Point(149, 127);
            this.passtx.Name = "passtx";
            this.passtx.PasswordChar = '*';
            this.passtx.Size = new System.Drawing.Size(164, 20);
            this.passtx.TabIndex = 82;
            // 
            // passlb
            // 
            this.passlb.AutoSize = true;
            this.passlb.BackColor = System.Drawing.Color.Transparent;
            this.passlb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlb.ForeColor = System.Drawing.Color.White;
            this.passlb.Location = new System.Drawing.Point(27, 121);
            this.passlb.Name = "passlb";
            this.passlb.Size = new System.Drawing.Size(116, 26);
            this.passlb.TabIndex = 81;
            this.passlb.Text = "password:";
            // 
            // editusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passtx);
            this.Controls.Add(this.passlb);
            this.Controls.Add(this.back);
            this.Controls.Add(this.rtltx);
            this.Controls.Add(this.datatx);
            this.Controls.Add(this.gendertx);
            this.Controls.Add(this.agetx);
            this.Controls.Add(this.citytx);
            this.Controls.Add(this.save);
            this.Controls.Add(this.datlb);
            this.Controls.Add(this.genderlb);
            this.Controls.Add(this.agelb);
            this.Controls.Add(this.addresslb);
            this.Controls.Add(this.citylb);
            this.Controls.Add(this.nationalidtx);
            this.Controls.Add(this.Nationalidlb);
            this.Controls.Add(this.emailtx);
            this.Controls.Add(this.emaillb);
            this.Controls.Add(this.phonetx);
            this.Controls.Add(this.phonelb);
            this.Controls.Add(this.fulltx);
            this.Controls.Add(this.fulllb);
            this.Controls.Add(this.userlb);
            this.Controls.Add(this.usertx);
            this.Controls.Add(this.deletebtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editusers";
            this.Text = "editusers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userlb;
        private System.Windows.Forms.TextBox usertx;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label datlb;
        private System.Windows.Forms.Label genderlb;
        private System.Windows.Forms.Label agelb;
        private System.Windows.Forms.Label addresslb;
        private System.Windows.Forms.Label citylb;
        private System.Windows.Forms.TextBox nationalidtx;
        private System.Windows.Forms.Label Nationalidlb;
        private System.Windows.Forms.TextBox emailtx;
        private System.Windows.Forms.Label emaillb;
        private System.Windows.Forms.TextBox phonetx;
        private System.Windows.Forms.Label phonelb;
        private System.Windows.Forms.TextBox fulltx;
        private System.Windows.Forms.Label fulllb;
        private System.Windows.Forms.TextBox citytx;
        private System.Windows.Forms.TextBox agetx;
        private System.Windows.Forms.TextBox gendertx;
        private System.Windows.Forms.TextBox datatx;
        private System.Windows.Forms.TextBox rtltx;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox passtx;
        private System.Windows.Forms.Label passlb;
    }
}