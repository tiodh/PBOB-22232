using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using static Book_ticket.Controller;

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

