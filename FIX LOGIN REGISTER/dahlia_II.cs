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
    public partial class dahlia_II : Form
    {

        int i;

        private void dahlia_II_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            effectDetail_dahlia_II.Start();
        }

        private void effectDetail_dahlia_II_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                effectDetail_dahlia_II.Stop();
            }
            else
            {
                Opacity += 0.03;
            }
        }
        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
