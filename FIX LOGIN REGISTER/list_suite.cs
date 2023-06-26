using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FIX_LOGIN_REGISTER
{

    public partial class list_suite : Form
    {
        private Login.User user;
        public static int parentX, parentY;
        private Size formOriginalSize;
        private Rectangle reclb_tittle_suite;
        private Rectangle recpnl_listSuite;
        private Rectangle reclabel20;
        private Rectangle recbtPesan_listSuite;
        private Rectangle reclabel10;
        private Rectangle reclabel11;
        private Rectangle reclabel12;
        private Rectangle reclabel13;
        private Rectangle reclabel3;
        private Rectangle recpictureBox1;
        private Rectangle recpictureBox5;
        private Rectangle recpictureBox6;
        private Rectangle recpictureBox7;
        private Rectangle recpictureBox8;
        private Rectangle recpictureBox9;
        private Rectangle reclbMount_suite;
        private Rectangle reclb_tittlesuite_;





        public list_suite(Login.User user)
        {
            InitializeComponent();
            this.user = user;
            this.Resize += list_suite_Resize;
            formOriginalSize = this.Size;
            reclb_tittle_suite = new Rectangle(lb_tittle_suite.Location, lb_tittle_suite.Size);
            recpnl_listSuite = new Rectangle(pnl_listSuite.Location, pnl_listSuite.Size);
            reclabel20 = new Rectangle(label20.Location, label20.Size);
            recbtPesan_listSuite = new Rectangle(btPesan_listSuite.Location, btPesan_listSuite.Size);
            reclabel10 = new Rectangle(label10.Location, label10.Size);
            reclabel11 = new Rectangle(label11.Location, label11.Size);
            reclabel12 = new Rectangle(label12.Location, label12.Size);
            reclabel13 = new Rectangle(label13.Location, label13.Size);
            reclabel3 = new Rectangle(label3.Location, label3.Size);
            recpictureBox1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recpictureBox5 = new Rectangle(pictureBox5.Location, pictureBox5.Size);
            recpictureBox6 = new Rectangle(pictureBox6.Location, pictureBox6.Size);
            recpictureBox7 = new Rectangle(pictureBox7.Location, pictureBox7.Size);
            recpictureBox8 = new Rectangle(pictureBox8.Location, pictureBox8.Size);
            recpictureBox9 = new Rectangle(pictureBox9.Location, pictureBox9.Size);
            reclbMount_suite = new Rectangle(lbMount_suite.Location, lbMount_suite.Size);
            reclb_tittlesuite_ = new Rectangle(lb_tittlesuite_.Location, lb_tittlesuite_.Size);

        }

        private void lb_tittleDahlia_Click(object sender, EventArgs e)
        {
            page_ut form_ut = new page_ut(user);
            form_ut.Show();
            this.Close();
        }


        private void btDetail_dahlia_I_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (Form2 modal = new Form2(user))
            {

                modalBackground.StartPosition = FormStartPosition.CenterScreen;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();

            }
        }


        private void btPesan_listDahlia_I_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (detail_suite modal = new detail_suite(user))
            {

                modalBackground.StartPosition = FormStartPosition.CenterScreen;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();

            }
        }

        private void pnl_listSuite_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_tittleMelati_Click(object sender, EventArgs e)
        {
            page_ut form_ut = new page_ut(user);
            form_ut.Show();
            this.Close();
        }

        private void list_suite_Resize(object sender, EventArgs e)
        {
            resize_Control(lb_tittle_suite, reclb_tittle_suite);
            resize_Control(pnl_listSuite, recpnl_listSuite);
            resize_Control(label20, reclabel20);
            resize_Control(btPesan_listSuite, recbtPesan_listSuite);
            resize_Control(label10, reclabel10);
            resize_Control(label11, reclabel11);
            resize_Control(label12, reclabel12);
            resize_Control(label13, reclabel13);
            resize_Control(label3, reclabel3);
            resize_Control(pictureBox1, recpictureBox1);
            resize_Control(pictureBox5, recpictureBox5);
            resize_Control(pictureBox6, recpictureBox6);
            resize_Control(pictureBox7, recpictureBox7);
            resize_Control(pictureBox8, recpictureBox8);
            resize_Control(pictureBox9, recpictureBox9);
            resize_Control(lbMount_suite, reclbMount_suite);
            resize_Control(lb_tittlesuite_, reclb_tittlesuite_);

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
