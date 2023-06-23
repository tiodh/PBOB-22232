using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace riwayat
{
    public partial class Form1 : Form
    {
        private Size formOriginalSize;
        private Rectangle recpanel1;
        private Rectangle reclabel1;
        private Rectangle recguna2Panel2;
        private Rectangle reclabel10;
        private Rectangle reclabel5;
        private Rectangle reclabel4;
        private Rectangle reclabel2;
        private Rectangle recguna2Panel5;
        private Rectangle reclabel18;
        private Rectangle reclabel19;
        private Rectangle reclabel20;
        private Rectangle reclabel21;
        private Rectangle recguna2Panel4;
        private Rectangle reclabel14;
        private Rectangle reclabel15;
        private Rectangle reclabel16;
        private Rectangle reclabel17;
        private Rectangle recguna2Panel3;
        private Rectangle reclabel9;
        private Rectangle reclabel11;
        private Rectangle reclabel12;
        private Rectangle reclabel13;
        private Rectangle recguna2Panel1;
        private Rectangle reclabel3;
        private Rectangle reclabel6;
        private Rectangle reclabel7;
        private Rectangle reclabel8;
        private Rectangle recguna2Panel6;
        private Rectangle reclabel22;
        private Rectangle reclabel23;
        private Rectangle reclabel24;
        private Rectangle reclabel25;
        private Rectangle recguna2Panel10;
        private Rectangle reclabel38;
        private Rectangle reclabel39;
        private Rectangle reclabel40;
        private Rectangle reclabel41;
        private Rectangle recguna2Panel9;
        private Rectangle reclabel34;
        private Rectangle reclabel35;
        private Rectangle reclabel36;
        private Rectangle reclabel37;
        private Rectangle recguna2Panel8;
        private Rectangle reclabel30;
        private Rectangle reclabel31;
        private Rectangle reclabel32;
        private Rectangle reclabel33;
        private Rectangle recguna2Panel7;
        private Rectangle reclabel26;
        private Rectangle reclabel27;
        private Rectangle reclabel28;
        private Rectangle reclabel29;
        private Rectangle recpanel9;
        private Rectangle recpictureBox17;
        private Rectangle recpictureBox32;
        private Rectangle recpictureBox33;
        private Rectangle recpictureBox34;
        private Rectangle reclabel50;
        private Rectangle reclabel51;
        private Rectangle reclabel52;
        private Rectangle reclabel53;
        private Rectangle reclabel54;
        private Rectangle reclabel55;
        private Rectangle reclabel56;
        private Rectangle reclabel57;
        private Rectangle reclabel58;
        private Rectangle reclabel59;
        private Rectangle reclabel60;
        private Rectangle reclabel61;
        private Rectangle recpictureBox35;
        private Rectangle recpictureBox36;
        private Rectangle recpictureBox37;
        private Rectangle reclabel62;
        private Rectangle reclabel63;
        private Rectangle reclabel64;
        private Rectangle reclabel65;
        private Rectangle recpanel10;
        private Rectangle rectextBox2;
        private Rectangle recbutton4;
        private Rectangle recpictureBox39;
        private Rectangle recpictureBox40;
        private Rectangle reclabel66;
        private Rectangle recpictureBox41;
        private Rectangle recpictureBox42;
        private Rectangle reclabel67;


        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            recpanel1 = new Rectangle(panel1.Location, panel1.Size);
            reclabel1 = new Rectangle(label1.Location, label1.Size);
            recguna2Panel2 = new Rectangle(guna2Panel2.Location, guna2Panel2.Size);
            reclabel10 = new Rectangle(label10.Location, label10.Size);
            reclabel5 = new Rectangle(label5.Location, label5.Size);
            reclabel4 = new Rectangle(label4.Location, label4.Size);
            reclabel2 = new Rectangle(label2.Location, label2.Size);
            recguna2Panel5 = new Rectangle(guna2Panel5.Location, guna2Panel5.Size);
            reclabel18 = new Rectangle(label18.Location, label18.Size);
            reclabel19 = new Rectangle(label19.Location, label19.Size);
            reclabel20 = new Rectangle(label20.Location, label20.Size);
            reclabel21 = new Rectangle(label21.Location, label21.Size);
            recguna2Panel4 = new Rectangle(guna2Panel4.Location, guna2Panel4.Size);
            reclabel14 = new Rectangle(label14.Location, label14.Size);
            reclabel15 = new Rectangle(label15.Location, label15.Size);
            reclabel16 = new Rectangle(label16.Location, label16.Size);
            reclabel17 = new Rectangle(label17.Location, label17.Size);
            recguna2Panel3 = new Rectangle(guna2Panel3.Location, guna2Panel3.Size);
            reclabel9 = new Rectangle(label9.Location, label9.Size);
            reclabel11 = new Rectangle(label11.Location, label11.Size);
            reclabel12 = new Rectangle(label12.Location, label12.Size);
            reclabel13 = new Rectangle(label13.Location, label13.Size);
            recguna2Panel1 = new Rectangle(guna2Panel1.Location, guna2Panel1.Size);
            reclabel3 = new Rectangle(label3.Location, label3.Size);
            reclabel6 = new Rectangle(label6.Location, label6.Size);
            reclabel7 = new Rectangle(label7.Location, label7.Size);
            reclabel8 = new Rectangle(label8.Location, label8.Size);
            recguna2Panel6 = new Rectangle(guna2Panel6.Location, guna2Panel6.Size);
            reclabel22 = new Rectangle(label22.Location, label22.Size);
            reclabel23 = new Rectangle(label23.Location, label23.Size);
            reclabel24 = new Rectangle(label24.Location, label24.Size);
            reclabel25 = new Rectangle(label25.Location, label25.Size);
            recguna2Panel10 = new Rectangle(guna2Panel10.Location, guna2Panel10.Size);
            reclabel38 = new Rectangle(label38.Location, label38.Size);
            reclabel39 = new Rectangle(label39.Location, label39.Size);
            reclabel40 = new Rectangle(label40.Location, label40.Size);
            reclabel41 = new Rectangle(label41.Location, label41.Size);
            recguna2Panel9 = new Rectangle(guna2Panel9.Location, guna2Panel9.Size);
            reclabel34 = new Rectangle(label34.Location, label34.Size);
            reclabel35 = new Rectangle(label35.Location, label35.Size);
            reclabel36 = new Rectangle(label36.Location, label36.Size);
            reclabel37 = new Rectangle(label37.Location, label37.Size);
            recguna2Panel8 = new Rectangle(guna2Panel8.Location, guna2Panel8.Size);
            reclabel30 = new Rectangle(label30.Location, label30.Size);
            reclabel31 = new Rectangle(label31.Location, label31.Size);
            reclabel32 = new Rectangle(label32.Location, label32.Size);
            reclabel33 = new Rectangle(label33.Location, label33.Size);
            recguna2Panel7 = new Rectangle(guna2Panel7.Location, guna2Panel7.Size);
            reclabel26 = new Rectangle(label26.Location, label26.Size);
            reclabel27 = new Rectangle(label27.Location, label27.Size);
            reclabel28 = new Rectangle(label28.Location, label28.Size);
            reclabel29 = new Rectangle(label29.Location, label29.Size);
            recpanel9 = new Rectangle(panel9.Location, panel9.Size);
            recpictureBox17 = new Rectangle(pictureBox17.Location, pictureBox17.Size);
            recpictureBox32 = new Rectangle(pictureBox32.Location, pictureBox32.Size);
            recpictureBox33 = new Rectangle(pictureBox33.Location, pictureBox33.Size);
            recpictureBox34 = new Rectangle(pictureBox34.Location, pictureBox34.Size);
            reclabel50 = new Rectangle(label50.Location, label50.Size);
            reclabel51 = new Rectangle(label51.Location, label51.Size);
            reclabel52 = new Rectangle(label52.Location, label52.Size);
            reclabel53 = new Rectangle(label53.Location, label53.Size);
            reclabel54 = new Rectangle(label54.Location, label54.Size);
            reclabel55 = new Rectangle(label55.Location, label55.Size);
            reclabel56 = new Rectangle(label56.Location, label56.Size);
            reclabel57 = new Rectangle(label57.Location, label57.Size);
            reclabel58 = new Rectangle(label58.Location, label58.Size);
            reclabel59 = new Rectangle(label59.Location, label59.Size);
            reclabel60 = new Rectangle(label60.Location, label60.Size);
            reclabel61 = new Rectangle(label61.Location, label61.Size);
            recpictureBox35 = new Rectangle(pictureBox35.Location, pictureBox35.Size);
            recpictureBox36 = new Rectangle(pictureBox36.Location, pictureBox36.Size);
            recpictureBox37 = new Rectangle(pictureBox37.Location, pictureBox37.Size);
            reclabel62 = new Rectangle(label62.Location, label62.Size);
            reclabel63 = new Rectangle(label63.Location, label63.Size);
            reclabel64 = new Rectangle(label64.Location, label64.Size);
            //reclabel65 = new Rectangle(label65.Location, label65.Size);
            //recpanel10 = new Rectangle(panel10.Location, panel10.Size);
            // rectextBox2 = new Rectangle(textBox2.Location, textBox2.Size);
            //recbutton4 = new Rectangle(button4.Location, button4.Size);
            recpictureBox39 = new Rectangle(pictureBox39.Location, pictureBox39.Size);
            recpictureBox40 = new Rectangle(pictureBox40.Location, pictureBox40.Size);
            reclabel66 = new Rectangle(label66.Location, label66.Size);
            recpictureBox41 = new Rectangle(pictureBox41.Location, pictureBox41.Size);
            //recpictureBox42 = new Rectangle(pictureBox42.Location, pictureBox42.Size);
            // reclabel67 = new Rectangle(label67.Location, label67.Size);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(panel1, recpanel1);
            resize_Control(label1, reclabel1);
            resize_Control(guna2Panel2, recguna2Panel2);
            resize_Control(label10, reclabel10);
            resize_Control(label5, reclabel5);
            resize_Control(label4, reclabel4);
            resize_Control(label2, reclabel2);
            resize_Control(guna2Panel5, recguna2Panel5);
            resize_Control(label18, reclabel18);
            resize_Control(label19, reclabel19);
            resize_Control(label20, reclabel20);
            resize_Control(label21, reclabel21);
            resize_Control(guna2Panel4, recguna2Panel4);
            resize_Control(label14, reclabel14);
            resize_Control(label15, reclabel15);
            resize_Control(label16, reclabel16);
            resize_Control(label17, reclabel17);
            resize_Control(guna2Panel3, recguna2Panel3);
            resize_Control(label9, reclabel9);
            resize_Control(label11, reclabel11);
            resize_Control(label12, reclabel12);
            resize_Control(label13, reclabel13);
            resize_Control(guna2Panel1, recguna2Panel1);
            resize_Control(label3, reclabel3);
            resize_Control(label6, reclabel6);
            resize_Control(label7, reclabel7);
            resize_Control(label8, reclabel8);
            resize_Control(guna2Panel6, recguna2Panel6);
            resize_Control(label22, reclabel22);
            resize_Control(label23, reclabel23);
            resize_Control(label24, reclabel24);
            resize_Control(label25, reclabel25);
            resize_Control(guna2Panel10, recguna2Panel10);
            resize_Control(label38, reclabel38);
            resize_Control(label39, reclabel39);
            resize_Control(label40, reclabel40);
            resize_Control(label41, reclabel41);
            resize_Control(guna2Panel9, recguna2Panel9);
            resize_Control(label34, reclabel34);
            resize_Control(label35, reclabel35);
            resize_Control(label36, reclabel36);
            resize_Control(label37, reclabel37);
            resize_Control(guna2Panel8, recguna2Panel8);
            resize_Control(label30, reclabel30);
            resize_Control(label31, reclabel31);
            resize_Control(label32, reclabel32);
            resize_Control(label33, reclabel33);
            resize_Control(guna2Panel7, recguna2Panel7);
            resize_Control(label26, reclabel26);
            resize_Control(label27, reclabel27);
            resize_Control(label28, reclabel28);
            resize_Control(label29, reclabel29);
            resize_Control(panel9, recpanel9);
            resize_Control(pictureBox17, recpictureBox17);
            resize_Control(pictureBox32, recpictureBox32);
            resize_Control(pictureBox33, recpictureBox33);
            resize_Control(pictureBox34, recpictureBox34);
            resize_Control(label50, reclabel50);
            resize_Control(label51, reclabel51);
            resize_Control(label52, reclabel52);
            resize_Control(label53, reclabel53);
            resize_Control(label54, reclabel54);
            resize_Control(label55, reclabel55);
            resize_Control(label56, reclabel56);
            resize_Control(label57, reclabel57);
            resize_Control(label58, reclabel58);
            resize_Control(label59, reclabel59);
            resize_Control(label60, reclabel60);
            resize_Control(label61, reclabel61);
            resize_Control(pictureBox35, recpictureBox35);
            resize_Control(pictureBox36, recpictureBox36);
            resize_Control(pictureBox37, recpictureBox37);
            resize_Control(label62, reclabel62);
            resize_Control(label63, reclabel63);
            resize_Control(label64, reclabel64);
            // resize_Control(label65, reclabel65);
            //resize_Control(panel10, recpanel10);
            // resize_Control(textBox2, rectextBox2);
            //resize_Control(button4, recbutton4);
            resize_Control(pictureBox39, recpictureBox39);
            resize_Control(pictureBox40, recpictureBox40);
            resize_Control(label66, reclabel66);
            resize_Control(pictureBox41, recpictureBox41);
            // resize_Control(pictureBox42, recpictureBox42);
            //resize_Control(label67, reclabel67);
        }

        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}