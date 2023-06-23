using Npgsql;
using System.Data;
using System.Data.Common;
using System.Text;
using Timer = System.Threading.Timer;

namespace PemberitahuanKonfirmasi
{
    public partial class Notifikasi1 : Form
    {
        private Size formOriginalSize;
        private Rectangle recpnl1;
        private Rectangle recpnl2;
        private Rectangle recpnlnt;
        private Rectangle reclbl1;
        private Rectangle reclbl2;
        private Rectangle reclbl3;
        private Rectangle reclbl4;
        private Rectangle reclbl5;
        private Rectangle recpnlout;
        public Notifikasi1()
        {
            InitializeComponent();
            //panelButtons = new Panel();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            recpnl1 = new Rectangle(panel1.Location, panel1.Size);
            recpnlnt = new Rectangle(PanelNotif.Location, PanelNotif.Size);
            recpnl2 = new Rectangle(panel2.Location, panel2.Size);
            reclbl1 = new Rectangle(label1.Location, label1.Size);
            reclbl2 = new Rectangle(label2.Location, label2.Size);
            reclbl3 = new Rectangle(label3.Location, label3.Size);
            reclbl4 = new Rectangle(label4.Location, label4.Size);
            reclbl5 = new Rectangle(label5.Location, label5.Size);
            recpnlout = new Rectangle(panelout.Location, panelout.Size);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BacaData();
            BacaNotif();
        }
        private void BacaData()
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=Ululps01;Database=Rembangan";
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
                        while (dr.Read())
                        {
                            if (dr.HasRows)
                            {
                                string rowdata = $"{dr.GetString(1)}\n{dr.GetString(2)}\n{dr.GetInt32(3)}\n{dr.GetInt32(4)}\n{dr.GetInt32(5)}";
                                selectedRowId = dr.GetInt32(0);
                                label15.Text = rowdata;
                            }
                            else
                            {
                                label15.Text = "Tidak ada pemesanan";
                            }
                            //label15_Click();
                        }
                        dr.Close();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void BacaNotif()
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=Ululps01;Database=Rembangan";
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
                        while (dr.Read())
                        {
                            if (dr.HasRows)
                            {
                                string rowdata = $"{dr.GetString(1)} \n {dr.GetInt32(2)}";
                                selectedRowId = dr.GetInt32(0);
                                label12.Text = rowdata;
                            }
                            else
                            {
                                label12.Text = "Tidak ada pemesanan";
                            }
                            //label15_Click();
                        }
                        dr.Close();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(panel1, recpnl1);
            resize_Control(PanelNotif, recpnlnt);
            resize_Control(panel2, recpnl2);
            resize_Control(label1, reclbl1);
            resize_Control(label2, reclbl2);
            resize_Control(label3, reclbl3);
            resize_Control(label4, reclbl4);
            resize_Control(label5, reclbl5);
            resize_Control(panelout, recpnlout);
        }
        private void resize_Control(Control c, Rectangle r)
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

        private bool notifikasi = false;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (notifikasi)
            {
                PanelNotif.Hide();
                notifikasi = false;
            }
            else
            {
                PanelNotif.Show();
                notifikasi = true;
            }


        }
        private void hidenotif()
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
        }
        private void Form1_TextChanged(object sender, EventArgs e)
        {
            float fontSize = (float)(Width + Height) / 100; // Sesuaikan rumus ini sesuai kebutuhan Anda

            // Atur ukuran font pada kontrol yang diinginkan
            label1.Font = new Font(label1.Font.FontFamily, fontSize, label1.Font.Style);
            //button1.Font = new Font(button1.Font.FontFamily, fontSize, button1.Font.Style);
        }
        private int selectedRowId = 0;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda akan mengkonfirmasi pesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=Ululps01;Database=Rembangan";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    //using (NpgsqlTransaction transaction = conn.BeginTransaction())
                    //{
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = conn;
                        //cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.Text;

                        // Update status menjadi "true" untuk row yang dipilih
                        string updateStatusQuery = "UPDATE notifikasi_admin SET status = true WHERE id_notifikasi_admin = @id";
                        cmd.CommandText = updateStatusQuery;
                        cmd.Parameters.AddWithValue("@id", selectedRowId);
                        //selectedRowId = GetInt32
                        cmd.ExecuteNonQuery();

                        // Insert dan Select
                        string insertQuery = "INSERT INTO notifikasi_user (id_akun, id_kamar, jumlah_kamar, jumlah_malam, total_harga) SELECT id_akun, id_kamar, jumlah_kamar, jumlah_malam, total_harga from notifikasi_admin";
                        cmd.CommandText = insertQuery;
                        cmd.ExecuteNonQuery();

                        // Hapus data dari database untuk row yang dipilih
                        string deleteQuery = "DELETE FROM notifikasi_admin WHERE id_notifikasi_admin = @id";
                        cmd.CommandText = deleteQuery;
                        cmd.Parameters.AddWithValue("@id", selectedRowId);
                        cmd.ExecuteNonQuery();

                        BacaData();
                    }

                    catch (Exception ex)
                    {
                        //transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    //}

                }
            }
        }

        private void PanelNotif_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool pictureprofil = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureprofil)
            {
                panelout.Hide();
                pictureprofil = false;
            }
            else
            {
                panelout.Show();
                Notifikasiformpopup profil = new Notifikasiformpopup();
                profil.TopLevel = false;
                profil.FormBorderStyle = FormBorderStyle.None;
                this.panelout.Controls.Add(profil);
                profil.Show();
                pictureprofil = true;
            }
            hidenotif();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda akan membatalkan pesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=Ululps01;Database=Rembangan";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    //using (NpgsqlTransaction transaction = conn.BeginTransaction())
                    //{
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = conn;
                        //cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.Text;

                        // Hapus data dari database untuk row yang dipilih
                        string deleteQuery = "DELETE FROM notifikasi_admin WHERE id_notifikasi_admin = @id";
                        cmd.CommandText = deleteQuery;
                        cmd.Parameters.AddWithValue("@id", selectedRowId);
                        cmd.ExecuteNonQuery();

                        //transaction.Commit();

                        // Hapus label dari panel


                        // Tampilkan data dari row selanjutnya
                        BacaData();
                    }
                    catch (Exception ex)
                    {
                        //transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    //}
                }
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            guna2Button1.Show();
            guna2Button2.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            guna2Button3.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda mengkonfirmasi kode pembayaran ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=Ululps01;Database=Rembangan";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    //using (NpgsqlTransaction transaction = conn.BeginTransaction())
                    //{
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = conn;
                        //cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.Text;

                        // Hapus data dari database untuk row yang dipilih
                        string deleteQuery = "DELETE FROM notifikasi_user WHERE id_notifikasi_user = @id";
                        cmd.CommandText = deleteQuery;
                        cmd.Parameters.AddWithValue("@id", selectedRowId);
                        cmd.ExecuteNonQuery();
                        BacaNotif();
                    }
                    catch (Exception ex)
                    {
                        //transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    
                }
            }
        }
    }
}