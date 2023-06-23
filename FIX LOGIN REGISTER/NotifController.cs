using homepage_admin;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fixlahyah
{
    internal class NotifController
    {
        private HomepageAdmin view;
        private NotifikasiAdmin notifikasiAdmin;
        private KodePembayaran kodePembayaran;

        public NotifController(HomepageAdmin view)
        {
            this.view = view;
            this.notifikasiAdmin = new NotifikasiAdmin();
            this.kodePembayaran = new KodePembayaran();
        }

        public void BacaData()
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=fathinanisatuz01;Database=fix";
            string sql = "SELECT id_notifikasi_admin, a.username_akun, k.nama_kamar, jumlah_malam, jumlah_kamar, total_harga " +
                "FROM notifikasi_admin na " +
                "JOIN akun a ON (na.id_akun = a.id_akun) " +
                "JOIN kamar_penginapan k ON (na.id_kamar = k.id_kamar) " +
                "WHERE na.status = false " +
                "ORDER BY id_notifikasi_admin ASC " +
                "LIMIT 1";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        NpgsqlDataReader dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            notifikasiAdmin.Id = dr.GetInt32(0);
                            notifikasiAdmin.Username = dr.GetString(1);
                            notifikasiAdmin.NamaKamar = dr.GetString(2);
                            notifikasiAdmin.JumlahMalam = dr.GetInt32(3);
                            notifikasiAdmin.JumlahKamar = dr.GetInt32(4);
                            notifikasiAdmin.TotalHarga = dr.GetInt32(5);

                            view.updatelabel8($"Username            : {notifikasiAdmin.Username}\nNama Kamar       : {notifikasiAdmin.NamaKamar}\nJumlah Malam     : {notifikasiAdmin.JumlahMalam} Malam\nJumlah Kamar     : {notifikasiAdmin.JumlahKamar} Kamar\nTotal Harga         : {notifikasiAdmin.TotalHarga}");
                        }
                        else
                        {
                            view.updatelabel8("Tidak ada pemesanan");
                            view.ShowLabel12();
                            view.HideButton1();
                            view.HideButton2();
                            BacaNotif();
                        }
                        dr.Close();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        view.ShowErrorMessage("Error: " + ex.Message);
                    }
                }
            }
        }

        public void BacaNotif()
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=fathinanisatuz01;Database=fix";
            string sql = "SELECT id_kode_pembayaran, a.username_akun, k.kode_pembayaran " +
                         "FROM kode_pembayaran k " +
                         "JOIN notifikasi_user nu ON (nu.id_notifikasi_user = k.id_notifikasi_user) " +
                         "JOIN akun a ON (nu.id_akun = a.id_akun) " +
                         "WHERE k.status = false " +
                         "ORDER BY k.id_kode_pembayaran ASC " +
                         "LIMIT 1";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        NpgsqlDataReader dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            kodePembayaran.Id = dr.GetInt32(0);
                            kodePembayaran.Username = dr.GetString(1);
                            kodePembayaran.kodepembayaran = dr.GetInt32(2);

                            view.updatelabel12($"Username                : {kodePembayaran.Username,-20}\nKode Pembayaran : {kodePembayaran.kodepembayaran,-20}");

                        }
                        else
                        {
                            view.updatelabel12("");
                            view.HideButton3();
                            view.HideButton4();
                        }

                        dr.Close();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        view.ShowErrorMessage("Error: " + ex.Message);
                    }
                }
            }
        }

        
    }
}
