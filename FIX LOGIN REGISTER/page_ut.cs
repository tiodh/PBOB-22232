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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace FIX_LOGIN_REGISTER
{
    public partial class page_ut : Form
    {
        private Login.User user;
        private Size formOriginalSize;
        private Rectangle rectableLayoutPanel_ut;
        private Rectangle reclb_tittle_ut;
        private Rectangle recpanel1;
        private Rectangle recpnlsuite_ut;
        private Rectangle recpnlmelati_ut;
        private Rectangle recpnlmawar_ut;
        private Rectangle recpnldahlia_ut;
        private Rectangle reclabel2;
        private Rectangle reclabel18;
        private Rectangle reclabel3;
        private Rectangle reclabel6;
        private Rectangle reclabel8;
        private Rectangle reclabel7;
        private Rectangle reclabel9;
        private Rectangle reclabel10;
        private Rectangle reclabel4;
        private Rectangle reclabel14;
        private Rectangle reclabel12;
        private Rectangle reclabel13;
        private Rectangle reclabel16;
        private Rectangle reclabel5;
        private Rectangle reclabel11;
        private Rectangle reclabel15;
        private Rectangle reclabel17;
        private Rectangle recpicb1;
        private Rectangle recpicb2;
        private Rectangle recpicb3;
        private Rectangle recpicb4;
        private Rectangle recbtMawar_ut;
        private Rectangle recbtSuite_ut;
        private Rectangle recbtMelati_ut;
        private Rectangle recbtDahlia_ut;



        public page_ut(Login.User user)
        {
            InitializeComponent();
            this.user = user;
            Resize += page_ut_Resize;
            formOriginalSize = this.Size;

            reclb_tittle_ut = new Rectangle(lb_tittle_ut.Location, lb_tittle_ut.Size);
            recpanel1 = new Rectangle(panel1.Location, panel1.Size);
            recpnlsuite_ut = new Rectangle(pnlsuite_ut.Location, pnlsuite_ut.Size);
            recpnlmelati_ut = new Rectangle(pnlmelati_ut.Location, pnlmelati_ut.Size);
            recpnlmawar_ut = new Rectangle(pnlmawar_ut.Location, pnlmawar_ut.Size);
            recpnldahlia_ut = new Rectangle(pnldahlia_ut.Location, pnldahlia_ut.Size);
            reclabel2 = new Rectangle(label2.Location, label2.Size);
            reclabel18 = new Rectangle(label18.Location, label18.Size);
            reclabel3 = new Rectangle(label3.Location, label3.Size);
            reclabel6 = new Rectangle(label6.Location, label6.Size);
            reclabel8 = new Rectangle(label8.Location, label8.Size);
            reclabel7 = new Rectangle(label7.Location, label7.Size);
            reclabel9 = new Rectangle(label9.Location, label9.Size);
            reclabel10 = new Rectangle(label10.Location, label10.Size);
            reclabel4 = new Rectangle(label4.Location, label4.Size);
            reclabel14 = new Rectangle(label14.Location, label14.Size);
            reclabel12 = new Rectangle(label12.Location, label12.Size);
            reclabel13 = new Rectangle(label13.Location, label13.Size);
            reclabel16 = new Rectangle(label16.Location, label16.Size);
            reclabel5 = new Rectangle(label5.Location, label5.Size);
            reclabel11 = new Rectangle(label11.Location, label11.Size);
            reclabel15 = new Rectangle(label15.Location, label15.Size);
            reclabel17 = new Rectangle(label17.Location, label17.Size);
            recpicb1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recpicb2 = new Rectangle(pictureBox2.Location, pictureBox2.Size);
            recpicb3 = new Rectangle(pictureBox3.Location, pictureBox3.Size);
            recpicb4 = new Rectangle(pictureBox4.Location, pictureBox4.Size);
            recbtSuite_ut = new Rectangle(btSuite_ut.Location, btSuite_ut.Size);
            recbtMelati_ut = new Rectangle(btMelati_ut.Location, btMelati_ut.Size);
            recbtMawar_ut = new Rectangle(btMawar_ut.Location, btMawar_ut.Size);
            recbtDahlia_ut = new Rectangle(btDahlia_ut.Location, btDahlia_ut.Size);

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void page_ut_Load(object sender, EventArgs e)
        {

        }

        private void btSuite_ut_Click(object sender, EventArgs e)
        {
            list_suite ls_suite = new list_suite(user);
            ls_suite.Show();
            this.Hide();
        }

        private void btMelati_ut_Click(object sender, EventArgs e)
        {
            list_melati ls_melati = new list_melati(user);
            ls_melati.Show();
            this.Hide();
        }

        private void btMawar_ut_Click(object sender, EventArgs e)
        {
            list_mawar ls_mawar = new list_mawar(user);
            ls_mawar.Show();
            this.Hide();
        }

        private void btDahlia_ut_Click(object sender, EventArgs e)
        {
            list_dahlia ls_dahlia = new list_dahlia(user);
            ls_dahlia.Show();
            this.Hide();
        }

        private void page_ut_Resize(object sender, EventArgs e)
        {

            resize_Control(lb_tittle_ut, reclb_tittle_ut);
            resize_Control(pnlsuite_ut, recpnlsuite_ut);
            resize_Control(pnlmelati_ut, recpnlmelati_ut);
            resize_Control(pnlmawar_ut, recpnlmawar_ut);
            resize_Control(pnldahlia_ut, recpnldahlia_ut);
            resize_Control(panel1, recpanel1);
            resize_Control(label2, reclabel2);
            resize_Control(label18, reclabel18);
            resize_Control(label3, reclabel3);
            resize_Control(label6, reclabel6);
            resize_Control(label8, reclabel8);
            resize_Control(label7, reclabel7);
            resize_Control(label9, reclabel9);
            resize_Control(label10, reclabel10);
            resize_Control(label4, reclabel4);
            resize_Control(label14, reclabel14);
            resize_Control(label12, reclabel12);
            resize_Control(label13, reclabel13);
            resize_Control(label16, reclabel16);
            resize_Control(label5, reclabel5);
            resize_Control(label11, reclabel11);
            resize_Control(label15, reclabel15);
            resize_Control(label17, reclabel17);
            resize_Control(pictureBox1, recpicb1);
            resize_Control(pictureBox2, recpicb2);
            resize_Control(pictureBox3, recpicb3);
            resize_Control(pictureBox4, recpicb4);
            resize_Control(btSuite_ut, recbtSuite_ut);
            resize_Control(btMelati_ut, recbtMelati_ut);
            resize_Control(btMawar_ut, recbtMawar_ut);
            resize_Control(btDahlia_ut, recbtDahlia_ut);

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

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(user);
            homepage.Show();
            this.Hide();
        }
    }
}
