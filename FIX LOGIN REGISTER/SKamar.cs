using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Reflection.Emit;
using Npgsql;
namespace FIX_LOGIN_REGISTER
{
    public partial class SKamar : Form
    {
        private Login.User user;
        private Size formOriginalSize;
        private Rectangle recpanel1;
        private Rectangle recpanel6;
        private Rectangle recpanel13;
        private Rectangle recbutton5;
        private Rectangle reccomboBox9;
        private Rectangle reccomboBox10;
        private Rectangle reclabel14;
        private Rectangle reclabel15;
        private Rectangle reclabel16;
        private Rectangle recpanel5;
        private Rectangle recbutton4;
        private Rectangle reccomboBox7;
        private Rectangle reccomboBox8;
        private Rectangle reclabel11;
        private Rectangle reclabel12;
        private Rectangle reclabel13;
        private Rectangle recpanel4;
        private Rectangle recbutton3;
        private Rectangle reccombobox5;
        private Rectangle reccombobox6;
        private Rectangle reclabel8;
        private Rectangle reclabel9;
        private Rectangle reclabel10;
        private Rectangle recpanel3;
        private Rectangle recbutton2;
        private Rectangle reccomboBox3;
        private Rectangle reccombobox4;
        private Rectangle reclabel5;
        private Rectangle reclabel6;
        private Rectangle reclabel7;
        private Rectangle reclabel1;
        private Rectangle recbutton1;
        private Rectangle reccombobox2;
        private Rectangle reccomboBox1;
        private Rectangle reclabel4;
        private Rectangle reclabel3;
        private Rectangle reclabel2;
        private Rectangle recpictureBox3;
        private Rectangle recpicturebox2;
        private Rectangle recpicturebox1;
        private Rectangle recpanel12;
        private Rectangle recbuton122;
        private Rectangle reccombobox23;
        private Rectangle reccomboBox24;
        private Rectangle reclabel35;
        private Rectangle reclabe26;
        private Rectangle reclabel37;
        private Rectangle reclabel32;
        private Rectangle recbutton11;
        private Rectangle reccombobox21;
        private Rectangle reccombobox22;
        private Rectangle reclabel33;
        private Rectangle reclabel34;
        private Rectangle recbuttlabel;
        private Rectangle recpanel11;
        private Rectangle recbutton10;
        private Rectangle reccombobox19;
        private Rectangle reccombobox20;
        private Rectangle reclabel29;
        private Rectangle reclabel30;
        private Rectangle reclabel311;
        private Rectangle recpanel8;
        private Rectangle recpanel9;
        private Rectangle recpanel10;
        private Rectangle recbutton9;
        private Rectangle reccombobox17;
        private Rectangle reccombobox18;
        private Rectangle reclabel26;
        private Rectangle reclabel27;
        private Rectangle reclabel28;
        private Rectangle recbutton8;
        private Rectangle reccombobox15;
        private Rectangle reccombobox16;
        private Rectangle reclabel23;
        private Rectangle reclabel24;
        private Rectangle reclabel25;
        private Rectangle recbutton7;
        private Rectangle reccombobox13;
        private Rectangle reccombobox14;
        private Rectangle reclabel20;
        private Rectangle reclabel21;
        private Rectangle reclabel22;
        private Rectangle recpanel7;
        private Rectangle recbutton6;
        private Rectangle reccombobox11;
        private Rectangle reccombobox12;
        private Rectangle reclabel17;
        private Rectangle reclabel18;
        private Rectangle reclabel19;
        private Rectangle recpanel2;
        public SKamar(Login.User user)
        {
            InitializeComponent();
            this.user = user;
            this.Resize += SKamar_Resize;
            formOriginalSize = this.Size;
            recpanel1 = new Rectangle(panel1.Location, panel1.Size);
            //recpanel14 = new Rectangle(panel14.Location, panel14.Size);
            recbutton1 = new Rectangle(button1.Location, button1.Size);
            recbutton10 = new Rectangle(button10.Location, button10.Size);
            recbutton11 = new Rectangle(button11.Location, button11.Size);
            recbutton2 = new Rectangle(button2.Location, button2.Size);
            recbutton3 = new Rectangle(button3.Location, button3.Size);
            recbutton4 = new Rectangle(button4.Location, button4.Size);
            recbutton5 = new Rectangle(button5.Location, button5.Size);
            recbutton6 = new Rectangle(button6.Location, button6.Size);
            recbutton7 = new Rectangle(button7.Location, button7.Size);
            recbutton8 = new Rectangle(button8.Location, button8.Size);
            recbutton9 = new Rectangle(button9.Location, button9.Size);
            reccomboBox1 = new Rectangle(comboBox1.Location, comboBox1.Size);
            reccomboBox10 = new Rectangle(comboBox10.Location, comboBox10.Size);
            reccombobox11 = new Rectangle(comboBox11.Location, comboBox11.Size);
            reccombobox12 = new Rectangle(comboBox12.Location, comboBox12.Size);
            reccombobox13 = new Rectangle(comboBox13.Location, comboBox13.Size);
            reccombobox14 = new Rectangle(comboBox14.Location, comboBox14.Size);
            reccombobox15 = new Rectangle(comboBox15.Location, comboBox15.Size);
            reccombobox16 = new Rectangle(comboBox16.Location, comboBox16.Size);
            reccombobox17 = new Rectangle(comboBox17.Location, comboBox17.Size);
            reccombobox18 = new Rectangle(comboBox18.Location, comboBox18.Size);
            reccombobox19 = new Rectangle(comboBox19.Location, comboBox19.Size);
            reccombobox20 = new Rectangle(comboBox20.Location, comboBox20.Size);
            reccombobox21 = new Rectangle(comboBox21.Location, comboBox21.Size);
            reccombobox22 = new Rectangle(comboBox22.Location, comboBox22.Size);
            reccombobox23 = new Rectangle(comboBox23.Location, comboBox23.Size);
            reccombobox2 = new Rectangle(comboBox2.Location, comboBox2.Size);
            reccomboBox3 = new Rectangle(comboBox3.Location, comboBox3.Size);
            reccombobox4 = new Rectangle(comboBox4.Location, comboBox4.Size);
            reccombobox5 = new Rectangle(comboBox5.Location, comboBox5.Size);
            reccombobox6 = new Rectangle(comboBox6.Location, comboBox6.Size);
            reccomboBox7 = new Rectangle(comboBox7.Location, comboBox7.Size);
            reccomboBox8 = new Rectangle(comboBox8.Location, comboBox8.Size);
            reccomboBox9 = new Rectangle(comboBox9.Location, comboBox9.Size);
            reclabel1 = new Rectangle(label1.Location, label1.Size);
            reclabel10 = new Rectangle(label10.Location, label10.Size);
            reclabel11 = new Rectangle(label11.Location, label11.Size);
            reclabel12 = new Rectangle(label12.Location, label12.Size);
            reclabel13 = new Rectangle(label13.Location, label13.Size);
            reclabel14 = new Rectangle(label14.Location, label14.Size);
            reclabel15 = new Rectangle(label15.Location, label15.Size);
            reclabel2 = new Rectangle(label2.Location, label2.Size);
            reclabel3 = new Rectangle(label3.Location, label3.Size);
            reclabel4 = new Rectangle(label4.Location, label4.Size);
            reclabel5 = new Rectangle(label5.Location, label5.Size);
            reclabel6 = new Rectangle(label6.Location, label6.Size);
            reclabel7 = new Rectangle(label7.Location, label7.Size);
            reclabel8 = new Rectangle(label8.Location, label8.Size);
            reclabel9 = new Rectangle(label9.Location, label9.Size);
            recpanel1 = new Rectangle(panel1.Location, panel1.Size);
            recpanel10 = new Rectangle(panel10.Location, panel10.Size);
            recpanel11 = new Rectangle(panel11.Location, panel11.Size);
            recpanel12 = new Rectangle(panel12.Location, panel12.Size);
            recpanel13 = new Rectangle(panel13.Location, panel13.Size);
            recpanel2 = new Rectangle(panel2.Location, panel2.Size);
            recpanel3 = new Rectangle(panel3.Location, panel3.Size);
            recpanel4 = new Rectangle(panel4.Location, panel4.Size);
            recpanel5 = new Rectangle(panel5.Location, panel5.Size);
            recpanel6 = new Rectangle(panel6.Location, panel6.Size);
            recpanel7 = new Rectangle(panel7.Location, panel7.Size);
            recpanel8 = new Rectangle(panel8.Location, panel8.Size);
            recpanel9 = new Rectangle(panel9.Location, panel9.Size);
            recpicturebox1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recpicturebox2 = new Rectangle(pictureBox2.Location, pictureBox2.Size);
            recpictureBox3 = new Rectangle(pictureBox3.Location, pictureBox3.Size);



        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SKamar_Resize(object sender, EventArgs e)
        {

            resize_Control(panel1, recpanel1);
            resize_Control(panel2, recpanel2);
            resize_Control(panel3, recpanel3);
            resize_Control(panel4, recpanel4);
            resize_Control(panel5, recpanel5);
            resize_Control(panel6, recpanel6);
            resize_Control(panel7, recpanel7);
            resize_Control(panel8, recpanel8);
            resize_Control(panel9, recpanel9);
            resize_Control(panel10, recpanel10);
            resize_Control(panel11, recpanel11);
            resize_Control(panel12, recpanel12);
            resize_Control(panel13, recpanel13);
            resize_Control(button1, recbutton1);
            resize_Control(button2, recbutton2);
            resize_Control(button3, recbutton3);
            resize_Control(button4, recbutton4);
            resize_Control(button5, recbutton5);
            resize_Control(button6, recbutton6);
            resize_Control(button7, recbutton7);
            resize_Control(button8, recbutton8);
            resize_Control(button9, recbutton9);
            resize_Control(button10, recbutton10);
            resize_Control(button11, recbutton11);
            resize_Control(label1, reclabel1);
            resize_Control(label2, reclabel2);
            resize_Control(label3, reclabel3);
            resize_Control(label4, reclabel4);
            resize_Control(label5, reclabel5);
            resize_Control(label6, reclabel6);
            resize_Control(label7, reclabel7);
            resize_Control(label8, reclabel8);
            resize_Control(label9, reclabel9);
            resize_Control(label10, reclabel10);
            resize_Control(label11, reclabel11);
            resize_Control(label12, reclabel12);
            resize_Control(label13, reclabel13);
            resize_Control(label14, reclabel14);
            resize_Control(label15, reclabel15);
            resize_Control(comboBox1, reccomboBox1);
            resize_Control(comboBox2, reccombobox2);
            resize_Control(comboBox3, reccomboBox3);
            resize_Control(comboBox4, reccombobox4);
            resize_Control(comboBox4, reccombobox4);
            resize_Control(comboBox6, reccombobox6);
            resize_Control(comboBox7, reccomboBox7);
            resize_Control(comboBox8, reccomboBox8);
            resize_Control(comboBox9, reccomboBox9);
            resize_Control(comboBox10, reccomboBox10);
            resize_Control(comboBox11, reccombobox11);
            resize_Control(comboBox12, reccombobox12);
            resize_Control(comboBox13, reccombobox13);
            resize_Control(comboBox14, reccombobox14);
            resize_Control(comboBox15, reccombobox15);
            resize_Control(comboBox16, reccombobox16);
            resize_Control(comboBox17, reccombobox17);
            resize_Control(comboBox18, reccombobox18);
            resize_Control(comboBox19, reccombobox19);
            resize_Control(comboBox20, reccombobox20);
            resize_Control(comboBox21, reccombobox21);
            resize_Control(comboBox22, reccombobox22);
            resize_Control(comboBox23, reccombobox23);
            resize_Control(comboBox5, reccombobox5);
            resize_Control(pictureBox1, recpicturebox1);
            resize_Control(pictureBox2, recpicturebox2);
            resize_Control(pictureBox3, recpictureBox3);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void SKamar_Load(object sender, EventArgs e)
        {
            try
            {
                int id10 = 10;
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT nomor_kamar FROM detail_kamar WHERE id_kamar =  @id order by nomor_kamar asc";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id10);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    // Mengosongkan items pada ComboBox1 sebelum menambahkan data baru
                    comboBox24.Items.Clear();

                    // Membaca baris per baris dari hasil query
                    while (reader.Read())
                    {
                        // Mendapatkan nilai kolom nomor_kamar
                        string nomorKamar = reader["nomor_kamar"].ToString();

                        // Menambahkan nomor_kamar ke ComboBox1
                        comboBox24.Items.Add(nomorKamar);
                    }

                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
            try
            {
                int id9 = 9;
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT nomor_kamar FROM detail_kamar WHERE id_kamar =  @id order by nomor_kamar asc";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id9);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    // Mengosongkan items pada ComboBox1 sebelum menambahkan data baru
                    comboBox22.Items.Clear();

                    // Membaca baris per baris dari hasil query
                    while (reader.Read())
                    {
                        // Mendapatkan nilai kolom nomor_kamar
                        string nomorKamar = reader["nomor_kamar"].ToString();

                        // Menambahkan nomor_kamar ke ComboBox1
                        comboBox22.Items.Add(nomorKamar);
                    }

                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
            try
            {
                int id8 = 8;
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT nomor_kamar FROM detail_kamar WHERE id_kamar =  @id order by nomor_kamar asc";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id8);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    // Mengosongkan items pada ComboBox1 sebelum menambahkan data baru
                    comboBox18.Items.Clear();

                    // Membaca baris per baris dari hasil query
                    while (reader.Read())
                    {
                        // Mendapatkan nilai kolom nomor_kamar
                        string nomorKamar = reader["nomor_kamar"].ToString();

                        // Menambahkan nomor_kamar ke ComboBox1
                        comboBox18.Items.Add(nomorKamar);
                    }

                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
            try
            {
                int id7 = 7;
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT nomor_kamar FROM detail_kamar WHERE id_kamar =  @id order by nomor_kamar asc";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id7);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    // Mengosongkan items pada ComboBox1 sebelum menambahkan data baru
                    comboBox20.Items.Clear();

                    // Membaca baris per baris dari hasil query
                    while (reader.Read())
                    {
                        // Mendapatkan nilai kolom nomor_kamar
                        string nomorKamar = reader["nomor_kamar"].ToString();

                        // Menambahkan nomor_kamar ke ComboBox1
                        comboBox20.Items.Add(nomorKamar);
                    }

                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
            try
            {
                int id6 = 6;
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT nomor_kamar FROM detail_kamar WHERE id_kamar =  @id order by nomor_kamar asc";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id6);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    // Mengosongkan items pada ComboBox1 sebelum menambahkan data baru
                    comboBox12.Items.Clear();

                    // Membaca baris per baris dari hasil query
                    while (reader.Read())
                    {
                        // Mendapatkan nilai kolom nomor_kamar
                        string nomorKamar = reader["nomor_kamar"].ToString();

                        // Menambahkan nomor_kamar ke ComboBox1
                        comboBox12.Items.Add(nomorKamar);
                    }

                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }

            try
            {
                int id5 = 5;
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT nomor_kamar FROM detail_kamar WHERE id_kamar =  @id order by nomor_kamar asc";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id5);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    // Mengosongkan items pada ComboBox1 sebelum menambahkan data baru
                    comboBox10.Items.Clear();

                    // Membaca baris per baris dari hasil query
                    while (reader.Read())
                    {
                        // Mendapatkan nilai kolom nomor_kamar
                        string nomorKamar = reader["nomor_kamar"].ToString();

                        // Menambahkan nomor_kamar ke ComboBox1
                        comboBox10.Items.Add(nomorKamar);
                    }

                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }

            try
            {
                int id4 = 4;
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT nomor_kamar FROM detail_kamar WHERE id_kamar =  @id order by nomor_kamar asc";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id4);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    // Mengosongkan items pada ComboBox1 sebelum menambahkan data baru
                    comboBox8.Items.Clear();

                    // Membaca baris per baris dari hasil query
                    while (reader.Read())
                    {
                        // Mendapatkan nilai kolom nomor_kamar
                        string nomorKamar = reader["nomor_kamar"].ToString();

                        // Menambahkan nomor_kamar ke ComboBox1
                        comboBox8.Items.Add(nomorKamar);
                    }

                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }

            try
            {
                int id3 = 3;
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT nomor_kamar FROM detail_kamar WHERE id_kamar =  @id order by nomor_kamar asc";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id3);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    // Mengosongkan items pada ComboBox1 sebelum menambahkan data baru
                    comboBox6.Items.Clear();

                    // Membaca baris per baris dari hasil query
                    while (reader.Read())
                    {
                        // Mendapatkan nilai kolom nomor_kamar
                        string nomorKamar = reader["nomor_kamar"].ToString();

                        // Menambahkan nomor_kamar ke ComboBox1
                        comboBox6.Items.Add(nomorKamar);
                    }

                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }

            try
            {
                int id2 = 2;
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT nomor_kamar FROM detail_kamar WHERE id_kamar =  @id order by nomor_kamar asc";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id2);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    // Mengosongkan items pada ComboBox1 sebelum menambahkan data baru
                    comboBox4.Items.Clear();

                    // Membaca baris per baris dari hasil query
                    while (reader.Read())
                    {
                        // Mendapatkan nilai kolom nomor_kamar
                        string nomorKamar = reader["nomor_kamar"].ToString();

                        // Menambahkan nomor_kamar ke ComboBox1
                        comboBox4.Items.Add(nomorKamar);
                    }

                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
            try
            {
                int id1 = 1;
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT nomor_kamar FROM detail_kamar WHERE id_kamar =  @id order by nomor_kamar asc ";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id1);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    // Mengosongkan items pada ComboBox1 sebelum menambahkan data baru
                    comboBox1.Items.Clear();

                    // Membaca baris per baris dari hasil query
                    while (reader.Read())
                    {
                        // Mendapatkan nilai kolom nomor_kamar
                        string nomorKamar = reader["nomor_kamar"].ToString();

                        // Menambahkan nomor_kamar ke ComboBox1
                        comboBox1.Items.Add(nomorKamar);
                    }

                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }

            comboBox2.Items.Add("Aktif");
            comboBox2.Items.Add("Non-Aktif");
            comboBox3.Items.Add("Aktif");
            comboBox3.Items.Add("Non-Aktif");
            comboBox5.Items.Add("Aktif");
            comboBox5.Items.Add("Non-Aktif");
            comboBox7.Items.Add("Aktif");
            comboBox7.Items.Add("Non-Aktif");
            comboBox9.Items.Add("Aktif");
            comboBox9.Items.Add("Non-Aktif");
            comboBox11.Items.Add("Aktif");
            comboBox11.Items.Add("Non-Aktif");
            comboBox17.Items.Add("Aktif");
            comboBox17.Items.Add("Non-Aktif");
            comboBox19.Items.Add("Aktif");
            comboBox19.Items.Add("Non-Aktif");
            comboBox21.Items.Add("Aktif");
            comboBox21.Items.Add("Non-Aktif");
            comboBox23.Items.Add("Aktif");
            comboBox23.Items.Add("Non-Aktif");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 1;
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                string nomorKamar = comboBox1.SelectedItem.ToString();
                bool statusKamar = comboBox2.SelectedItem.ToString() == "Non-Aktif" ? false : true;

                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE detail_kamar SET status_kamar = @status WHERE nomor_kamar = @nomor and id_kamar = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@status", statusKamar);
                    cmd.Parameters.AddWithValue("@nomor", nomorKamar);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status kamar berhasil diperbarui.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status kamar.");
                    }

                    cmd.Dispose();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih nomor kamar dan status yang ingin diperbarui.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = 2;
            if (comboBox4.SelectedItem != null && comboBox3.SelectedItem != null)
            {
                string nomorKamar = comboBox4.SelectedItem.ToString();
                bool statusKamar = comboBox3.SelectedItem.ToString() == "Non-Aktif" ? false : true;

                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE detail_kamar SET status_kamar = @status WHERE nomor_kamar = @nomor and id_kamar = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@status", statusKamar);
                    cmd.Parameters.AddWithValue("@nomor", nomorKamar);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status kamar berhasil diperbarui.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status kamar.");
                    }

                    cmd.Dispose();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih nomor kamar dan status yang ingin diperbarui.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = 3;
            if (comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
            {
                string nomorKamar = comboBox6.SelectedItem.ToString();
                bool statusKamar = comboBox5.SelectedItem.ToString() == "Non-Aktif" ? false : true;

                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE detail_kamar SET status_kamar = @status WHERE nomor_kamar = @nomor and id_kamar = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@status", statusKamar);
                    cmd.Parameters.AddWithValue("@nomor", nomorKamar);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status kamar berhasil diperbarui.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status kamar.");
                    }

                    cmd.Dispose();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih nomor kamar dan status yang ingin diperbarui.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = 4;
            if (comboBox7.SelectedItem != null && comboBox8.SelectedItem != null)
            {
                string nomorKamar = comboBox8.SelectedItem.ToString();
                bool statusKamar = comboBox7.SelectedItem.ToString() == "Non-Aktif" ? false : true;

                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE detail_kamar SET status_kamar = @status WHERE nomor_kamar = @nomor and id_kamar = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@status", statusKamar);
                    cmd.Parameters.AddWithValue("@nomor", nomorKamar);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status kamar berhasil diperbarui.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status kamar.");
                    }

                    cmd.Dispose();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih nomor kamar dan status yang ingin diperbarui.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = 5;
            if (comboBox9.SelectedItem != null && comboBox10.SelectedItem != null)
            {
                string nomorKamar = comboBox10.SelectedItem.ToString();
                bool statusKamar = comboBox9.SelectedItem.ToString() == "Non-Aktif" ? false : true;

                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE detail_kamar SET status_kamar = @status WHERE nomor_kamar = @nomor and id_kamar = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@status", statusKamar);
                    cmd.Parameters.AddWithValue("@nomor", nomorKamar);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status kamar berhasil diperbarui.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status kamar.");
                    }

                    cmd.Dispose();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih nomor kamar dan status yang ingin diperbarui.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id = 6;
            if (comboBox11.SelectedItem != null && comboBox12.SelectedItem != null)
            {
                string nomorKamar = comboBox12.SelectedItem.ToString();
                bool statusKamar = comboBox11.SelectedItem.ToString() == "Non-Aktif" ? false : true;

                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE detail_kamar SET status_kamar = @status WHERE nomor_kamar = @nomor and id_kamar = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@status", statusKamar);
                    cmd.Parameters.AddWithValue("@nomor", nomorKamar);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status kamar berhasil diperbarui.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status kamar.");
                    }

                    cmd.Dispose();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih nomor kamar dan status yang ingin diperbarui.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int id = 8;
            if (comboBox18.SelectedItem != null && comboBox17.SelectedItem != null)
            {
                string nomorKamar = comboBox18.SelectedItem.ToString();
                bool statusKamar = comboBox17.SelectedItem.ToString() == "Non-Aktif" ? false : true;

                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE detail_kamar SET status_kamar = @status WHERE nomor_kamar = @nomor and id_kamar = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@status", statusKamar);
                    cmd.Parameters.AddWithValue("@nomor", nomorKamar);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status kamar berhasil diperbarui.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status kamar.");
                    }

                    cmd.Dispose();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih nomor kamar dan status yang ingin diperbarui.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int id = 7;
            if (comboBox19.SelectedItem != null && comboBox20.SelectedItem != null)
            {
                string nomorKamar = comboBox20.SelectedItem.ToString();
                bool statusKamar = comboBox19.SelectedItem.ToString() == "Non-Aktif" ? false : true;

                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE detail_kamar SET status_kamar = @status WHERE nomor_kamar = @nomor and id_kamar = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@status", statusKamar);
                    cmd.Parameters.AddWithValue("@nomor", nomorKamar);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status kamar berhasil diperbarui.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status kamar.");
                    }

                    cmd.Dispose();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih nomor kamar dan status yang ingin diperbarui.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int id = 9;
            if (comboBox22.SelectedItem != null && comboBox21.SelectedItem != null)
            {
                string nomorKamar = comboBox22.SelectedItem.ToString();
                bool statusKamar = comboBox21.SelectedItem.ToString() == "Non-Aktif" ? false : true;

                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE detail_kamar SET status_kamar = @status WHERE nomor_kamar = @nomor and id_kamar = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@status", statusKamar);
                    cmd.Parameters.AddWithValue("@nomor", nomorKamar);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status kamar berhasil diperbarui.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status kamar.");
                    }

                    cmd.Dispose();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih nomor kamar dan status yang ingin diperbarui.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int id = 10;
            if (comboBox24.SelectedItem != null && comboBox23.SelectedItem != null)
            {
                string nomorKamar = comboBox24.SelectedItem.ToString();
                bool statusKamar = comboBox23.SelectedItem.ToString() == "Non-Aktif" ? false : true;

                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE detail_kamar SET status_kamar = @status WHERE nomor_kamar = @nomor and id_kamar = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@status", statusKamar);
                    cmd.Parameters.AddWithValue("@nomor", nomorKamar);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status kamar berhasil diperbarui.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status kamar.");
                    }

                    cmd.Dispose();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih nomor kamar dan status yang ingin diperbarui.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(user);
            admin.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}