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
    public partial class list_melati : Form
    {
        private Login.User user;
        public static int parentX, parentY;
        private Size formOriginalSize;
        private Rectangle reclb_tittleMelati;
        private Rectangle reclb_tittleMelati_;
        private Rectangle rectableLayoutPanel_listMelati;
        private Rectangle reclabel6;
        private Rectangle reclabel7;
        private Rectangle reclabel8;
        private Rectangle reclabel9;
        private Rectangle reclabel10;
        private Rectangle reclbMount_melati_I;
        private Rectangle reclabel11;
        private Rectangle reclabel12;
        private Rectangle reclabel13;
        private Rectangle reclabel2;
        private Rectangle recpnl_listMelati_I;
        private Rectangle reclbMount_melati_II;
        private Rectangle reclabel19;
        private Rectangle reclabel18;
        private Rectangle reclabel17;
        private Rectangle reclabel16;
        private Rectangle reclabel3;
        private Rectangle recpnl_listMelati_II;
        private Rectangle reclbMount_melati_IIs;
        private Rectangle reclabel24;
        private Rectangle reclabel23;
        private Rectangle reclabel22;
        private Rectangle reclabel21;
        private Rectangle reclabel4;
        private Rectangle recpnl_listMelati_IIs;
        private Rectangle reclbMount_melati_III;
        private Rectangle reclabel29;
        private Rectangle reclabel28;
        private Rectangle reclabel27;
        private Rectangle reclabel26;
        private Rectangle reclabel5;
        private Rectangle recpnl_listMelati_III;
        private Rectangle recpictureBox1;
        private Rectangle recpictureBox4;
        private Rectangle recpictureBox3;
        private Rectangle recpictureBox2;
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
        private Rectangle recpictureBox19;
        private Rectangle recpictureBox20;
        private Rectangle recpictureBox21;
        private Rectangle recpictureBox22;
        private Rectangle recpictureBox23;
        private Rectangle recpictureBox24;
        private Rectangle recbtPesan_listMelati_I;
        private Rectangle recbtPesan_listMelati_II;
        private Rectangle recbtPesan_listMelati_IIs;
        private Rectangle recbtPesan_listMelati_III;
        private Rectangle recbtDetail_listMelati_I;
        private Rectangle recbtDetail_listMelati_II;
        private Rectangle recbtDetail_listMelati_IIs;
        private Rectangle recbtDetail_listMelati_III;

        public list_melati(Login.User user)
        {
            InitializeComponent();
            this.user = user;
            this.Resize += list_melati_Resize;
            formOriginalSize = this.Size;
            reclb_tittleMelati = new Rectangle(lb_tittleMelati.Location, lb_tittleMelati.Size);
            reclb_tittleMelati_ = new Rectangle(lb_tittleMelati_.Location, lb_tittleMelati_.Size);

            reclabel6 = new Rectangle(label6.Location, label6.Size);
            reclabel7 = new Rectangle(label7.Location, label7.Size);
            reclabel8 = new Rectangle(label8.Location, label8.Size);
            reclabel9 = new Rectangle(label9.Location, label9.Size);
            reclabel10 = new Rectangle(label10.Location, label10.Size);
            reclabel11 = new Rectangle(label11.Location, label11.Size);
            reclabel12 = new Rectangle(label12.Location, label12.Size);
            reclabel13 = new Rectangle(label13.Location, label13.Size);
            reclabel2 = new Rectangle(label2.Location, label2.Size);
            reclbMount_melati_I = new Rectangle(lbMount_melati_I.Location, lbMount_melati_I.Size);
            reclbMount_melati_II = new Rectangle(lbMount_melati_II.Location, lbMount_melati_II.Size);
            reclbMount_melati_IIs = new Rectangle(lbMount_melati_IIs.Location, lbMount_melati_IIs.Size);
            reclbMount_melati_III = new Rectangle(lbMount_melati_III.Location, lbMount_melati_III.Size);
            reclabel16 = new Rectangle(label16.Location, label16.Size);
            reclabel17 = new Rectangle(label17.Location, label17.Size);
            reclabel18 = new Rectangle(label18.Location, label18.Size);
            reclabel19 = new Rectangle(label19.Location, label19.Size);
            reclabel3 = new Rectangle(label3.Location, label3.Size);
            reclabel4 = new Rectangle(label4.Location, label4.Size);
            reclabel21 = new Rectangle(label21.Location, label21.Size);
            reclabel22 = new Rectangle(label22.Location, label22.Size);
            reclabel23 = new Rectangle(label23.Location, label23.Size);
            reclabel24 = new Rectangle(label24.Location, label24.Size);
            reclabel5 = new Rectangle(label5.Location, label5.Size);
            reclabel26 = new Rectangle(label26.Location, label26.Size);
            reclabel27 = new Rectangle(label27.Location, label27.Size);
            reclabel28 = new Rectangle(label28.Location, label28.Size);
            reclabel29 = new Rectangle(label29.Location, label29.Size);
            recpnl_listMelati_I = new Rectangle(pnl_listMelati_I.Location, pnl_listMelati_I.Size);
            recpnl_listMelati_II = new Rectangle(pnl_listMelati_II.Location, pnl_listMelati_II.Size);
            recpnl_listMelati_IIs = new Rectangle(pnl_listMelati_IIs.Location, pnl_listMelati_IIs.Size);
            recpnl_listMelati_III = new Rectangle(pnl_listMelati_III.Location, pnl_listMelati_III.Size);
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
            recpictureBox19 = new Rectangle(pictureBox19.Location, pictureBox19.Size);
            recpictureBox20 = new Rectangle(pictureBox20.Location, pictureBox20.Size);
            recpictureBox21 = new Rectangle(pictureBox21.Location, pictureBox21.Size);
            recpictureBox22 = new Rectangle(pictureBox22.Location, pictureBox22.Size);
            recpictureBox23 = new Rectangle(pictureBox23.Location, pictureBox23.Size);
            recpictureBox24 = new Rectangle(pictureBox24.Location, pictureBox24.Size);
            recbtPesan_listMelati_I = new Rectangle(btPesan_listMelati_I.Location, btPesan_listMelati_I.Size);
            recbtPesan_listMelati_II = new Rectangle(btPesan_listMelati_II.Location, btPesan_listMelati_II.Size);
            recbtPesan_listMelati_IIs = new Rectangle(btPesan_listMelati_IIs.Location, btPesan_listMelati_IIs.Size);
            recbtPesan_listMelati_III = new Rectangle(btPesan_listMelati_III.Location, btPesan_listMelati_III.Size);
            recbtDetail_listMelati_I = new Rectangle(btDetail_listMelati_I.Location, btDetail_listMelati_I.Size);
            recbtDetail_listMelati_II = new Rectangle(btDetail_listMelati_II.Location, btDetail_listMelati_II.Size);
            recbtDetail_listMelati_IIs = new Rectangle(btDetail_listMelati_IIs.Location, btDetail_listMelati_IIs.Size);
            recbtDetail_listMelati_III = new Rectangle(btDetail_listMelati_III.Location, btDetail_listMelati_III.Size);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btPesan_listMelati_I_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (detail_melatiI modal = new detail_melatiI(user))
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

        private void btPesan_listMelati_II_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (detail_melatiII modal = new detail_melatiII(user))
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

        private void btPesan_listMelati_IIs_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (detail_melatiIIs modal = new detail_melatiIIs(user))
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

        private void btPesan_listMelati_III_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (detail_melatiIII modal = new detail_melatiIII(user))
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

        private void btDetail_listMelati_I_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (melati modal = new melati(user))
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

        private void btDetail_listMelati_II_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (melati_II modal = new melati_II(user))
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

        private void btDetail_listMelati_IIs_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (melati_II_s_ modal = new melati_II_s_(user))
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

        private void btDetail_listMelati_III_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (melati_III modal = new melati_III(user))
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

        private void lb_tittleMelati_Click(object sender, EventArgs e)
        {
            page_ut form_ut = new page_ut(user);
            form_ut.Show();
            this.Close();

        }

        private void list_melati_Resize(object sender, EventArgs e)
        {
            resize_Control(lb_tittleMelati, reclb_tittleMelati);
            resize_Control(lb_tittleMelati_, reclb_tittleMelati_);

            resize_Control(lbMount_melati_I, reclbMount_melati_I);
            resize_Control(lbMount_melati_II, reclbMount_melati_II);
            resize_Control(lbMount_melati_IIs, reclbMount_melati_IIs);
            resize_Control(lbMount_melati_III, reclbMount_melati_III);
            resize_Control(pnl_listMelati_I, recpnl_listMelati_I);
            resize_Control(pnl_listMelati_II, recpnl_listMelati_II);
            resize_Control(pnl_listMelati_IIs, recpnl_listMelati_IIs);
            resize_Control(pnl_listMelati_III, recpnl_listMelati_III);
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
            resize_Control(label5, reclabel5);
            resize_Control(label21, reclabel21);
            resize_Control(label22, reclabel22);
            resize_Control(label23, reclabel23);
            resize_Control(label24, reclabel24);
            resize_Control(label26, reclabel26);
            resize_Control(label27, reclabel27);
            resize_Control(label28, reclabel28);
            resize_Control(label29, reclabel29);
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
            resize_Control(pictureBox13, recpictureBox13);
            resize_Control(pictureBox14, recpictureBox14);
            resize_Control(pictureBox15, recpictureBox15);
            resize_Control(pictureBox16, recpictureBox16);
            resize_Control(pictureBox17, recpictureBox17);
            resize_Control(pictureBox18, recpictureBox18);
            resize_Control(pictureBox19, recpictureBox19);
            resize_Control(pictureBox20, recpictureBox20);
            resize_Control(pictureBox21, recpictureBox21);
            resize_Control(pictureBox22, recpictureBox22);
            resize_Control(pictureBox23, recpictureBox23);
            resize_Control(pictureBox24, recpictureBox24);
            resize_Control(btPesan_listMelati_I, recbtPesan_listMelati_I);
            resize_Control(btPesan_listMelati_II, recbtPesan_listMelati_II);
            resize_Control(btPesan_listMelati_IIs, recbtPesan_listMelati_IIs);
            resize_Control(btPesan_listMelati_III, recbtPesan_listMelati_III);
            resize_Control(btDetail_listMelati_I, recbtDetail_listMelati_I);
            resize_Control(btDetail_listMelati_II, recbtDetail_listMelati_II);
            resize_Control(btDetail_listMelati_IIs, recbtDetail_listMelati_IIs);
            resize_Control(btDetail_listMelati_III, recbtDetail_listMelati_III);

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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_tittleMelati_Click_1(object sender, EventArgs e)
        {
            page_ut form_ut = new page_ut(user);
            form_ut.Show();
            this.Close();
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            page_ut form_ut = new page_ut(user);
            form_ut.Show();
            this.Close();
        }

        private void lb_tittleMelati_Click_2(object sender, EventArgs e)
        {
            page_ut form_ut = new page_ut(user);
            form_ut.Show();
            this.Close();
        }
    }
}
