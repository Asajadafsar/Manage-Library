using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manage_library
{
    public partial class editusers : Form
    {

        public editusers()
        {
            InitializeComponent();
            ApplyRoundedCorners();
        }
        private void LoadUserData(string username)
        {
            //user name input this texbox search
            //call delet buuton
            string userDirectory = Path.Combine(Application.StartupPath, username);
            //get foolder username
            if (Directory.Exists(userDirectory))
            {
                //ghrar dadan har file dar texbox
                var fileMappings = new Dictionary<string, TextBox>
        {

            {"fullname.txt", fulltx},
            //location file txt this tex box edit
            {"phone.txt", phonetx},
            {"email.txt", emailtx},
            {"age.txt", agetx},
            {"city.txt", citytx},
            {"gender.txt", gendertx},
            {"data.txt", datatx},
            {"address.txt", rtltx},
            {"nationalid.txt", nationalidtx}


        };

                foreach (var entry in fileMappings)
                {
                    string filePath = Path.Combine(userDirectory, entry.Key);
                    //read file this file path
                    if (File.Exists(filePath))
                    {
                        entry.Value.Text = File.ReadAllText(filePath);
                    }
                    else
                    {
                        entry.Value.Text = "";
                        //if not file this claer
                    }
                }
            }
            else
            {
                MessageBox.Show("User directory not found.");
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            LoadUserData(usertx.Text);
        }
        private static string GetMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            string username = usertx.Text;
            //user name input this texbox search
            string userDirectory = Path.Combine(Application.StartupPath, username);
            //save password md5
            if (!String.IsNullOrEmpty(passtx.Text))
            {
                //convert password ti md5
                string hashedPassword = GetMD5Hash(passtx.Text);
                string passwordFilePath = Path.Combine(userDirectory, "password.txt");
                File.WriteAllText(passwordFilePath, hashedPassword);
                //save password md5
            }
            var fileMappings = new Dictionary<string, TextBox>
    {

            {"fullname.txt", fulltx},
            {"phone.txt", phonetx},
            {"email.txt", emailtx},
            {"age.txt", agetx},
            {"city.txt", citytx},
            {"gender.txt", gendertx},
            {"data.txt", datatx},
            {"address.txt", rtltx},
            {"nationalid.txt", nationalidtx}
    };

            foreach (var entry in fileMappings)
            {
                string filePath = Path.Combine(userDirectory, entry.Key);
                File.WriteAllText(filePath, entry.Value.Text);
                //save edit this files
            }

            MessageBox.Show("User data saved successfully.");

        }
        private void ApplyRoundedCorners()
        {
            //border radius
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
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminpanel adminpanel = new adminpanel();
            adminpanel.Show();
        }
    }
}
