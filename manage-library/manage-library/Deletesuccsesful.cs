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
    public partial class Deletesuccsesful : Form
    {
        private string userFolderPath;
        public Deletesuccsesful(string username)
        {
            InitializeComponent();
            userFolderPath = Path.Combine(Application.StartupPath, username);
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

        private void Borrow_Click(object sender, EventArgs e)
        {
            string username = nameTx.Text.Trim();
            string boojname = bookTx.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }
            string pathsucssefull = @"%USERPROFILE%\source\repos\manage-library\manage-library\bin\successful";
            string expandedPath = Environment.ExpandEnvironmentVariables(pathsucssefull);
            DeleteFilesStartingWithUsername(expandedPath, username);
            string requestsDirectory = @"%USERPROFILE%\source\repos\manage-library\manage-library\bin\request-admin";
            string expandedPathRequest = Environment.ExpandEnvironmentVariables(requestsDirectory);
            DeleteFilesStartingWithUsername(expandedPathRequest, username);
            MessageBox.Show("Files for the user have been successfully deleted.");
            string specificFolderPath22 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"source\repos\manage-library\manage-library\bin\books", boojname);
            string expandedPath22 = Path.GetFullPath(specificFolderPath22);
            string filePath = Path.Combine(expandedPath22, "ok.txt");
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            else
            {
                Console.WriteLine("Ops not finde file!.");
            }
            //DeleteFilesStartingWithUsername(expandedPath22, "ok.txt");
        }

        private void DeleteFilesStartingWithUsername(string directoryPath, string username)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            //ebteda by username file
            FileInfo[] userFiles = directoryInfo.GetFiles($"{username}*.txt");

            foreach (FileInfo file in userFiles)
            {
                file.Delete();
            }
        }
    
    }
    }