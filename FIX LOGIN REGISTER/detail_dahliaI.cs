using Npgsql;
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
    public partial class detail_dahliaI : Form
    {
       
        public detail_dahliaI()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            //pictureBox2.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button left.png");
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            //pictureBox2.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button left2.png");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            //pictureBox2.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button left efek.png");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            //pictureBox2.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button left.png");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            StrukHotel struk = new StrukHotel(user);
            struk.Show();
            this.Hide();
        }

        private void detail_dahliaI_Load(object sender, EventArgs e)
        {
            
        }


        private void dateTimePicker14_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker13_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            label134.Visible = true;
            label133.Visible = true;
            label132.Visible = true;
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
