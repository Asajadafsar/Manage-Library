using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.IO;
using System.Security.Cryptography;

namespace manage_library
{
    public partial class tab_admin_user : Form
    {
        //public string LoggedInUsername { get; private set; }

        public tab_admin_user()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            //chek user and pass admin 
            if (boxuser.Text == "sajadafsar" && boxpass.Text == "afsar123")
            {

                this.Hide();
                adminpanel adminpanel = new adminpanel();
                adminpanel.Show();
            }
            else
            {
                MessageBox.Show("OPS not password || username");
            }
        }

        private void lbclick_Click(object sender, EventArgs e)
        {
            tab.SelectedIndex = 1;
            //view select tab and tab
        }

        private void clicklb_Click(object sender, EventArgs e)
        {
            tab.SelectedIndex = 0;
            //view select tab and tab
        }
        private string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        private void logbtn_Click(object sender, EventArgs e)
        {
            string username = userbox.Text;
            string password = passbox.Text;

            string hashedPassword = CalculateMD5Hash(password);

            if (ValidateUser(username, hashedPassword))
            {
                // پس از تایید هویت، فرم جدید باز می‌شود و اطلاعات کاربر نمایش داده می‌شوند.
                ShowUserInfo(username);
            }
            else
            {
                MessageBox.Show("Username or password is incorrect.");
            }

        }
        private bool ValidateUser(string username, string hashedPassword)
        {
            // بررسی اگر پوشه با نام کاربری موجود است
            string userPath = Path.Combine(Application.StartupPath, username);
            if (Directory.Exists(userPath))
            {
                // مقایسه هش پسورد دخیره شده با هش پسورد وارد شده
                string savedPasswordHash = File.ReadAllText(Path.Combine(userPath, "password.txt"));
                return hashedPassword.Equals(savedPasswordHash, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }
        private void ShowUserInfo(string username)
        {
            string userPath = Path.Combine(Application.StartupPath, username);
            string userInfo = File.ReadAllText(Path.Combine(userPath, "username.txt"));
            string idinfo = File.ReadAllText(Path.Combine(userPath, "userId.txt"));
            string address = File.ReadAllText(Path.Combine(userPath, "address.txt"));
            string age = File.ReadAllText(Path.Combine(userPath, "age.txt"));
            string city = File.ReadAllText(Path.Combine(userPath, "city.txt"));
            string data = File.ReadAllText(Path.Combine(userPath, "data.txt"));
            string email = File.ReadAllText(Path.Combine(userPath, "email.txt"));
            string fullname = File.ReadAllText(Path.Combine(userPath, "fullname.txt"));
            string phone = File.ReadAllText(Path.Combine(userPath, "phone.txt"));
            string gender = File.ReadAllText(Path.Combine(userPath, "gender.txt"));
            string nationalid = File.ReadAllText(Path.Combine(userPath, "nationalid.txt"));

            this.Hide();
            Mainuser Mainuser = new Mainuser(userInfo, idinfo,address, age, city, data,email,fullname,phone,gender,nationalid);
            Mainuser.Show();
        }
    }
}