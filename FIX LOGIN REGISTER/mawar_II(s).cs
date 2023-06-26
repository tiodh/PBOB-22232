using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIX_LOGIN_REGISTER
{
    public partial class mawar_II_s_ : Form
    {
        private Login.User user;
        public System.Windows.Forms.Label label;
        public mawar_II_s_(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Lb_close_MouseUp(object sender, MouseEventArgs e)
        {
            ////Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\efek close2.png");
        }

        private void Lb_close_MouseDown(object sender, MouseEventArgs e)
        {
            ////Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\efek close1.png");
        }

        int i;
        private void mawar_II_s__Load(object sender, EventArgs e)
        {
            i = list_mawar.parentY + 150;
            this.StartPosition = FormStartPosition.CenterScreen;
            effectDetail_mawar_IIs.Start();
        }

        private void Lb_close_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            ////Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\X.png");
        }

        private void Lb_close_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            //Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button back.png");
        }

        private void Lb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void effectDetail_mawar_IIs_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                effectDetail_mawar_IIs.Stop();
            }
            else
            {
                Opacity += 0.03;
            }

            int targetY = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2; // Menghitung koordinat Y tengah layar
            int targetX = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2; // Menghitung koordinat X tengah layar

            int y = list_mawar.parentY += 3; // INCREMENT
            this.Location = new Point(targetX, y); // Mengatur posisi form pada koordinat X tengah layar dan koordinat Y yang berubah
            if (y >= targetY)
            {
                effectDetail_mawar_IIs.Stop();
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
