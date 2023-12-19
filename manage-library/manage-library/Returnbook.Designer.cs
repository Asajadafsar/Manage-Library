namespace manage_library
{
    partial class Returnbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Returnbook));
            this.submit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.usernameLb = new System.Windows.Forms.Label();
            this.usernameTx = new System.Windows.Forms.TextBox();
            this.bookTx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Tomato;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(247, 104);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(127, 40);
            this.submit.TabIndex = 53;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Tomato;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(22, 379);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(127, 40);
            this.back.TabIndex = 52;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // usernameLb
            // 
            this.usernameLb.AutoSize = true;
            this.usernameLb.BackColor = System.Drawing.Color.Transparent;
            this.usernameLb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLb.ForeColor = System.Drawing.Color.White;
            this.usernameLb.Location = new System.Drawing.Point(17, 44);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(117, 26);
            this.usernameLb.TabIndex = 54;
            this.usernameLb.Text = "username:";
            // 
            // usernameTx
            // 
            this.usernameTx.Location = new System.Drawing.Point(146, 50);
            this.usernameTx.Name = "usernameTx";
            this.usernameTx.Size = new System.Drawing.Size(164, 20);
            this.usernameTx.TabIndex = 56;
            // 
            // bookTx
            // 
            this.bookTx.Location = new System.Drawing.Point(462, 50);
            this.bookTx.Name = "bookTx";
            this.bookTx.Size = new System.Drawing.Size(164, 20);
            this.bookTx.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(333, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 57;
            this.label1.Text = "bookname:";
            // 
            // Returnbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookTx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTx);
            this.Controls.Add(this.usernameLb);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Returnbook";
            this.Text = "Returnbook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label usernameLb;
        private System.Windows.Forms.TextBox usernameTx;
        private System.Windows.Forms.TextBox bookTx;
        private System.Windows.Forms.Label label1;
    }
}