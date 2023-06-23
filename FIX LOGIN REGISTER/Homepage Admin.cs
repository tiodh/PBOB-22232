using Guna.UI2.WinForms.Enums;
using Npgsql;

namespace homepage_admin
{
    public partial class HomepageAdmin : Form
    {
        private Size formOriginalSize;
        private Rectangle recpnl1;
        private Rectangle recpnl2;
        private Rectangle recpnlnt;
        private Rectangle reclbl1;
        private Rectangle reclbl2;
        private Rectangle reclbl3;
        private Rectangle reclbl4;
        private Rectangle reclbl5;
        private Rectangle recpnlout;
        public HomepageAdmin()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            recpnl1 = new Rectangle(panel1.Location, panel1.Size);
            recpnlnt = new Rectangle(PanelNotif.Location, PanelNotif.Size);
            recpnl2 = new Rectangle(panel2.Location, panel2.Size);
            reclbl1 = new Rectangle(lblhome.Location, lblhome.Size);
            reclbl2 = new Rectangle(lblstaff.Location, lblstaff.Size);
            reclbl3 = new Rectangle(lbldatabase_user.Location, lbldatabase_user.Size);
            reclbl4 = new Rectangle(lblstts_kmr.Location, lblstts_kmr.Size);
            reclbl5 = new Rectangle(lblkritik.Location, lblkritik.Size);
            recpnlout = new Rectangle(panelout.Location, panelout.Size);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(panel1, recpnl1);
            resize_Control(PanelNotif, recpnlnt);
            resize_Control(panel2, recpnl2);
            resize_Control(lblhome, reclbl1);
            resize_Control(lblstaff, reclbl2);
            resize_Control(lbldatabase_user, reclbl3);
            resize_Control(lblstts_kmr, reclbl4);
            resize_Control(lblkritik, reclbl5);
            resize_Control(panelout, recpnlout);
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

        private bool notifikasi = false;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (notifikasi)
            {
                PanelNotif.Hide();
                notifikasi = false;
            }
            else
            {
                PanelNotif.Show();
                notifikasi = true;
            }


        }
        private void hidenotif()
        {

        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
        }
        private void Form1_TextChanged(object sender, EventArgs e)
        {
            float fontSize = (float)(Width + Height) / 100; // Sesuaikan rumus ini sesuai kebutuhan Anda

            // Atur ukuran font pada kontrol yang diinginkan
            lblhome.Font = new Font(lblhome.Font.FontFamily, fontSize, lblhome.Font.Style);
            //button1.Font = new Font(button1.Font.FontFamily, fontSize, button1.Font.Style);
        }

        private void panel3_DoubleClick(object sender, EventArgs e)
        {
            //Form2 fm2 = new Form2();
            //fm2.TopLevel = false;
            //fm2.FormBorderStyle = FormBorderStyle.None;
            //this.panel3.Controls.Add(fm2);
            //fm2.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void PanelNotif_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool pictureprofil = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureprofil)
            {
                panelout.Hide();
                pictureprofil = false;
            }
            else
            {

                panelout.Show();
                profil fm2 = new profil();
                fm2.TopLevel = false;
                fm2.FormBorderStyle = FormBorderStyle.None;
                this.panelout.Controls.Add(fm2);
                fm2.Show();
                pictureprofil = true;
            }
            //panelout.Show();
            //Form2 fm2 = new Form2();
            //fm2.TopLevel = false;
            //fm2.FormBorderStyle = FormBorderStyle.None;
            //this.panelout.Controls.Add(fm2);
            //fm2.Show();
            //hidenotif();
        }

        private void panelout_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lblhome_MouseHover(object sender, EventArgs e)
        {
            lblhome.ForeColor = Color.Blue;
        }

        private void lblhome_MouseLeave(object sender, EventArgs e)
        {
            lblhome.ForeColor = Color.Black;
        }
        private void lblstaff_Click(object sender, EventArgs e)
        {
            // lblstaff st = new lblstaff();
            // st.Show();
            // this.Hide();
        }

        private void lblstaff_MouseHover(object sender, EventArgs e)
        {
            lblstaff.ForeColor = Color.Blue;
        }

        private void lblstaff_MouseLeave(object sender, EventArgs e)
        {
            lblstaff.ForeColor = Color.Black;
        }

        private void lbldatabase_user_Click(object sender, EventArgs e)
        {
            // lbldatabase_user du = new lbldatabase_user();
            // du.Show();
            // this.Hide();
        }

        private void lbldatabase_user_MouseHover(object sender, EventArgs e)
        {
            lbldatabase_user.ForeColor = Color.Blue;
        }

        private void lbldatabase_user_MouseLeave(object sender, EventArgs e)
        {
            lbldatabase_user.ForeColor = Color.Black;
        }

        private void lblstts_kmr_Click(object sender, EventArgs e)
        {
            //lblstts_kmr sk = new lblstts_kmr();
            //sk.Show();
            //this.Hide();
        }

        private void lblstts_kmr_MouseHover(object sender, EventArgs e)
        {
            lblstts_kmr.ForeColor = Color.Blue;
        }

        private void lblstts_kmr_MouseLeave(object sender, EventArgs e)
        {
            lblstts_kmr.ForeColor = Color.Black;
        }

        private void lblkritik_Click(object sender, EventArgs e)
        {
            // lblkritik kr = new lblkritik();
            // kr.Show();
            // this.Hide();
        }

        private void lblkritik_MouseHover(object sender, EventArgs e)
        {
            lblkritik.ForeColor = Color.Blue;
        }

        private void lblkritik_MouseLeave(object sender, EventArgs e)
        {
            lblkritik.ForeColor = Color.Black;
        }

        private void homepage_admin_Load(object sender, EventArgs e)
        {

        }
    }
}