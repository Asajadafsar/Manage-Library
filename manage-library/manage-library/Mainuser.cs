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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace manage_library
{
    public partial class Mainuser : Form
    {
        public Mainuser(string username,string userId,string address,string age,string city,string data,string email,string fullname,string gender,string nationalid,string phone)
        {
            InitializeComponent();

           usernameLb.Text = username;
            idLB.Text = userId;
            AddressLb.Text = address;
            AgeLb.Text = age;
            CityLb.Text = city;
            dataLb.Text = data;
            EmailLb.Text = email;
            FullnameLB.Text = fullname;
            PhoneLb.Text = phone;
            GenderLb.Text = gender;
            NationalidLB.Text = nationalid;
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
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, 10, 10));
                }
            }
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            tab_admin_user tab_Admin_User = new tab_admin_user();
            tab_Admin_User.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string username= usernameLb.Text;
            this.Hide();
            Editprofile editprofile = new Editprofile(username);
            editprofile.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string username = usernameLb.Text;
            this.Hide();
            searchBooks searchBooks=new searchBooks(username);
            searchBooks.Show();
        }

        private void debtBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string username = usernameLb.Text;
            this.Hide();
            DebtbookUSer debtbookUSer = new DebtbookUSer(username);
            debtbookUSer.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string username = usernameLb.Text;
            this.Hide();
            Deletesuccsesful deletesuccsesful = new Deletesuccsesful(username);
            deletesuccsesful.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qustionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            qustion qustion=new qustion();
            qustion.Show();
        }
    }
}