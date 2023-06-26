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
    public partial class detail_dahliaI : Form
    {
        private Login.User user;
        public detail_dahliaI(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button13_Click(object sender, EventArgs e)
        {
            StrukHotel struk = new StrukHotel(user);
            struk.Show();
            this.Hide();
        }

        private void detail_dahliaI_Load(object sender, EventArgs e)
        {
            try
            {
                int id = 6;
                using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=;Database=Jecation"))
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandText = "select nomor_kamar from detail_kamar where status_kamar = '1' and id_kamar = @id order by nomor_kamar asc";

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

        private int GetSelisihHari()
        {

            DateTime checkInDate = dateTimePicker14.Value;
            DateTime checkOutDate = dateTimePicker13.Value.Date.AddDays(1).AddSeconds(-1);
            TimeSpan selisih = checkOutDate - checkInDate;
            return selisih.Days;
        }

        public void UpdateResult()
        {
            int selisihHari = GetSelisihHari();
            int jumlahPilihan = checkedListBox1.CheckedItems.Count;
            int nilaiLabel = Convert.ToInt32(label130.Text);
            int hasilPerkalian = selisihHari * jumlahPilihan * nilaiLabel;

            label133.Text = ("Total Harga = " + hasilPerkalian.ToString());
            label134.Text = (("x " + selisihHari.ToString() + " Malam"));
            label132.Text = (("Tagihan Minimal = ") + hasilPerkalian * 1 / 4);
        }

        private void dateTimePicker14_ValueChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void dateTimePicker13_ValueChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResult();
            label134.Visible = true;
            label133.Visible = true;
            label132.Visible = true;
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
