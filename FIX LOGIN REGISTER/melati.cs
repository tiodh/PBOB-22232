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
    public partial class melati : Form
    {
        int i;
        private void melati_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            effectDetail_melati_I.Start();
        }
        private void effectDetail_melati_I_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                effectDetail_melati_I.Stop();
            }
            else
            {
                Opacity += 0.03;
            }

            int targetY = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2; // Menghitung koordinat Y tengah layar
            int targetX = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2; // Menghitung koordinat X tengah layar

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

