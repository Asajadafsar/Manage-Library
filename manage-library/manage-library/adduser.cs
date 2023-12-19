using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace manage_library
{
    public partial class adduser : Form
    {
        private static readonly Random random = new Random();
        public adduser()
        {
            InitializeComponent();
            ApplyRoundedCorners();
            GenerateRandomUserId();
        }
        private void GenerateRandomUserId()
        {
            int randomId = random.Next(1000, 9999); 
            //4 ragham random
            idrandom.Text = randomId.ToString(); 
        }
        private void ApplyRoundedCorners()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, 10, 10));
                }
            }
            foreach (Control control in Controls)
            {
                if (control is ComboBox)
                {
                    control.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, 10, 10));
                }
            }
            foreach (Control control in Controls)
            {
                if (control is RichTextBox)
                {
                    control.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, 10, 10));
                }
            }
            foreach (Control control in Controls)
            {
                if (control is DateTimePicker)
                {
                    control.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, 10, 10));
                }
            }
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

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminpanel adminpanel = new adminpanel();
            adminpanel.Show();
        }

        private void savefoolder()
        {
            string username = nametx.Text;
            string fullname = fulltx.Text;
            string phone = phonetx.Text;
            string email = emailtx.Text;
            string nationalid = nationalidtx.Text;
            string address = rtltxt.Text;
            string age = agecom.Text;
            string city = citycom.Text;
            string gender = gendercom.Text;
            string data = datatim.Text;
            string password=passtx.Text;
            string userId = idrandom.Text;
            
            //add string this void-call
            string userDirectoryPath = Path.Combine(Application.StartupPath, username);
            

           //add if not folder
            if (!Directory.Exists(userDirectoryPath))
            {
                Directory.CreateDirectory(userDirectoryPath);
            }
            //add hash md5
            SavePassword(userDirectoryPath, password);


            //save file joda joda
            
            SaveFieldToFile(userDirectoryPath, "username.txt", username);
            SaveFieldToFile(userDirectoryPath, "fullname.txt", fullname);
            SaveFieldToFile(userDirectoryPath, "age.txt", age);
            SaveFieldToFile(userDirectoryPath, "nationalid.txt", nationalid);
            SaveFieldToFile(userDirectoryPath, "city.txt", city);
            SaveFieldToFile(userDirectoryPath, "phone.txt", phone);
            SaveFieldToFile(userDirectoryPath, "email.txt", email);
            SaveFieldToFile(userDirectoryPath, "address.txt", address);
            SaveFieldToFile(userDirectoryPath, "data.txt", data);
            SaveFieldToFile(userDirectoryPath, "gender.txt", gender);
            SaveFieldToFile(userDirectoryPath, "userId.txt", userId);
        }
        private static string ComputeMd5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        private void SavePassword(string directoryPath, string password)
        {
            string hashedPassword = ComputeMd5Hash(password);
            string passwordFilePath = Path.Combine(directoryPath, "password.txt");
            File.WriteAllText(passwordFilePath, hashedPassword);
        }
        private void SaveFieldToFile(string directoryPath, string fileName, string content)
        {
            string filePath = Path.Combine(directoryPath, fileName);
            File.WriteAllText(filePath, content);
        }
        
        private void send_Click(object sender, EventArgs e)
        {
        bool fieldsFilled = true;

        foreach (Control control in this.Controls)
        {
            if (control is TextBox)
            {
                if (string.IsNullOrWhiteSpace(((TextBox)control).Text))
                {
                    MessageBox.Show("Please fill in all the text fields.");
                    fieldsFilled = false;
                    break;
                }
            }
            else if (control is ComboBox)
            {
                ComboBox comboBox = control as ComboBox;
                if (comboBox != null && comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an item from the dropdown list.");
                    fieldsFilled = false;
                    break;
                }
            }
            else if (control is RichTextBox)
            {
                if (string.IsNullOrWhiteSpace(((RichTextBox)control).Text))
                {
                    MessageBox.Show("Please fill in all the rich text fields.");
                    fieldsFilled = false;
                    break;
                }
            }

        }

        if (fieldsFilled)
        {
                savefoolder();
                MessageBox.Show("Information sent successfully.");

            }

    }
}
}