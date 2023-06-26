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
    
    public partial class KodePembayaranuser : Form
    {
        private Login.User user;
        private Homepage homepage;
        public KodePembayaranuser(Login.User user)
        {
            InitializeComponent();
            this.user = user;
            homepage = new Homepage();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=;Database=Jecation";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    string insertquery = "INSERT INTO kode_pembayaran (kode_pembayaran, id_akun) VALUES (@kode_pembayaran, @id_akun); UPDATE notifikasi_user SET status = true WHERE id_akun = @id_akun";
                    cmd.CommandText = insertquery;
                    cmd.Parameters.AddWithValue("@id_akun", user.id_user);
                    cmd.Parameters.AddWithValue("@kode_pembayaran", int.Parse(textBox1.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kode telah terkirim");
                    this.Hide();
                    //homepage.bacadata();
                    this.Refresh();         
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
