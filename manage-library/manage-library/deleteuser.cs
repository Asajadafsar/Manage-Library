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
    public partial class deleteuser : Form
    {
        public deleteuser()
        {
            InitializeComponent();
            ApplyRoundedCorners();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string username=usertx.Text;
            string userDirectoryPath = Path.Combine(Application.StartupPath, username);
            //finde username is login to username

            if (Directory.Exists(userDirectoryPath))
            {
                //delete foolder
                Directory.Delete(userDirectoryPath, true);
                MessageBox.Show("user by by.");

                //update list users
                PopulateUsersDataGridView();
            }
            else
            {
                MessageBox.Show("not finde user!");
            }
        }
        private void PopulateUsersDataGridView()
        {
            lstuser.Rows.Clear();
            //update list and clear
            string[] userDirectories = Directory.GetDirectories(Application.StartupPath);
            //path userDirectories get login
            foreach (string dir in userDirectories)
            {
                Dictionary<string, string> fileContents = new Dictionary<string, string>
        {
            {"userId", ""},
            {"email", ""},
            {"phone", ""},
            {"address", ""},
            {"city", ""},
            {"age", ""},
            {"nationalid", ""},
            {"gender", ""},
            {"fullname", ""},
            {"data", ""}
            //add iteam this read file txt
        };

                string[] textFiles = Directory.GetFiles(dir, "*.txt");
                //str textFiles get login
                foreach (string textFilePath in textFiles)
                {
                    string fileContent = File.ReadAllText(textFilePath);
                    //read file txt
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(textFilePath);
                    //get file name no path .txt
                    if (fileContents.ContainsKey(fileNameWithoutExtension))
                    {
                        //fileContents this mohtaviat file
                        fileContents[fileNameWithoutExtension] = fileContent;
                    }
                }

                //add radif 
                lstuser.Rows.Add(new object[]
                {
            Path.GetFileName(dir),
            fileContents["userId"],
            //username foolder
            fileContents["email"], 
            //mohtava file txt
            fileContents["phone"],   
            fileContents["address"],
            fileContents["city"],
            fileContents["age"],
            fileContents["nationalid"],
            fileContents["gender"],
            fileContents["fullname"],
            fileContents["data"],
                });
            }
        }

        private void deleteuser_Load(object sender, EventArgs e)
        {
           PopulateUsersDataGridView();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminpanel adminpanel=new adminpanel();
            adminpanel.Show();
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

        private void lstuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usertx_TextChanged(object sender, EventArgs e)
        {

        }

        private void userlb_Click(object sender, EventArgs e)
        {

        }
    }
}
