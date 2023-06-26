using Npgsql;
using System.Data;

namespace FIX_LOGIN_REGISTER
{
    public partial class Info : Form
    {
        private Login.User user;
        private Size formOriginalSize;
        private Rectangle atas1;
        private Rectangle atas2;
        private Rectangle atas3;
        private Rectangle atas4;
        private Rectangle atas5;
        private Rectangle atas6;
        private Rectangle atas7;
        public Info(Login.User user)
        {
            InitializeComponent();
            this.user = user;
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            atas1 = new Rectangle(panel3.Location, panel3.Size);
            atas2 = new Rectangle(label1.Location, label1.Size);
            atas3 = new Rectangle(dateTimePicker1.Location, dateTimePicker1.Size);
            atas4 = new Rectangle(panel2.Location, panel2.Size);
            atas5 = new Rectangle(label3.Location, label3.Size);
            atas6 = new Rectangle(label4.Location, label4.Size);
            atas7 = new Rectangle(label5.Location, label5.Size);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(panel3, atas1);
            resize_Control(label1, atas2);
            resize_Control(dateTimePicker1, atas3);
            resize_Control(panel2, atas4);
            resize_Control(label3, atas5);
            resize_Control(label4, atas6);
            resize_Control(label5, atas7);
            //resize_Control(radioButton1, recRdo1);
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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select count(id_pmsn_tiket) from pemesanan_tiket where jadwal_pmsn_tiket = @now";
                cmd.Parameters.AddWithValue("@now", dateTimePicker1.Value);
                cmd.CommandType = CommandType.Text;

                // Mengambil hasil eksekusi perintah sebagai objek
                object result = cmd.ExecuteScalar();

                // Memeriksa apakah hasilnya tidak null
                if (result != null)
                {
                    // Mengkonversi hasil ke string dan menetapkannya ke label4.Text
                    label4.Text = "Pada tanggal " + dateTimePicker1.Value.ToString("dd MMMM yyyy") + ", terdapat " + result.ToString() + " orang yang sedang menikmati wisata kami.";
                }

                cmd.Dispose();
                connection.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select count(id_pmsn_tiket) from pemesanan_tiket where jadwal_pmsn_tiket = @now";
                cmd.Parameters.AddWithValue("@now", dateTimePicker1.Value);
                cmd.CommandType = CommandType.Text;

                // Mengambil hasil eksekusi perintah sebagai objek
                object result = cmd.ExecuteScalar();

                // Memeriksa apakah hasilnya tidak null
                if (result != null)
                {
                    // Mengkonversi hasil ke string dan menetapkannya ke label4.Text
                    label4.Text = "Pada tanggal " + dateTimePicker1.Value.ToString("dd MMMM yyyy") + ", terdapat " + result.ToString() + " orang yang sedang menikmati wisata kami.";
                }

                cmd.Dispose();
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel11.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel11.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(user);
            homepage.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel12.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel12.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            FAQBaru faq = new FAQBaru(user);
            faq.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Info info = new Info(user);
            info.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            page_ut page_Ut = new page_ut(user);
            page_Ut.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Kritik kritik = new Kritik(user);
            kritik.Show();
            this.Hide();
        }

        private void label35_Click(object sender, EventArgs e)
        {
            GantiPasswordUser gantiPasswordUser = new GantiPasswordUser(user);
            gantiPasswordUser.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            page_ut page_Ut = new page_ut(user);
            page_Ut.Show();
            this.Hide();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            BookTiket bookTiket = new BookTiket(user);
            bookTiket.Show();
            this.Hide();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            FAQBaru faq = new FAQBaru(user);
            faq.Show();
            this.Hide();
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            Info kepadatan = new Info(user);
            kepadatan.Show();
            this.Hide();
        }

        private void label8_Click_1(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel11.Hide();
        }
    }
}