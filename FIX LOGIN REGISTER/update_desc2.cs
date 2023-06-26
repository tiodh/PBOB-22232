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
    public partial class update_desc2 : Form
    {
        private Login.User user;
        public update_desc2(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password=");
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tempat_wisata where id_wisata=1";
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                id_wisata.Text = reader["id_wisata"].ToString();
                textBox4.Text = reader["deskripsi_wisata"].ToString();
            }

            con.Close();
        }

        private void Simpanbutton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password=");
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE tempat_wisata SET deskripsi_wisata = @ayam WHERE id_wisata = 1";
            string ayam = textBox4.Text;
            cmd.Parameters.AddWithValue("@ayam", ayam);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Berhasil, Yeyyy!");
        }

        private void label16_Click(object sender, EventArgs e)
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
