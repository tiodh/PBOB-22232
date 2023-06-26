using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace FIX_LOGIN_REGISTER
{
    public partial class KritikAdmin : Form
    {
        private Login.User user;
        public KritikAdmin(Login.User user)
        {
            InitializeComponent();
            this.user = user;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password=123"))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "select * from kritik_pengaduan";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();
                    connection.Close();

                    dataGridView1.DataSource = dt;

                }
            }
            catch { }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {
            update_desc1 update = new update_desc1(user);
            update.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            updatefaq1 update = new updatefaq1(user);
            update.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(user);
            admin.Show();
            this.Hide();
        }
    }
}