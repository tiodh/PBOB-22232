
using FontAwesome.Sharp;
using Guna.Charts;
using System.Runtime.InteropServices;
using Npgsql;
using System.Data;
using static FIX_LOGIN_REGISTER.Login;
using Microsoft.IdentityModel.Tokens;
using System.Windows.Forms;

namespace FIX_LOGIN_REGISTER
{
    public partial class Homepage : Form
    {
        private Login.User user;
        private Rectangle rectbly1;
        private Size formOriginalSize;
        private Rectangle recBut1;
        private Rectangle recBut2;
        private Rectangle recBut3;
        private Rectangle recPnl1;
        private Rectangle recPnl3;
        private Rectangle recPnl4;
        private Rectangle recPnl5;
        private Rectangle recPnl7;
        private Rectangle recPnl8;
        private Rectangle recPnl9;
        private Rectangle recPnl10;
        private Rectangle recPnl11;
        private Rectangle recPnl12;
        private Rectangle recIbut1;
        private Rectangle recIbut2;
        private Rectangle recIbut3;
        private Rectangle recIbut4;
        private Rectangle recIbut5;
        private Rectangle recLbl2;
        private Rectangle recLbl3;
        private Rectangle recLbl4;
        private Rectangle recLbl5;
        private Rectangle recLbl6;
        private Rectangle recLbl7;
        private Rectangle recLbl8;
        private Rectangle recLbl9;
        private Rectangle recLbl10;
        private Rectangle recLbl11;
        private Rectangle recLbl12;
        private Rectangle recLbl13;
        private Rectangle recLbl14;
        private Rectangle recLbl15;
        private Rectangle recLbl16;
        private Rectangle recLbl17;
        private Rectangle recLbl18;
        private Rectangle recLbl19;
        private Rectangle recLbl20;
        private Rectangle recLbl21;
        private Rectangle recLbl22;
        private Rectangle recLbl23;
        private Rectangle recLbl24;
        private Rectangle recLbl25;
        private Rectangle recLbl26;
        private Rectangle recLbl27;
        private Rectangle recLbl28;
        private Rectangle recLbl29;
        private Rectangle recLbl30;
        private Rectangle recLbl35;
        private Rectangle recPbox1;
        private Rectangle recPbox2;
        private Rectangle recPbox3;
        private Rectangle recPbox4;
        private Rectangle recPbox5;
        private Rectangle recPbox6;
        private Rectangle recPbox7;
        private Rectangle recPbox8;
        private Rectangle recPbox9;
        private Rectangle recPbox10;
        private Rectangle recPbox11;
        private Rectangle recPbox12;
        private Rectangle recPbox13;
        private Rectangle recPbox14;
        private Rectangle recPbox15;
        private Rectangle recPbox16;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );

        private IconButton currentBtn;
        private Panel topBorderBtn;

