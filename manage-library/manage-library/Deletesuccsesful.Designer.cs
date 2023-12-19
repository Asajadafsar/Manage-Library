namespace manage_library
{
    partial class Deletesuccsesful
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deletesuccsesful));
            this.Borrow = new System.Windows.Forms.Button();
            this.nameTx = new System.Windows.Forms.TextBox();
            this.NameLb = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.bookTx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Borrow
            // 
            this.Borrow.BackColor = System.Drawing.Color.Tomato;
            this.Borrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Borrow.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrow.ForeColor = System.Drawing.Color.White;
            this.Borrow.Location = new System.Drawing.Point(503, 48);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(127, 40);
            this.Borrow.TabIndex = 90;
            this.Borrow.Text = "Borrow";
            this.Borrow.UseVisualStyleBackColor = false;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // nameTx
            // 
            this.nameTx.Location = new System.Drawing.Point(310, 54);
            this.nameTx.Name = "nameTx";
            this.nameTx.Size = new System.Drawing.Size(164, 20);
            this.nameTx.TabIndex = 88;
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.BackColor = System.Drawing.Color.Transparent;
            this.NameLb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.ForeColor = System.Drawing.Color.White;
            this.NameLb.Location = new System.Drawing.Point(175, 48);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(117, 26);
            this.NameLb.TabIndex = 87;
            this.NameLb.Text = "username:";
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
            this.back.TabIndex = 91;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // bookTx
            // 
            this.bookTx.Location = new System.Drawing.Point(310, 95);
            this.bookTx.Name = "bookTx";
            this.bookTx.Size = new System.Drawing.Size(164, 20);
            this.bookTx.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 92;
            this.label1.Text = "Book Name:";
            // 
            // Deletesuccsesful
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookTx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Borrow);
            this.Controls.Add(this.nameTx);
            this.Controls.Add(this.NameLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deletesuccsesful";
            this.Text = "Deletesuccsesful";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Borrow;
        private System.Windows.Forms.TextBox nameTx;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox bookTx;
        private System.Windows.Forms.Label label1;
    }
}