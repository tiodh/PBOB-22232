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
    public partial class PengumpulanPoin4 : Form
    {
        private Login.User user;
        public PengumpulanPoin4(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PengumpulanPoin3 form6 = new PengumpulanPoin3(user);
            form6.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(user);
            homepage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(user);
            homepage.Show(); this.Hide();
        }
    }
}
