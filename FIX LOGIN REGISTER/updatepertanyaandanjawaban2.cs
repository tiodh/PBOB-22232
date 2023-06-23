using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using static System.Collections.Specialized.BitVector32;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace updatepertanyaandanjawaban
{
    public partial class updatepertanyaandanjawaban2 : Form
    {
        public updatepertanyaandanjawaban2()
        {
            InitializeComponent();
        }

        private void PopulateComboBox()
        {
            if (int.TryParse(comboBox1.SelectedItem.ToString(), out int selectedId))
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5433; Database=Jecation; User Id=postgres; Password=adell1234"))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT pertanyaan_faq, jawaban_faq FROM faq WHERE id_faq = @id";
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.CommandType = CommandType.Text;

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string column1 = reader["pertanyaan_faq"].ToString();
                        string column2 = reader["jawaban_faq"].ToString();

                        textBox1.Text = column1;
                        textBox2.Text = column2;
                    }
                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }

        private void btnupdatefaq_Click(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox1.SelectedItem.ToString(), out int selectedId))
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5433; Database=Jecation; User Id=postgres; Password=adell1234");
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE faq SET pertanyaan_faq=@pf, jawaban_faq=@jf WHERE id_faq=@id";
                comm.CommandType = CommandType.Text;
                comm.Parameters.Add(new NpgsqlParameter("@id", selectedId));
                comm.Parameters.Add(new NpgsqlParameter("@pf", textBox1.Text));
                comm.Parameters.Add(new NpgsqlParameter("@jf", textBox2.Text));
                comm.ExecuteNonQuery();
                comm.Dispose();
                conn.Close();
                PopulateComboBox();
                MessageBox.Show("Data Berhasil di Update");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5433; Database=Jecation; User Id=postgres; Password=adell1234");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select id_faq from faq order by id_faq asc";
            NpgsqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["id_faq"].ToString());
            }
            reader.Close();
            comm.Dispose();
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
