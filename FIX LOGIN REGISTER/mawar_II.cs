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
    public partial class mawar_II : Form
    {
        int i;
        private void mawar_II_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            effectDetail_mawar_II.Start();
        }
        private void effectDetail_mawar_II_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                effectDetail_mawar_II.Stop();
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
