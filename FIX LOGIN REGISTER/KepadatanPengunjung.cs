using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KepadatanPengunjung
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public class Database
        {
            private string connectionString = "Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password=Akbar_29102005";

            public int GetVisitorCount(DateTime date)
            {
                using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT COUNT(id_pmsn_tiket) FROM pemesanan_tiket WHERE jadwal_pmsn_tiket = @date";
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.CommandType = System.Data.CommandType.Text;

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            panel1 = new Panel();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            this.dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("MS Reference Sans Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(61, 26);
            button1.Name = "button1";
            button1.Size = new Size(123, 49);
            button1.TabIndex = 0;
            button1.Text = "LOGO";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1894, 100);
            panel1.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Location = new Point(1576, 21);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 2;
            button6.Text = "\r\n";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Location = new Point(1660, 21);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 3;
            button7.Text = "\r\n";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Location = new Point(1744, 21);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 4;
            button8.Text = "\r\n";
            button8.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1059, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(474, 25);
            textBox1.TabIndex = 5;
            textBox1.Text = "Apa yang ingin Anda cari...";
            // 
            // button5
            // 
            button5.Font = new Font("MS Reference Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(865, 26);
            button5.Name = "button5";
            button5.Size = new Size(123, 49);
            button5.TabIndex = 4;
            button5.Text = "Lainnya";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("MS Reference Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(693, 26);
            button4.Name = "button4";
            button4.Size = new Size(123, 49);
            button4.TabIndex = 3;
            button4.Text = "Kuliner";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("MS Reference Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(521, 26);
            button3.Name = "button3";
            button3.Size = new Size(123, 49);
            button3.TabIndex = 2;
            button3.Text = "Wisata";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("MS Reference Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(349, 26);
            button2.Name = "button2";
            button2.Size = new Size(123, 49);
            button2.TabIndex = 1;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(710, 259);
            panel2.Name = "panel2";
            panel2.Size = new Size(37, 37);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(156, 196);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(488, 618);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(700, 196);
            label1.Name = "label1";
            label1.Size = new Size(656, 45);
            label1.TabIndex = 4;
            label1.Text = "Informasi Kepadatan Pengunjung";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(704, 345);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 6;
            label3.Text = "Halo User!";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(708, 391);
            label4.Name = "label4";
            label4.Size = new Size(483, 20);
            label4.TabIndex = 7;
            label4.Text = "Hari ini terdapat 250 orang nih yang sedang menikmati wisata kami.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(708, 447);
            label5.Name = "label5";
            label5.Size = new Size(239, 66);
            label5.TabIndex = 8;
            label5.Text = "Yuk Segera \nDatang dan Nikmati \nWisata Alam Rembangan!";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(767, 266);
            this.dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(221, 25);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.Value = new DateTime(2023, 6, 12, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += this.dateTimePicker1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1894, 1009);
            Controls.Add(this.dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Window1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;

        private void Form1_Load(object sender, EventArgs e)
        {
            Database database = new Database();

            // Mengambil jumlah pengunjung dari database berdasarkan tanggal
            int visitorCount = database.GetVisitorCount(dateTimePicker1.Value);

            // Menetapkan hasil ke label4.Text
            label4.Text = "Pada tanggal " + dateTimePicker1.Value.ToString("dd MMMM yyyy") + ", terdapat " + visitorCount.ToString() + " orang yang sedang menikmati wisata kami.";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Database database = new Database();

            // Mengambil jumlah pengunjung dari database berdasarkan tanggal
            int visitorCount = database.GetVisitorCount(dateTimePicker1.Value);

            // Menetapkan hasil ke label4.Text
            label4.Text = "Pada tanggal " + dateTimePicker1.Value.ToString("dd MMMM yyyy") + ", terdapat " + visitorCount.ToString() + " orang yang sedang menikmati wisata kami.";
        }
    }
}

