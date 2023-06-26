using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIX_LOGIN_REGISTER
{
    public partial class RiwayatAdmin : Form
    {
        private Login.User user;
        public RiwayatAdmin(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(user);
            admin.Show();
            this.Hide();
        }

        private void RiwayatAdmin_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT id_riwayat_penginapan, id_kamar, jumlah_malam, jumlah_kamar, total_harga, id_akun FROM riwayat_penginapan ORDER BY id_riwayat_penginapan";
                cmd.CommandType = CommandType.Text;
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
                cmd.CommandText = "SELECT id_riwayat_tiket, tiket_anak, tiket_dewasa, total_harga, id_akun FROM riwayat_tiket ORDER BY id_riwayat_tiket";
                cmd.CommandType = CommandType.Text;
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
    }
}