        public Homepage(Login.User user)
        {

            InitializeComponent();
            this.user = user;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=;Database=Jecation"))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "select deskripsi_wisata from te mpat_wisata where id_wisata = 1";
                    cmd.CommandType = CommandType.Text;


                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string text = reader.GetString(reader.GetOrdinal("deskripsi_wisata"));
                            label5.Text = text;
                        }
                    }



                }
            }
            catch { }

            rectbly1 = new Rectangle(tableLayoutPanel1.Location, tableLayoutPanel1.Size);
            topBorderBtn = new Panel();
            topBorderBtn.Size = new Size(5, 50);
            panel1.Controls.Add(topBorderBtn);
            this.Resize += Form1_Resize_1;
            formOriginalSize = this.Size;
            recBut1 = new Rectangle(button1.Location, button1.Size);
            recBut2 = new Rectangle(button2.Location, button2.Size);
            recBut2 = new Rectangle(button3.Location, button3.Size);
            recPnl1 = new Rectangle(panel1.Location, panel1.Size);
            recPnl3 = new Rectangle(panel3.Location, panel3.Size);
            recPnl4 = new Rectangle(panel4.Location, panel4.Size);
            recPnl5 = new Rectangle(panel5.Location, panel5.Size);
            recPnl7 = new Rectangle(panel7.Location, panel7.Size);
            recPnl8 = new Rectangle(panel8.Location, panel8.Size);
            recPnl9 = new Rectangle(panel9.Location, panel9.Size);
            recPnl10 = new Rectangle(panel10.Location, panel10.Size);
            recPnl11 = new Rectangle(panel11.Location, panel11.Size);
            recPnl11 = new Rectangle(panel12.Location, panel12.Size);
            //recIbut1 = new Rectangle(iconButton1.Location, iconButton1.Size);
            // recIbut2 = new Rectangle(iconButton2.Location, iconButton2.Size);
            //recIbut3 = new Rectangle(iconButton3.Location, iconButton3.Size);
            // recIbut4 = new Rectangle(iconButton4.Location, iconButton4.Size);
            // recIbut5 = new Rectangle(iconButton5.Location, iconButton5.Size);
            recLbl2 = new Rectangle(label2.Location, label2.Size);
            recLbl3 = new Rectangle(label3.Location, label3.Size);
            recLbl4 = new Rectangle(label4.Location, label4.Size);
            recLbl5 = new Rectangle(label5.Location, label5.Size);
            recLbl6 = new Rectangle(label6.Location, label6.Size);
            recLbl7 = new Rectangle(label7.Location, label7.Size);
            recLbl8 = new Rectangle(label8.Location, label8.Size);
            recLbl9 = new Rectangle(label7.Location, label9.Size);
            recLbl10 = new Rectangle(label7.Location, label10.Size);
            recLbl11 = new Rectangle(label7.Location, label11.Size);
            recLbl12 = new Rectangle(label12.Location, label12.Size);
            recLbl13 = new Rectangle(label13.Location, label13.Size);
            recLbl14 = new Rectangle(label14.Location, label14.Size);
            recLbl15 = new Rectangle(label15.Location, label15.Size);
            recLbl16 = new Rectangle(label16.Location, label16.Size);
            recLbl17 = new Rectangle(label17.Location, label17.Size);
            recLbl18 = new Rectangle(label18.Location, label18.Size);
            recLbl19 = new Rectangle(label19.Location, label19.Size);
            recLbl20 = new Rectangle(label20.Location, label20.Size);
            recLbl21 = new Rectangle(label21.Location, label21.Size);
            recLbl22 = new Rectangle(label22.Location, label22.Size);
            recLbl23 = new Rectangle(label23.Location, label23.Size);
            recLbl24 = new Rectangle(label24.Location, label24.Size);
            recLbl25 = new Rectangle(label25.Location, label25.Size);
            recLbl26 = new Rectangle(label26.Location, label26.Size);
            recLbl27 = new Rectangle(label27.Location, label27.Size);
            recLbl28 = new Rectangle(label28.Location, label28.Size);
            recLbl29 = new Rectangle(label29.Location, label29.Size);
            recLbl30 = new Rectangle(label30.Location, label30.Size);
            recLbl30 = new Rectangle(label35.Location, label35.Size);
            recPbox1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recPbox2 = new Rectangle(pictureBox2.Location, pictureBox2.Size);
            recPbox3 = new Rectangle(pictureBox3.Location, pictureBox3.Size);
            recPbox4 = new Rectangle(pictureBox4.Location, pictureBox4.Size);
            recPbox5 = new Rectangle(pictureBox5.Location, pictureBox5.Size);
            recPbox6 = new Rectangle(pictureBox6.Location, pictureBox6.Size);
            recPbox7 = new Rectangle(pictureBox7.Location, pictureBox7.Size);
            recPbox8 = new Rectangle(pictureBox8.Location, pictureBox8.Size);
            recPbox9 = new Rectangle(pictureBox9.Location, pictureBox9.Size);
            recPbox10 = new Rectangle(pictureBox10.Location, pictureBox10.Size);
            recPbox11 = new Rectangle(pictureBox11.Location, pictureBox11.Size);
            recPbox12 = new Rectangle(pictureBox12.Location, pictureBox12.Size);
            recPbox13 = new Rectangle(pictureBox13.Location, pictureBox13.Size);
            recPbox14 = new Rectangle(pictureBox14.Location, pictureBox14.Size);
            recPbox15 = new Rectangle(pictureBox15.Location, pictureBox15.Size);
            recPbox16 = new Rectangle(pictureBox16.Location, pictureBox16.Size);
        }

        public Homepage()
        {
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(0, 0, 255);
            public static Color color2 = Color.FromArgb(0, 0, 255);
            public static Color color3 = Color.FromArgb(0, 0, 255);
            public static Color color4 = Color.FromArgb(0, 0, 255);
            public static Color color5 = Color.FromArgb(0, 0, 255);
            public static Color color6 = Color.FromArgb(0, 0, 255);

        }
        private void ActivateButton(object senderBtn, Color color)
        {

            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;

                topBorderBtn.BackColor = color;
                topBorderBtn.Location = new Point(244, currentBtn.Location.Y);
                topBorderBtn.Visible = false;
                topBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            }
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
        private void Form1_Resize_1(object sender, EventArgs e)
        {

            resize_Control(button1, recBut1);
            resize_Control(button2, recBut2);
            resize_Control(button3, recBut3);
            resize_Control(panel1, recPnl1);
            resize_Control(panel3, recPnl3);
            resize_Control(panel4, recPnl4);
            resize_Control(panel5, recPnl5);
            resize_Control(panel7, recPnl7);
            resize_Control(panel8, recPnl8);
            resize_Control(panel9, recPnl9);
            resize_Control(panel10, recPnl10);
            resize_Control(panel11, recPnl11);
            resize_Control(panel12, recPnl12);
            //resize_Control(iconButton1, recIbut1);
            //resize_Control(iconButton2, recIbut2);
            //resize_Control(iconButton3, recIbut3);
            //resize_Control(iconButton4, recIbut4);
            //resize_Control(iconButton5, recIbut5);
            resize_Control(label2, recLbl2);
            resize_Control(label3, recLbl3);
            resize_Control(label4, recLbl4);
            resize_Control(label5, recLbl5);
            resize_Control(label6, recLbl6);
            resize_Control(label7, recLbl7);
            resize_Control(label8, recLbl8);
            resize_Control(label9, recLbl9);
            resize_Control(label10, recLbl10);
            resize_Control(label11, recLbl11);
            resize_Control(label12, recLbl12);
            resize_Control(label13, recLbl13);
            resize_Control(label14, recLbl14);
            resize_Control(label15, recLbl15);
            resize_Control(label16, recLbl16);
            resize_Control(label17, recLbl17);
            resize_Control(label18, recLbl18);
            resize_Control(label19, recLbl19);
            resize_Control(label20, recLbl20);
            resize_Control(label21, recLbl21);
            resize_Control(label22, recLbl22);
            resize_Control(label23, recLbl23);
            resize_Control(label24, recLbl24);
            resize_Control(label25, recLbl25);
            resize_Control(label26, recLbl26);
            resize_Control(label27, recLbl27);
            resize_Control(label28, recLbl28);
            resize_Control(label29, recLbl29);
            resize_Control(label30, recLbl30);
            resize_Control(label35, recLbl35);
            resize_Control(pictureBox1, recPbox1);
            resize_Control(pictureBox2, recPbox2);
            resize_Control(pictureBox3, recPbox3);
            resize_Control(pictureBox4, recPbox4);
            resize_Control(pictureBox5, recPbox5);
            resize_Control(pictureBox6, recPbox6);
            resize_Control(pictureBox7, recPbox7);
            resize_Control(pictureBox8, recPbox8);
            resize_Control(pictureBox9, recPbox9);
            resize_Control(pictureBox10, recPbox10);
            resize_Control(pictureBox11, recPbox11);
            resize_Control(pictureBox12, recPbox12);
            resize_Control(pictureBox13, recPbox13);
            resize_Control(pictureBox14, recPbox14);
            resize_Control(pictureBox15, recPbox15);
            resize_Control(pictureBox16, recPbox16);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel11.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel11.Hide();
        }
        public void bacadata()
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=;Database=Jecation";
            string sql = "SELECT id_notifikasi_user, a.username_akun, k.nama_kamar, jumlah_malam, jumlah_kamar, total_harga " +
                "FROM notifikasi_user nu " +
                "JOIN akun a ON (nu.id_akun = a.id_akun) " +
                "JOIN kamar_penginapan k ON (nu.id_kamar = k.id_kamar) " +
                "WHERE nu.status = false " +
                "ORDER BY id_notifikasi_user ASC " +
                "LIMIT 1";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        NpgsqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            dr.GetInt32(0);
                            dr.GetString(1);
                            dr.GetString(2);
                            dr.GetInt32(3);
                            dr.GetInt32(4);
                            dr.GetInt32(5);

                            string rowdata = $"Pemesanan Telah Dikonfirmasi\nUsername: {dr.GetString(1)}\n{dr.GetString(2)}\n{dr.GetInt32(3)} Malam\n{dr.GetInt32(4)} Kamar\nTotal Harga: {dr.GetInt32(5)}";
                            label36.Text = rowdata;
                        }

                        dr.Close();
                        conn.Close();
                        bacakode();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
        public void bacakode()
        {
            string connStrin = "Server=localhost;Port=5432;User Id=postgres;Password=;Database=Jecation";
            string sqll = "SELECT id_kode_pembayaran, a.username_akun, k.kode_pembayaran " +
                         "FROM kode_pembayaran k " +
                         "JOIN notifikasi_user nu ON (nu.id_notifikasi_user = k.id_notifikasi_user) " +
                         "JOIN akun a ON (nu.id_akun = a.id_akun) " +
                         "WHERE k.status = true " +
                         "ORDER BY k.id_kode_pembayaran ASC " +
                         "LIMIT 1";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStrin))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(sqll, conn))
                {
                    try
                    {
                        conn.Open();
                        NpgsqlDataReader dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.GetInt32(0);
                            dr.GetString(1);
                            dr.GetInt32(2);

                            string rowdata = $"Pembayaran Telah Dikonfirmasi\nUsername: {dr.GetString(1)}\n{dr.GetInt32(2)}";
                            label39.Text = rowdata;
                        }
                        else
                        {
                            label39.Text = ("");
                            //view.HideButton3();
                        }

                        dr.Close();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            bacadata();
            bacakode();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "select deskripsi_wisata from tempat_wisata where id_wisata = 1";
                    cmd.CommandType = CommandType.Text;


                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string text = reader.GetString(reader.GetOrdinal("deskripsi_wisata"));
                            label5.Text = text;
                        }
                    }

                }
            }

            catch (Exception)
            {

                throw;
            }
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 30, 30));
            pictureBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 30, 30));
            pictureBox5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox5.Width, pictureBox5.Height, 30, 30));
            pictureBox6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox6.Width, pictureBox6.Height, 30, 30));
            pictureBox7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox7.Width, pictureBox7.Height, 30, 30));
            pictureBox8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox8.Width, pictureBox8.Height, 30, 30));
            pictureBox9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox9.Width, pictureBox9.Height, 30, 30));
            pictureBox10.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox10.Width, pictureBox10.Height, 30, 30));
            pictureBox11.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox11.Width, pictureBox11.Height, 30, 30));
            pictureBox12.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox12.Width, pictureBox12.Height, 30, 30));
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel12.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel12.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Info kepadatan = new Info(user);
            kepadatan.Show();
            this.Hide();
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Kritik kritik = new Kritik(user);
            kritik.Show();
            this.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel12.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            FAQBaru faq = new FAQBaru(user);
            faq.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            page_ut page_Ut = new page_ut(user);
            page_Ut.Show();
            this.Hide();
        }

        private void label35_Click(object sender, EventArgs e)
        {
            GantiPasswordUser gantiPasswordUser = new GantiPasswordUser(user);
            gantiPasswordUser.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            BookTiket bookTiket = new BookTiket(user);
            bookTiket.Show();
            this.Hide();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            Ulasan ulasan = new Ulasan(user);
            ulasan.Show();
            this.Hide();
        }
        private bool notifikasi = false;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (notifikasi)
            {
                panel13.Hide();
                notifikasi = false;
            }
            else
            {
                panel13.Show();
                notifikasi = true;
            }
        }

        private void label36_Click(object sender, EventArgs e)
        {
            KodePembayaranuser kp = new KodePembayaranuser(user);
            kp.StartPosition = FormStartPosition.Manual;
            kp.Location = new Point(620, 120);
            kp.ShowDialog();
        }

        public void newlabel36(string text)
        {
            label36.Text = text;
        }
        public void newlabel37(string text)
        {
            label37.Text = text;
        }
        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label33_Click(object sender, EventArgs e)
        {
            Riwayat_User riwayat_User = new Riwayat_User(user);
            riwayat_User.Show();
            this.Hide();
        }

        private void label38_Click(object sender, EventArgs e)
        {
            PengumpulanPoin1 pengumpulanPoin1 = new PengumpulanPoin1(user);
            pengumpulanPoin1.Show();
            this.Hide();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}