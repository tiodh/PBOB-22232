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
    public partial class StruckTiketMasuk : Form
    {

        private Size formOriginalSize;
        private Rectangle recpicture1;
        private Rectangle recpicture2;
        private Rectangle recpicture3;
        private Rectangle recpicture4;
        private Rectangle rectabel2;
        private Rectangle rectabel4;
        private Rectangle rectabel5;
        private Rectangle rectabel7;
        private Rectangle rectabel8;
        private Rectangle rectabel9;
        private Rectangle rectabel10;
        private Rectangle rectabel12;
        private Rectangle rectabel13;
        private Rectangle rectabel14;
        private Rectangle rectabel15;
        private Rectangle rectabel17;
        private Rectangle rectabel18;
        private Rectangle rectabel19;
        private Rectangle rectabel20;
        private Rectangle recbutton3;
        public StruckTiketMasuk()
        {
            InitializeComponent();
            this.Resize += Form2_Resize;
            formOriginalSize = this.Size;
            recpicture1 = new Rectangle(pictureBox2.Location, pictureBox2.Size);
            recpicture2 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recpicture3 = new Rectangle(pictureBox3.Location, pictureBox3.Size);
            recpicture4 = new Rectangle(pictureBox4.Location, pictureBox4.Size);
            recbutton3 = new Rectangle(guna2Button1.Location, guna2Button1.Size);
            rectabel2 = new Rectangle(label1.Location, label1.Size);
            rectabel4 = new Rectangle(label4.Location, label4.Size);
            rectabel5 = new Rectangle(label21.Location, label21.Size);
            rectabel7 = new Rectangle(label2.Location, label2.Size);
            rectabel8 = new Rectangle(label13.Location, label13.Size);
            rectabel9 = new Rectangle(label5.Location, label5.Size);
            rectabel10 = new Rectangle(label14.Location, label14.Size);
            rectabel13 = new Rectangle(label19.Location, label19.Size);
            rectabel15 = new Rectangle(label15.Location, label15.Size);
            rectabel18 = new Rectangle(label10.Location, label10.Size);
            rectabel20 = new Rectangle(label23.Location, label23.Size);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            resize_Control(pictureBox2, recpicture1);
            resize_Control(pictureBox1, recpicture2);
            resize_Control(pictureBox3, recpicture3);
            resize_Control(pictureBox4, recpicture4);
            resize_Control(guna2Button1, recbutton3);
            resize_Control(label19, rectabel13);
            resize_Control(label14, rectabel10);
            resize_Control(label21, rectabel5);
            resize_Control(label13, rectabel8);
            resize_Control(label5, rectabel9);
            resize_Control(label4, rectabel4);
            resize_Control(label2, rectabel7);
            resize_Control(label15, rectabel15);
            resize_Control(label10, rectabel18);
            resize_Control(label3, rectabel19);
            resize_Control(label23, rectabel20);

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

        private bool button1clicked = false;
        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {

            if (button1clicked)
            {
                guna2Button1.Text = "Booking";
                guna2Button1.ForeColor = Color.White;
                guna2Button1.FillColor = Color.FromArgb(8, 102, 255);
                button1clicked = false;
            }
            else
            {
                guna2Button1.Text = "Booked";
                guna2Button1.ForeColor = Color.WhiteSmoke;
                guna2Button1.FillColor = Color.DarkGray;
                button1clicked = true;
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pictureBox5.Show();
        }
    }
}
