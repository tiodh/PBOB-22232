using Book_ticket;
using Org.BouncyCastle.Asn1.IsisMtt.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_ticket
{
    public class Pesan
    {
        private string nama = string.Empty;
        private string pengunjung_dws = string.Empty;
        private string pengunjung_ank = string.Empty;
        private string tgl_booking = string.Empty;
        private string harga = string.Empty;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Pengunjung_dws
        {
            get { return pengunjung_dws; }
            set { pengunjung_dws = value; }
        }

        public string Pengunjung_ank
        {
            get { return pengunjung_ank; }
            set { pengunjung_ank = value; }
        }

        public string Tgl_booking
        {
            get { return tgl_booking; }
            set { tgl_booking = value; }
        }

        public string Harga
        {
            get { return harga; }
            set { harga = value; }
        }
    }
}


