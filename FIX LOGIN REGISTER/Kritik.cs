using Npgsql;
using System.Data;

namespace FIX_LOGIN_REGISTER
{
    public partial class Kritik : Form
    {
        private Login.User user;
        private Size formOriginalSize;
        private Rectangle recBut2;
        private Rectangle recib1;
        private Rectangle recib2;
        private Rectangle recib3;
        private Rectangle recib4;
        private Rectangle recib5;
        private Rectangle recib6;
        private Rectangle recpb16;
        private Rectangle recpb5;
        private Rectangle recpb7;
        private Rectangle recpb9;
        private Rectangle reclbl1;
        private Rectangle reclbl2;
        private Rectangle reclbl6;
        private Rectangle reclbl8;
        private Rectangle recpb1;
        private Rectangle reclbl7;
        private Rectangle recrtb1;
        private Rectangle recBut1;

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

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(button1, recBut1);
            resize_Control(button2, recBut2);
            resize_Control(iconButton1, recib1);
            resize_Control(iconButton2, recib2);
            resize_Control(iconButton3, recib3);
            resize_Control(iconButton4, recib4);
            resize_Control(iconButton5, recib5);
            //resize_Control(iconButton6, recib6);
            resize_Control(label1, reclbl1);
            resize_Control(label2, reclbl2);
            resize_Control(label6, reclbl6);
            resize_Control(label7, reclbl7);
            resize_Control(label8, reclbl8);
            resize_Control(pictureBox1, recpb1);
            resize_Control(pictureBox16, recpb16);
            resize_Control(pictureBox5, recpb5);
            resize_Control(pictureBox7, recpb7);
            //resize_Control(pictureBox9, recpb9);
            resize_Control(richTextBox1, recrtb1);
        }

        public Kritik(Login.User user)
        {
            this.user = user;
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            recBut1 = new Rectangle(button1.Location, button1.Size);
            recBut2 = new Rectangle(button2.Location, button2.Size);
            recib1 = new Rectangle(iconButton1.Location, iconButton1.Size);
            recib2 = new Rectangle(iconButton2.Location, iconButton2.Size);
            recib3 = new Rectangle(iconButton3.Location, iconButton3.Size);
            recib4 = new Rectangle(iconButton4.Location, iconButton4.Size);
            recib5 = new Rectangle(iconButton5.Location, iconButton5.Size);
            //recib6 = new Rectangle(iconButton6.Location, iconButton6.Size);
            reclbl1 = new Rectangle(label1.Location, label1.Size);
            reclbl2 = new Rectangle(label2.Location, label2.Size);
            reclbl6 = new Rectangle(label6.Location, label6.Size);
            reclbl7 = new Rectangle(label7.Location, label7.Size);
            reclbl8 = new Rectangle(label8.Location, label8.Size);
            recpb1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recpb16 = new Rectangle(pictureBox16.Location, pictureBox16.Size);
            recpb5 = new Rectangle(pictureBox5.Location, pictureBox5.Size);
            recpb7 = new Rectangle(pictureBox7.Location, pictureBox7.Size);
            //recpb9 = new Rectangle(pictureBox9.Location, pictureBox9.Size);
            recrtb1 = new Rectangle(richTextBox1.Location, richTextBox1.Size);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
            richTextBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into kritik_pengaduan (kritikan, tanggal, id_wisata, id_akun) values (@kritikan, current_timestamp, 1, 1)";
                cmd.Parameters.Add(new NpgsqlParameter("@kritikan", richTextBox1.Text));
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();
                richTextBox1.Text = "";

                MessageBox.Show("Data Berhasil ditambahkan");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel11.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel11.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Info kepadatan = new Info(user);
            kepadatan.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Kritik kritik = new Kritik(user);
            kritik.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(user);
            homepage.Show();
            this.Hide();
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            panel12.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel12.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(user);
            homepage.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel11.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            FAQBaru faq = new FAQBaru(user);
            faq.Show();
            this.Hide();
        }

        private void pictureBox10_Click_2(object sender, EventArgs e)
        {
            panel12.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            page_ut page_Ut = new page_ut(user);
            page_Ut.Show();
            this.Hide();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label35_Click(object sender, EventArgs e)
        {
            GantiPasswordUser user_pass = new GantiPasswordUser(user);
            user_pass.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Kritik kritik = new Kritik(user);
            kritik.Show();
            this.Hide();
        }

        private void label33_Click(object sender, EventArgs e)
        {
            Riwayat_User riwayat_User = new Riwayat_User(user);
            riwayat_User.Show();
            this.Hide();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            Ulasan ulasan = new Ulasan(user);
            ulasan.Show();
            this.Hide();
        }

        private void label38_Click(object sender, EventArgs e)
        {
            PengumpulanPoin1 pengumpulanPoin1 = new PengumpulanPoin1(user);
            pengumpulanPoin1.Show();
            this.Hide();
        }
    }
}