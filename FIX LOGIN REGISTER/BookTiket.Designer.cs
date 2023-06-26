namespace FIX_LOGIN_REGISTER
{
    partial class BookTiket
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTiket));
            panel2 = new Panel();
            harga = new Label();
            label7 = new Label();
            pesan = new Button();
            tgl_kunjungan = new DateTimePicker();
            pengunjung_ank = new TextBox();
            jml_pengunjung = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            pictureBox16 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel11 = new Panel();
            label38 = new Label();
            label32 = new Label();
            label33 = new Label();
            label31 = new Label();
            label10 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(8, 102, 255);
            panel2.Controls.Add(harga);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pesan);
            panel2.Controls.Add(tgl_kunjungan);
            panel2.Controls.Add(pengunjung_ank);
            panel2.Controls.Add(jml_pengunjung);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(533, 299);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(938, 473);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // harga
            // 
            harga.AutoSize = true;
            harga.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            harga.ForeColor = Color.White;
            harga.Location = new Point(110, 240);
            harga.Margin = new Padding(2, 0, 2, 0);
            harga.Name = "harga";
            harga.Size = new Size(92, 20);
            harga.TabIndex = 18;
            harga.Text = "Total harga:";
            harga.Click += harga_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(107, 152);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(195, 45);
            label7.TabIndex = 17;
            label7.Text = "*Pengunjung dikategorikan sebagai\r\npengunjung anak apabila berumur \r\nkurang dari 7 tahun";
            // 
            // pesan
            // 
            pesan.Cursor = Cursors.Hand;
            pesan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pesan.Location = new Point(552, 394);
            pesan.Margin = new Padding(2);
            pesan.Name = "pesan";
            pesan.Size = new Size(136, 38);
            pesan.TabIndex = 16;
            pesan.Text = "Pesan";
            pesan.UseVisualStyleBackColor = true;
            pesan.Click += pesan_Click;
            // 
            // tgl_kunjungan
            // 
            tgl_kunjungan.Cursor = Cursors.Hand;
            tgl_kunjungan.CustomFormat = "yyyy-MM-dd";
            tgl_kunjungan.Format = DateTimePickerFormat.Custom;
            tgl_kunjungan.Location = new Point(110, 55);
            tgl_kunjungan.Margin = new Padding(2);
            tgl_kunjungan.Name = "tgl_kunjungan";
            tgl_kunjungan.Size = new Size(209, 27);
            tgl_kunjungan.TabIndex = 15;
            // 
            // pengunjung_ank
            // 
            pengunjung_ank.Cursor = Cursors.IBeam;
            pengunjung_ank.Location = new Point(110, 126);
            pengunjung_ank.Margin = new Padding(2);
            pengunjung_ank.Name = "pengunjung_ank";
            pengunjung_ank.Size = new Size(209, 27);
            pengunjung_ank.TabIndex = 13;
            // 
            // jml_pengunjung
            // 
            jml_pengunjung.Cursor = Cursors.IBeam;
            jml_pengunjung.Location = new Point(356, 126);
            jml_pengunjung.Margin = new Padding(2);
            jml_pengunjung.Name = "jml_pengunjung";
            jml_pengunjung.Size = new Size(209, 27);
            jml_pengunjung.TabIndex = 12;
            jml_pengunjung.TextChanged += jml_pengunjung_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(109, 30);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(62, 19);
            label8.TabIndex = 10;
            label8.Text = "Tanggal";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(107, 101);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(177, 19);
            label9.TabIndex = 9;
            label9.Text = "Jumlah Pengunjung Anak";
            label9.Click += label9_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(353, 99);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(194, 19);
            label6.TabIndex = 6;
            label6.Text = "Jumlah Pengunjung Dewasa";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox16);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 94);
            panel1.TabIndex = 26;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(9, 5);
            button2.Name = "button2";
            button2.Size = new Size(80, 80);
            button2.TabIndex = 17;
            button2.Text = "=";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Cursor = Cursors.Hand;
            pictureBox16.Image = (Image)resources.GetObject("pictureBox16.Image");
            pictureBox16.Location = new Point(111, 13);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(150, 68);
            pictureBox16.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox16.TabIndex = 16;
            pictureBox16.TabStop = false;
            pictureBox16.Click += pictureBox16_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Location = new Point(5141, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 70);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Location = new Point(5065, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(4989, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // panel11
            // 
            panel11.BackColor = Color.WhiteSmoke;
            panel11.Controls.Add(label38);
            panel11.Controls.Add(label32);
            panel11.Controls.Add(label33);
            panel11.Controls.Add(label31);
            panel11.Controls.Add(label10);
            panel11.Controls.Add(label1);
            panel11.Controls.Add(label2);
            panel11.Controls.Add(label4);
            panel11.Controls.Add(button1);
            panel11.Dock = DockStyle.Left;
            panel11.ImeMode = ImeMode.Off;
            panel11.Location = new Point(0, 94);
            panel11.Name = "panel11";
            panel11.Size = new Size(350, 939);
            panel11.TabIndex = 37;
            panel11.Visible = false;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BackColor = Color.Transparent;
            label38.Cursor = Cursors.Hand;
            label38.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label38.Location = new Point(43, 461);
            label38.Name = "label38";
            label38.Size = new Size(54, 25);
            label38.TabIndex = 45;
            label38.Text = "Poin";
            label38.Click += label38_Click;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Cursor = Cursors.Hand;
            label32.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label32.Location = new Point(39, 416);
            label32.Name = "label32";
            label32.Size = new Size(74, 25);
            label32.TabIndex = 44;
            label32.Text = "Ulasan";
            label32.Click += label32_Click;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Cursor = Cursors.Hand;
            label33.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label33.Location = new Point(39, 370);
            label33.Name = "label33";
            label33.Size = new Size(195, 24);
            label33.TabIndex = 43;
            label33.Text = "Riwayat Pemesanan ";
            label33.Click += label33_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Cursor = Cursors.Hand;
            label31.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label31.Location = new Point(39, 152);
            label31.Name = "label31";
            label31.Size = new Size(117, 24);
            label31.TabIndex = 43;
            label31.Text = "Tiket Masuk";
            label31.Click += label31_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(39, 262);
            label10.Name = "label10";
            label10.Size = new Size(234, 25);
            label10.TabIndex = 40;
            label10.Text = "Info Pengunjung Harian";
            label10.Click += label10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 205);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 39;
            label1.Text = "F.A.Q";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 316);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 38;
            label2.Text = "Kritik";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 103);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 37;
            label4.Text = "Tiket Hotel";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(293, 2);
            button1.Name = "button1";
            button1.Size = new Size(53, 53);
            button1.TabIndex = 24;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = false;
            // 
            // BookTiket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel11);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "BookTiket";
            Text = "Jecation";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TextBox pengunjung_ank;
        private Label label8;
        private Label label9;
        private Label label6;
        private Button pesan;
        private DateTimePicker tgl_kunjungan;
        private Label label7;
        private Label harga;
        private Panel panel1;
        private Button button2;
        private PictureBox pictureBox16;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        public TextBox jml_pengunjung;
        private Panel panel11;
        private Label label38;
        private Label label32;
        private Label label33;
        private Label label31;
        private Label label10;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button button1;
    }
}