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
    public partial class Form3 : Form
    {
        private Login.User user;
        public Form3(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
    }
}
