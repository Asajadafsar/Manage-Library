namespace manage_library
{
    partial class DebtbookUSer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtbookUSer));
            this.search = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.nameTx = new System.Windows.Forms.TextBox();
            this.NameLb = new System.Windows.Forms.Label();
            this.Borrow = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Tomato;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(603, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(127, 40);
            this.search.TabIndex = 57;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
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
            this.back.TabIndex = 56;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // nameTx
            // 
            this.nameTx.Location = new System.Drawing.Point(414, 27);
            this.nameTx.Name = "nameTx";
            this.nameTx.Size = new System.Drawing.Size(164, 20);
            this.nameTx.TabIndex = 55;
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.BackColor = System.Drawing.Color.Transparent;
            this.NameLb.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.ForeColor = System.Drawing.Color.White;
            this.NameLb.Location = new System.Drawing.Point(279, 21);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(129, 26);
            this.NameLb.TabIndex = 54;
            this.NameLb.Text = "Book Name:";
            // 
            // Borrow
            // 
            this.Borrow.BackColor = System.Drawing.Color.Tomato;
            this.Borrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Borrow.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrow.ForeColor = System.Drawing.Color.White;
            this.Borrow.Location = new System.Drawing.Point(451, 344);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(127, 40);
            this.Borrow.TabIndex = 84;
            this.Borrow.Text = "Borrow";
            this.Borrow.UseVisualStyleBackColor = false;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.CodeBook});
            this.dataGridViewBooks.Location = new System.Drawing.Point(384, 94);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.Size = new System.Drawing.Size(246, 220);
            this.dataGridViewBooks.TabIndex = 86;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // CodeBook
            // 
            this.CodeBook.HeaderText = "CodeBook";
            this.CodeBook.Name = "CodeBook";
            this.CodeBook.ReadOnly = true;
            // 
            // DebtbookUSer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.ClientSize = new System.Drawing.Size(1049, 450);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.Borrow);
            this.Controls.Add(this.search);
            this.Controls.Add(this.back);
            this.Controls.Add(this.nameTx);
            this.Controls.Add(this.NameLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DebtbookUSer";
            this.Text = "DebtbookUSer";
            this.Load += new System.EventHandler(this.DebtbookUSer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox nameTx;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Button Borrow;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeBook;
    }
}