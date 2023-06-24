using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace Point
{
    public partial class Poin : Form
    {
        private const string ConnectionString = "Host=localhost;Port=5432;Database=poin_jecation;Username=postgres;Password=password";


        private int number1 = 0;
        private int number2 = 0;
        public Poin()
        {

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var connection = new NpgsqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Menjalankan query untuk mendapatkan data dari tabel
                    string query = "SELECT poin_akun FROM akun LIMIT 1";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Mendapatkan nilai kolom pertama dari baris pertama
                                string value = reader.GetString(0);

                                // Menampilkan nilai di Label
                                label8.Text = value;
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateLabels()
        {
            label8.Text = number1.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(label8.Text);
            number2 = int.Parse(label9.Text);
            int result = number1 - number2;
            label8.Text = result.ToString();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(label8.Text);
            number2 = int.Parse(label21.Text);
            int result = number1 - number2;
            label8.Text = result.ToString();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(label8.Text);
            number2 = int.Parse(label17.Text);
            int result = number1 - number2;
            label8.Text = result.ToString();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(label8.Text);
            number2 = int.Parse(label33.Text);
            int result = number1 - number2;
            label8.Text = result.ToString();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(label8.Text);
            number2 = int.Parse(label25.Text);
            int result = number1 - number2;
            label8.Text = result.ToString();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(label8.Text);
            number2 = int.Parse(label29.Text);
            int result = number1 - number2;
            label8.Text = result.ToString();
        }
    }
}
