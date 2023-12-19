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
    public partial class addBook : Form
    {
        private static readonly Random random = new Random();
        public addBook()
        {
            InitializeComponent();
            GenerateRandomUserId();
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

        private void back_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            adminpanel adminpanel = new adminpanel();
            adminpanel.Show();
        }
        private void GenerateRandomUserId()
        {
            int randomId = random.Next(1000, 9999);
            //4 ragham random
            IdRandom.Text = randomId.ToString();
        }
        private void send_Click(object sender, EventArgs e)
        {
            //info disign
            string bookName = NameTx.Text;
            string codebook = CodeTx.Text;
            string price = PriceTx.Text;
            string publisher = publisherTx.Text;
            string authorName = AuthorTx.Text;
            string bookShelf = BookshelfCom.SelectedItem.ToString();
            string registrationDate = CreatedAtTDat.Value.ToString("yyyy-MM-dd");
            bool isAvailable = Available.Checked;
            string Rand = IdRandom.Text;
            //Path main foolder
            string mainBooksFolderPath = @"C:\Users\sajad\source\repos\manage-library\manage-library\bin\books";

            // check Path main True or False(mojood)
            if (!Directory.Exists(mainBooksFolderPath))
            {
                Directory.CreateDirectory(mainBooksFolderPath);
            }
            // creat foolder by book
            string safeBookName = new string(bookName.Where(ch => !Path.GetInvalidFileNameChars().Contains(ch)).ToArray());
            string bookFolderPath = Path.Combine(mainBooksFolderPath, safeBookName);
            if (!Directory.Exists(bookFolderPath))
            {
                Directory.CreateDirectory(bookFolderPath);
            }
            //save info joda joda this file txt
            File.WriteAllText(Path.Combine(bookFolderPath, "BookName.txt"), bookName);
            File.WriteAllText(Path.Combine(bookFolderPath, "CodeBook.txt"), codebook);
            File.WriteAllText(Path.Combine(bookFolderPath, "Price.txt"), price);
            File.WriteAllText(Path.Combine(bookFolderPath, "Publisher.txt"), publisher);
            File.WriteAllText(Path.Combine(bookFolderPath, "Author.txt"), authorName);
            File.WriteAllText(Path.Combine(bookFolderPath, "BookShelf.txt"), bookShelf);
            File.WriteAllText(Path.Combine(bookFolderPath, "RegistrationDate.txt"), registrationDate);
            File.WriteAllText(Path.Combine(bookFolderPath, "Availability.txt"), isAvailable.ToString());
            File.WriteAllText(Path.Combine(bookFolderPath, "id.txt"), Rand);

            // save image if select 
            if (imageBook.Image != null)
            {
                string imagePath = Path.Combine(bookFolderPath, "ImageBook.jpg");
                imageBook.Image.Save(imagePath);
            }
            MessageBox.Show("Book information saved successfully.");
        }
       
        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "select";
            ofd.Filter = "Images (*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd.InitialDirectory = @"C:\";
            ofd.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    imageBook.Image = Image.FromFile(filePath);
                }
            }
        }
    }
