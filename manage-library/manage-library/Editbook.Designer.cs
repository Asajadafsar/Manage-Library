namespace manage_library
{
    partial class Editbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editbook));
            this.Upload = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.unavailable = new System.Windows.Forms.RadioButton();
            this.Available = new System.Windows.Forms.RadioButton();
            this.CreatedAtTDat = new System.Windows.Forms.DateTimePicker();
            this.CreatedAtLb = new System.Windows.Forms.Label();
            this.BookshelfCom = new System.Windows.Forms.ComboBox();
            this.BookshelfLb = new System.Windows.Forms.Label();
            this.publisherTx = new System.Windows.Forms.TextBox();
            this.publisherLb = new System.Windows.Forms.Label();
            this.PriceTx = new System.Windows.Forms.TextBox();
            this.PriceLb = new System.Windows.Forms.Label();
            this.AuthorTx = new System.Windows.Forms.TextBox();
            this.AuthorLb = new System.Windows.Forms.Label();
            this.imageBook = new System.Windows.Forms.PictureBox();
            this.CodeTx = new System.Windows.Forms.TextBox();
            this.CodeLb = new System.Windows.Forms.Label();
            this.NameLb = new System.Windows.Forms.Label();
            this.Texboxname = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.UpdatedAtTDat = new System.Windows.Forms.DateTimePicker();
            this.UpdatedAtLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).BeginInit();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.BackColor = System.Drawing.Color.Tomato;
            this.Upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Upload.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.ForeColor = System.Drawing.Color.White;
            this.Upload.Location = new System.Drawing.Point(641, 375);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(127, 40);
            this.Upload.TabIndex = 74;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = false;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Tomato;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(426, 332);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(127, 40);
            this.save.TabIndex = 73;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Tomato;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(41, 390);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(127, 40);
            this.back.TabIndex = 72;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // unavailable
            // 
            this.unavailable.AutoSize = true;
            this.unavailable.BackColor = System.Drawing.Color.Transparent;
            this.unavailable.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unavailable.ForeColor = System.Drawing.Color.Yellow;
            this.unavailable.Location = new System.Drawing.Point(164, 209);
            this.unavailable.Name = "unavailable";
            this.unavailable.Size = new System.Drawing.Size(124, 26);
            this.unavailable.TabIndex = 71;
            this.unavailable.TabStop = true;
            this.unavailable.Text = "unavailable";
            this.unavailable.UseVisualStyleBackColor = false;
            // 
            // Available
            // 
            this.Available.AutoSize = true;
            this.Available.BackColor = System.Drawing.Color.Transparent;
            this.Available.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available.ForeColor = System.Drawing.Color.Yellow;
            this.Available.Location = new System.Drawing.Point(35, 194);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(106, 26);
            this.Available.TabIndex = 70;
            this.Available.TabStop = true;
            this.Available.Text = "Available";
            this.Available.UseVisualStyleBackColor = false;
            // 
            // CreatedAtTDat
            // 
            this.CreatedAtTDat.Location = new System.Drawing.Point(153, 338);
            this.CreatedAtTDat.Name = "CreatedAtTDat";
            this.CreatedAtTDat.Size = new System.Drawing.Size(200, 20);
            this.CreatedAtTDat.TabIndex = 69;
            // 
            // CreatedAtLb
            // 
            this.CreatedAtLb.AutoSize = true;
            this.CreatedAtLb.BackColor = System.Drawing.Color.Transparent;
            this.CreatedAtLb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedAtLb.ForeColor = System.Drawing.Color.White;
            this.CreatedAtLb.Location = new System.Drawing.Point(25, 332);
            this.CreatedAtLb.Name = "CreatedAtLb";
            this.CreatedAtLb.Size = new System.Drawing.Size(122, 26);
            this.CreatedAtLb.TabIndex = 68;
            this.CreatedAtLb.Text = "CreatedAt:";
            // 
            // BookshelfCom
            // 
            this.BookshelfCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BookshelfCom.ForeColor = System.Drawing.SystemColors.Info;
            this.BookshelfCom.FormattingEnabled = true;
            this.BookshelfCom.Location = new System.Drawing.Point(409, 296);
            this.BookshelfCom.Name = "BookshelfCom";
            this.BookshelfCom.Size = new System.Drawing.Size(160, 21);
            this.BookshelfCom.TabIndex = 67;
            this.BookshelfCom.Text = "Select";
            // 
            // BookshelfLb
            // 
            this.BookshelfLb.AutoSize = true;
            this.BookshelfLb.BackColor = System.Drawing.Color.Transparent;
            this.BookshelfLb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookshelfLb.ForeColor = System.Drawing.Color.White;
            this.BookshelfLb.Location = new System.Drawing.Point(290, 291);
            this.BookshelfLb.Name = "BookshelfLb";
            this.BookshelfLb.Size = new System.Drawing.Size(113, 26);
            this.BookshelfLb.TabIndex = 66;
            this.BookshelfLb.Text = "Bookshelf:";
            // 
            // publisherTx
            // 
            this.publisherTx.Location = new System.Drawing.Point(405, 257);
            this.publisherTx.Name = "publisherTx";
            this.publisherTx.Size = new System.Drawing.Size(164, 20);
            this.publisherTx.TabIndex = 65;
            // 
            // publisherLb
            // 
            this.publisherLb.AutoSize = true;
            this.publisherLb.BackColor = System.Drawing.Color.Transparent;
            this.publisherLb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLb.ForeColor = System.Drawing.Color.White;
            this.publisherLb.Location = new System.Drawing.Point(290, 251);
            this.publisherLb.Name = "publisherLb";
            this.publisherLb.Size = new System.Drawing.Size(109, 26);
            this.publisherLb.TabIndex = 64;
            this.publisherLb.Text = "publisher:";
            // 
            // PriceTx
            // 
            this.PriceTx.Location = new System.Drawing.Point(112, 297);
            this.PriceTx.Name = "PriceTx";
            this.PriceTx.Size = new System.Drawing.Size(164, 20);
            this.PriceTx.TabIndex = 63;
            // 
            // PriceLb
            // 
            this.PriceLb.AutoSize = true;
            this.PriceLb.BackColor = System.Drawing.Color.Transparent;
            this.PriceLb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLb.ForeColor = System.Drawing.Color.White;
            this.PriceLb.Location = new System.Drawing.Point(39, 291);
            this.PriceLb.Name = "PriceLb";
            this.PriceLb.Size = new System.Drawing.Size(67, 26);
            this.PriceLb.TabIndex = 62;
            this.PriceLb.Text = "Price:";
            // 
            // AuthorTx
            // 
            this.AuthorTx.Location = new System.Drawing.Point(112, 257);
            this.AuthorTx.Name = "AuthorTx";
            this.AuthorTx.Size = new System.Drawing.Size(164, 20);
            this.AuthorTx.TabIndex = 61;
            // 
            // AuthorLb
            // 
            this.AuthorLb.AutoSize = true;
            this.AuthorLb.BackColor = System.Drawing.Color.Transparent;
            this.AuthorLb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLb.ForeColor = System.Drawing.Color.White;
            this.AuthorLb.Location = new System.Drawing.Point(19, 251);
            this.AuthorLb.Name = "AuthorLb";
            this.AuthorLb.Size = new System.Drawing.Size(87, 26);
            this.AuthorLb.TabIndex = 60;
            this.AuthorLb.Text = "Author:";
            // 
            // imageBook
            // 
            this.imageBook.BackColor = System.Drawing.Color.Transparent;
            this.imageBook.Image = global::manage_library.Properties.Resources.library22;
            this.imageBook.Location = new System.Drawing.Point(610, 251);
            this.imageBook.Name = "imageBook";
            this.imageBook.Size = new System.Drawing.Size(178, 118);
            this.imageBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBook.TabIndex = 59;
            this.imageBook.TabStop = false;
            // 
            // CodeTx
            // 
            this.CodeTx.Location = new System.Drawing.Point(112, 168);
            this.CodeTx.Name = "CodeTx";
            this.CodeTx.Size = new System.Drawing.Size(164, 20);
            this.CodeTx.TabIndex = 56;
            // 
            // CodeLb
            // 
            this.CodeLb.AutoSize = true;
            this.CodeLb.BackColor = System.Drawing.Color.Transparent;
            this.CodeLb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeLb.ForeColor = System.Drawing.Color.White;
            this.CodeLb.Location = new System.Drawing.Point(30, 164);
            this.CodeLb.Name = "CodeLb";
            this.CodeLb.Size = new System.Drawing.Size(68, 26);
            this.CodeLb.TabIndex = 55;
            this.CodeLb.Text = "Code:";
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.BackColor = System.Drawing.Color.Transparent;
            this.NameLb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.ForeColor = System.Drawing.Color.White;
            this.NameLb.Location = new System.Drawing.Point(221, 33);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(76, 26);
            this.NameLb.TabIndex = 53;
            this.NameLb.Text = "Name:";
            // 
            // Texboxname
            // 
            this.Texboxname.Location = new System.Drawing.Point(315, 35);
            this.Texboxname.Name = "Texboxname";
            this.Texboxname.Size = new System.Drawing.Size(164, 20);
            this.Texboxname.TabIndex = 76;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Tomato;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(490, 24);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(127, 40);
            this.searchBtn.TabIndex = 75;
            this.searchBtn.Text = "serach";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // UpdatedAtTDat
            // 
            this.UpdatedAtTDat.Location = new System.Drawing.Point(426, 172);
            this.UpdatedAtTDat.Name = "UpdatedAtTDat";
            this.UpdatedAtTDat.Size = new System.Drawing.Size(200, 20);
            this.UpdatedAtTDat.TabIndex = 78;
            // 
            // UpdatedAtLb
            // 
            this.UpdatedAtLb.AutoSize = true;
            this.UpdatedAtLb.BackColor = System.Drawing.Color.Transparent;
            this.UpdatedAtLb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatedAtLb.ForeColor = System.Drawing.Color.White;
            this.UpdatedAtLb.Location = new System.Drawing.Point(291, 168);
            this.UpdatedAtLb.Name = "UpdatedAtLb";
            this.UpdatedAtLb.Size = new System.Drawing.Size(129, 26);
            this.UpdatedAtLb.TabIndex = 77;
            this.UpdatedAtLb.Text = "UpdatedAt:";
            // 
            // Editbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdatedAtTDat);
            this.Controls.Add(this.UpdatedAtLb);
            this.Controls.Add(this.Texboxname);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.save);
            this.Controls.Add(this.back);
            this.Controls.Add(this.unavailable);
            this.Controls.Add(this.Available);
            this.Controls.Add(this.CreatedAtTDat);
            this.Controls.Add(this.CreatedAtLb);
            this.Controls.Add(this.BookshelfCom);
            this.Controls.Add(this.BookshelfLb);
            this.Controls.Add(this.publisherTx);
            this.Controls.Add(this.publisherLb);
            this.Controls.Add(this.PriceTx);
            this.Controls.Add(this.PriceLb);
            this.Controls.Add(this.AuthorTx);
            this.Controls.Add(this.AuthorLb);
            this.Controls.Add(this.imageBook);
            this.Controls.Add(this.CodeTx);
            this.Controls.Add(this.CodeLb);
            this.Controls.Add(this.NameLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editbook";
            this.Text = "Editbook";
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.RadioButton unavailable;
        private System.Windows.Forms.RadioButton Available;
        private System.Windows.Forms.DateTimePicker CreatedAtTDat;
        private System.Windows.Forms.Label CreatedAtLb;
        private System.Windows.Forms.ComboBox BookshelfCom;
        private System.Windows.Forms.Label BookshelfLb;
        private System.Windows.Forms.TextBox publisherTx;
        private System.Windows.Forms.Label publisherLb;
        private System.Windows.Forms.TextBox PriceTx;
        private System.Windows.Forms.Label PriceLb;
        private System.Windows.Forms.TextBox AuthorTx;
        private System.Windows.Forms.Label AuthorLb;
        private System.Windows.Forms.PictureBox imageBook;
        private System.Windows.Forms.TextBox CodeTx;
        private System.Windows.Forms.Label CodeLb;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.TextBox Texboxname;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DateTimePicker UpdatedAtTDat;
        private System.Windows.Forms.Label UpdatedAtLb;
    }
}