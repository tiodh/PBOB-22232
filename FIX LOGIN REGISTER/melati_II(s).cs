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
    public partial class melati_II_s_ : Form
    {
        int i;
        private void melati_II_s__Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            effectDetail_melati_IIs.Start();
        }
        private void effectDetail_melati_IIs_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                effectDetail_melati_IIs.Stop();
            }
            else
            {
                Opacity += 0.03;
            }

            int targetY = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2; // Menghitung koordinat Y tengah layar
            int targetX = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2; // Menghitung koordinat X tengah layar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
