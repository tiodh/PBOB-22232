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

namespace homepage_admin
{
    public partial class profil : Form
    {
        public profil()
        {
            InitializeComponent();
        }

        private void profil_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=123; Database=pbo_b"))
            {
                conn.Open();
                using NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM akun where role = admin";
                cmd.CommandType = CommandType.Text;
                NpgsqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    this.tb_nama_lengkap.Text = reader.GetString(2) + reader.GetString(3); //Kolom First Name + last Name
                    this.tb_tanggal_lahir.Text = reader.GetString(8); //Kolom Tanggal Lahir
                    this.tb_nik.Text = reader.GetString(6); //Kolom NIK
                    this.tb_provinsi.Text = reader.GetString(9); //Kolom Provinsi
                    this.tb_kabupaten.Text = reader.GetString(10); //Kolom Kabupaten
                    this.tb_kecamatan.Text = reader.GetString(11); //Kolom Kecamatan
                    this.value_poin.Text = reader.GetString(12); //Kolom Poin Akun
                }
                reader.Close();
                conn.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login log = new login();
            //this.Hide();
            //log.Show();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_nama_lengkap_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void tb_tanggal_lahir_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void tb_nik_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_provinsi_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void tb_kabupaten_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_kecamatan_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void value_poin_Click(object sender, EventArgs e)
        {
        }
    }
}
