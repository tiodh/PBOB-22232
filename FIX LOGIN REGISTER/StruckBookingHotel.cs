using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace rembangan_part_5
{
    public partial class Form1 : Form
    {
        private Size formOriginalSize;
        private Rectangle recpxb4;
        private Rectangle recpxb3;
        private Rectangle recpxb1;
        private Rectangle recpxb2;
        private Rectangle recbutton1;
        private Rectangle rectabel2;
        private Rectangle rectabel3;
        private Rectangle rectabel5;
        private Rectangle rectabel6;
        private Rectangle rectabel7;
        private Rectangle rectabel8;
        private Rectangle rectabel9;
        private Rectangle rectabel10;
        private Rectangle rectabel11;
        private Rectangle rectabel12;
        private Rectangle rectabel13;
        private Rectangle rectabel14;
        private Rectangle rectabel15;
        private Rectangle rectabel16;
        private Rectangle rectabel17;
        private Rectangle rectabel18;
        private Rectangle rectabel19;
        private Rectangle rectabel20;
        private Rectangle rectabel22;
        private Rectangle rectabel24;
        private Rectangle rectabel25;
        private Rectangle rectabel26;
        private Rectangle rectabel27;
        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            recpxb4 = new Rectangle(pictureBox4.Location, pictureBox4.Size);
            recpxb1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recpxb3 = new Rectangle(pictureBox3.Location, pictureBox3.Size);
            recpxb2 = new Rectangle(pictureBox2.Location, pictureBox2.Size);
            recbutton1 = new Rectangle(guna2Button1.Location, guna2Button1.Size);
            rectabel2 = new Rectangle(label2.Location, rectabel2.Size);
            rectabel3 = new Rectangle(label3.Location, rectabel3.Size);
            rectabel5 = new Rectangle(label5.Location, rectabel5.Size);
            rectabel6 = new Rectangle(label6.Location, rectabel6.Size);
            rectabel7 = new Rectangle(label7.Location, rectabel7.Size);
            rectabel8 = new Rectangle(label8.Location, rectabel8.Size);
            rectabel9 = new Rectangle(label9.Location, rectabel9.Size);
            rectabel10 = new Rectangle(label10.Location, rectabel10.Size);
            rectabel11 = new Rectangle(label11.Location, rectabel11.Size);
            rectabel12 = new Rectangle(label12.Location, rectabel12.Size);
            rectabel13 = new Rectangle(label13.Location, rectabel13.Size);
            rectabel14 = new Rectangle(label14.Location, rectabel14.Size);
            rectabel15 = new Rectangle(label15.Location, rectabel15.Size);
            rectabel16 = new Rectangle(label16.Location, rectabel16.Size);
            rectabel17 = new Rectangle(label17.Location, rectabel17.Size);
            rectabel18 = new Rectangle(label18.Location, rectabel18.Size);
            rectabel19 = new Rectangle(label19.Location, rectabel19.Size);
            rectabel20 = new Rectangle(label20.Location, rectabel20.Size);
            rectabel22 = new Rectangle(label22.Location, rectabel22.Size);
            rectabel24 = new Rectangle(label24.Location, rectabel24.Size);
            rectabel25 = new Rectangle(label25.Location, rectabel25.Size);
            rectabel26 = new Rectangle(label26.Location, rectabel26.Size);
            rectabel27 = new Rectangle(label27.Location, rectabel27.Size);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(pictureBox4, recpxb4);
            resize_Control(pictureBox1, recpxb1);
            resize_Control(pictureBox3, recpxb3);
            resize_Control(pictureBox2, recpxb2);
            resize_Control(guna2Button1, recbutton1);
            resize_Control(label2, rectabel2);
            resize_Control(label3, rectabel3);
            resize_Control(label5, rectabel5);
            resize_Control(label6, rectabel6);
            resize_Control(label7, rectabel7);
            resize_Control(label8, rectabel8);
            resize_Control(label9, rectabel9);
            resize_Control(label10, rectabel10);
            resize_Control(label11, rectabel11);
            resize_Control(label12, rectabel12);
            resize_Control(label13, rectabel13);
            resize_Control(label14, rectabel14);
            resize_Control(label15, rectabel15);
            resize_Control(label16, rectabel16);
            resize_Control(label17, rectabel17);
            resize_Control(label18, rectabel18);
            resize_Control(label19, rectabel19);
            resize_Control(label20, rectabel20);
            resize_Control(label22, rectabel22);
            resize_Control(label24, rectabel24);
            resize_Control(label25, rectabel25);
            resize_Control(label26, rectabel26);
            resize_Control(label27, rectabel27);



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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private bool button2 = false;
        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (button2)
            {
                guna2Button1.Text = "Booking";
                guna2Button1.ForeColor = Color.White;
                guna2Button1.FillColor = Color.FromArgb(8, 102, 255);
                button2 = false;
            }
            else
            {
                guna2Button1.Text = "Booked";
                guna2Button1.ForeColor = Color.WhiteSmoke;
                guna2Button1.FillColor = Color.DarkGray;
                button2 = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pictureBox5.Show();
        }
    }
}


