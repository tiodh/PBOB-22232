using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FIX_LOGIN_REGISTER
{
    public partial class detail_suite : Form
    {
        

        public detail_suite()
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
        private void detail_suite_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //UpdateResult();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //UpdateResult();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UpdateResult();
            label17.Visible = true; label18.Visible = true; label16.Visible = true;
        }
    }
}
