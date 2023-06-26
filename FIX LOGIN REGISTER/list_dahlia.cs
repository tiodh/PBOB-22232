using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIX_LOGIN_REGISTER
{
    public partial class list_dahlia : Form
    {
        private Login.User user;
        public static int parentX, parentY;
        private Size formOriginalSize;
        private Rectangle rectableLayoutPanel_listDahlia;
        private Rectangle recpnl_listDahlia_I;
        private Rectangle recpnl_listDahlia_II;
        private Rectangle reclb_tittleDahlia;
        private Rectangle reclb_tittleDahlia_;
        private Rectangle reclbMount_dahlia_I;
        private Rectangle reclbMount_dahlia_II;
        private Rectangle recbtPesan_listDahlia_I;
        private Rectangle recbtPesan_listDahlia_II;
        private Rectangle reclabel2;
        private Rectangle reclabel3;
        private Rectangle reclabel4;
        private Rectangle reclabel6;
        private Rectangle reclabel7;
        private Rectangle reclabel8;
        private Rectangle reclabel9;
        private Rectangle reclabel10;
        private Rectangle reclabel11;
        private Rectangle reclabel12;
        private Rectangle reclabel13;
        private Rectangle reclabel20;
        private Rectangle recpictureBox1;
        private Rectangle recpictureBox2;
        private Rectangle recpictureBox3;
        private Rectangle recpictureBox4;
        private Rectangle recpictureBox5;
        private Rectangle recpictureBox6;
        private Rectangle recpictureBox7;
        private Rectangle recpictureBox8;
        private Rectangle recpictureBox9;
        private Rectangle recpictureBox10;
        private Rectangle recpictureBox11;
        private Rectangle recpictureBox12;
        private Rectangle recbtDetail_dahlia_I;
        private Rectangle recbtDetail_dahlia_II;


        public list_dahlia(Login.User user)
        {
            InitializeComponent();
            this.user = user;
            this.Resize += list_dahlia_Resize;
            formOriginalSize = this.Size;

            recpnl_listDahlia_I = new Rectangle(pnl_listDahlia_I.Location, pnl_listDahlia_I.Size);
            recpnl_listDahlia_II = new Rectangle(pnl_listDahlia_II.Location, pnl_listDahlia_II.Size);
            reclb_tittleDahlia = new Rectangle(lb_tittleDahlia.Location, lb_tittleDahlia.Size);
            reclb_tittleDahlia_ = new Rectangle(lb_tittleDahlia_.Location, lb_tittleDahlia_.Size);
            reclbMount_dahlia_I = new Rectangle(lbMount_dahlia_I.Location, lbMount_dahlia_I.Size);
            reclbMount_dahlia_II = new Rectangle(lbMount_dahlia_II.Location, lbMount_dahlia_II.Size);
            recbtPesan_listDahlia_I = new Rectangle(btPesan_listDahlia_I.Location, btPesan_listDahlia_I.Size);
            recbtPesan_listDahlia_II = new Rectangle(btPesan_listDahlia_II.Location, btPesan_listDahlia_II.Size);
            reclabel2 = new Rectangle(label2.Location, label2.Size);
            reclabel3 = new Rectangle(label3.Location, label3.Size);
            reclabel4 = new Rectangle(label4.Location, label4.Size);
            reclabel6 = new Rectangle(label6.Location, label6.Size);
            reclabel7 = new Rectangle(label7.Location, label7.Size);
            reclabel8 = new Rectangle(label8.Location, label8.Size);
            reclabel9 = new Rectangle(label9.Location, label9.Size);
            reclabel10 = new Rectangle(label10.Location, label10.Size);
            reclabel11 = new Rectangle(label11.Location, label11.Size);
            reclabel12 = new Rectangle(label12.Location, label12.Size);
            reclabel13 = new Rectangle(label13.Location, label13.Size);
            reclabel20 = new Rectangle(label20.Location, label20.Size);
            recpictureBox1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recpictureBox2 = new Rectangle(pictureBox2.Location, pictureBox2.Size);
            recpictureBox3 = new Rectangle(pictureBox3.Location, pictureBox3.Size);
            recpictureBox4 = new Rectangle(pictureBox4.Location, pictureBox4.Size);
            recpictureBox5 = new Rectangle(pictureBox5.Location, pictureBox5.Size);
            recpictureBox6 = new Rectangle(pictureBox6.Location, pictureBox6.Size);
            recpictureBox7 = new Rectangle(pictureBox7.Location, pictureBox7.Size);
            recpictureBox8 = new Rectangle(pictureBox8.Location, pictureBox8.Size);
            recpictureBox9 = new Rectangle(pictureBox9.Location, pictureBox9.Size);
            recpictureBox10 = new Rectangle(pictureBox10.Location, pictureBox10.Size);
            recpictureBox11 = new Rectangle(pictureBox11.Location, pictureBox11.Size);
            recpictureBox12 = new Rectangle(pictureBox12.Location, pictureBox12.Size);
            recbtDetail_dahlia_I = new Rectangle(btDetail_dahlia_I.Location, btDetail_dahlia_I.Size);
            recbtDetail_dahlia_II = new Rectangle(btDetail_dahlia_II.Location, btDetail_dahlia_II.Size);
        }

        private void list_dahlia_Load(object sender, EventArgs e)
        {

        }

        private void btPesan_listDahlia_I_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (detail_dahliaI modal = new detail_dahliaI(user))
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

        private void btPesan_listDahlia_II_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (detail_dahliaII modal = new detail_dahliaII(user))
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

        private void btDetail_dahlia_I_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (dahlia_I modal = new dahlia_I(user))
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

        private void btDetail_dahlia_II_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (dahlia_II modal = new dahlia_II(user))
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

        private void lb_tittleDahlia_Click(object sender, EventArgs e)
        {
            page_ut form_ut = new page_ut(user);
            form_ut.Show();
            this.Close();
        }

        private void list_dahlia_Resize(object sender, EventArgs e)
        {

            resize_Control(pnl_listDahlia_I, recpnl_listDahlia_I);
            resize_Control(pnl_listDahlia_II, recpnl_listDahlia_II);
            resize_Control(lb_tittleDahlia, reclb_tittleDahlia);
            resize_Control(lb_tittleDahlia_, reclb_tittleDahlia_);
            resize_Control(lbMount_dahlia_I, reclbMount_dahlia_I);
            resize_Control(lbMount_dahlia_II, reclbMount_dahlia_II);
            resize_Control(btPesan_listDahlia_I, recbtPesan_listDahlia_I);
            resize_Control(btPesan_listDahlia_II, recbtPesan_listDahlia_II);
            resize_Control(label2, reclabel2);
            resize_Control(label3, reclabel3);
            resize_Control(label4, reclabel4);
            resize_Control(label6, reclabel6);
            resize_Control(label7, reclabel7);
            resize_Control(label8, reclabel8);
            resize_Control(label9, reclabel9);
            resize_Control(label10, reclabel10);
            resize_Control(label11, reclabel11);
            resize_Control(label12, reclabel12);
            resize_Control(label13, reclabel13);
            resize_Control(pictureBox1, recpictureBox1);
            resize_Control(pictureBox2, recpictureBox2);
            resize_Control(pictureBox3, recpictureBox3);
            resize_Control(pictureBox4, recpictureBox4);
            resize_Control(pictureBox5, recpictureBox5);
            resize_Control(pictureBox6, recpictureBox6);
            resize_Control(pictureBox7, recpictureBox7);
            resize_Control(pictureBox8, recpictureBox8);
            resize_Control(pictureBox9, recpictureBox9);
            resize_Control(pictureBox10, recpictureBox10);
            resize_Control(pictureBox11, recpictureBox11);
            resize_Control(pictureBox12, recpictureBox12);
            resize_Control(btDetail_dahlia_I, recbtDetail_dahlia_I);
            resize_Control(btDetail_dahlia_II, recbtDetail_dahlia_II);
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

        private void pnl_listDahlia_II_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
