﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homepage_admin
{
    public partial class profil : Form
    {
        public profil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            profil log = new profil();
            this.Hide();
            log.Show();

        }

        private void logout_Load(object sender, EventArgs e)
        {
           
        }
    }
}
