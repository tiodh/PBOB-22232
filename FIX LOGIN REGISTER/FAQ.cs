using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FAQ
{
    public partial class FAQ : Form
    {
        private Size formOriginalSize;
        private Rectangle recPcBoxHeader;
        private Rectangle recPnl1;
        private Rectangle recPnlAns1;
        private Rectangle recLblAns1;
        private Rectangle recLblAsk1;
        private Rectangle recLblDesc;
        private Rectangle recLblFAQ;
        private Rectangle recPnlAns8;
        private Rectangle recLblAns8;
        private Rectangle recLblAsk8;
        private Rectangle recPnlAns7;
        private Rectangle recLblAns7;
        private Rectangle recLblAsk7;
        private Rectangle recPnlAns6;
        private Rectangle recLblAns6;
        private Rectangle recLblAsk6;
        private Rectangle recPnlAns5;
        private Rectangle recLblAns5;
        private Rectangle recLblAsk5;
        private Rectangle recPnlAns4;
        private Rectangle recLblAns4;
        private Rectangle recLblAsk4;
        private Rectangle recPnlAns3;
        private Rectangle recLblAns3;
        private Rectangle recLblAsk3;
        private Rectangle recPnlAns2;
        private Rectangle recLblAns2;
        private Rectangle recLblAsk2;
        private Rectangle recPnlAns12;
        private Rectangle recLblAns12;
        private Rectangle recLblAsk12;
        private Rectangle recPnlAns11;
        private Rectangle recLblAns11;
        private Rectangle recLblAsk11;
        private Rectangle recPnlAns10;
        private Rectangle recLblAns10;
        private Rectangle recLblAsk10;
        private Rectangle recPnlAns9;
        private Rectangle recLblAns9;
        private Rectangle recLblAsk9;
        private Rectangle recPnlAns16;
        private Rectangle recLblAns16;
        private Rectangle recLblAsk16;
        private Rectangle recPnlAns15;
        private Rectangle recLblAns15;
        private Rectangle recLblAsk15;
        private Rectangle recPnlAns14;
        private Rectangle recLblAns14;
        private Rectangle recLblAsk14;
        private Rectangle recPnlAns13;
        private Rectangle recLblAns13;
        private Rectangle recLblAsk13;
        private Rectangle recPnlAns20;
        private Rectangle recLblAns20;
        private Rectangle recLblAsk20;
        private Rectangle recPnlAns19;
        private Rectangle recLblAns19;
        private Rectangle recLblAsk19;
        private Rectangle recPnlAns18;
        private Rectangle recLblAns18;
        private Rectangle recLblAsk18;
        private Rectangle recPnlAns17;
        private Rectangle recLblAns17;
        private Rectangle recLblAsk17;

        public FAQ()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;

            recPcBoxHeader = new Rectangle(pcboxheader.Location, pcboxheader.Size);
            recPnl1 = new Rectangle(pnl1.Location, pnl1.Size);
            recPnlAns1 = new Rectangle(pnlans1.Location, pnlans1.Size);
            recLblAns1 = new Rectangle(lblans1.Location, lblans1.Size);
            recLblAsk1 = new Rectangle(lblask1.Location, lblask1.Size);
            recLblDesc = new Rectangle(lbldesc.Location, lbldesc.Size);
            recLblFAQ = new Rectangle(lblfaq.Location, lblfaq.Size);
            recPnlAns8 = new Rectangle(pnlans8.Location, pnlans8.Size);
            recLblAns8 = new Rectangle(lblans8.Location, lblans8.Size);
            recLblAsk8 = new Rectangle(lblask8.Location, lblask8.Size);
            recPnlAns7 = new Rectangle(pnlans7.Location, pnlans7.Size);
            recLblAns7 = new Rectangle(lblans7.Location, lblans7.Size);
            recLblAsk7 = new Rectangle(lblask7.Location, lblask7.Size);
            recPnlAns6 = new Rectangle(pnlans6.Location, pnlans6.Size);
            recLblAns6 = new Rectangle(lblans6.Location, lblans6.Size);
            recLblAsk6 = new Rectangle(lblask6.Location, lblask6.Size);
            recPnlAns5 = new Rectangle(pnlans5.Location, pnlans5.Size);
            recLblAns5 = new Rectangle(lblans5.Location, lblans5.Size);
            recLblAsk5 = new Rectangle(lblask5.Location, lblask5.Size);
            recPnlAns4 = new Rectangle(pnlans4.Location, pnlans4.Size);
            recLblAns4 = new Rectangle(lblans4.Location, lblans4.Size);
            recLblAsk4 = new Rectangle(lblask4.Location, lblask4.Size);
            recPnlAns3 = new Rectangle(pnlans3.Location, pnlans3.Size);
            recLblAns3 = new Rectangle(lblans3.Location, lblans3.Size);
            recLblAsk3 = new Rectangle(lblask3.Location, lblask3.Size);
            recPnlAns2 = new Rectangle(pnlans2.Location, pnlans2.Size);
            recLblAns2 = new Rectangle(lblans2.Location, lblans2.Size);
            recLblAsk2 = new Rectangle(lblask2.Location, lblask2.Size);
            recPnlAns12 = new Rectangle(pnlans12.Location, pnlans12.Size);
            recLblAns12 = new Rectangle(lblans12.Location, lblans12.Size);
            recLblAsk12 = new Rectangle(lblask12.Location, lblask12.Size);
            recPnlAns11 = new Rectangle(pnlans11.Location, pnlans11.Size);
            recLblAns11 = new Rectangle(lblans11.Location, lblans11.Size);
            recLblAsk11 = new Rectangle(lblask11.Location, lblask11.Size);
            recPnlAns10 = new Rectangle(pnlans10.Location, pnlans10.Size);
            recLblAns10 = new Rectangle(lblans10.Location, lblans10.Size);
            recLblAsk10 = new Rectangle(lblask10.Location, lblask10.Size);
            recPnlAns9 = new Rectangle(pnlans9.Location, pnlans9.Size);
            recLblAns9 = new Rectangle(lblans9.Location, lblans9.Size);
            recLblAsk9 = new Rectangle(lblask9.Location, lblask9.Size);
            recPnlAns16 = new Rectangle(pnlans16.Location, pnlans16.Size);
            recLblAns16 = new Rectangle(lblans16.Location, lblans16.Size);
            recLblAsk16 = new Rectangle(lblask16.Location, lblask16.Size);
            recPnlAns15 = new Rectangle(pnlans15.Location, pnlans15.Size);
            recLblAns15 = new Rectangle(lblans15.Location, lblans15.Size);
            recLblAsk15 = new Rectangle(lblask15.Location, lblask15.Size);
            recPnlAns14 = new Rectangle(pnlans14.Location, pnlans14.Size);
            recLblAns14 = new Rectangle(lblans14.Location, lblans14.Size);
            recLblAsk14 = new Rectangle(lblask14.Location, lblask14.Size);
            recPnlAns13 = new Rectangle(pnlans13.Location, pnlans13.Size);
            recLblAns13 = new Rectangle(lblans13.Location, lblans13.Size);
            recLblAsk13 = new Rectangle(lblask13.Location, lblask13.Size);
            recPnlAns20 = new Rectangle(pnlans20.Location, pnlans20.Size);
            recLblAns20 = new Rectangle(lblans20.Location, lblans20.Size);
            recLblAsk20 = new Rectangle(lblask20.Location, lblask20.Size);
            recPnlAns19 = new Rectangle(pnlans19.Location, pnlans19.Size);
            recLblAns19 = new Rectangle(lblans19.Location, lblans19.Size);
            recLblAsk19 = new Rectangle(lblask19.Location, lblask19.Size);
            recPnlAns18 = new Rectangle(pnlans18.Location, pnlans18.Size);
            recLblAns18 = new Rectangle(lblans18.Location, lblans18.Size);
            recLblAsk18 = new Rectangle(lblask18.Location, lblask18.Size);
            recPnlAns17 = new Rectangle(pnlans17.Location, pnlans17.Size);
            recLblAns17 = new Rectangle(lblans17.Location, lblans17.Size);
            recLblAsk17 = new Rectangle(lblask17.Location, lblask17.Size);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

            ResizeControl(pcboxheader, recPcBoxHeader, xRatio, yRatio);
            ResizeControl(pnl1, recPnl1, xRatio, yRatio);
            ResizeControl(pnlans1, recPnlAns1, xRatio, yRatio);
            ResizeControl(lblans1, recLblAns1, xRatio, yRatio);
            ResizeControl(lblask1, recLblAsk1, xRatio, yRatio);
            ResizeControl(lbldesc, recLblDesc, xRatio, yRatio);
            ResizeControl(lblfaq, recLblFAQ, xRatio, yRatio);
            ResizeControl(pnlans8, recPnlAns8, xRatio, yRatio);
            ResizeControl(lblans8, recLblAns8, xRatio, yRatio);
            ResizeControl(lblask8, recLblAsk8, xRatio, yRatio);
            ResizeControl(pnlans7, recPnlAns7, xRatio, yRatio);
            ResizeControl(lblans7, recLblAns7, xRatio, yRatio);
            ResizeControl(lblask7, recLblAsk7, xRatio, yRatio);
            ResizeControl(pnlans6, recPnlAns6, xRatio, yRatio);
            ResizeControl(lblans6, recLblAns6, xRatio, yRatio);
            ResizeControl(lblask6, recLblAsk6, xRatio, yRatio);
            ResizeControl(pnlans5, recPnlAns5, xRatio, yRatio);
            ResizeControl(lblans5, recLblAns5, xRatio, yRatio);
            ResizeControl(lblask5, recLblAsk5, xRatio, yRatio);
            ResizeControl(pnlans4, recPnlAns4, xRatio, yRatio);
            ResizeControl(lblans4, recLblAns4, xRatio, yRatio);
            ResizeControl(lblask4, recLblAsk4, xRatio, yRatio);
            ResizeControl(pnlans3, recPnlAns3, xRatio, yRatio);
            ResizeControl(lblans3, recLblAns3, xRatio, yRatio);
            ResizeControl(lblask3, recLblAsk3, xRatio, yRatio);
            ResizeControl(pnlans2, recPnlAns2, xRatio, yRatio);
            ResizeControl(lblans2, recLblAns2, xRatio, yRatio);
            ResizeControl(lblask2, recLblAsk2, xRatio, yRatio);
            ResizeControl(pnlans12, recPnlAns12, xRatio, yRatio);
            ResizeControl(lblans12, recLblAns12, xRatio, yRatio);
            ResizeControl(lblask12, recLblAsk12, xRatio, yRatio);
            ResizeControl(pnlans11, recPnlAns11, xRatio, yRatio);
            ResizeControl(lblans11, recLblAns11, xRatio, yRatio);
            ResizeControl(lblask11, recLblAsk11, xRatio, yRatio);
            ResizeControl(pnlans10, recPnlAns10, xRatio, yRatio);
            ResizeControl(lblans10, recLblAns10, xRatio, yRatio);
            ResizeControl(lblask10, recLblAsk10, xRatio, yRatio);
            ResizeControl(pnlans9, recPnlAns9, xRatio, yRatio);
            ResizeControl(lblans9, recLblAns9, xRatio, yRatio);
            ResizeControl(lblask9, recLblAsk9, xRatio, yRatio);
            ResizeControl(pnlans16, recPnlAns16, xRatio, yRatio);
            ResizeControl(lblans16, recLblAns16, xRatio, yRatio);
            ResizeControl(lblask16, recLblAsk16, xRatio, yRatio);
            ResizeControl(pnlans15, recPnlAns15, xRatio, yRatio);
            ResizeControl(lblans15, recLblAns15, xRatio, yRatio);
            ResizeControl(lblask15, recLblAsk15, xRatio, yRatio);
            ResizeControl(pnlans14, recPnlAns14, xRatio, yRatio);
            ResizeControl(lblans14, recLblAns14, xRatio, yRatio);
            ResizeControl(lblask14, recLblAsk14, xRatio, yRatio);
            ResizeControl(pnlans13, recPnlAns13, xRatio, yRatio);
            ResizeControl(lblans13, recLblAns13, xRatio, yRatio);
            ResizeControl(lblask13, recLblAsk13, xRatio, yRatio);
            ResizeControl(pnlans20, recPnlAns20, xRatio, yRatio);
            ResizeControl(lblans20, recLblAns20, xRatio, yRatio);
            ResizeControl(lblask20, recLblAsk20, xRatio, yRatio);
            ResizeControl(pnlans19, recPnlAns19, xRatio, yRatio);
            ResizeControl(lblans19, recLblAns19, xRatio, yRatio);
            ResizeControl(lblask19, recLblAsk19, xRatio, yRatio);
            ResizeControl(pnlans18, recPnlAns18, xRatio, yRatio);
            ResizeControl(lblans18, recLblAns18, xRatio, yRatio);
            ResizeControl(lblask18, recLblAsk18, xRatio, yRatio);
            ResizeControl(pnlans17, recPnlAns17, xRatio, yRatio);
            ResizeControl(lblans17, recLblAns17, xRatio, yRatio);
            ResizeControl(lblask17, recLblAsk17, xRatio, yRatio);
        }

        private void ResizeControl(Control control, Rectangle originalSize, float xRatio, float yRatio)
        {
            control.Left = (int)(originalSize.Left * xRatio);
            control.Top = (int)(originalSize.Top * yRatio);
            control.Width = (int)(originalSize.Width * xRatio);
            control.Height = (int)(originalSize.Height * yRatio);
        }

        private void lblask17_Click(object sender, EventArgs e)
        {

        }
    }
}