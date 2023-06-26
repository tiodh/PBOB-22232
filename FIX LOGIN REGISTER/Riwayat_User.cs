using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIX_LOGIN_REGISTER;
using Npgsql;

namespace FIX_LOGIN_REGISTER
{
    public partial class Riwayat_User : Form
    {
        private Login.User user;
        public Riwayat_User(Login.User user)
        {
            InitializeComponent();
            this.user = user;

        }
        private void Riwayat_User_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT id_riwayat_penginapan, id_kamar, jumlah_malam, jumlah_kamar, total_harga, id_akun FROM riwayat_penginapan WHERE id_akun = @id_akun ORDER BY id_riwayat_penginapan";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_akun", user.id_user);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                // Menghubungkan DataTable dengan BindingSource
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                // Menghubungkan BindingSource dengan DataGridView
                guna2DataGridView1.DataSource = bindingSource;

                reader.Close();
                cmd.Dispose();
                connection.Close();
            }

            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT id_riwayat_tiket, tiket_anak, tiket_dewasa, total_harga, id_akun FROM riwayat_tiket WHERE id_akun = @id_akun ORDER BY id_riwayat_tiket";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_akun", user.id_user);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                // Menghubungkan DataTable dengan BindingSource
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                // Menghubungkan BindingSource dengan DataGridView
                guna2DataGridView2.DataSource = bindingSource;

                reader.Close();
                cmd.Dispose();
                connection.Close();
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(user);
            homepage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel11.Hide();
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

        private void label9_Click(object sender, EventArgs e)
        {
            FAQBaru fAQBaru = new FAQBaru(user);
            fAQBaru.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Info info = new Info(user);
            info.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            panel11.Show();
        }
    }
}
