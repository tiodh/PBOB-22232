
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;

namespace FIX_LOGIN_REGISTER
{
    public partial class Sign_Up : Form
    {

        private Size formOriginalSize;
        private Rectangle rectb7;
        private Rectangle rectb1;
        private Rectangle rectb2;
        private Rectangle rectb3;
        private Rectangle rectb4;
        private Rectangle rectb5;
        private Rectangle rectb6;
        private Rectangle reclbl17;
        private Rectangle reclbl1;
        private Rectangle reclbl2;
        private Rectangle reclbl3;
        private Rectangle reclbl4;
        private Rectangle reclbl5;
        private Rectangle reclbl6;
        private Rectangle reclbl15;
        private Rectangle reclbl16;
        private Rectangle reclbl7;
        private Rectangle reclbl8;
        private Rectangle reclbl9;
        private Rectangle recdtp1;
        private Rectangle reccb1;
        private Rectangle reccb2;
        private Rectangle reccb3;
        private Rectangle reclinklbl2;
        private Rectangle recgb1;
        private Rectangle recpb1;

        public Sign_Up()
        {
            InitializeComponent();
            this.Resize += Sign_Up_Resize;
            formOriginalSize = this.Size;
            rectb7 = new Rectangle(tbox7.Location, tbox7.Size);
            rectb1 = new Rectangle(tbox1.Location, tbox1.Size);
            rectb2 = new Rectangle(tbox2.Location, tbox2.Size);
            rectb3 = new Rectangle(tbox3.Location, tbox3.Size);
            rectb4 = new Rectangle(tbox4.Location, tbox4.Size);
            rectb5 = new Rectangle(tbox5.Location, tbox5.Size);
            rectb6 = new Rectangle(tbox6.Location, tbox6.Size);
            reclbl17 = new Rectangle(lbl17.Location, lbl17.Size);
            reclbl1 = new Rectangle(lbl1.Location, lbl1.Size);
            reclbl2 = new Rectangle(lbl2.Location, lbl2.Size);
            reclbl3 = new Rectangle(lbl3.Location, lbl3.Size);
            reclbl4 = new Rectangle(lbl4.Location, lbl4.Size);
            reclbl5 = new Rectangle(lbl5.Location, lbl5.Size);
            reclbl6 = new Rectangle(lbl6.Location, lbl6.Size);
            reclbl15 = new Rectangle(lbl15.Location, lbl15.Size);
            reclbl16 = new Rectangle(lbl16.Location, lbl16.Size);
            reclbl7 = new Rectangle(lbl7.Location, lbl7.Size);
            reclbl8 = new Rectangle(lbl8.Location, lbl8.Size);
            reclbl9 = new Rectangle(lbl9.Location, lbl9.Size);
            recdtp1 = new Rectangle(dtpick1.Location, dtpick1.Size);
            reccb1 = new Rectangle(cbox1.Location, cbox1.Size);
            reccb2 = new Rectangle(cbox2.Location, cbox2.Size);
            reccb3 = new Rectangle(cbox3.Location, cbox3.Size);
            reclinklbl2 = new Rectangle(linklbl2.Location, linklbl2.Size);
            recgb1 = new Rectangle(btn1.Location, btn1.Size);
            recpb1 = new Rectangle(pcbox1.Location, pcbox1.Size);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox5.Text == "") { lbl5.Visible = true; } else { lbl5.Visible = false; }
            if (tbox6.Text == "") { lbl15.Visible = true; } else { lbl15.Visible = false; }
            if (tbox7.Text == "") { lbl17.Visible = true; } else { lbl17.Visible = false; }
            tbox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lbl2.Visible = false;
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox5.Text == "") { lbl5.Visible = true; } else { lbl5.Visible = false; }
            if (tbox6.Text == "") { lbl15.Visible = true; } else { lbl15.Visible = false; }
            if (tbox7.Text == "") { lbl17.Visible = true; } else { lbl17.Visible = false; }
            tbox2.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            lbl3.Visible = false;
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox5.Text == "") { lbl5.Visible = true; } else { lbl5.Visible = false; }
            if (tbox6.Text == "") { lbl15.Visible = true; } else { lbl15.Visible = false; }
            if (tbox7.Text == "") { lbl17.Visible = true; } else { lbl17.Visible = false; }
            tbox3.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            lbl4.Visible = false;
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox5.Text == "") { lbl5.Visible = true; } else { lbl5.Visible = false; }
            if (tbox6.Text == "") { lbl15.Visible = true; } else { lbl15.Visible = false; }
            if (tbox7.Text == "") { lbl17.Visible = true; } else { lbl17.Visible = false; }
            tbox4.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            lbl5.Visible = false;
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox6.Text == "") { lbl15.Visible = true; } else { lbl15.Visible = false; }
            if (tbox7.Text == "") { lbl17.Visible = true; } else { lbl17.Visible = false; }
            tbox5.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbox1.Text == "")
            {
                lbl13.Text = "Please enter firsth name";
            }
            else
            {
                lbl13.Text = "";
            }
            lbl1.Visible = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (tbox2.Text == "")
            {
                lbl14.Text = "Please enter last name";
            }
            else
            {
                lbl14.Text = "";
            }
            lbl2.Visible = false;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (tbox3.Text == "")
            {
                lbl10.Text = "Please enter username";
            }
            else
            {
                lbl10.Text = "";
            }
            lbl3.Visible = false;



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (tbox4.Text == "")
            {
                lbl11.Text = "Please enter password";
            }
            else
            {
                lbl11.Text = "";
            }
            lbl4.Visible = false;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (tbox5.Text == "")
            {
                lbl12.Text = "Please enter confirm password";
            }
            else
            {
                lbl12.Text = "";
            }
            lbl5.Visible = false;

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox5.Text == "") { lbl5.Visible = true; } else { lbl5.Visible = false; }
            if (tbox6.Text == "") { lbl15.Visible = true; } else { lbl15.Visible = false; }
            if (tbox7.Text == "") { lbl17.Visible = true; } else { lbl17.Visible = false; }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            lbl2.Visible = false;
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox5.Text == "") { lbl5.Visible = true; } else { lbl5.Visible = false; }
            if (tbox6.Text == "") { lbl15.Visible = true; } else { lbl15.Visible = false; }
            if (tbox7.Text == "") { lbl17.Visible = true; } else { lbl17.Visible = false; }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            lbl3.Visible = false;
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox5.Text == "") { lbl5.Visible = true; } else { lbl5.Visible = false; }
            if (tbox6.Text == "") { lbl15.Visible = true; } else { lbl15.Visible = false; }
            if (tbox7.Text == "") { lbl17.Visible = true; } else { lbl17.Visible = false; }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            lbl4.Visible = false;
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox5.Text == "") { lbl5.Visible = true; } else { lbl5.Visible = false; }
            if (tbox6.Text == "") { lbl15.Visible = true; } else { lbl15.Visible = false; }
            if (tbox7.Text == "") { lbl17.Visible = true; } else { lbl17.Visible = false; }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            lbl5.Visible = false;
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox6.Text == "") { lbl15.Visible = true; } else { lbl5.Visible = false; }
            if (tbox7.Text == "") { lbl17.Visible = true; } else { lbl17.Visible = false; }
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                tbox3.Focus();
                lbl3.Visible = false;
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                tbox4.Focus();
                lbl4.Visible = false;
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                tbox5.Focus();
                lbl5.Visible = false;
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                tbox6.Focus();
                lbl15.Visible = false;
            }
        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void label9_Click(object sender, EventArgs e)
        {
            lbl9.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            if (tbox1.Text == "")
            {
                lbl13.Show();
            }
            else
            {
                lbl13.Hide();
            }
            if (tbox2.Text == "")
            {
                lbl14.Show();
            }
            else { lbl14.Hide(); }
            if (tbox3.Text == "")
            {
                lbl10.Show();
            }
            else
            {
                lbl10.Hide();
            }
            if (tbox4.Text == "")
            {
                lbl11.Show();
            }
            else
            {
                lbl11.Hide();
            }
            if (tbox5.Text == "")
            {
                lbl12.Show();
            }
            else
            {
                lbl12.Hide();
            }
            if (tbox7.Text == "")
            {
                lbl18.Show();
            }
            else
            {
                lbl18.Hide();
            }
            return;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            lbl17.Visible = false;
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox5.Text == "") { lbl5.Visible = true; } else { lbl5.Visible = false; }
            if (tbox6.Text == "") { lbl15.Visible = true; } else { lbl15.Visible = false; }
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            tbox7.Focus();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (tbox7.Text == "")
            {
                lbl18.Text = "Please enter NIK";
            }
            else
            {
                lbl18.Text = "";
            }
            lbl17.Visible = false;

        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            lbl17.Visible = false;
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox5.Text == "") { lbl5.Visible = true; } else { lbl5.Visible = false; }
            if (tbox6.Text == "") { lbl15.Visible = true; } else { lbl5.Visible = false; }
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }

        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            lbl15.Visible = false;
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox5.Text == "") { lbl5.Visible = true; } else { lbl5.Visible = false; }
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox7.Text == "") { lbl17.Visible = true; } else { lbl17.Visible = false; }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            lbl15.Visible = false;

        }

        private void label15_Click(object sender, EventArgs e)
        {
            lbl15.Visible = false;
            if (tbox2.Text == "") { lbl2.Visible = true; } else { lbl2.Visible = false; }
            if (tbox3.Text == "") { lbl3.Visible = true; } else { lbl3.Visible = false; }
            if (tbox4.Text == "") { lbl4.Visible = true; } else { lbl4.Visible = false; }
            if (tbox5.Text == "") { lbl5.Visible = true; } else { lbl5.Visible = false; }
            if (tbox1.Text == "") { lbl1.Visible = true; } else { lbl1.Visible = false; }
            if (tbox7.Text == "") { lbl17.Visible = true; } else { lbl17.Visible = false; }
            tbox6.Focus();
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                tbox1.Focus();
                lbl1.Visible = false;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void Sign_Up_Resize(object sender, EventArgs e)
        {
            resize_Control(tbox7, rectb7);
            resize_Control(tbox1, rectb1);
            resize_Control(tbox2, rectb2);
            resize_Control(tbox3, rectb3);
            resize_Control(tbox4, rectb4);
            resize_Control(tbox5, rectb5);
            resize_Control(tbox6, rectb6);
            resize_Control(lbl17, reclbl17);
            resize_Control(lbl1, reclbl1);
            resize_Control(lbl2, reclbl2);
            resize_Control(lbl3, reclbl3);
            resize_Control(lbl4, reclbl4);
            resize_Control(lbl5, reclbl5);
            resize_Control(lbl15, reclbl15);
            resize_Control(lbl16, reclbl16);
            resize_Control(lbl6, reclbl6);
            resize_Control(lbl7, reclbl7);
            resize_Control(lbl8, reclbl8);
            resize_Control(lbl9, reclbl9);
            resize_Control(dtpick1, recdtp1);
            resize_Control(cbox3, reccb3);
            resize_Control(cbox2, reccb2);
            resize_Control(cbox1, reccb1);
            resize_Control(linklbl2, reclinklbl2);
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
    }
}
