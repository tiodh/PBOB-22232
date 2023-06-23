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
        private Form1 view;
        private NotifikasiAdmin notifikasiAdmin;
        private KodePembayaran kodePembayaran;

        public NotifController(Form1 view)
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

                            view.UpdateLabel15($"Username            : {notifikasiAdmin.Username}\nNama Kamar       : {notifikasiAdmin.NamaKamar}\nJumlah Malam     : {notifikasiAdmin.JumlahMalam} Malam\nJumlah Kamar     : {notifikasiAdmin.JumlahKamar} Kamar\nTotal Harga         : {notifikasiAdmin.TotalHarga}");
                        }
                        else
                        {
                            view.UpdateLabel15("Tidak ada pemesanan");
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

                            view.UpdateLabel12($"Username                : {kodePembayaran.Username,-20}\nKode Pembayaran : {kodePembayaran.kodepembayaran,-20}");

                        }
                        else
                        {
                            view.UpdateLabel12("");
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

        public void KonfirmasiPesanan()
        {
            DialogResult result = view.ShowConfirmationDialog("Apakah Anda akan mengkonfirmasi pesanan ini?", "Konfirmasi");
            if (result == DialogResult.Yes)
            {
                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=fathinanisatuz01;Database=fix";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;

                        // Update status menjadi "true" untuk row yang dipilih
                        string updateStatusQuery = "UPDATE notifikasi_admin SET status = true WHERE id_notifikasi_admin = @id; INSERT INTO notifikasi_user (id_akun, id_kamar, jumlah_kamar, jumlah_malam, total_harga) SELECT id_akun, id_kamar, jumlah_kamar, jumlah_malam, total_harga from notifikasi_admin WHERE id_notifikasi_admin = @id";
                        cmd.CommandText = updateStatusQuery;
                        cmd.Parameters.AddWithValue("@id", notifikasiAdmin.Id);
                        cmd.ExecuteNonQuery();

                        BacaData();
                    }
                    catch (Exception ex)
                    {
                        view.ShowErrorMessage("Error: " + ex.Message);
                    }
                    conn.Close();
                }
            }
        }

        public void DeletePesanan()
        {
            DialogResult result = view.ShowConfirmationDialog("Apakah Anda Akan Membatalkan Pesanan Ini?", "Pembatalan");
            if (result == DialogResult.Yes)
            {
                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=fathinanisatuz01;Database=fix";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;

                        // Delete
                        string DeleteQuery = "DELETE FROM notifikasi_admin WHERE status = false AND id_notifikasi_admin = @id";
                        cmd.CommandText = DeleteQuery;
                        cmd.Parameters.AddWithValue("@id", notifikasiAdmin.Id);
                        cmd.ExecuteNonQuery();

                        BacaData();
                    }
                    catch (Exception ex)
                    {
                        view.ShowErrorMessage("Error: " + ex.Message);
                    }
                    conn.Close();
                }
            }
        }

        public void KonfirmasiKodePembayaran()
        {
            DialogResult result = view.ShowConfirmationDialog("Apakah Anda Akan Mengkonfirmasi Pesanan Ini?", "Konfirmasi");
            if (result == DialogResult.Yes)
            {
                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=fathinanisatuz01;Database=fix";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;

                        // Update status menjadi "true" untuk row yang dipilih
                        string updateStatusQuery = "UPDATE kode_pembayaran SET status = true WHERE id_kode_pembayaran = @id";
                        cmd.CommandText = updateStatusQuery;
                        cmd.Parameters.AddWithValue("@id", kodePembayaran.Id);
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        view.ShowErrorMessage("Error: " + ex.Message);
                    }
                    BacaNotif();
                    conn.Close();
                }
            }
        }

        public void DeleteKodePembayaran()
        {
            DialogResult result = view.ShowConfirmationDialog("Apakah Anda Akan Menghapus Pesanan Ini?", "Pembatalan");
            if (result == DialogResult.Yes)
            {
                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=fathinanisatuz01;Database=fix";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;

                        // Delete Kode Pembayaran
                        string updateStatusQuery = "DELETE FROM kode_pembayaran WHERE status = false AND id_kode_pembayaran = @id";
                        cmd.CommandText = updateStatusQuery;
                        cmd.Parameters.AddWithValue("@id", kodePembayaran.Id);
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        view.ShowErrorMessage("Error: " + ex.Message);
                    }
                    BacaNotif();
                    conn.Close();
                }
            }
        }
    }
}
