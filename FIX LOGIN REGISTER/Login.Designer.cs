namespace FIX_LOGIN_REGISTER
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tbox1 = new TextBox();
            tbox2 = new TextBox();
            lbl1 = new Label();
            lbl2 = new Label();
            linklbl1 = new LinkLabel();
            lbl3 = new Label();
            linklbl2 = new LinkLabel();
            btn1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            lbl13 = new Label();
            lbl4 = new Label();
            pcbox1 = new PictureBox();
            pcbox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbox2).BeginInit();
            SuspendLayout();
            // 
            // tbox1
            // 
            tbox1.Anchor = AnchorStyles.None;
            tbox1.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbox1.ForeColor = Color.FromArgb(64, 64, 64);
            tbox1.Location = new Point(1204, 373);
            tbox1.Name = "tbox1";
            tbox1.Size = new Size(469, 36);
            tbox1.TabIndex = 0;
            tbox1.Click += textBox1_Click;
            tbox1.TextChanged += textBox1_TextChanged;
            tbox1.KeyDown += textBox1_KeyDown;
            // 
            // tbox2
            // 
            tbox2.Anchor = AnchorStyles.None;
            tbox2.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbox2.ForeColor = Color.FromArgb(64, 64, 64);
            tbox2.Location = new Point(1204, 459);
            tbox2.Name = "tbox2";
            tbox2.PasswordChar = '*';
            tbox2.Size = new Size(469, 36);
            tbox2.TabIndex = 1;
            tbox2.Click += textBox2_Click;
            tbox2.TextChanged += textBox2_TextChanged;
            // 
            // lbl1
            // 
            lbl1.Anchor = AnchorStyles.None;
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.White;
            lbl1.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.ForeColor = Color.Gray;
            lbl1.Location = new Point(1202, 374);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(139, 33);
            lbl1.TabIndex = 2;
            lbl1.Text = "Username";
            lbl1.Click += label1_Click;
            // 
            // lbl2
            // 
            lbl2.Anchor = AnchorStyles.None;
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.White;
            lbl2.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.ForeColor = Color.Gray;
            lbl2.Location = new Point(1202, 460);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(132, 33);
            lbl2.TabIndex = 3;
            lbl2.Text = "Password";
            lbl2.Click += label2_Click;
            // 
            // linklbl1
            // 
            linklbl1.ActiveLinkColor = Color.DodgerBlue;
            linklbl1.AutoSize = true;
            linklbl1.BackColor = Color.White;
            linklbl1.Font = new Font("Montserrat", 8F, FontStyle.Bold, GraphicsUnit.Point);
            linklbl1.LinkColor = Color.Black;
            linklbl1.Location = new Point(1593, 523);
            linklbl1.Name = "linklbl1";
            linklbl1.Size = new Size(141, 20);
            linklbl1.TabIndex = 5;
            linklbl1.TabStop = true;
            linklbl1.Text = "Forgot Password?";
            linklbl1.LinkClicked += linkLabel1_LinkClicked;
            linklbl1.Click += linkLabel1_Click;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.White;
            lbl3.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.Location = new Point(1340, 960);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(189, 24);
            lbl3.TabIndex = 7;
            lbl3.Text = "Don't Have Account?";
            // 
            // linklbl2
            // 
            linklbl2.ActiveLinkColor = Color.DodgerBlue;
            linklbl2.AutoSize = true;
            linklbl2.Font = new Font("Montserrat SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            linklbl2.LinkColor = Color.Black;
            linklbl2.Location = new Point(1526, 960);
            linklbl2.Name = "linklbl2";
            linklbl2.Size = new Size(80, 24);
            linklbl2.TabIndex = 8;
            linklbl2.TabStop = true;
            linklbl2.Text = "Sign Up";
            linklbl2.LinkClicked += linkLabel2_LinkClicked_1;
            linklbl2.Click += linkLabel2_Click;
            // 
            // btn1
            // 
            btn1.BorderRadius = 14;
            btn1.CustomizableEdges = customizableEdges3;
            btn1.DisabledState.BorderColor = Color.DarkGray;
            btn1.DisabledState.CustomBorderColor = Color.DarkGray;
            btn1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn1.FillColor = Color.FromArgb(8, 102, 255);
            btn1.FillColor2 = Color.FromArgb(8, 186, 255);
            btn1.Font = new Font("Montserrat SemiBold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(1191, 579);
            btn1.Name = "btn1";
            btn1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn1.Size = new Size(543, 58);
            btn1.TabIndex = 9;
            btn1.Text = "Login";
            btn1.Click += guna2GradientTileButton1_Click;
            // 
            // lbl13
            // 
            lbl13.AutoSize = true;
            lbl13.BackColor = Color.White;
            lbl13.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl13.ForeColor = Color.Red;
            lbl13.Location = new Point(1204, 415);
            lbl13.Name = "lbl13";
            lbl13.RightToLeft = RightToLeft.No;
            lbl13.Size = new Size(142, 21);
            lbl13.TabIndex = 25;
            lbl13.Text = "Invalid Username";
            lbl13.Visible = false;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = Color.White;
            lbl4.Cursor = Cursors.IBeam;
            lbl4.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl4.ForeColor = Color.Red;
            lbl4.Location = new Point(1204, 501);
            lbl4.Name = "lbl4";
            lbl4.RightToLeft = RightToLeft.No;
            lbl4.Size = new Size(180, 21);
            lbl4.TabIndex = 26;
            lbl4.Text = "Please Enter Password";
            lbl4.Visible = false;
            // 
            // pcbox1
            // 
            pcbox1.Image = (Image)resources.GetObject("pcbox1.Image");
            pcbox1.Location = new Point(1687, 379);
            pcbox1.Name = "pcbox1";
            pcbox1.Size = new Size(27, 30);
            pcbox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pcbox1.TabIndex = 29;
            pcbox1.TabStop = false;
            // 
            // pcbox2
            // 
            pcbox2.Image = (Image)resources.GetObject("pcbox2.Image");
            pcbox2.Location = new Point(1690, 468);
            pcbox2.Name = "pcbox2";
            pcbox2.Size = new Size(21, 27);
            pcbox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pcbox2.TabIndex = 30;
            pcbox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pcbox2);
            Controls.Add(pcbox1);
            Controls.Add(lbl4);
            Controls.Add(lbl13);
            Controls.Add(btn1);
            Controls.Add(linklbl2);
            Controls.Add(lbl3);
            Controls.Add(linklbl1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(tbox2);
            Controls.Add(tbox1);
            Cursor = Cursors.IBeam;
            DoubleBuffered = true;
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)pcbox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbox1;
        private TextBox tbox2;
        private Label lbl1;
        private Label lbl2;
        private LinkLabel linklbl1;
        private Label lbl3;
        private LinkLabel linklbl2;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn1;
        private Label lbl13;
        private Label lbl4;
        private PictureBox pcbox1;
        private PictureBox pcbox2;
    }
}