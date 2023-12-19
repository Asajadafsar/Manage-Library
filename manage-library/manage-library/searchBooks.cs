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
    public partial class searchBooks : Form
    {
        private string userFolderPath;
        public searchBooks(string username)
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
            {"RegistrationDate", ""},
            {"Author", ""},
            {"Availability", ""},
            {"BookShelf", ""},
            {"CodeBook", ""},
            {"Price", ""},
            {"Publisher", ""},
            {"UpdateDate", ""},
            {"id", ""}
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
            fileContents["RegistrationDate"],
            fileContents["Author"],
            fileContents["Availability"],
            fileContents["BookShelf"],
            fileContents["CodeBook"],
            fileContents["Price"],
            fileContents["Publisher"],
            fileContents["UpdateDate"],
            fileContents["id"]
                });
            }
            
        }
        private void back_Click(object sender, EventArgs e)
        {
            string username = Path.GetFileName(userFolderPath);
            ShowUserInfo(username);
        }
        private void AuthorDataGridView(string authorSearchQuery)
        {
            dataGridViewBooks.Rows.Clear();

            string booksFolderPath = @"%USERPROFILE%\source\repos\manage-library\manage-library\bin\books";
            string expandedPath = Environment.ExpandEnvironmentVariables(booksFolderPath);

            foreach (string bookFolder in Directory.GetDirectories(expandedPath))
            {
                string authorTxtFilePath = Path.Combine(bookFolder, "Author.txt");

                //Yes Author? OR no Author.txt this foolder mojood
                if (!File.Exists(authorTxtFilePath))
                {
                    continue;
                    //NO Author... next foolder
                }

                string authorName = File.ReadAllText(authorTxtFilePath);

                //check Author=searchTx
                if (authorName.Equals(authorSearchQuery, StringComparison.OrdinalIgnoreCase))
                {
                    //if Author Ok read all file 
                    string[] allTxtFiles = Directory.GetFiles(bookFolder, "*.txt");
                    Dictionary<string, string> bookInfo = new Dictionary<string, string>();

                    foreach (string txtFile in allTxtFiles)
                    {
                        string key = Path.GetFileNameWithoutExtension(txtFile);
                        bookInfo[key] = File.ReadAllText(txtFile);
                    }

                    dataGridViewBooks.Rows.Add(new object[]
                    {
                Path.GetFileName(bookFolder),
                //folder=bookname
                bookInfo.TryGetValue("RegistrationDate", out var registrationDate) ? registrationDate : "",
                authorName,
                bookInfo.TryGetValue("Availability", out var availability) ? availability : "",
                bookInfo.TryGetValue("BookShelf", out var bookShelf) ? bookShelf : "",
                bookInfo.TryGetValue("CodeBook", out var codeBook) ? codeBook : "",
                bookInfo.TryGetValue("Price", out var price) ? price : "",
                bookInfo.TryGetValue("Publisher", out var publisher) ? publisher : "",
                bookInfo.TryGetValue("UpdateDate", out var UpdateDate) ? UpdateDate : "",
                bookInfo.TryGetValue("id", out var id) ? id : ""
                    });
                }
            }

            
        }
        private void Search_Click(object sender, EventArgs e)
        {

            string searchQuery = SearchTx.Text;
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
                AuthorDataGridView(searchQuery);
            }

            //Upload info books by string searchQuery

        }
       
        private void searchBooks_Load(object sender, EventArgs e)
        {
            string searchQuery = SearchTx.Text;
            PopulateUsersDataGridView(searchQuery);
        }
    }
}
