using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket
{
    public partial class melati_III : Form
    {
        public melati_III()
        {
            InitializeComponent();
        }

        private void Lb_close_MouseUp(object sender, MouseEventArgs e)
        {
            //Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\efek close2.png");
        }

        private void Lb_close_MouseDown(object sender, MouseEventArgs e)
        {
            //Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\efek close1.png");
        }

        int i;
        private void melati_III_Load(object sender, EventArgs e)
        {
            i = list_melati.parentY + 150;
            this.Location = new Point(list_melati.parentX + 220, list_melati.parentY + 150);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(list_melati.parentX + 220, list_melati.parentY + 150);
            this.StartPosition = FormStartPosition.CenterScreen;

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=123; Database=final"))
            {
                conn.Open();
                using NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT nama_fasilitas_kamar FROM fasilitas_kamar where id_kamar = 5 ORDER BY id_fasilitas_kamar ASC";
                cmd.CommandType = CommandType.Text;
                NpgsqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int labelIndex = 1; // Indeks Label pertama

                    do
                    {
                        string kolomValue = reader.GetString(0); // Ubah indeks sesuai dengan posisi kolom pada SELECT

                        // Cari Label berdasarkan indeks
                        Label label = this.Controls.Find("fasilitas" + labelIndex, true).FirstOrDefault() as Label;

                        if (label != null)
                        {
                            // Set nilai data pada Label
                            label.Text = kolomValue;
                        }

                        // Tingkatkan indeks Label untuk baris berikutnya
                        labelIndex++;
                    }
                    while (reader.Read());
                }
                reader.Close();
                conn.Close();
            }
        }

        private void Lb_close_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            //Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\X.png");
        }

        private void Lb_close_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            //Lb_close.Image = Image.FromFile("D:\\KULIAH\\SEMESTER 2\\PBO\\projek\\icon\\button back.png");
        }

        private void Lb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void effectDetail_melati_III_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                effectDetail_melati_III.Stop();
            }
            else
            {
                Opacity += .03;
            }

            int y = list_melati.parentY += 3; //INCREMENT
            this.Location = new Point(list_melati.parentX + 220, y);
            if (y >= i)
            {
                effectDetail_melati_III.Stop();
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lb_title_Click(object sender, EventArgs e)
        {

        }
    }
}
