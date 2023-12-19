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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace manage_library
{
    public partial class Editprofile : Form
    {
        private string userFolderPath;
        public Editprofile(string username)
        {
            InitializeComponent();
            userFolderPath = Path.Combine(Application.StartupPath, username);
            LoadUserInfo();
            ApplyRoundedCorners();
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
        private void LoadUserInfo()
        {
            fullnameTx.Text= ReadValueFromFile(Path.Combine(userFolderPath, "fullname.txt"));
            EmailTx.Text = ReadValueFromFile(Path.Combine(userFolderPath, "email.txt"));
            agecom.Text = ReadValueFromFile(Path.Combine(userFolderPath, "age.txt"));
            phoneTx.Text= ReadValueFromFile(Path.Combine(userFolderPath, "phone.txt"));
            addressTx.Text= ReadValueFromFile(Path.Combine(userFolderPath, "address.txt"));
            nationalidTx.Text= ReadValueFromFile(Path.Combine(userFolderPath, "nationalid.txt"));
            citycom.Text= ReadValueFromFile(Path.Combine(userFolderPath, "city.txt"));
            string genderValue = ReadValueFromFile(Path.Combine(userFolderPath, "gender.txt"));
            gendercom.SelectedItem = genderValue != "" ? genderValue : gendercom.Items[0];

        }
        private string ReadValueFromFile(string filePath)
        {
            return File.Exists(filePath) ? File.ReadAllText(filePath).Trim() : "";
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
            Mainuser Mainuser = new Mainuser(userInfo, idinfo, address, age, city, data, email, fullname, phone, gender, nationalid);
            Mainuser.Show();
        }
        private void back_Click(object sender, EventArgs e)
        {
            string username = Path.GetFileName(userFolderPath);
            ShowUserInfo(username);

        }

        private void send_Click(object sender, EventArgs e)
        {
           
            File.WriteAllText(Path.Combine(userFolderPath, "email.txt"), EmailTx.Text);
            File.WriteAllText(Path.Combine(userFolderPath, "age.txt"), agecom.Text);
            File.WriteAllText(Path.Combine(userFolderPath, "fullname.txt"), fullnameTx.Text);
            File.WriteAllText(Path.Combine(userFolderPath, "phone.txt"), phoneTx.Text);
            File.WriteAllText(Path.Combine(userFolderPath, "address.txt"), addressTx.Text);
            File.WriteAllText(Path.Combine(userFolderPath, "nationalid.txt"), nationalidTx.Text);
            File.WriteAllText(Path.Combine(userFolderPath, "city.txt"), citycom.Text);

            File.WriteAllText(Path.Combine(userFolderPath, "age.txt"), agecom.Text);
            if (gendercom.SelectedItem != null)
            {
                File.WriteAllText(Path.Combine(userFolderPath, "gender.txt"), gendercom.SelectedItem.ToString());
            }
            MessageBox.Show("Information has been saved successfully.");
        }
    }
}
