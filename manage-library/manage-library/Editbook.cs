using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manage_library
{

    public partial class Editbook : Form
    {
        string bookFolderPath;
        public Editbook()
        {
            InitializeComponent();
            addIteam();
            ApplyRoundedCorners();
        }
        public void addIteam()
        {
            string folderPath = @"%USERPROFILE%\source\repos\manage-library\manage-library\bin\bookshelf";
            //C:\\Users\\sajad\\source\\repos\\manage-library\\manage-library\\bin\\bookshelf
            string expandedPath = Environment.ExpandEnvironmentVariables(folderPath);


            if (Directory.Exists(expandedPath))
            {
                // nadide gereftan foolder mojod
                var existingItems = new HashSet<string>(BookshelfCom.Items.Cast<string>());

                // ckeck mojood foolder?
                foreach (string subdirectory in Directory.GetDirectories(expandedPath))
                {
                    string subdirectoryName = Path.GetFileName(subdirectory); 

                    if (!existingItems.Contains(subdirectoryName))
                    {
                        BookshelfCom.Items.Add(subdirectoryName); 
                    }
                }
            }
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string bookName = Texboxname.Text;
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string bookFolderPath = Path.Combine(userProfile, @"source\repos\manage-library\manage-library\bin\books", bookName);
            //@"C:\Users\sajad\source\repos\manage-library\manage-library\bin\books"

            if (!Directory.Exists(bookFolderPath))
            {
                MessageBox.Show("Book not found.");
                return;
            }

            //view info book
            CodeTx.Text = File.ReadAllText(Path.Combine(bookFolderPath, "CodeBook.txt"));
            PriceTx.Text = File.ReadAllText(Path.Combine(bookFolderPath, "Price.txt"));
            publisherTx.Text = File.ReadAllText(Path.Combine(bookFolderPath, "Publisher.txt"));
            AuthorTx.Text = File.ReadAllText(Path.Combine(bookFolderPath, "Author.txt"));
            BookshelfCom.Text = File.ReadAllText(Path.Combine(bookFolderPath, "BookShelf.txt"));
            if (bool.TryParse(File.ReadAllText(Path.Combine(bookFolderPath, "Availability.txt")), out bool isAvailable))
            {
                //check radiobutton True or False this veiw
                Available.Checked = isAvailable;
                unavailable.Checked = !isAvailable;
            }
            try
            {
                string filePath = Path.Combine(bookFolderPath, "RegistrationDate.txt");
                string registrationDateString = File.ReadAllText(filePath).Trim(); 
                CreatedAtTDat.Value = DateTime.ParseExact(registrationDateString, "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                //convert format file txt MM/dd/yyyy hh:mm:ss tt(12/14/2023 2:50:11 PM)
            }
            catch (FormatException ex)
            {
                /*MessageBox.Show($"خطا در تبدیل تاریخ: {ex.Message}");*/
            }
            //view image image
            imageBook.ImageLocation = Path.Combine(bookFolderPath, "ImageBook.jpg");
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminpanel adminpanel = new adminpanel();
            adminpanel.Show();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "select";
            ofd.Filter = "Images (*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd.InitialDirectory = @"C:\";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageBook.Image = Image.FromFile(ofd.FileName);

                // copy file  image
                string imagePath = Path.Combine(bookFolderPath, "ImageBook.jpg");
                File.Copy(ofd.FileName, imagePath, true);

            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string registrationDate = UpdatedAtTDat.Value.ToString("yyyy-MM-dd");
            File.WriteAllText(Path.Combine(bookFolderPath, "UpdateDate.txt"), registrationDate);
            File.WriteAllText(Path.Combine(bookFolderPath, "BookShelf.txt"), BookshelfCom.Text);
            File.WriteAllText(Path.Combine(bookFolderPath, "Availability.txt"), Available.Checked.ToString());
            File.WriteAllText(Path.Combine(bookFolderPath, "Price.txt"), PriceTx.Text);
            File.WriteAllText(Path.Combine(bookFolderPath, "Publisher.txt"), publisherTx.Text);
            File.WriteAllText(Path.Combine(bookFolderPath, "AuthorName.txt"), AuthorTx.Text);
            File.WriteAllText(Path.Combine(bookFolderPath, "CodeBook.txt"), CodeTx.Text);
            File.WriteAllText(Path.Combine(bookFolderPath, "RegistrationDate.txt"), CreatedAtTDat.Value.ToString());
            MessageBox.Show("Book information saved successfully.");
            // File.WriteAllText(Path.Combine(bookFolderPath, "LastEditDate.txt"), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
