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
    public partial class detail_melatiIIs : Form
    {
        private Login.User user;
        public detail_melatiIIs(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GetSelisihHari()
        {

            DateTime checkInDate = dateTimePicker8.Value;
            DateTime checkOutDate = dateTimePicker7.Value.Date.AddDays(1).AddSeconds(-1);
            TimeSpan selisih = checkOutDate - checkInDate;
            return selisih.Days;
        }

        public void UpdateResult()
        {
            int selisihHari = GetSelisihHari();
            int jumlahPilihan = checkedListBox1.CheckedItems.Count;
            int nilaiLabel = Convert.ToInt32(label77.Text);
            int hasilPerkalian = selisihHari * jumlahPilihan * nilaiLabel;

            label80.Text = ("Total Harga = " + hasilPerkalian.ToString());
            label81.Text = ("x " + selisihHari.ToString() + " Malam");
            label79.Text = (("Tagihan Minimal = ") + hasilPerkalian * 1 / 4);
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            //pictureBox2.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button left.png");
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            //pictureBox2.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button left2.png");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            //pictureBox2.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button left efek.png");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            //pictureBox2.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button left.png");
        }

        private void detail_melatiIIs_Load(object sender, EventArgs e)
        {
            try
            {
                int id = 4;
                using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=;Database=Jecation"))
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandText = "select nomor_kamar from detail_kamar where status_kamar = false and id_kamar = @id order by nomor_kamar asc";

                    command.Parameters.AddWithValue("@id", id);
                    NpgsqlDataReader reader = command.ExecuteReader();
                    List<string> nomorKamarList = new List<string>();

                    while (reader.Read())
                    {
                        //bool statusKamar = reader.GetBoolean(reader.GetOrdinal("status_kamar"));
                        string nomorKamar = reader.GetString(reader.GetOrdinal("nomor_kamar"));

                        //if (statusKamar)
                        //{
                        nomorKamarList.Add(nomorKamar.ToString());
                        //}
                    }

                    foreach (string nomorKamar in nomorKamarList)
                    {
                        checkedListBox1.Items.Add(nomorKamar);
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void dateTimePicker8_ValueChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void label84_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker7_ValueChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResult(); label81.Visible = true; label80.Visible = true; label79.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int jumlah = checkedListBox1.CheckedItems.Count;
            int id = 1;
            int selisihHari = GetSelisihHari();
            int jumlahPilihan = checkedListBox1.CheckedItems.Count;
            int nilaiLabel = Convert.ToInt32(label77.Text);
            int hasilPerkalian = selisihHari * jumlahPilihan * nilaiLabel;
            using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=;Database=Jecation"))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandText = "insert into reservasi_penginapan (id_akun,jumlah_kamar,id_kamar, jadwal_masuk_penginapan, jadwal_keluar_penginapan, harga, harga_minimal , nama_kamar) values ( @id_akun,@jumlah_kamar, @id, @checkin, @checkout, @harga, @harga_minimal,'MelatiIIs')";
                command.Parameters.AddWithValue("@jumlah_kamar", jumlah);
                command.Parameters.AddWithValue("@checkin", dateTimePicker8.Value);
                command.Parameters.AddWithValue("@checkout", dateTimePicker7.Value);
                command.Parameters.AddWithValue("@harga", hasilPerkalian); // Ganti dengan harga yang sesuai
                command.Parameters.AddWithValue("@harga_minimal", hasilPerkalian * 1 / 4);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@id_akun", user.id_user);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                StrukTiketMasuk struk = new StrukTiketMasuk(user);
                struk.Show();
                this.Hide();

            }
        }
    }
}
