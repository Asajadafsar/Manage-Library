using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manage_library
{
    public partial class Form1 : Form
    {
        private bool isLoginShown = false;
        public Form1()
        {
            InitializeComponent();
            ApplyRoundedCorners();
            progressBar1.Maximum = 100;
            progressTimer.Interval = 500;
            //time load
            
            progressTimer.Tick += new EventHandler(progressTimer_Tick);
            progressTimer.Start();
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10; 
                //afzayesh
            }
            else if (!isLoginShown) // this condition prevents multiple form openings
            {
                isLoginShown = true;
                progressTimer.Stop();
                tab_admin_user tab_admin_user = new tab_admin_user();
                tab_admin_user.Show();
                this.Hide();
            }

        }

        private void ApplyRoundedCorners()
        {
            foreach (Control control in Controls)
            {
                if (control is ProgressBar)
                {
                    control.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, 30, 30));
                }
            }
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
    }
}
