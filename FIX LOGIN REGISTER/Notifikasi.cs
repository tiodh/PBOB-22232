using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Project_Interface_PBO_B

{

    public partial class Notifikasi : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );

        private IconButton currentBtn;
        private Panel topBorderBtn;

        public Notifikasi()
        {
            InitializeComponent();
            topBorderBtn = new Panel();
            topBorderBtn.Size = new Size(5, 50);
            panel1.Controls.Add(topBorderBtn);
        }
        private struct RGBColors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(0, 0, 255);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(0, 0, 255);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(0, 0, 255);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(0, 0, 255);

        }
        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;

                topBorderBtn.BackColor = color;
                topBorderBtn.Location = new Point(244, currentBtn.Location.Y);
                topBorderBtn.Visible = false;
                topBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = System.Drawing.Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 30, 30));
            pictureBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 30, 30));
            pictureBox5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox5.Width, pictureBox5.Height, 30, 30));
            pictureBox6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox6.Width, pictureBox6.Height, 30, 30));
            pictureBox7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox7.Width, pictureBox7.Height, 30, 30));
            pictureBox8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox8.Width, pictureBox8.Height, 30, 30));
            pictureBox9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox9.Width, pictureBox9.Height, 30, 30));
            pictureBox10.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox10.Width, pictureBox10.Height, 30, 30));
            pictureBox11.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox11.Width, pictureBox11.Height, 30, 30));
            pictureBox12.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox12.Width, pictureBox12.Height, 30, 30));
            panel11.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel11.Width, panel11.Height, 30, 30));
            panel1.Parent = pictureBox15;
            panel1.BackColor = System.Drawing.Color.Transparent;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {

        }
    }
}