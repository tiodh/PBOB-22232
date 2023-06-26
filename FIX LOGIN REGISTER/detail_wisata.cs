using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FIX_LOGIN_REGISTER
{
    public partial class detail_wisata : Form
    {
        private Login.User user;
        public System.Windows.Forms.Label label;
        public detail_wisata(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Lb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lb_close_MouseUp(object sender, MouseEventArgs e)
        {
            //Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\efek close2.png");
        }

        private void Lb_close_MouseDown(object sender, MouseEventArgs e)
        {
            //Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\efek close1.png");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //int i;
        private void detail_wisata_Load(object sender, EventArgs e)
        {
            //i = UserControl1_tiket_.parentY + 150;
            //this.Location = new Point(UserControl1_tiket_.parentX + 220, UserControl1_tiket_.parentY + 150);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Lb_close_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            //Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\X.png");
        }

        private void Lb_close_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            //Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button back.png");
        }

        
    }
}
