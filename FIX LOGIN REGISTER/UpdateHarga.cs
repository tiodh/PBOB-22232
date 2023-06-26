using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FIX_LOGIN_REGISTER
{
    public partial class UpdateHarga : Form
    {
        private Login.User user;
        public UpdateHarga(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
            {
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select kategori, harga_tiket_masuk from tiket_masuk where id_tiket_masuk = 2";
                NpgsqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    label4.Text = reader["kategori"].ToString();
                    label5.Text = reader["harga_tiket_masuk"].ToString();
                }
                conn.Close();
            }

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
            {
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select kategori, harga_tiket_masuk from tiket_masuk where id_tiket_masuk = 1";
                NpgsqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    label2.Text = reader["kategori"].ToString();
                    label3.Text = reader["harga_tiket_masuk"].ToString();
                }
                conn.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateHargaDewasa frm = new UpdateHargaDewasa(user);
            frm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateHargaAnak frm = new UpdateHargaAnak(user);
            frm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(user);
            admin.Show();
            this.Hide();
        }
    }
}