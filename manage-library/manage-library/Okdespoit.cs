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
    public partial class Okdespoit : Form
    {
        private HashSet<string> approvedRequests = new HashSet<string>();
        public Okdespoit()
        {
            InitializeComponent();
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
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminpanel adminpanel=new adminpanel();
            adminpanel.Show();
        }
        private void PopulateRequestsComboBox()
        {
            string requestsDirectory = @"%USERPROFILE%\source\repos\manage-library\manage-library\bin\request-admin";
            string expandedPathRequest = Environment.ExpandEnvironmentVariables(requestsDirectory);
            DirectoryInfo di = new DirectoryInfo(expandedPathRequest);
            //filter brayeh finde request files
            FileInfo[] requestFiles = di.GetFiles("*-admin-request.txt"); 
            comboBoxUsernames.Items.Clear(); 
            //clear iteams ghabli

            foreach (FileInfo file in requestFiles)
            {
                string requestName = file.Name.Replace("-admin-request.txt", "");
                if (!approvedRequests.Contains(requestName))
                {
                    comboBoxUsernames.Items.Add(requestName);
                }
            }
        }
        private void submit_Click(object sender, EventArgs e)
        {
            string selectedRequest = comboBoxUsernames.SelectedItem.ToString();
            string requestFilePath = Path.Combine(@"%USERPROFILE%\source\repos\manage-library\manage-library\bin\request-admin", $"{ selectedRequest}-admin-request.txt");
            string expandedPathFilePath = Environment.ExpandEnvironmentVariables(requestFilePath);
            string userDirectory = Path.Combine(Application.StartupPath, usernameTx.Text); 
            string successfullyFilePath = Path.Combine(@"%USERPROFILE%\source\repos\manage-library\manage-library\bin\successful", $"{selectedRequest}-successfully.txt");
            string expandedsuccessful = Environment.ExpandEnvironmentVariables(successfullyFilePath);

            string databrrow = dateTimePicker1.Value.ToString();
            string rep=dateTimePicker2.Value.ToString();


            string booksCountFilePath = Path.Combine(Application.StartupPath, usernameTx.Text, "books_count.txt");

            if (!File.Exists(booksCountFilePath))
            {
                File.WriteAllText(booksCountFilePath, "1");
            }
            else
            {
                int previousCount = int.Parse(File.ReadAllText(booksCountFilePath));

                int newCount = previousCount + 1;

                File.WriteAllText(booksCountFilePath, newCount.ToString());
            }

            string booksLine = $"history books={File.ReadAllText(booksCountFilePath)}";

            string booksFilePath = Path.Combine(userDirectory, "books.txt"); 
            File.AppendAllText(booksFilePath, booksLine);













            string[] lines = File.ReadAllLines(expandedPathFilePath);
            if (!Directory.Exists(userDirectory)) 
                //cerat foolder if not mojood
            {
                Directory.CreateDirectory(userDirectory);
            }
            string successfullyFilePathdata = Path.Combine(@"%USERPROFILE%\source\repos\manage-library\manage-library\bin\successful", $"{selectedRequest}-successfully-BorrowDate.txt");
            string expandedsuccessfuldata = Environment.ExpandEnvironmentVariables(successfullyFilePathdata);
            string successfullyFilePathdat = Path.Combine(@"%USERPROFILE%\source\repos\manage-library\manage-library\bin\successful", $"{selectedRequest}-successfully-ReturnDate.txt");
            string expandedsuccessfuldaa = Environment.ExpandEnvironmentVariables(successfullyFilePathdat);
            //creat file successfully.txt
            File.WriteAllLines(expandedsuccessful, lines);
            File.WriteAllText(expandedsuccessfuldata, databrrow);
            File.WriteAllText(expandedsuccessfuldaa, rep);

            // creat file books.txt
            File.AppendAllLines(booksFilePath, lines);
            //add list taidd shdeh
            approvedRequests.Add(selectedRequest);

            PopulateRequestsComboBox();
            //update combox
            MessageBox.Show("The request has been successfully approved.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUsername = comboBoxUsernames.SelectedItem.ToString();
            string filePath = Path.Combine(@"%USERPROFILE%\source\repos\manage-library\manage-library\bin\request-admin", $"{selectedUsername}-admin-request.txt");
            string expandedPathFilePath = Environment.ExpandEnvironmentVariables(filePath);


            if (File.Exists(expandedPathFilePath))
            {
                LoadRequestData(expandedPathFilePath);
            }
        }

        private void Okdespoit_Load(object sender, EventArgs e)
        {
            PopulateRequestsComboBox();

        }
        private void LoadRequestData(string filePath)
        {
            string[] requestData = File.ReadAllLines(filePath);

            booknameTX.Text = requestData.Length > 0 ? requestData[0] : "";
            codeTx.Text = requestData.Length > 1 ? requestData[1] : "";
            usernameTx.Text = requestData.Length > 2 ? requestData[2] : "";
            UserIdTx.Text = requestData.Length > 3 ? requestData[3] : "";
        }
        private void veiw_Click(object sender, EventArgs e)
        {
            
        }

    }
}
