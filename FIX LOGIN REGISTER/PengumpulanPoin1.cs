using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace FIX_LOGIN_REGISTER
{

    public partial class PengumpulanPoin1 : Form
    {
        private Login.User user;

        public class Program
        {

        }
        public PengumpulanPoin1(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            PengumpulanPoin2 form5 = new PengumpulanPoin2(user);
            form5.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PengumpulanPoin1_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password="))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT poin_akun, username_akun FROM akun WHERE id_akun = @id";
                command.Parameters.AddWithValue("@id", user.id_user);
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string jeniskontak = reader.GetString(reader.GetOrdinal("username_akun"));
                        label10.Text = jeniskontak;

                        int nomorkontak = reader.GetInt32(reader.GetOrdinal("poin_akun"));
                        label8.Text = nomorkontak.ToString();
                    }
                }
            }

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(user);
            homepage.Show();
            this.Hide();
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            //    PengumpulanPoin2 pengumpulanPoin2 = new PengumpulanPoin2(user);
            //    pengumpulanPoin2.Show();
            //    this.Hide();
        }

        private void PerpanjangPromo3()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"
                UPDATE voucher
                SET tanggal_berakhir = tanggal_berakhir + INTERVAL '2 weeks'
                WHERE id_voucher = 1;
                
                UPDATE akun
                SET poin_akun = poin_akun - 60
                WHERE poin_akun >= 60;
            ";
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Perpanjangan promo berhasil. Poin akun dikurangi 60.");
                    }
                    else
                    {
                        MessageBox.Show("Perpanjangan promo tidak berhasil. Poin akun tidak mencukupi atau voucher tidak ditemukan.");
                    }
                }

                connection.Close();
            }
        }


        private void PerpanjangPromo2()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"
                UPDATE voucher
                SET tanggal_berakhir = tanggal_berakhir + INTERVAL '2 weeks'
                WHERE id_voucher = 1;
                
                UPDATE akun
                SET poin_akun = poin_akun - 80
                WHERE poin_akun >= 80;
            ";
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Perpanjangan promo berhasil. Poin akun dikurangi 80.");
                    }
                    else
                    {
                        MessageBox.Show("Perpanjangan promo tidak berhasil. Poin akun tidak mencukupi atau voucher tidak ditemukan.");
                    }
                }

                connection.Close();
            }
        }


        private void PerpanjangPromo1()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"
                UPDATE voucher
                SET tanggal_berakhir = tanggal_berakhir + INTERVAL '2 weeks'
                WHERE id_voucher = 1;
                
                UPDATE akun
                SET poin_akun = poin_akun - 100
                WHERE poin_akun >= 100;
            ";
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Perpanjangan promo berhasil. Poin akun dikurangi 100.");
                    }
                    else
                    {
                        MessageBox.Show("Perpanjangan promo tidak berhasil. Poin akun tidak mencukupi atau voucher tidak ditemukan.");
                    }
                }

                connection.Close();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            PerpanjangPromo1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PerpanjangPromo2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PerpanjangPromo3();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel11.Hide();
        }
    }

}
