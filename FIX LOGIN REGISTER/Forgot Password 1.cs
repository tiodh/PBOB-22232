using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FIX_LOGIN_REGISTER
{
    public partial class Forgot_Password_1 : Form
    {
        private Size formOriginalSize;
        private Rectangle rectb1;
        private Rectangle rectb2;
        private Rectangle rectb3;
        private Rectangle rectb4;
        private Rectangle reclb1;
        private Rectangle reclb2;
        private Rectangle reclb3;
        private Rectangle reclb4;
        private Rectangle recdtp1;
        private Rectangle recgb1;
        private Rectangle recpb1;
        public Forgot_Password_1()
        {
            InitializeComponent();
            this.Resize += Forgot_Password_1_Resize;
            formOriginalSize = this.Size;
            rectb1  = new Rectangle(tbox1.Location, tbox1.Size);
            rectb2  = new Rectangle(tbox2.Location, tbox2.Size);
            rectb1  = new Rectangle(tbox3.Location, tbox3.Size);
            rectb2  = new Rectangle(tbox4.Location, tbox4.Size);
            reclb1  = new Rectangle(lbl1.Location, lbl1.Size);
            reclb2  = new Rectangle(lbl2.Location, lbl2.Size);
            reclb3  = new Rectangle(lbl3.Location, lbl3.Size);
            reclb4  = new Rectangle(lbl4.Location, lbl4.Size);
            recdtp1 = new Rectangle(dtpick1.Location, dtpick1.Size);
            recgb1  = new Rectangle(btn1.Location, btn1.Size);
            recpb1  = new Rectangle(pcbox1.Location, pcbox1.Size);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.AutoSize = false;

            //textBox1.Height = 32;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tbox1.Focus();
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            lbl1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            tbox1.Focus();
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            lbl1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            tbox4.Focus();
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            lbl4.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tbox2.Focus();
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            lbl2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tbox3.Focus();
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            lbl3.Visible = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //textBox4.AutoSize = false;
            //textBox4.Height = 32;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.AutoSize = false;
            //textBox2.Height = 32;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //textBox3.AutoSize = false;
            //textBox3.Height = 32;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            tbox4.Focus();
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            lbl4.Visible = false;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            tbox2.Focus();
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            lbl2.Visible = false;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            tbox3.Focus();
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            lbl3.Visible = false;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                tbox1.Focus();
                lbl1.Visible = false;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                tbox3.Focus();
                lbl3.Visible = false;
            }
        }

        private void Forgot_Password_1_Resize(object sender, EventArgs e)
        {
            resize_Control(tbox1, rectb1);
            resize_Control(tbox2, rectb2);
            resize_Control(tbox3, rectb3);
            resize_Control(tbox4, rectb4);
            resize_Control(lbl1, reclb1);
            resize_Control(lbl2, reclb2);
            resize_Control(lbl3, reclb3);
            resize_Control(lbl4, reclb4);
            resize_Control(dtpick1, recdtp1);
            resize_Control(btn1, recgb1);
            resize_Control(pcbox1, recpb1);
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

        private void Forgot_Password_1_Load(object sender, EventArgs e)
        {

        }
    }
}
