using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Security.Cryptography;
using Npgsql;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Guna.Charts;

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
            rectb1 = new Rectangle(textBox1.Location, textBox1.Size);
            rectb2 = new Rectangle(textBox2.Location, textBox2.Size);
            reclb1 = new Rectangle(label1.Location, label1.Size);
            reclb2 = new Rectangle(label2.Location, label2.Size);
            reclb3 = new Rectangle(label3.Location, label3.Size);
            reclb4 = new Rectangle(label4.Location, label4.Size);
            reclb13 = new Rectangle(label13.Location, label13.Size);
            reclinklbl1 = new Rectangle(linkLabel1.Location, linkLabel1.Size);
            reclinklbl2 = new Rectangle(linkLabel2.Location, linkLabel2.Size);
            recgb1 = new Rectangle(guna2GradientTileButton1.Location, guna2GradientTileButton1.Size);
            recpb1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recpb2 = new Rectangle(pictureBox2.Location, pictureBox2.Size);
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
            label1.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }


        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }

            textBox2.Focus();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

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
            resize_Control(textBox1, rectb1);
            resize_Control(textBox2, rectb2);
            resize_Control(label1, reclb1);
            resize_Control(label2, reclb2);
            resize_Control(label3, reclb3);
            resize_Control(label4, reclb4);
            resize_Control(label13, reclb13);
            resize_Control(linkLabel1, reclinklbl1);
            resize_Control(linkLabel2, reclinklbl2);
            resize_Control(guna2GradientTileButton1, recgb1);
            resize_Control(pictureBox1, recpb1);
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




