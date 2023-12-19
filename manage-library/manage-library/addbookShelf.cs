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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace manage_library
{
   
    public partial class addbookShelf : Form
    {
        private static readonly Random random = new Random();
        public addbookShelf()
        {
            InitializeComponent();
            GenerateRandomUserId();

        }

        private void GenerateRandomUserId()
        {
            int randomId = random.Next(1000, 9999);
            //4 ragham random
            idR.Text = randomId.ToString();
        }
        private void send_Click(object sender, EventArgs e)
        {

            //BookshelfCom.Items.Add(NameTx.Text);
            string foldername;
            foldername = NameTx.Text;
            string folderpath = @"%USERPROFILE%\source\repos\manage-library\manage-library\bin\bookshelf";
            //C:\\Users\\sajad\\source\\repos\\manage-library\\manage-library\\bin\\bookshelf
            string expandedPath = Environment.ExpandEnvironmentVariables(folderpath);

            string safeBookName = new string(foldername.Where(ch => !Path.GetInvalidFileNameChars().Contains(ch)).ToArray());
            string bookshelfFolderPath = Path.Combine(expandedPath, safeBookName);
            if (!Directory.Exists(bookshelfFolderPath))
            {
                Directory.CreateDirectory(bookshelfFolderPath);
            }
            string bookName = NameTx.Text;
            string order = orderTx.Text;
            string id = idR.Text;
            //save info joda joda this file txt 
            File.WriteAllText(Path.Combine(bookshelfFolderPath, "name.txt"), NameTx.Text);
            File.WriteAllText(Path.Combine(bookshelfFolderPath, "order.txt"), orderTx.Text);
            File.WriteAllText(Path.Combine(bookshelfFolderPath, "id.txt"), idR.Text);
            

            MessageBox.Show("successfully registered");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminpanel adminpanel = new adminpanel();
            adminpanel.Show();
        }
    }
}