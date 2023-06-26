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
using System;
using System.Windows.Forms;
using System.Threading;

namespace FIX_LOGIN_REGISTER
{
    public partial class Fasilitas_Kamar : Form
    {
        private Login.User user;
        public Fasilitas_Kamar(Login.User user)
        {
            InitializeComponent();
            this.user = user;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            UpdateFasilitas updateFasilitas = new UpdateFasilitas(user);
            updateFasilitas.Show();
            this.Hide();
        }

        private void Fasilitas_Kamar_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password=");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from fasilitas_kamar order by id_fasilitas_kamar asc";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(user);
            admin.Show();
            this.Hide();
        }
    }
}