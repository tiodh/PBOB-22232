using Microsoft.VisualBasic.ApplicationServices;
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
using System.Threading;

namespace FIX_LOGIN_REGISTER
{
    public partial class UpdateFasilitas : Form
    {
        Login.User user;
        public UpdateFasilitas(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UpdateFasilitas_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password=;"))
            {
                //conn.Open();
                //NpgsqlCommand comm = new NpgsqlCommand();
                //comm.Connection = conn;
                //comm.CommandType = CommandType.Text;
                //comm.CommandText = "select nama_fasilitas_kamar from fasilitas_kamar where id_fasilitas_kamar = @id";
                //comm.ExecuteNonQuery();
                //comm.Dispose();
                //conn.Close();
            }

            using (NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = Jecation; User Id = postgres; Password = ; "))
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "select id_fasilitas_kamar from fasilitas_kamar order by id_fasilitas_kamar asc";
                NpgsqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader["id_fasilitas_kamar"].ToString());
                    }
                }
                conn.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox2.SelectedItem.ToString(), out int idni))
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = Jecation; User Id = postgres; Password = ; "))
                {
                    conn.Open();
                    NpgsqlCommand comm = new NpgsqlCommand();
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "select nama_fasilitas_kamar, id_kamar from fasilitas_kamar where id_fasilitas_kamar = @id";
                    int id = comboBox2.SelectedIndex;
                    comm.Parameters.AddWithValue("@id", idni);

                    NpgsqlDataReader reader = comm.ExecuteReader();
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = reader["nama_fasilitas_kamar"].ToString();
                        }
                        else
                        {
                            textBox1.Text = string.Empty;
                        }
                    }

                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password=;");
            conn.Open();
            NpgsqlCommand comm = conn.CreateCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update fasilitas_kamar set nama_fasilitas_kamar='" + textBox1.Text + "' where id_fasilitas_kamar = @id";
            comm.Parameters.AddWithValue("@id", comboBox2.SelectedIndex);
            comm.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data berhasil diperbarui");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fasilitas_Kamar fasilitasKamar = new Fasilitas_Kamar(user);
            fasilitasKamar.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(user);
            admin.Show();
            this.Hide();
        }
    }
}
