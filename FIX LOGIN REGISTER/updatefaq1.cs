using FIX_LOGIN_REGISTER;
using Npgsql;
using System.Data;

namespace FIX_LOGIN_REGISTER
{
    public partial class updatefaq1 : Form
    {
        private Login.User user;
        public updatefaq1(Login.User user)
        {
            InitializeComponent();
            this.user = user;
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
            {
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select * from faq order by id_faq";
                NpgsqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                }
                comm.Dispose();
                conn.Close();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            updatefaq2 form2 = new updatefaq2(user);
            this.Hide();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(user);
            admin.Show();
            this.Hide();
        }
    }
}