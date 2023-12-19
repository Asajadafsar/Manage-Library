namespace manage_library
{
    partial class deleteuser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteuser));
            this.deletebtn = new System.Windows.Forms.Button();
            this.usertx = new System.Windows.Forms.TextBox();
            this.userlb = new System.Windows.Forms.Label();
            this.lstuser = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstuser)).BeginInit();
            this.SuspendLayout();
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Tomato;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletebtn.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(547, 23);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(127, 40);
            this.deletebtn.TabIndex = 19;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // usertx
            // 
            this.usertx.Location = new System.Drawing.Point(372, 34);
            this.usertx.Name = "usertx";
            this.usertx.Size = new System.Drawing.Size(164, 20);
            this.usertx.TabIndex = 22;
            this.usertx.TextChanged += new System.EventHandler(this.usertx_TextChanged);
            // 
            // userlb
            // 
            this.userlb.AutoSize = true;
            this.userlb.BackColor = System.Drawing.Color.Transparent;
            this.userlb.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlb.ForeColor = System.Drawing.Color.White;
            this.userlb.Location = new System.Drawing.Point(217, 22);
            this.userlb.Name = "userlb";
            this.userlb.Size = new System.Drawing.Size(149, 37);
            this.userlb.TabIndex = 23;
            this.userlb.Text = "username:";
            this.userlb.Click += new System.EventHandler(this.userlb_Click);
            // 
            // lstuser
            // 
            this.lstuser.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.lstuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.userId,
            this.email,
            this.phone,
            this.address,
            this.city,
            this.age,
            this.nationalid,
            this.gender,
            this.fullname,
            this.data});
            this.lstuser.Location = new System.Drawing.Point(1, 80);
            this.lstuser.Name = "lstuser";
            this.lstuser.ReadOnly = true;
            this.lstuser.Size = new System.Drawing.Size(1149, 438);
            this.lstuser.TabIndex = 24;
            this.lstuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstuser_CellContentClick);
            // 
            // username
            // 
            this.username.HeaderText = "username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // userId
            // 
            this.userId.HeaderText = "userId";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // city
            // 
            this.city.HeaderText = "city";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // age
            // 
            this.age.HeaderText = "age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // nationalid
            // 
            this.nationalid.HeaderText = "nationalid";
            this.nationalid.Name = "nationalid";
            this.nationalid.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.HeaderText = "fullname";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // data
            // 
            this.data.HeaderText = "data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Tomato;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(904, 14);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(127, 40);
            this.back.TabIndex = 25;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // deleteuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.ClientSize = new System.Drawing.Size(1151, 516);
            this.Controls.Add(this.back);
            this.Controls.Add(this.lstuser);
            this.Controls.Add(this.userlb);
            this.Controls.Add(this.usertx);
            this.Controls.Add(this.deletebtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "deleteuser";
            this.Text = "deleteuser";
            this.Load += new System.EventHandler(this.deleteuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.TextBox usertx;
        private System.Windows.Forms.Label userlb;
        private System.Windows.Forms.DataGridView lstuser;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
    }
}