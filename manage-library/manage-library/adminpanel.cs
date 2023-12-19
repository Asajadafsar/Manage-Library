using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manage_library
{
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
            ApplyRoundedCorners();
        }
        private void ApplyRoundedCorners()
        {
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    control.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, 30, 30));
                }
            }
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            tab_admin_user tab_Admin_User=new tab_admin_user();
            tab_Admin_User.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            adduser adduser = new adduser();
            adduser.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteuser deleteuser=new deleteuser();
            deleteuser.Show();
        }

        private void editUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            editusers editusers=new editusers();
            editusers.Show();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            addBook addBook=new addBook();
            addBook.Show();
        }

        private void eiditbookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editbook Editbook = new Editbook();
            Editbook.Show();
        }

        private void listBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listbooks listbooks = new Listbooks();
            listbooks.Show();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            listUsers listUsers = new listUsers();
            listUsers.Show();
        }

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_books Delete_books = new Delete_books();
            Delete_books.Show();
        }

        private void addBookShelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            addbookShelf addbookShelf = new addbookShelf();
            addbookShelf.Show();
        }

        private void deleteBookShelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_bookShelf delete_bookShelf = new delete_bookShelf();
            delete_bookShelf.Show();
        }

        private void listBookShelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            listBookshelf listBookshelf = new listBookshelf();
            listBookshelf.Show();
        }

        private void editBookShelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            editBookshelf editBookshelf = new editBookshelf();
            editBookshelf.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Returnbook returnbook = new Returnbook();
            returnbook.Show();
        }

        private void debtBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Okdespoit okdespoit=new Okdespoit();
            okdespoit.Show();
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            listBorrowbook listBorrowbook=new listBorrowbook();
            listBorrowbook.Show();
        }

        private void listBookTrueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            listbooksmojood listbooksmojood = new listbooksmojood();
            listbooksmojood.Show();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            history history=new history();
            history.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
