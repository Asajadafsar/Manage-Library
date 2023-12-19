namespace manage_library
{
    partial class history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(history));
            this.back = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.agelb = new System.Windows.Forms.Label();
            this.usernameTx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.historyLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Tomato;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(22, 398);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(127, 40);
            this.back.TabIndex = 83;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Tomato;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(661, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(127, 40);
            this.save.TabIndex = 82;
            this.save.Text = "search";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // agelb
            // 
            this.agelb.AutoSize = true;
            this.agelb.BackColor = System.Drawing.Color.Transparent;
            this.agelb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agelb.ForeColor = System.Drawing.Color.White;
            this.agelb.Location = new System.Drawing.Point(206, 23);
            this.agelb.Name = "agelb";
            this.agelb.Size = new System.Drawing.Size(117, 26);
            this.agelb.TabIndex = 81;
            this.agelb.Text = "username:";
            // 
            // usernameTx
            // 
            this.usernameTx.Location = new System.Drawing.Point(340, 27);
            this.usernameTx.Name = "usernameTx";
            this.usernameTx.Size = new System.Drawing.Size(164, 20);
            this.usernameTx.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 85;
            this.label1.Text = "history Borrow:";
            // 
            // historyLb
            // 
            this.historyLb.AutoSize = true;
            this.historyLb.BackColor = System.Drawing.Color.Transparent;
            this.historyLb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyLb.ForeColor = System.Drawing.Color.White;
            this.historyLb.Location = new System.Drawing.Point(206, 88);
            this.historyLb.Name = "historyLb";
            this.historyLb.Size = new System.Drawing.Size(25, 26);
            this.historyLb.TabIndex = 86;
            this.historyLb.Text = "?";
            // 
            // history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historyLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTx);
            this.Controls.Add(this.back);
            this.Controls.Add(this.save);
            this.Controls.Add(this.agelb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "history";
            this.Text = "history";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label agelb;
        private System.Windows.Forms.TextBox usernameTx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label historyLb;
    }
}