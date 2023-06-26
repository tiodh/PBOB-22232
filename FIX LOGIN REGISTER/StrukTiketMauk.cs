using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static FIX_LOGIN_REGISTER.BookTiket;
using System.Globalization;
using System.Reflection.Emit;

namespace FIX_LOGIN_REGISTER
{

    public partial class StrukHotel : Form
    {
        private Login.User user;
        private Size formOriginalSize;
        private Rectangle recpicture1;
        private Rectangle recpicture2;
        private Rectangle recpicture3;
        private Rectangle recpicture4;
        private Rectangle rectabel2;
        private Rectangle rectabel4;
        private Rectangle rectabel5;
        private Rectangle rectabel7;
        private Rectangle rectabel8;
        private Rectangle rectabel9;
        private Rectangle rectabel10;
        private Rectangle rectabel12;
        private Rectangle rectabel13;
        private Rectangle rectabel14;
        private Rectangle rectabel15;
        private Rectangle rectabel17;
        private Rectangle rectabel18;
        private Rectangle rectabel19;
        private Rectangle rectabel20;
        private Rectangle recbutton3;
        public StrukHotel(Login.User user)
        {
            InitializeComponent();
            this.user = user;
            this.Resize += Form2_Resize;
            formOriginalSize = this.Size;
            recpicture1 = new Rectangle(pictureBox2.Location, pictureBox2.Size);
            recpicture2 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recpicture3 = new Rectangle(pictureBox3.Location, pictureBox3.Size);
            recpicture4 = new Rectangle(pictureBox4.Location, pictureBox4.Size);
            recbutton3 = new Rectangle(guna2Button1.Location, guna2Button1.Size);
            rectabel2 = new Rectangle(label1.Location, label1.Size);
            rectabel4 = new Rectangle(label4.Location, label4.Size);
            rectabel5 = new Rectangle(label21.Location, label21.Size);
            rectabel7 = new Rectangle(label2.Location, label2.Size);
            rectabel8 = new Rectangle(label13.Location, label13.Size);
            rectabel9 = new Rectangle(label5.Location, label5.Size);
            rectabel10 = new Rectangle(label14.Location, label14.Size);
            rectabel12 = new Rectangle(label10.Location, label10.Size);
            rectabel13 = new Rectangle(label19.Location, label19.Size);
            rectabel14 = new Rectangle(label15.Location, label15.Size);
            rectabel15 = new Rectangle(label15.Location, label15.Size);
            rectabel17 = new Rectangle(label19.Location, label19.Size);
            rectabel18 = new Rectangle(label10.Location, label10.Size);
            rectabel19 = new Rectangle(label3.Location, label3.Size);
            rectabel20 = new Rectangle(label23.Location, label23.Size);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private int harga;
        private DateTime hari;
        private int tiket_anak;
        private int tiket_dewasa;
        private void Form2_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT id_pmsn_tiket, harga, jadwal_pmsn_tiket, tiket_anak, harga, tiket_dewasa FROM pemesanan_tiket WHERE id_akun = @id ORDER BY id_pmsn_tiket DESC LIMIT 1";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", user.id_user);

                NpgsqlDataReader reader = cmd.ExecuteReader();

                // Membaca baris per baris dari hasil query
                while (reader.Read())
                {
                    // Mendapatkan nilai-nilai kolom
                    string id_pmsn_tiket = reader["id_pmsn_tiket"].ToString();
                    string tiket_anak = reader["tiket_anak"].ToString();
                    DateTime jadwal_penginapan_tiket = Convert.ToDateTime(reader["jadwal_pmsn_tiket"]);
                    string harga = reader["harga"].ToString();
                    string tiket_dewasa = reader["tiket_dewasa"].ToString();

                    // Menetapkan nilai-nilai ke label-label yang sesuai
                    label21.Text = id_pmsn_tiket;
                    label19.Text = tiket_anak;
                    label23.Text = jadwal_penginapan_tiket.ToString("yyyy-MM-dd");
                    label15.Text = harga;
                    label14.Text = tiket_dewasa;
                    label13.Text = user.username;
                }

