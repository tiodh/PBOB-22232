using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIX_LOGIN_REGISTER
{
    public partial class PengumpulanPoin2 : Form
    {
        Login.User user;
        public PengumpulanPoin2(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            PengumpulanPoin1 form1 = new PengumpulanPoin1(user);
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PengumpulanPoin1 form1 = new PengumpulanPoin1(user);
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PengumpulanPoin3 form6 = new PengumpulanPoin3(user);
            form6.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PengumpulanPoin1 form1 = new PengumpulanPoin1(user);
            form1.Show();
            this.Hide();
        }
    }
}
