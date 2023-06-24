using KritikAdmin.Models;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace KritikAdmin
{
    public partial class KritikAdmin : Form
    {
        kritikContext isikonteks;
        public KritikAdmin()
        {
            InitializeComponent();
            isikonteks = new kritikContext();

            show();
            //try
            //{
            //    using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=jcation; User Id=postgres; Password=123"))
            //    {
            //        connection.Open();
            //        NpgsqlCommand cmd = new NpgsqlCommand();
            //        cmd.Connection = connection;
            //        cmd.CommandText = "select * from kritik_pengaduan";
            //        cmd.CommandType = CommandType.Text;
            //        cmd.ExecuteNonQuery();

            //        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();
            //        da.Fill(dt);
            //        cmd.Dispose();
            //        connection.Close();

            //        dataGridView1.DataSource = dt;

            //    }
            //}
            //catch { }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void show()
        {
            isikonteks.Read();
            List<kritik> kritiklist;
            kritiklist = isikonteks.kritiklist;

            dgv.Controls.Clear();

            foreach (var kritik in kritiklist)
            {
                int id_kritik = kritik.id_kritik;
                string kritikan = kritik.kritikan;
                DateTime tanggal = kritik.tanggal;
                int id_wisata = kritik.id_wisata;
                //int id_akun = kritik.id_akun;


            }

            bool isSuccess = isikonteks.Read();
            dgv.DataSource = kritiklist;
        }

    }
}