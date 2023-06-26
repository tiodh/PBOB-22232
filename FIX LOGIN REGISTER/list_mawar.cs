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
    public partial class list_mawar : Form
    {
        private Login.User user;
        public static int parentX, parentY;
        private Size formOriginalSize;
        private Rectangle reclb_tittleMawar;
        private Rectangle reclb_tittleMawar_;
        private Rectangle rectableLayoutPanel_listMawar;
        private Rectangle reclabel10;
        private Rectangle reclbMount_mawar_I;
        private Rectangle reclabel11;
        private Rectangle reclabel12;
        private Rectangle reclabel13;
        private Rectangle reclabel2;
        private Rectangle recpnl_listMawar_I;
        private Rectangle reclbMount_mawar_II;
        private Rectangle reclabel9;
        private Rectangle reclabel8;
        private Rectangle reclabel7;
        private Rectangle reclabel6;
        private Rectangle reclabel3;
        private Rectangle recpnl_listMawar_II;
        private Rectangle reclbMount_mawar_IIs;
        private Rectangle reclabel19;
        private Rectangle reclabel18;
        private Rectangle reclabel17;
        private Rectangle reclabel16;
        private Rectangle reclabel4;
        private Rectangle recpnl_listMawar_IIs;
        private Rectangle reclabel20;
        private Rectangle reclabel21;
        private Rectangle reclabel22;
        private Rectangle recpictureBox1;
        private Rectangle recpictureBox2;
        private Rectangle recpictureBox3;
        private Rectangle recpictureBox5;
        private Rectangle recpictureBox6;
        private Rectangle recpictureBox7;
        private Rectangle recpictureBox8;
        private Rectangle recpictureBox9;
        private Rectangle recpictureBox10;
        private Rectangle recpictureBox11;
        private Rectangle recpictureBox12;
        private Rectangle recpictureBox13;
        private Rectangle recpictureBox14;
        private Rectangle recpictureBox15;
        private Rectangle recpictureBox16;
        private Rectangle recpictureBox17;
        private Rectangle recpictureBox18;
        private Rectangle recpictureBox4;
        private Rectangle recbtPesan_listMawar_I;
        private Rectangle recbtPesan_listMawar_II;
        private Rectangle recbtPesan_listMawar_IIs;
        private Rectangle recbtDetail_listMawar_I;
        private Rectangle recbtDetail_listMawar_II;
        private Rectangle recbtDetail_listMawar_IIs;

        public list_mawar(Login.User user)
        {
            InitializeComponent();
            this.user = user;
            this.Resize += list_mawar_Resize;
            formOriginalSize = this.Size;
            reclb_tittleMawar = new Rectangle(lb_tittleMawar.Location, lb_tittleMawar.Size);
            reclb_tittleMawar_ = new Rectangle(lb_tittleMawar_.Location, lb_tittleMawar_.Size);

            reclabel6 = new Rectangle(label6.Location, label6.Size);
            reclabel7 = new Rectangle(label7.Location, label7.Size);
            reclabel8 = new Rectangle(label8.Location, label8.Size);
            reclabel9 = new Rectangle(label9.Location, label9.Size);
            reclabel10 = new Rectangle(label10.Location, label10.Size);
            reclabel11 = new Rectangle(label11.Location, label11.Size);
            reclabel12 = new Rectangle(label12.Location, label12.Size);
            reclabel13 = new Rectangle(label13.Location, label13.Size);
            reclabel2 = new Rectangle(label2.Location, label2.Size);
            recbtPesan_listMawar_I = new Rectangle(btPesan_listMawar_I.Location, btPesan_listMawar_I.Size);
            recbtPesan_listMawar_II = new Rectangle(btPesan_listMawar_II.Location, btPesan_listMawar_II.Size);
            recbtPesan_listMawar_IIs = new Rectangle(btPesan_listMawar_IIs.Location, btPesan_listMawar_IIs.Size);
            recbtDetail_listMawar_I = new Rectangle(btDetail_listMawar_I.Location, btDetail_listMawar_I.Size);
            recbtDetail_listMawar_II = new Rectangle(btDetail_listMawar_II.Location, btDetail_listMawar_II.Size);
            recbtDetail_listMawar_IIs = new Rectangle(btDetail_listMawar_IIs.Location, btDetail_listMawar_IIs.Size);
            reclbMount_mawar_I = new Rectangle(lbMount_mawar_I.Location, lbMount_mawar_I.Size);
            reclbMount_mawar_II = new Rectangle(lbMount_mawar_II.Location, lbMount_mawar_II.Size);
            reclbMount_mawar_IIs = new Rectangle(lbMount_mawar_IIs.Location, lbMount_mawar_IIs.Size);
            reclabel16 = new Rectangle(label16.Location, label16.Size);
            reclabel17 = new Rectangle(label17.Location, label17.Size);
            reclabel18 = new Rectangle(label18.Location, label18.Size);
            reclabel19 = new Rectangle(label19.Location, label19.Size);
            reclabel3 = new Rectangle(label3.Location, label3.Size);
            reclabel4 = new Rectangle(label4.Location, label4.Size);
            reclabel21 = new Rectangle(label21.Location, label21.Size);
            reclabel22 = new Rectangle(label22.Location, label22.Size);
            reclabel20 = new Rectangle(label20.Location, label20.Size);
            recpnl_listMawar_I = new Rectangle(pnl_listMawar_I.Location, pnl_listMawar_I.Size);
            recpnl_listMawar_II = new Rectangle(pnl_listMawar_II.Location, pnl_listMawar_II.Size);
            recpnl_listMawar_IIs = new Rectangle(pnl_listMawar_IIs.Location, pnl_listMawar_IIs.Size);
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
            recpictureBox13 = new Rectangle(pictureBox13.Location, pictureBox13.Size);
            recpictureBox14 = new Rectangle(pictureBox14.Location, pictureBox14.Size);
            recpictureBox15 = new Rectangle(pictureBox15.Location, pictureBox15.Size);
            recpictureBox16 = new Rectangle(pictureBox16.Location, pictureBox16.Size);
            recpictureBox17 = new Rectangle(pictureBox17.Location, pictureBox17.Size);
            recpictureBox18 = new Rectangle(pictureBox18.Location, pictureBox18.Size);

        }





        private void btPesan_listMawar_I_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (detail_mawarI modal = new detail_mawarI(user))
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

        private void btPesan_listMawar_II_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (detail_mawarII modal = new detail_mawarII(user))
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

        private void btPesan_listMawar_IIs_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (detail_mawarIIs modal = new detail_mawarIIs(user))
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

        private void btDetail_listMawar_I_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (mawar_I modal = new mawar_I(user))
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

        private void btDetail_listMawar_II_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (mawar_II modal = new mawar_II(user))
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

        private void btDetail_listMawar_IIs_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (mawar_II_s_ modal = new mawar_II_s_(user))
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

        private void lb_tittleMawar_Click(object sender, EventArgs e)
        {
            page_ut form_ut = new page_ut(user);
            form_ut.Show();
            this.Close();
        }

        private void list_mawar_Resize(object sender, EventArgs e)
        {
            resize_Control(lb_tittleMawar, reclb_tittleMawar);
            resize_Control(lb_tittleMawar_, reclb_tittleMawar_);

            resize_Control(lbMount_mawar_I, reclbMount_mawar_I);
            resize_Control(lbMount_mawar_II, reclbMount_mawar_II);
            resize_Control(lbMount_mawar_IIs, reclbMount_mawar_IIs);
            resize_Control(pnl_listMawar_I, recpnl_listMawar_I);
            resize_Control(pnl_listMawar_II, recpnl_listMawar_II);
            resize_Control(pnl_listMawar_IIs, recpnl_listMawar_IIs);
            resize_Control(btDetail_listMawar_I, recbtDetail_listMawar_I);
            resize_Control(btDetail_listMawar_II, recbtDetail_listMawar_II);
            resize_Control(btDetail_listMawar_IIs, recbtDetail_listMawar_IIs);
            resize_Control(btPesan_listMawar_I, recbtPesan_listMawar_I);
            resize_Control(btPesan_listMawar_II, recbtPesan_listMawar_II);
            resize_Control(btPesan_listMawar_IIs, recbtPesan_listMawar_IIs);
            resize_Control(label2, reclabel2);
            resize_Control(label6, reclabel6);
            resize_Control(label7, reclabel7);
            resize_Control(label8, reclabel8);
            resize_Control(label9, reclabel9);
            resize_Control(label10, reclabel10);
            resize_Control(label11, reclabel11);
            resize_Control(label12, reclabel12);
            resize_Control(label13, reclabel13);
            resize_Control(label3, reclabel3);
            resize_Control(label4, reclabel4);
            resize_Control(label16, reclabel16);
            resize_Control(label17, reclabel17);
            resize_Control(label18, reclabel18);
            resize_Control(label19, reclabel19);
            resize_Control(label21, reclabel21);
            resize_Control(label22, reclabel22);
            resize_Control(label20, reclabel20);
            resize_Control(pictureBox1, recpictureBox1);
            resize_Control(pictureBox2, recpictureBox2);
            resize_Control(pictureBox3, recpictureBox3);
            resize_Control(pictureBox5, recpictureBox5);
            resize_Control(pictureBox6, recpictureBox6);
            resize_Control(pictureBox7, recpictureBox7);
            resize_Control(pictureBox8, recpictureBox8);
            resize_Control(pictureBox9, recpictureBox9);
            resize_Control(pictureBox10, recpictureBox10);
            resize_Control(pictureBox11, recpictureBox11);
            resize_Control(pictureBox12, recpictureBox12);
            resize_Control(pictureBox13, recpictureBox13);
            resize_Control(pictureBox14, recpictureBox14);
            resize_Control(pictureBox15, recpictureBox15);
            resize_Control(pictureBox16, recpictureBox16);
            resize_Control(pictureBox17, recpictureBox17);
            resize_Control(pictureBox18, recpictureBox18);
            resize_Control(pictureBox4, recpictureBox4);
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
