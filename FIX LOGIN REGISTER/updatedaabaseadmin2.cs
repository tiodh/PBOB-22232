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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace updatetiket
{
    public partial class UpHargaTiketANK : Form
    {
        public UpHargaTiketANK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HargaTiket frm = new HargaTiket();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=jecationn; User Id=postgres; Password=dita041003");
            conn.Open();
            NpgsqlCommand comm = conn.CreateCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update tiket_masuk set harga_tiket_masuk = '" + textBox3.Text + "' where id_tiket_masuk = '" + textBox1.Text + "' and kategori = '" + textBox2.Text + "'";
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Harga tiket berhasil diperbarui!");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=jecationn; User Id=postgres; Password=dita041003");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from tiket_masuk where id_tiket_masuk = 1";
            NpgsqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())

            {
                textBox1.Text = reader["id_tiket_masuk"].ToString();
                textBox2.Text = reader["kategori"].ToString();
                textBox3.Text = reader["harga_tiket_masuk"].ToString();
            }
            conn.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }

    public partial class UpHargaTiketDWS : Form
    {
        public UpHargaTiketDWS()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=jecationn; User Id=postgres; Password=dita041003");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from tiket_masuk where id_tiket_masuk = 2";
            NpgsqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())

            {
                textBox1.Text = reader["id_tiket_masuk"].ToString();
                textBox2.Text = reader["kategori"].ToString();
                textBox3.Text = reader["harga_tiket_masuk"].ToString();
            }
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=jecationn; User Id=postgres; Password=dita041003");
            conn.Open();
            NpgsqlCommand comm = conn.CreateCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update tiket_masuk set harga_tiket_masuk = '" + textBox3.Text + "' where id_tiket_masuk = '" + textBox1.Text + "' and kategori = '" + textBox2.Text + "'";
            comm.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Harga tiket berhasil diperbarui!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HargaTiket frm = new HargaTiket();
            frm.ShowDialog();
        }
    }
}
