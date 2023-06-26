using Guna.UI2.AnimatorNS;
using static System.Net.Mime.MediaTypeNames;

namespace FIX_LOGIN_REGISTER
{
    public partial class Admin : Form
    {
        private Notif controller;
        private Login.User user;
        private bool isPanelVisible = false;
        private Size formOriginalSize;
        private Rectangle recpnl1;
        private Rectangle recpnl2;
        private Rectangle recpnlnt;
        private Rectangle recpnlout;
        private Rectangle recpcbx7;
        private Rectangle recpcbx6;

        public Admin(Login.User user)
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            recpnl1 = new Rectangle(panel1.Location, panel1.Size);
            recpnlnt = new Rectangle(PanelNotif.Location, PanelNotif.Size);
            recpnl2 = new Rectangle(panel2.Location, panel2.Size);
            recpnlout = new Rectangle(panelout.Location, panelout.Size);
            recpcbx7 = new Rectangle(pictureBox7.Location, pictureBox7.Size);
            recpcbx6 = new Rectangle(pictureBox6.Location, pictureBox6.Size);
            this.user = user;
            controller = new Notif(this);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(panel1, recpnl1);
            resize_Control(PanelNotif, recpnlnt);
            resize_Control(panel2, recpnl2);
            resize_Control(panelout, recpnlout);
            resize_Control(pictureBox7, recpcbx7);
            resize_Control(pictureBox6, recpcbx6);

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
        }
        private void Form1_TextChanged(object sender, EventArgs e)
        {
            float fontSize = (float)(Width + Height) / 100; // Sesuaikan rumus ini sesuai kebutuhan Anda
        }

        private void panel3_DoubleClick(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            controller.KonfirmasiPesanan();
        }

        private void PanelNotif_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelout_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label5_Click(object sender, EventArgs e)
        {
            KritikAdmin ka = new KritikAdmin(user);
            ka.Show();
            this.Hide();
        }




        private bool pictureprofil = false;

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (isPanelVisible)
            {
                PanelNotif.Visible = false;
                isPanelVisible = false;
            }
            else
            {
                PanelNotif.Visible = true;
                isPanelVisible = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (isPanelVisible)
            {
                panelout.Visible = false;
                isPanelVisible = false;
            }
            else
            {
                panelout.Visible = true;
                isPanelVisible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel11.Show();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            update_desc1 upDesc1 = new update_desc1(user);
            upDesc1.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            updatefaq1 updatefaq1 = new updatefaq1(user);
            updatefaq1.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            SKamar sKamar = new SKamar(user);
            sKamar.Show();
            this.Hide();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            Fasilitas_Kamar fasilitas_Kamar = new Fasilitas_Kamar(user);
            fasilitas_Kamar.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            UpdateHarga updateHarga = new UpdateHarga(user);
            updateHarga.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            controller.BacaData();
            controller.BacaNotif();
        }

        public void UpdateLabel8(string text)
        {
            label8.Text = text;
        }

        public void UpdateLabel12(string text)
        {
            label12.Text = text;
        }

        public void HideButton1()
        {
            guna2Button1.Hide();
        }

        public void HideButton2()
        {
            guna2Button2.Hide();
        }

        public void HideButton3()
        {
            guna2Button3.Hide();
        }

        public void HideButton4()
        {
            guna2Button4.Hide();
        }

        public DialogResult ShowConfirmationDialog(string message, string caption)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            guna2Button1.Show();
            guna2Button2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.KonfirmasiPesanan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.KonfirmasiKodePembayaran();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            guna2Button3.Show();
            guna2Button4.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            controller.DeletePesanan();
        }

        public void ShowLabel12()
        {
            label12.Show();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            controller.DeletePesanan();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            controller.KonfirmasiKodePembayaran();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            controller.DeleteKodePembayaran();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(user);
            form1.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            UpdateHarga updateHarga = new UpdateHarga(user);
            updateHarga.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            RiwayatAdmin admin = new RiwayatAdmin(user);
            admin.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel11.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}