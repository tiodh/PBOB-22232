using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using Npgsql;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Emit;
using System.Data;


namespace FIX_LOGIN_REGISTER
{
    public partial class BookTiket : Form
    {
        private Login.User user;
        private string connString = String.Format("Server=localhost; port=5432; Database=Jecation; User Id=postgres; Password=");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex = -1;

        public BookTiket(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void pesan_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex < 0)
            {
                NpgsqlConnection conn = new NpgsqlConnection(connString);
                try
                {
                    int d = Convert.ToInt32(jml_pengunjung.Text);
                    int a = Convert.ToInt32(pengunjung_ank.Text);
                    DateTime t = Convert.ToDateTime(tgl_kunjungan.Text);
                    harga.Text = $"{(d * 10000) + (a * 7500)}";
                    int ha = Convert.ToInt32(harga.Text);
                    conn.Open();
                    string sql = "INSERT INTO pemesanan_tiket (id_akun,tiket_dewasa, tiket_anak, jadwal_pmsn_tiket, harga) " +
                        "VALUES(@id,@pengunjung_dws, @pengunjung_ank, @tanggal_booking, @harga);";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("pengunjung_dws", d);
                    cmd.Parameters.AddWithValue("pengunjung_ank", a);
                    cmd.Parameters.AddWithValue("tanggal_booking", t);
                    cmd.Parameters.AddWithValue("harga", ha);
                    cmd.Parameters.AddWithValue("@id", user.id_user);
                    cmd.ExecuteScalar();
                    conn.Close();
                    harga.Text = $"Total harga: {(d * 10000) + (a * 7500)}";
                    MessageBox.Show("Inserted Successfully");
                    StrukHotel strukTiketMasuk = new StrukHotel(user);
                    strukTiketMasuk.Show();
                    this.Hide();
                    Select();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Insert Fail. Error: " + ex.Message);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public void jml_pengunjung_TextChanged(object sender, EventArgs e)
        {

        }

        private void harga_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StrukHotel struk = new StrukHotel(user);
            struk.Show();
            this.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(user);
            homepage.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {
            FAQBaru faq = new FAQBaru(user);
            faq.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Info kepadatan = new Info(user);
            kepadatan.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
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