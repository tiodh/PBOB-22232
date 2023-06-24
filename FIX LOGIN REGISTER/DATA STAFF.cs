using Guna.UI2.WinForms;
using Npgsql;
using STAFF_REVISI.isi;
using STAFF_REVISI.isi;
using System.Data;
using System.Numerics;
using System.Windows.Forms;

namespace STAFF_REVISI
{
    public partial class Form1 : Form
    {
        private CRUD crud;
        public Form1()
        {
            InitializeComponent();
            crud = new CRUD();
            show();
        }
        private void btninsert_Click(object sender, EventArgs e)
        {
            insert();
            if (string.IsNullOrWhiteSpace(tboxid.Text))
            {
                MessageBox.Show("Harap isi data lengkap.");
                return;
            }

            // Memeriksa apakah tboxnama kosong
            if (string.IsNullOrWhiteSpace(tboxnama.Text))
            {
                MessageBox.Show("Harap isi data lengkap");
                return;
            }

            // Memeriksa apakah tboxnohp kosong
            if (string.IsNullOrWhiteSpace(tboxnohp.Text))
            {
                MessageBox.Show("Harap isi data lengkap.");
                return;
            }

            // Lanjutkan proses penambahan data jika semua kotak teks telah diisi
            int id = 0;
            if (!int.TryParse(tboxid.Text, out id))
            {
                MessageBox.Show("Input ID tidak valid. Harap masukkan bilangan bulat.");
                return;
            }
            show();

        }

        private void insert()
        {
            int id = 0;
            if (!int.TryParse(tboxid.Text, out id))
            {
                // Penanganan kesalahan jika input id tidak valid
                MessageBox.Show("Harap isi data lengkap.");
                return; // Keluar dari metode btninsert_Click
            }

            string nama = tboxnama.Text;

            long hp = 0;
            if (!long.TryParse(tboxnohp.Text, out hp))
            {
                // Penanganan kesalahan jika input hp tidak valid
                MessageBox.Show("Harap isi data lengkap.");
                return; // Keluar dari metode btninsert_Click
            }

            Staff newstaff = new Staff()
            {
                id_staff = id.ToString(), // Mengonversi id ke string karena tipe data id_staff adalah string
                nama_staff = nama,
                no_hp = hp.ToString() // Mengonversi hp ke string karena tipe data no_hp adalah string
            };

            CRUD crud = new CRUD();
            bool isSuccess = crud.Insert(newstaff);

            if (isSuccess)
            {
                MessageBox.Show("Berhasil menambahkan data staff");
            }
            else
            {
                MessageBox.Show("Data staff gagal ditambahkan");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            update();
            if (string.IsNullOrWhiteSpace(tboxid.Text))
            {
                MessageBox.Show("Harap isi data lengkap.");
                return;
            }

            // Memeriksa apakah tboxnama kosong
            if (string.IsNullOrWhiteSpace(tboxnama.Text))
            {
                MessageBox.Show("Harap isi data lengkap.");
                return;
            }

            // Memeriksa apakah tboxnohp kosong
            if (string.IsNullOrWhiteSpace(tboxnohp.Text))
            {
                MessageBox.Show("Harap isi data lengkap.");
                return;
            }
            show();
        }

        private void update()
        {
            int id = 0;
            if (!int.TryParse(tboxid.Text, out id))
            {
                // Penanganan kesalahan jika input id tidak valid
                MessageBox.Show("Input ID tidak valid. Harap masukkan bilangan bulat.");
                return; // Keluar dari metode btnupdate_Click
            }

            string nama = tboxnama.Text;

            long hp = 0;
            if (!long.TryParse(tboxnohp.Text, out hp))
            {
                // Penanganan kesalahan jika input hp tidak valid
                MessageBox.Show("Input No. HP tidak valid. Harap masukkan angka.");
                return; // Keluar dari metode btnupdate_Click
            }

            Staff updatedStaff = new Staff()
            {
                id_staff = id.ToString(),
                nama_staff = nama,
                no_hp = hp.ToString()
            };

            CRUD crud = new CRUD();
            bool isSuccess = crud.Update(updatedStaff);

            if (isSuccess)
            {
                MessageBox.Show("Berhasil memperbarui data staff");
            }
            else
            {
                MessageBox.Show("Data staff gagal diperbarui");
            }
        }
        private void btnshow_Click(object sender, EventArgs e)
        {
            show();
        }
        private void show()
        {
            CRUD crud = new CRUD();
            crud.ClearListStaff();

            // Mengambil data dari tabel staff
            List<Staff> staffList = crud.GetStaffList();

            // Menampilkan data di dalam DataGridView atau kontrol tampilan lainnya
            guna2DataGridView1.DataSource = staffList;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tboxid.Text))
            {
                MessageBox.Show("Harap isi id yang ingin dihapus.");
                return;
            }

            string id_staff = tboxid.Text;

            CRUD crud = new CRUD();
            bool isSuccess = crud.Delete(id_staff);

            if (isSuccess)
            {
                MessageBox.Show("Data staff berhasil dihapus");
                show();
            }
            else
            {
                MessageBox.Show("Data staff gagal dihapus");
            }
        }

        private void tboxid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                tboxnama.Focus();
            }
        }

        private void tboxnama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                tboxnohp.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password=123"))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM staff WHERE nama_staff ILIKE @nama_staff";
                    cmd.Parameters.Add(new NpgsqlParameter("@nama_staff", "%" + tboxsearch.Text + "%"));

                    int rowCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (rowCount == 0)
                    {
                        MessageBox.Show("Data tidak ditemukan.");
                        guna2DataGridView1.DataSource = null;
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM staff WHERE nama_staff ILIKE @nama_staff";
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        guna2DataGridView1.DataSource = dt;
                    }

                    cmd.Dispose();
                    connection.Close();

                    tboxsearch.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void tboxsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                pictureBox1.Invoke(new Action(() => pictureBox1_Click(pictureBox1, EventArgs.Empty)));
            }
        }

        private void lblDATASTAFF_Click(object sender, EventArgs e)
        {

        }
    }
}
