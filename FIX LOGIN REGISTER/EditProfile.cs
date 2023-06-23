using Npgsql;
using System.Data;
using System.Drawing;
using System.Windows.Forms;



namespace EditProfile
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                {
                    EditButton.BackColor = Color.Blue;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
        }

        private void background_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Provinsi_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Database_Jecation; User Id=postgres; Password=Ululps01"))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT name FROM reg_province";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataReader reader = cmd.ExecuteReader();

                // Membaca data dari reader dan menambahkannya ke ComboBox
                while (reader.Read())
                {
                    Provinsi.Items.Add(reader["name"].ToString());
                }

                reader.Close();
                cmd.Dispose();
                connection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Database_Jecation; User Id=postgres; Password=Ululps01"))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT name FROM reg_province";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataReader reader = cmd.ExecuteReader();

                // Membaca data dari reader dan menambahkannya ke ComboBox
                while (reader.Read())
                {
                    Provinsi.Items.Add(reader["name"].ToString());
                }

                reader.Close();
                cmd.Dispose();
                connection.Close();
            }
        }

        private void Provinsi_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}