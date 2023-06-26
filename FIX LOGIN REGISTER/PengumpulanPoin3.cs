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
    public partial class PengumpulanPoin3 : Form
    {
        private Login.User user;
        public PengumpulanPoin3(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PengumpulanPoin4 form7 = new PengumpulanPoin4(user);
            form7.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PengumpulanPoin2 form5 = new PengumpulanPoin2(user);
            form5.Show();
            this.Hide();
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
            homepage.Show();
            this.Hide();
        }
    }
}
