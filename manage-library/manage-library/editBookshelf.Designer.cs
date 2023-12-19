namespace manage_library
{
    partial class editBookshelf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editBookshelf));
            this.Texboxname = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.NameLb = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.orderTx = new System.Windows.Forms.TextBox();
            this.order = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Texboxname
            // 
            this.Texboxname.Location = new System.Drawing.Point(300, 36);
            this.Texboxname.Name = "Texboxname";
            this.Texboxname.Size = new System.Drawing.Size(164, 20);
            this.Texboxname.TabIndex = 79;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Tomato;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(475, 25);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(127, 40);
            this.searchBtn.TabIndex = 78;
            this.searchBtn.Text = "serach";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.BackColor = System.Drawing.Color.Transparent;
            this.NameLb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.ForeColor = System.Drawing.Color.White;
            this.NameLb.Location = new System.Drawing.Point(206, 34);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(76, 26);
            this.NameLb.TabIndex = 77;
            this.NameLb.Text = "Name:";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Tomato;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(12, 398);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(127, 40);
            this.back.TabIndex = 80;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // orderTx
            // 
            this.orderTx.Location = new System.Drawing.Point(157, 120);
            this.orderTx.Name = "orderTx";
            this.orderTx.Size = new System.Drawing.Size(164, 20);
            this.orderTx.TabIndex = 84;
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.BackColor = System.Drawing.Color.Transparent;
            this.order.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.White;
            this.order.Location = new System.Drawing.Point(75, 116);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(76, 26);
            this.order.TabIndex = 83;
            this.order.Text = "Order:";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Tomato;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(337, 107);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(127, 40);
            this.save.TabIndex = 85;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // editBookshelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.orderTx);
            this.Controls.Add(this.order);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Texboxname);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.NameLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editBookshelf";
            this.Text = "editBookshelf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Texboxname;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox orderTx;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Button save;
    }
}