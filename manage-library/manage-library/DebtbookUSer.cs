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

    public partial class DebtbookUSer : Form
    {
        public static string SharedString { get; set; }
        private string userFolderPath;

        private string usernamepath;
        public DebtbookUSer(string username)
        {
            InitializeComponent();
            userFolderPath = Path.Combine(Application.StartupPath, username);
             usernamepath = username;
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
        private void Borrow_Click(object sender, EventArgs e)
        {
            string loggedInUsername = usernamepath;
            string specificDirectory = @"%USERPROFILE%\source\repos\manage-library\manage-library\bin\request-admin";
            //C:\\Users\\sajad\\source\\repos\\manage-library\\manage-library\\bin\\request-admin
            string expandedPath = Environment.ExpandEnvironmentVariables(specificDirectory);
            bool isBookAlreadyRequested = false;
            string bookToCheck = ""; 

            // check books in DataGridView
            foreach (DataGridViewRow row in dataGridViewBooks.Rows)
            {
                if (row.Cells["name"].Value != null && row.Cells["CodeBook"].Value != null)
                {
                    bookToCheck = row.Cells["name"].Value.ToString();
                    break; 
                }
            }

            // if books=True(mojjod) check she
            if (!string.IsNullOrEmpty(bookToCheck))
            {
                foreach (string filePath in Directory.EnumerateFiles(expandedPath, "*-admin-request.txt"))
                {
                    string[] fileContent = File.ReadAllLines(filePath);
                    if (fileContent.Contains(bookToCheck))
                    {
                        MessageBox.Show("Ops Duplicate request: This book has already been requested.");
                        isBookAlreadyRequested = true;
                        break; 
                        //exit loop
                    }
                }
            }

            if (!isBookAlreadyRequested)
            {
                //if not request books and sign up this start
              //add file txt *request
                StringBuilder bookListData = new StringBuilder();
                foreach (DataGridViewRow row in dataGridViewBooks.Rows)
                {
                    if (row.Cells["name"].Value != null && row.Cells["CodeBook"].Value != null)
                    {
                        string bookTitle = row.Cells["name"].Value.ToString();
                        string CodeBook = row.Cells["CodeBook"].Value.ToString();
                        string loggedInUserDirectory = Path.Combine(Application.StartupPath, loggedInUsername);
                        string userIdFilePath = Path.Combine(loggedInUserDirectory, "userId.txt");
                        string userid = File.Exists(userIdFilePath) ? File.ReadAllText(userIdFilePath) : "Unknown";

                        bookListData.AppendLine(bookTitle);
                        bookListData.AppendLine(CodeBook);
                        bookListData.AppendLine(loggedInUsername);
                        bookListData.AppendLine(userid);
                    }
                }

                //check creat foolder specificDirectory and userSpecificAdminRequestPath
                if (!Directory.Exists(expandedPath))
                {
                    Directory.CreateDirectory(expandedPath);
                }
                string userSpecificAdminRequestPath = Path.Combine(expandedPath, $"{loggedInUsername}-admin-request.txt");
                File.WriteAllText(userSpecificAdminRequestPath, bookListData.ToString());

                MessageBox.Show("The list of books has been successfully saved.");
            }
            string textBoxFolderName = nameTx.Text; 

            string specificFolderPath22 = Path.Combine(@"%USERPROFILE%\source\\repos\manage-library\manage-library\bin\books", textBoxFolderName);
            string expandedPath22 = Environment.ExpandEnvironmentVariables(specificFolderPath22);

            if (!Directory.Exists(expandedPath22))
            {
                Directory.CreateDirectory(expandedPath22);
            }

            string okFilePath = Path.Combine(expandedPath22, "ok.txt");
            File.WriteAllText(okFilePath, "This book is not available");
        }
        private void PopulateUsersDataGridView(string searchQuery)
        {
            dataGridViewBooks.Rows.Clear();

            string booksFolderPath = @"%USERPROFILE%\source\repos\manage-library\manage-library\bin\books";
            string expandedPath = Environment.ExpandEnvironmentVariables(booksFolderPath);
            string bookDirectoryPath = Path.Combine(expandedPath, searchQuery);

            if (Directory.Exists(bookDirectoryPath))
            {
                Dictionary<string, string> fileContents = new Dictionary<string, string>
        {
            {"CodeBook", ""}
            
        };

                string[] textFiles = Directory.GetFiles(bookDirectoryPath, "*.txt");

                foreach (string textFilePath in textFiles)
                {
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(textFilePath);
                    if (fileContents.ContainsKey(fileNameWithoutExtension))
                    {
                        fileContents[fileNameWithoutExtension] = File.ReadAllText(textFilePath);
                    }
                }

                //add DataGridView radif
                dataGridViewBooks.Rows.Add(new object[]
                {
            searchQuery, 
            //if name foolder=bookname
            fileContents["CodeBook"]
                });
            }

        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchQuery = nameTx.Text;
            SharedString = searchQuery;
            string booksFolderPath = @"%USERPROFILE%\source\repos\manage-library\manage-library\bin\books";
            string expandedPath = Environment.ExpandEnvironmentVariables(booksFolderPath);
            string userDirectoryPath = Path.Combine(expandedPath, searchQuery);

            if (Directory.Exists(userDirectoryPath))
            {
                // Check if search query is a directory name (author name)
                PopulateUsersDataGridView(searchQuery);
            }
            else
            {
                // Check if search query is a book name
                MessageBox.Show("not books");
            }
        }

        private void DebtbookUSer_Load(object sender, EventArgs e)
        {
            string searchQuery = nameTx.Text;
            PopulateUsersDataGridView(searchQuery);
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
    }
}
