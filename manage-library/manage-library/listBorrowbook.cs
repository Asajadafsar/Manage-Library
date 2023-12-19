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
    public partial class listBorrowbook : Form
    {
        public listBorrowbook()
        {
            InitializeComponent();
            ApplyRoundedCorners();
            string folderPath = @"C:\\Users\\sajad\\source\\repos\\manage-library\\manage-library\\bin\\successful";
            //string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "successful");

            string[] filePaths = Directory.GetFiles(folderPath, "*-successfully.txt");
            string[] rowValues = new string[filePaths.Length];
            foreach (string filePath in filePaths)
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    int itemCount = lines.Length / 4;

                    for (int i = 0; i < itemCount; i++)
                    {
                        string[] values = new string[4];

                        for (int j = 0; j < 4; j++)
                        {
                            values[j] = lines[i * 4 + j];
                        }

                        dataGridView1.Rows.Add(values);
                    }
                }
                catch (Exception ex)
                {
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
    }
}
