using Npgsql;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace fixlahyah
{

    // View - Form1
    public partial class Form1 : Form
    {
        private NotifController controller;

        public Form1()
        {
            InitializeComponent();
            controller = new NotifController(this);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controller.BacaData();
            controller.BacaNotif();
        }

        public void UpdateLabel15(string text)
        {
            label15.Text = text;
        }

        public void UpdateLabel12(string text)
        {
            label12.Text = text;
        }

        public void ShowLabel12()
        {
            label12.Show();
        }

        public void HideButton1()
        {
            button1.Hide();
        }

        public void HideButton2()
        {
            button2.Hide();
        }

        public void HideButton3()
        {
            button3.Hide();
        }

        public DialogResult ShowConfirmationDialog(string message, string caption)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            button1.Show();
            button2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.KonfirmasiPesanan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.KonfirmasiKodePembayaran();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            button3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.DeletePesanan();
        }
    }
}
