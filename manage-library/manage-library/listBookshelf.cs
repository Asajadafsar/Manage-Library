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
    public partial class listBookshelf : Form
    {
        public listBookshelf()
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
        private void PopulateUsersDataGridView()
        {
            gridveiwshelf.Rows.Clear();
            //update list and clear
            string booksFolderPath = @"%USERPROFILE%\source\repos\manage-library\manage-library\bin\bookshelf";
            //C:\\Users\\sajad\\source\\repos\\manage-library\\manage-library\\bin\\bookshelf
            string expandedPath = Environment.ExpandEnvironmentVariables(booksFolderPath);

            string[] userDirectories = Directory.GetDirectories(expandedPath);
            //path userDirectories get login
            foreach (string dir in userDirectories)
            {
                Dictionary<string, string> fileContents = new Dictionary<string, string>
 {
     {"name", ""},
     {"order", ""},
     {"id", ""}
     
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
                gridveiwshelf.Rows.Add(new object[]
                {
     Path.GetFileName(dir),
     fileContents["name"],
     //username foolder
     fileContents["order"], 
     //mohtava file txt
     fileContents["id"]
                });
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminpanel adminpanel = new adminpanel();
            adminpanel.Show();
        }

        private void listBookshelf_Load(object sender, EventArgs e)
        {
            PopulateUsersDataGridView();
        }
    }
}
