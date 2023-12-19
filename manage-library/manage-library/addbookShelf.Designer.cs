namespace manage_library
{
    partial class addbookShelf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addbookShelf));
            this.NameTx = new System.Windows.Forms.TextBox();
            this.NameLb = new System.Windows.Forms.Label();
            this.orderTx = new System.Windows.Forms.TextBox();
            this.order = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.idR = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTx
            // 
            this.NameTx.Location = new System.Drawing.Point(110, 26);
            this.NameTx.Name = "NameTx";
            this.NameTx.Size = new System.Drawing.Size(164, 20);
            this.NameTx.TabIndex = 25;
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.BackColor = System.Drawing.Color.Transparent;
            this.NameLb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.ForeColor = System.Drawing.Color.White;
            this.NameLb.Location = new System.Drawing.Point(28, 22);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(76, 26);
            this.NameLb.TabIndex = 24;
            this.NameLb.Text = "Name:";
            // 
            // orderTx
            // 
            this.orderTx.Location = new System.Drawing.Point(110, 68);
            this.orderTx.Name = "orderTx";
            this.orderTx.Size = new System.Drawing.Size(164, 20);
            this.orderTx.TabIndex = 27;
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.BackColor = System.Drawing.Color.Transparent;
            this.order.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.White;
            this.order.Location = new System.Drawing.Point(28, 64);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(76, 26);
            this.order.TabIndex = 26;
            this.order.Text = "Order:";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.White;
            this.id.Location = new System.Drawing.Point(37, 120);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(35, 26);
            this.id.TabIndex = 28;
            this.id.Text = "id:";
            // 
            // idR
            // 
            this.idR.AutoSize = true;
            this.idR.BackColor = System.Drawing.Color.Transparent;
            this.idR.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idR.ForeColor = System.Drawing.Color.White;
            this.idR.Location = new System.Drawing.Point(69, 120);
            this.idR.Name = "idR";
            this.idR.Size = new System.Drawing.Size(25, 26);
            this.idR.TabIndex = 29;
            this.idR.Text = "?";
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.Tomato;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.send.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(171, 111);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(127, 40);
            this.send.TabIndex = 52;
            this.send.Text = "send";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
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
            this.back.TabIndex = 53;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // addbookShelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.send);
            this.Controls.Add(this.idR);
            this.Controls.Add(this.id);
            this.Controls.Add(this.orderTx);
            this.Controls.Add(this.order);
            this.Controls.Add(this.NameTx);
            this.Controls.Add(this.NameLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addbookShelf";
            this.Text = "addbookShelf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTx;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.TextBox orderTx;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label idR;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button back;
    }
}