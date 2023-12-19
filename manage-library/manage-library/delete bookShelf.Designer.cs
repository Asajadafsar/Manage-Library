namespace manage_library
{
    partial class delete_bookShelf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete_bookShelf));
            this.gridveiwshelf = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codelb = new System.Windows.Forms.Label();
            this.codetx = new System.Windows.Forms.TextBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridveiwshelf)).BeginInit();
            this.SuspendLayout();
            // 
            // gridveiwshelf
            // 
            this.gridveiwshelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridveiwshelf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.order,
            this.id});
            this.gridveiwshelf.Location = new System.Drawing.Point(235, 75);
            this.gridveiwshelf.Name = "gridveiwshelf";
            this.gridveiwshelf.ReadOnly = true;
            this.gridveiwshelf.Size = new System.Drawing.Size(352, 363);
            this.gridveiwshelf.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // order
            // 
            this.order.HeaderText = "order";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // codelb
            // 
            this.codelb.AutoSize = true;
            this.codelb.BackColor = System.Drawing.Color.Transparent;
            this.codelb.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codelb.ForeColor = System.Drawing.Color.White;
            this.codelb.Location = new System.Drawing.Point(170, 27);
            this.codelb.Name = "codelb";
            this.codelb.Size = new System.Drawing.Size(155, 37);
            this.codelb.TabIndex = 90;
            this.codelb.Text = "BookShelf:";
            // 
            // codetx
            // 
            this.codetx.Location = new System.Drawing.Point(331, 35);
            this.codetx.Name = "codetx";
            this.codetx.Size = new System.Drawing.Size(164, 20);
            this.codetx.TabIndex = 89;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Tomato;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletebtn.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(506, 24);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(127, 40);
            this.deletebtn.TabIndex = 88;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
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
            // delete_bookShelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::manage_library.Properties.Resources.background_sade;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.codelb);
            this.Controls.Add(this.codetx);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.gridveiwshelf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delete_bookShelf";
            this.Text = "delete_bookShelf";
            this.Load += new System.EventHandler(this.delete_bookShelf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridveiwshelf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridveiwshelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label codelb;
        private System.Windows.Forms.TextBox codetx;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button back;
    }
}