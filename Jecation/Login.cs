using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;


namespace FIX_LOGIN_REGISTER
{
    public partial class Login : Form
    {
        private Size formOriginalSize;
        private Rectangle rectb1;
        private Rectangle rectb2;
        private Rectangle reclb1;
        private Rectangle reclb2;
        private Rectangle reclb3;
        private Rectangle reclb4;
        private Rectangle reclb13;
        private Rectangle reclinklbl1;
        private Rectangle reclinklbl2;
        private Rectangle recgb1;
        private Rectangle recpb1;
        private Rectangle recpb2;

        public Login()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            rectb1 = new Rectangle(tbox1.Location, tbox1.Size);
            rectb2 = new Rectangle(tbox2.Location, tbox2.Size);
            reclb1 = new Rectangle(lbl1.Location, lbl1.Size);
            reclb2 = new Rectangle(lbl2.Location, lbl2.Size);
            reclb3 = new Rectangle(lbl3.Location, lbl3.Size);
            reclb4 = new Rectangle(lbl4.Location, lbl4.Size);
            reclb13 = new Rectangle(lbl13.Location, lbl13.Size);
            reclinklbl1 = new Rectangle(linklbl1.Location, linklbl1.Size);
            reclinklbl2 = new Rectangle(linklbl2.Location, linklbl2.Size);
            recgb1 = new Rectangle(btn1.Location, btn1.Size);
            recpb1 = new Rectangle(pcbox1.Location, pcbox1.Size);
            recpb2 = new Rectangle(pictureBox2.Location, pictureBox2.Size);
        }

        public class User
        {

        }

        public class TokenManager
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }


        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            lbl2.Visible = false;
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            tbox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lbl2.Visible = false;
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }

            tbox2.Focus();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                tbox2.Focus();
                lbl2.Visible = false;
            }
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password_1 forgotpw1 = new Forgot_Password_1();
            forgotpw1.Show();
            this.Hide();
        }
        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up daftar = new Sign_Up();
            daftar.Show();
            this.Hide();
        }

        public void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(tbox1, rectb1);
            resize_Control(tbox2, rectb2);
            resize_Control(lbl1, reclb1);
            resize_Control(lbl2, reclb2);
            resize_Control(lbl3, reclb3);
            resize_Control(lbl4, reclb4);
            resize_Control(lbl13, reclb13);
            resize_Control(linklbl1, reclinklbl1);
            resize_Control(linklbl2, reclinklbl2);
            resize_Control(btn1, recgb1);
            resize_Control(pcbox1, recpb1);
            resize_Control(pictureBox2, recpb2);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }
    }
}




