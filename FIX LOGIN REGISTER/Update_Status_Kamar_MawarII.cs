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

namespace pbo_desain
{
    public partial class Update_Status_Kamar_MawarII : Form
        
    {
        private string connstring = string.Format("Server=localhost; port=5432; Database=Mawar II; User Id=postgres; Password=haloavav23");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowindex = -1;

        public Update_Status_Kamar_MawarII()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //update
        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            string sql = $"update kamarmawarii set status = '{pilihstatus.Text}' where no_kamar = '{pilihkamar.Text}';";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("no_kamar", pilihkamar.Text);
            cmd.Parameters.AddWithValue("status", pilihstatus.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update Telah Berhasil");
        }

        //insert
        private void button1_Click_1(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            string sql = "insert into kamarmawarii(no_kamar, status)" +
                "values (@no_kamar, @status)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("no_kamar", pilihkamar.Text);
            cmd.Parameters.AddWithValue("status", pilihstatus.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Insert Telah Berhasil");
        }
    }
}
