using Npgsql;
using System.Data;

namespace updatepertanyaandanjawaban
{
    public partial class updatepertanyaandanjawaban1 : Form
    {
        public updatepertanyaandanjawaban1()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5433; Database=Jecation; User Id=postgres; Password=adell1234");
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

        private void btnedit_Click(object sender, EventArgs e)
        {
            updatepertanyaandanjawaban2 form2 = new updatepertanyaandanjawaban2();
            this.Hide();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}