using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace updatetiket
{
    public partial class HargaTiket : Form
    {
        public HargaTiket()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=jecationn; User Id=postgres; Password=dita041003"))
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

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=jecationn; User Id=postgres; Password=dita041003"))
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
            UpHargaTiketANK frm = new UpHargaTiketANK();
            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpHargaTiketDWS frm = new UpHargaTiketDWS();
            frm.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}