                harga = int.Parse(label15.Text);
                DateTime jadwal = DateTime.ParseExact(label23.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                hari = jadwal.Date;
                tiket_anak = int.Parse(label19.Text);
                tiket_dewasa = int.Parse(label14.Text);

                // Menambahkan 10 poin pada kolom "poin" di tabel "akun"
                

                reader.Close();
                cmd.Dispose();
                connection.Close();
            }


            label7.Text = promodigunakan;

            if (label7.Text == promodigunakan)
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT besar_voucher FROM voucher WHERE nama_voucher = @nama_voucher";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@nama_voucher", label7.Text);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    // Membaca baris per baris dari hasil query
                    if (reader.Read())
                    {
                        int besar_voucher = reader.GetInt32(reader.GetOrdinal("besar_voucher"));
                        int nilailabel14 = int.Parse(label14.Text);
                        int hasil = nilailabel14 + besar_voucher;
                        label14.Text = hasil.ToString();
                    }

                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            //resize_Control(pictureBox2, recpicture1);
            //resize_Control(pictureBox1, recpicture2);
            //resize_Control(pictureBox3, recpicture3);
            //resize_Control(pictureBox4, recpicture4);
            //resize_Control(guna2Button1, recbutton3);
            //resize_Control(label15, rectabel12);
            //resize_Control(label19, rectabel13);
            //resize_Control(label19, rectabel14);
            //resize_Control(label14, rectabel10);
            //resize_Control(label21, rectabel5);
            //resize_Control(label13, rectabel8);
            //resize_Control(label19, rectabel17);
            //resize_Control(label3, rectabel19);
            //resize_Control(label5, rectabel9);
            //resize_Control(label4, rectabel4);
            //resize_Control(label2, rectabel7);
            //resize_Control(label15, rectabel15);
            //resize_Control(label10, rectabel18);
            //resize_Control(label3, rectabel19);
            //resize_Control(label23, rectabel20);

        }
        private void resize_Control(System.Windows.Forms.Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }

        private bool button1clicked = false;
        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {

            if (button1clicked)
            {
                guna2Button1.Text = "Booking";
                guna2Button1.ForeColor = Color.White;
                guna2Button1.FillColor = Color.FromArgb(8, 102, 255);
                button1clicked = false;
            }
            else
            {
                guna2Button1.Text = "Booked";
                guna2Button1.ForeColor = Color.WhiteSmoke;
                guna2Button1.FillColor = Color.DarkGray;
                button1clicked = true;
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
            {
                connection.Open();
                int jumlahPoin = 10; 

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "insert into riwayat_tiket (id_akun, tiket_anak, tiket_dewasa, total_harga, tanggal_pemesanan) values (@id_akun, @tiket_anak, @tiket_dewasa, @total_harga, @tanggal_pemesanan)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_akun", user.id_user);
                cmd.Parameters.AddWithValue("@tiket_dewasa", tiket_dewasa);
                cmd.Parameters.AddWithValue("@tiket_anak", tiket_anak);
                cmd.Parameters.AddWithValue("@total_harga", harga);
                cmd.Parameters.AddWithValue("@tanggal_pemesanan", hari);
                int rowsaffected = cmd.ExecuteNonQuery();
                cmd.Dispose();

                if (rowsaffected > 0)
                {
                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE akun SET poin_akun = poin_akun + @jumlahPoin";
                        command.Parameters.AddWithValue("@jumlahPoin", jumlahPoin);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Pesanan berhasil dipesan");
                }
                else
                {
                    MessageBox.Show("Pesanan tidak berhasil dipesan");
                }

                connection.Close();
            }
        }
    


        public string promodigunakan { get; set; }


        private void buttonPromo_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(label14.Text, out int textBoxValue))
            {
                Promo form1 = new Promo(user);
                form1.label7value = textBoxValue; // Mengatur nilai properti LabelValue di Form promo
                form1.Show(); // Menampilkan Form2 sebagai dialog
                this.Hide(); // Menyembunyikan Form1
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(user);
            homepage.Show();
            this.Hide();
        }
    }
}
