using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manage_library
{
    public partial class editBookshelf : Form
    {
        string bookFolderPath;
        public editBookshelf()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminpanel adminpanel = new adminpanel();
            adminpanel.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string bookName = Texboxname.Text;
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string bookFolderPath = Path.Combine(userProfile, @"source\repos\manage-library\manage-library\bin\bookshelf", bookName);
            //@"C:\Users\sajad\source\repos\manage-library\manage-library\bin\bookshelf
            if (!Directory.Exists(bookFolderPath))
            {
                MessageBox.Show("Book not found.");
                return;
            }
            orderTx.Text = File.ReadAllText(Path.Combine(bookFolderPath, "order.txt"));
            //view info book
        }

        private void save_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Path.Combine(bookFolderPath, "order.txt"), orderTx.Text);
            MessageBox.Show("Book information saved successfully.");
        }
    }
    }