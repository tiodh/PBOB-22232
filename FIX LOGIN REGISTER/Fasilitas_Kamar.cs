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

namespace FasilitasKamar
{
    public partial class Fasilitas_Kamar : Form
    {
        public Fasilitas_Kamar()
        {
            InitializeComponent();
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            UpdateFasilitas updateFasilitas = new UpdateFasilitas();
            updateFasilitas.Show();
            this.Hide();
        }

        private void Fasilitas_Kamar_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=pbo;User Id=postgres;Password=123456789");
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
    }
}