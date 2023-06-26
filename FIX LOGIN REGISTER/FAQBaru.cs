using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIX_LOGIN_REGISTER
{
    public partial class FAQBaru : Form
    {
        private Login.User user;
        public FAQBaru(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }



        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(user);
            homepage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel11.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel11.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Kritik kritik = new Kritik(user);
            kritik.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Info info = new Info(user);
            info.Show();
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

        private void label13_Click(object sender, EventArgs e)
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

        private void FAQBaru_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password=");
            conn.Open();
            NpgsqlCommand cmd4 = new NpgsqlCommand();
            cmd4.Connection = conn;
            cmd4.CommandText = "SELECT * FROM kontak_darurat WHERE id_kontak_darurat = 1";

            using (NpgsqlDataReader reader = cmd4.ExecuteReader())
            {
                if (reader.Read())
                {
                    string jeniskontak = reader.GetString(reader.GetOrdinal("nama_kontak_darurat"));
                    label9.Text = jeniskontak;

                    string nomorkontak = reader.GetString(reader.GetOrdinal("nomor_kontak_darurat"));
                    label10.Text = nomorkontak;
                }
            }

            NpgsqlCommand cmd5 = new NpgsqlCommand();
            cmd5.Connection = conn;
            cmd5.CommandText = "SELECT * FROM kontak_darurat WHERE id_kontak_darurat = 2";

            using (NpgsqlDataReader reader = cmd5.ExecuteReader())
            {
                if (reader.Read())
                {
                    string jeniskontak = reader.GetString(reader.GetOrdinal("nama_kontak_darurat"));
                    label11.Text = jeniskontak;

                    string nomorkontak = reader.GetString(reader.GetOrdinal("nomor_kontak_darurat"));
                    label14.Text = nomorkontak;
                }
            }

            NpgsqlCommand cmd6 = new NpgsqlCommand();
            cmd6.Connection = conn;
            cmd6.CommandText = "SELECT * FROM kontak_darurat WHERE id_kontak_darurat = 3";

            using (NpgsqlDataReader reader = cmd6.ExecuteReader())
            {
                if (reader.Read())
                {
                    string jeniskontak = reader.GetString(reader.GetOrdinal("nama_kontak_darurat"));
                    label15.Text = jeniskontak;

                    string nomorkontak = reader.GetString(reader.GetOrdinal("nomor_kontak_darurat"));
                    label16.Text = nomorkontak;
                }
            }

            NpgsqlCommand cmd7 = new NpgsqlCommand();
            cmd7.Connection = conn;
            cmd7.CommandText = "SELECT * FROM kontak_darurat WHERE id_kontak_darurat = 4";

            using (NpgsqlDataReader reader = cmd7.ExecuteReader())
            {
                if (reader.Read())
                {
                    string jeniskontak = reader.GetString(reader.GetOrdinal("nama_kontak_darurat"));
                    label21.Text = jeniskontak;

                    string nomorkontak = reader.GetString(reader.GetOrdinal("nomor_kontak_darurat"));
                    label22.Text = nomorkontak;
                }
            }

            NpgsqlCommand cmd8 = new NpgsqlCommand();
            cmd8.Connection = conn;
            cmd8.CommandText = "SELECT * FROM kontak_darurat WHERE id_kontak_darurat = 5";

            using (NpgsqlDataReader reader = cmd7.ExecuteReader())
            {
                if (reader.Read())
                {
                    string jeniskontak = reader.GetString(reader.GetOrdinal("nama_kontak_darurat"));
                    label37.Text = jeniskontak;

                    string nomorkontak = reader.GetString(reader.GetOrdinal("nomor_kontak_darurat"));
                    label36.Text = nomorkontak;
                }
            }

            NpgsqlCommand cmd9 = new NpgsqlCommand();
            cmd9.Connection = conn;
            cmd9.CommandText = "SELECT * FROM kontak_darurat WHERE id_kontak_darurat = 6";

            using (NpgsqlDataReader reader = cmd9.ExecuteReader())
            {
                if (reader.Read())
                {
                    string jeniskontak = reader.GetString(reader.GetOrdinal("nama_kontak_darurat"));
                    label34.Text = jeniskontak;

                    string nomorkontak = reader.GetString(reader.GetOrdinal("nomor_kontak_darurat"));
                    label31.Text = nomorkontak;
                }
            }

            NpgsqlCommand cmd10 = new NpgsqlCommand();
            cmd10.Connection = conn;
            cmd10.CommandText = "SELECT * FROM kontak_darurat WHERE id_kontak_darurat = 7";

            using (NpgsqlDataReader reader = cmd10.ExecuteReader())
            {
                if (reader.Read())
                {
                    string jeniskontak = reader.GetString(reader.GetOrdinal("nama_kontak_darurat"));
                    label30.Text = jeniskontak;

                    string nomorkontak = reader.GetString(reader.GetOrdinal("nomor_kontak_darurat"));
                    label29.Text = nomorkontak;
                }
            }

            NpgsqlCommand cmd11 = new NpgsqlCommand();
            cmd11.Connection = conn;
            cmd11.CommandText = "SELECT * FROM kontak_darurat WHERE id_kontak_darurat = 8";

            using (NpgsqlDataReader reader = cmd11.ExecuteReader())
            {
                if (reader.Read())
                {
                    string jeniskontak = reader.GetString(reader.GetOrdinal("nama_kontak_darurat"));
                    label28.Text = jeniskontak;

                    string nomorkontak = reader.GetString(reader.GetOrdinal("nomor_kontak_darurat"));
                    label27.Text = nomorkontak;
                }
            }

            NpgsqlCommand cmd12 = new NpgsqlCommand();
            cmd12.Connection = conn;
            cmd12.CommandText = "SELECT * FROM kontak_darurat WHERE id_kontak_darurat = 9";

            using (NpgsqlDataReader reader = cmd12.ExecuteReader())
            {
                if (reader.Read())
                {
                    string jeniskontak = reader.GetString(reader.GetOrdinal("nama_kontak_darurat"));
                    label47.Text = jeniskontak;

                    string nomorkontak = reader.GetString(reader.GetOrdinal("nomor_kontak_darurat"));
                    label46.Text = nomorkontak;
                }
            }

            NpgsqlCommand cmd13 = new NpgsqlCommand();
            cmd13.Connection = conn;
            cmd13.CommandText = "SELECT * FROM kontak_darurat WHERE id_kontak_darurat = 10";

            using (NpgsqlDataReader reader = cmd13.ExecuteReader())
            {
                if (reader.Read())
                {
                    string jeniskontak = reader.GetString(reader.GetOrdinal("nama_kontak_darurat"));
                    label45.Text = jeniskontak;

                    string nomorkontak = reader.GetString(reader.GetOrdinal("nomor_kontak_darurat"));
                    label44.Text = nomorkontak;
                }
            }

            NpgsqlCommand cmd14 = new NpgsqlCommand();
            cmd14.Connection = conn;
            cmd14.CommandText = "SELECT * FROM kontak_darurat WHERE id_kontak_darurat = 11";

            using (NpgsqlDataReader reader = cmd14.ExecuteReader())
            {
                if (reader.Read())
                {
                    string jeniskontak = reader.GetString(reader.GetOrdinal("nama_kontak_darurat"));
                    label43.Text = jeniskontak;

                    string nomorkontak = reader.GetString(reader.GetOrdinal("nomor_kontak_darurat"));
                    label42.Text = nomorkontak;
                }
            }

            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                NpgsqlCommand command = new NpgsqlCommand("SELECT pertanyaan_faq FROM faq WHERE id_faq = 1 ", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ambil nilai kolom dari baris saat ini menggunakan indeks kolom atau nama kolom
                    string nama = reader.GetString(0);

                    // Tampilkan nilai kolom menggunakan label atau kontrol lainnya
                    label3.Text = nama + "\n";
                }
                reader.Close();
                connection.Close();
            }
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                NpgsqlCommand command = new NpgsqlCommand("SELECT pertanyaan_faq FROM faq WHERE id_faq = 2 ", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ambil nilai kolom dari baris saat ini menggunakan indeks kolom atau nama kolom
                    string nama = reader.GetString(0);

                    // Tampilkan nilai kolom menggunakan label atau kontrol lainnya
                    label4.Text = nama + "\n";
                }
                reader.Close();
                connection.Close();
            }
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                NpgsqlCommand command = new NpgsqlCommand("SELECT pertanyaan_faq FROM faq WHERE id_faq = 3 ", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ambil nilai kolom dari baris saat ini menggunakan indeks kolom atau nama kolom
                    string nama = reader.GetString(0);

                    // Tampilkan nilai kolom menggunakan label atau kontrol lainnya
                    label5.Text = nama + "\n";
                }
                reader.Close();
                connection.Close();
            }
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                NpgsqlCommand command = new NpgsqlCommand("SELECT pertanyaan_faq FROM faq WHERE id_faq = 4 ", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ambil nilai kolom dari baris saat ini menggunakan indeks kolom atau nama kolom
                    string nama = reader.GetString(0);

                    // Tampilkan nilai kolom menggunakan label atau kontrol lainnya
                    label8.Text = nama + "\n";
                }
                reader.Close();
                connection.Close();
            }
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                NpgsqlCommand command = new NpgsqlCommand("SELECT pertanyaan_faq FROM faq WHERE id_faq = 5 ", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ambil nilai kolom dari baris saat ini menggunakan indeks kolom atau nama kolom
                    string nama = reader.GetString(0);

                    // Tampilkan nilai kolom menggunakan label atau kontrol lainnya
                    label7.Text = nama + "\n";
                }
                reader.Close();
                connection.Close();
            }
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                NpgsqlCommand command = new NpgsqlCommand("SELECT pertanyaan_faq FROM faq WHERE id_faq = 6 ", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ambil nilai kolom dari baris saat ini menggunakan indeks kolom atau nama kolom
                    string nama = reader.GetString(0);

                    // Tampilkan nilai kolom menggunakan label atau kontrol lainnya
                    label6.Text = nama + "\n";
                }
                reader.Close();
                connection.Close();
            }
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                NpgsqlCommand command = new NpgsqlCommand("SELECT jawaban_faq FROM faq WHERE id_faq = 1 ", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ambil nilai kolom dari baris saat ini menggunakan indeks kolom atau nama kolom
                    string nama = reader.GetString(0);

                    // Tampilkan nilai kolom menggunakan label atau kontrol lainnya
                    label23.Text = nama + "\n";
                }
                reader.Close();
                connection.Close();
            }
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                NpgsqlCommand command = new NpgsqlCommand("SELECT jawaban_faq FROM faq WHERE id_faq = 2 ", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ambil nilai kolom dari baris saat ini menggunakan indeks kolom atau nama kolom
                    string nama = reader.GetString(0);

                    // Tampilkan nilai kolom menggunakan label atau kontrol lainnya
                    label24.Text = nama + "\n";
                }
                reader.Close();
                connection.Close();
            }
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                NpgsqlCommand command = new NpgsqlCommand("SELECT jawaban_faq FROM faq WHERE id_faq = 3 ", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ambil nilai kolom dari baris saat ini menggunakan indeks kolom atau nama kolom
                    string nama = reader.GetString(0);

                    // Tampilkan nilai kolom menggunakan label atau kontrol lainnya
                    label25.Text = nama + "\n";
                }
                reader.Close();
                connection.Close();
            }
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                NpgsqlCommand command = new NpgsqlCommand("SELECT jawaban_faq FROM faq WHERE id_faq = 4 ", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ambil nilai kolom dari baris saat ini menggunakan indeks kolom atau nama kolom
                    string nama = reader.GetString(0);

                    // Tampilkan nilai kolom menggunakan label atau kontrol lainnya
                    label26.Text = nama + "\n";
                }
                reader.Close();
                connection.Close();
            }
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                NpgsqlCommand command = new NpgsqlCommand("SELECT jawaban_faq FROM faq WHERE id_faq = 5 ", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ambil nilai kolom dari baris saat ini menggunakan indeks kolom atau nama kolom
                    string nama = reader.GetString(0);

                    // Tampilkan nilai kolom menggunakan label atau kontrol lainnya
                    label38.Text = nama + "\n";
                }
                reader.Close();
                connection.Close();
            }
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                NpgsqlCommand command = new NpgsqlCommand("SELECT jawaban_faq FROM faq WHERE id_faq = 6 ", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ambil nilai kolom dari baris saat ini menggunakan indeks kolom atau nama kolom
                    string nama = reader.GetString(0);

                    // Tampilkan nilai kolom menggunakan label atau kontrol lainnya
                    label39.Text = nama + "\n";
                }
                reader.Close();
                connection.Close();
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            page_ut page_Ut = new page_ut(user);
            page_Ut.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            BookTiket bookTiket = new BookTiket(user);
            bookTiket.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            FAQBaru fAQBaru = new FAQBaru(user);
            fAQBaru.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Info info = new Info(user);
            info.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
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

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
