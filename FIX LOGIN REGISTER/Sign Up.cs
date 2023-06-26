using Npgsql;
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
            rectb7 = new Rectangle(textBox7.Location, textBox7.Size);
            rectb1 = new Rectangle(textBox1.Location, textBox1.Size);
            rectb2 = new Rectangle(textBox2.Location, textBox2.Size);
            rectb3 = new Rectangle(textBox3.Location, textBox3.Size);
            rectb4 = new Rectangle(textBox4.Location, textBox4.Size);
            rectb5 = new Rectangle(textBox5.Location, textBox5.Size);
            rectb6 = new Rectangle(textBox6.Location, textBox6.Size);
            reclbl17 = new Rectangle(label17.Location, label17.Size);
            reclbl1 = new Rectangle(label1.Location, label1.Size);
            reclbl2 = new Rectangle(label2.Location, label2.Size);
            reclbl3 = new Rectangle(label3.Location, label3.Size);
            reclbl4 = new Rectangle(label4.Location, label4.Size);
            reclbl5 = new Rectangle(label5.Location, label5.Size);
            reclbl6= new Rectangle(label6.Location, label6.Size);
            reclbl15 = new Rectangle(label15.Location, label15.Size);
            reclbl16 = new Rectangle(label16.Location, label16.Size);
            reclbl7 = new Rectangle(label7.Location, label7.Size);
            reclbl8 = new Rectangle(label8.Location, label8.Size);
            reclbl9 = new Rectangle(label9.Location, label9.Size);
            recdtp1 = new Rectangle(dateTimePicker1.Location, dateTimePicker1.Size);
            reccb1 = new Rectangle(comboBox1.Location, comboBox1.Size);
            reccb2 = new Rectangle(comboBox2.Location, comboBox2.Size);
            reccb3 = new Rectangle(comboBox3.Location, comboBox3.Size);
            reclinklbl2 = new Rectangle(linkLabel2.Location, linkLabel2.Size);
            recgb1 = new Rectangle(guna2GradientTileButton1.Location, guna2GradientTileButton1.Size);
            recpb1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
            textBox2.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
            textBox3.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
            textBox4.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
            textBox5.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label13.Text = "Please enter firsth name";
            }
            else
            {
                label13.Text = "";
            }
            label1.Visible = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label14.Text = "Please enter last name";
            }
            else
            {
                label14.Text = "";
            }
            label2.Visible = false;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                label10.Text = "Please enter username";
            }
            else
            {
                label10.Text = "";
            }
            label3.Visible = false;



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                label11.Text = "Please enter password";
            }
            else
            {
                label11.Text = "";
            }
            label4.Visible = false;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                label12.Text = "Please enter confirm password";
            }
            else
            {
                label12.Text = "";
            }
            label5.Visible = false;

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label5.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBox2.Focus();
                label2.Visible = false;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBox3.Focus();
                label3.Visible = false;
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBox4.Focus();
                label4.Visible = false;
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBox5.Focus();
                label5.Visible = false;
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBox6.Focus();
                label15.Visible = false;
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
            label9.Visible = false;
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            label17.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            textBox7.Focus();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                label18.Text = "Please enter NIK";
            }
            else
            {
                label18.Text = "";
            }
            label17.Visible = false;

        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            label17.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label5.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }

        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            label15.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label15.Visible = false;

        }

        private void label15_Click(object sender, EventArgs e)
        {
            label15.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
            textBox6.Focus();
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBox1.Focus();
                label1.Visible = false;
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
            resize_Control(textBox7, rectb7);
            resize_Control(textBox1, rectb1);
            resize_Control(textBox2, rectb2);
            resize_Control(textBox3, rectb3);
            resize_Control(textBox4, rectb4);
            resize_Control(textBox5, rectb5);
            resize_Control(textBox6, rectb6);
            resize_Control(label17, reclbl17);
            resize_Control(label1, reclbl1);
            resize_Control(label2, reclbl2);
            resize_Control(label3, reclbl3);
            resize_Control(label4, reclbl4);
            resize_Control(label5, reclbl5);
            resize_Control(label15, reclbl15);
            resize_Control(label16, reclbl16);
            resize_Control(label6, reclbl6);
            resize_Control(label7, reclbl7);
            resize_Control(label8, reclbl8);
            resize_Control(label9, reclbl9);
            resize_Control(dateTimePicker1, recdtp1);
            resize_Control(comboBox3, reccb3);
            resize_Control(comboBox2, reccb2);
            resize_Control(comboBox1, reccb1);
            resize_Control(linkLabel2, reclinklbl2);
            resize_Control(guna2GradientTileButton1, recgb1);
            resize_Control(pictureBox1, recpb1);

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
