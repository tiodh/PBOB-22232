using Npgsql;
using Promo_Pemesanan;
using System;
using System.Data;
using System.Windows.Forms;
using static Book_ticket.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Book_ticket
{
    public partial class Form1 : Form
    {
        private Controller booking;
        public Form1()
        {
            InitializeComponent();
            booking = new Controller();
        }
        private void pesan_Click(object sender, EventArgs e)
        {
            string userName = namaValue();
            string adultCount = dwsValue();
            string childCount = ankValue();
            string bookingDate = tglValue();
            string totalPrice = hargaValue();

            booking.Pesan(userName, adultCount, childCount, bookingDate, totalPrice);

            if (int.TryParse(jml_pengunjung.Text, out int textBoxValue))    // menginisialisasi nilai textboxt jml_pengunjung.text menjadi textboxvalue, mengubah nilai yang diinputkan pada textboxt jml_pengunjung menjadi integer
            {
                Promo form1 = new Promo();
                form1.tiketdipesan = textBoxValue; // Mengirim nilai tiket yang dipesan dari label jml_pengunjung di Form promo 
                form1.ShowDialog(); // Menampilkan form promo sebagai dialog
                this.Hide(); // Menyembunyikan form booktiket
            }
        }

        public string namaValue()
        {
            return nama.Text;
        }
        public string dwsValue()
        {
            return jml_pengunjung.Text;
        }
        public string ankValue()
        {
            return pengunjung_ank.Text;
        }
        public string tglValue()
        {
            return tgl_kunjungan.Text;
        }
        public string hargaValue()
        {
            return harga.Text;
        }
    }
}

