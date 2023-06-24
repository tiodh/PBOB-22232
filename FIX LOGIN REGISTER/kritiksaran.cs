using Npgsql;
using System.Data;
using Npgsql;
using Kritik_Saran_FIXX.Models;

namespace Kritik_Saran_FIXX
{
    public partial class Form1 : Form
    {
        konten isiKritik;

        private Size formOriginalSize;
        private Rectangle recBut2;
        private Rectangle recib1;
        private Rectangle recib2;
        private Rectangle recib3;
        private Rectangle recib5;
        private Rectangle recib6;
        private Rectangle recpb16;
        private Rectangle recpb5;
        private Rectangle recpb7;
        private Rectangle recpb9;
        private Rectangle reclbl1;
        private Rectangle reclbl2;
        private Rectangle reclbl6;

        private Rectangle recpb1;
        private Rectangle reclbl7;
        private Rectangle recrtb1;
        private Rectangle recBut1;
        private Rectangle recib4;
        private Rectangle rectb;

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

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(btnKirim, recBut1);
            resize_Control(btnHamburger, recBut2);
            resize_Control(btnHome, recib1);
            resize_Control(btnWisata, recib2);
            resize_Control(btnArtikel, recib3);
            resize_Control(rtbKritik, rectb);
            resize_Control(btnUlasan, recib5);
            resize_Control(btnLainnya, recib6);
            resize_Control(lblRembangan, reclbl1);
            resize_Control(lblLokasi, reclbl2);
            resize_Control(lblHeader, reclbl6);
            resize_Control(lblKritik, reclbl7);

            resize_Control(pictureBox1, recpb1);
            resize_Control(pictureBox16, recpb16);
            resize_Control(pictureBox5, recpb5);
            resize_Control(pictureBox7, recpb7);
            resize_Control(pictureBox9, recpb9);
            resize_Control(btnTiket, recib4);

        }

        public Form1()
        {
            InitializeComponent();
            isiKritik = new konten();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            recBut1 = new Rectangle(btnKirim.Location, btnKirim.Size);
            recBut2 = new Rectangle(btnHamburger.Location, btnHamburger.Size);
            recib1 = new Rectangle(btnHome.Location, btnHome.Size);
            recib2 = new Rectangle(btnWisata.Location, btnWisata.Size);
            recib3 = new Rectangle(btnArtikel.Location, btnArtikel.Size);
            rectb = new Rectangle(rtbKritik.Location, rtbKritik.Size);
            recib5 = new Rectangle(btnUlasan.Location, btnUlasan.Size);
            recib6 = new Rectangle(btnLainnya.Location, btnLainnya.Size);
            reclbl1 = new Rectangle(lblRembangan.Location, lblRembangan.Size);
            reclbl2 = new Rectangle(lblLokasi.Location, lblLokasi.Size);
            reclbl6 = new Rectangle(lblHeader.Location, lblHeader.Size);
            reclbl7 = new Rectangle(lblKritik.Location, lblKritik.Size);

            recpb1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recpb16 = new Rectangle(pictureBox16.Location, pictureBox16.Size);
            recpb5 = new Rectangle(pictureBox5.Location, pictureBox5.Size);
            recpb7 = new Rectangle(pictureBox7.Location, pictureBox7.Size);
            recpb9 = new Rectangle(pictureBox9.Location, pictureBox9.Size);
            recib4 = new Rectangle(btnTiket.Location, btnTiket.Size);

        }



        private void btnKirim_Click(object sender, EventArgs e)
        {

            string kritik = rtbKritik.Text;

            Kritik newkritik = new Kritik()
            {
                kritikan = kritik,
            };

            bool isSuccess = isiKritik.Insert(newkritik);

            if (isSuccess)
            {
                MessageBox.Show("Berhasil menambahkan review");
                rtbKritik.Text = "";
            }
            else
            {
                MessageBox.Show("Review gagal ditambahkan");
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

        }

        private void rtbKritik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnKirim.PerformClick();
            }
        }

    }
}