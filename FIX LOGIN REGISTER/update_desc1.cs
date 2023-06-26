using System.Data;
using Npgsql;

namespace FIX_LOGIN_REGISTER
{
    public partial class update_desc1 : Form
    {
        private Login.User user;

        public update_desc1(Login.User user)
        {
            InitializeComponent();
            this.user = user;
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password=");
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tempat_wisata";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            cmd.Dispose();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_desc2 form = new update_desc2(user);
            this.Hide();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(user);
            admin.Show();
            this.Hide();
        }
    }
}