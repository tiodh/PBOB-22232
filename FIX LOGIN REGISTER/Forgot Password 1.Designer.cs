namespace FIX_LOGIN_REGISTER
{
    partial class Forgot_Password_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot_Password_1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lbl1 = new Label();
            tbox1 = new TextBox();
            pcbox1 = new PictureBox();
            dtpick1 = new DateTimePicker();
            btn1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            lbl3 = new Label();
            tbox3 = new TextBox();
            lbl2 = new Label();
            tbox2 = new TextBox();
            lbl4 = new Label();
            tbox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbox1).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.White;
            lbl1.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.ForeColor = Color.Gray;
            lbl1.Location = new Point(758, 480);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(276, 27);
            lbl1.TabIndex = 7;
            lbl1.Text = "Enter your mother's name";
            lbl1.Click += label1_Click;
            // 
            // tbox1
            // 
            tbox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbox1.BackColor = Color.White;
            tbox1.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbox1.ForeColor = Color.FromArgb(64, 64, 64);
            tbox1.Location = new Point(755, 476);
            tbox1.Name = "tbox1";
            tbox1.Size = new Size(376, 36);
            tbox1.TabIndex = 6;
            tbox1.Click += textBox1_Click;
            tbox1.TextChanged += textBox1_TextChanged;
            // 
            // pcbox1
            // 
            pcbox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbox1.BackColor = Color.Transparent;
            pcbox1.Image = (Image)resources.GetObject("pcbox1.Image");
            pcbox1.Location = new Point(11, 12);
            pcbox1.Name = "pcbox1";
            pcbox1.Size = new Size(51, 39);
            pcbox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbox1.TabIndex = 21;
            pcbox1.TabStop = false;
            pcbox1.Click += pictureBox1_Click;
            // 
            // dtpick1
            // 
            dtpick1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpick1.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dtpick1.Format = DateTimePickerFormat.Short;
            dtpick1.Location = new Point(755, 544);
            dtpick1.Name = "dtpick1";
            dtpick1.Size = new Size(269, 36);
            dtpick1.TabIndex = 22;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn1.BorderRadius = 14;
            btn1.CustomizableEdges = customizableEdges1;
            btn1.DisabledState.BorderColor = Color.DarkGray;
            btn1.DisabledState.CustomBorderColor = Color.DarkGray;
            btn1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn1.FillColor = Color.FromArgb(8, 102, 255);
            btn1.FillColor2 = Color.FromArgb(8, 186, 255);
            btn1.Font = new Font("Montserrat SemiBold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(757, 784);
            btn1.Name = "btn1";
            btn1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn1.Size = new Size(408, 58);
            btn1.TabIndex = 23;
            btn1.Text = "Reset Password";
            btn1.Click += guna2GradientTileButton1_Click;
            // 
            // lbl3
            // 
            lbl3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.White;
            lbl3.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.ForeColor = Color.Gray;
            lbl3.Location = new Point(758, 683);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(198, 27);
            lbl3.TabIndex = 29;
            lbl3.Text = "Confirm Password";
            lbl3.Click += label3_Click;
            // 
            // tbox3
            // 
            tbox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbox3.BackColor = Color.White;
            tbox3.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbox3.ForeColor = Color.FromArgb(64, 64, 64);
            tbox3.Location = new Point(755, 677);
            tbox3.Name = "tbox3";
            tbox3.PasswordChar = '*';
            tbox3.Size = new Size(376, 36);
            tbox3.TabIndex = 28;
            tbox3.Click += textBox3_Click;
            tbox3.TextChanged += textBox3_TextChanged;
            // 
            // lbl2
            // 
            lbl2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.White;
            lbl2.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.ForeColor = Color.Gray;
            lbl2.Location = new Point(758, 622);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(162, 27);
            lbl2.TabIndex = 27;
            lbl2.Text = "New Password";
            lbl2.Click += label2_Click;
            // 
            // tbox2
            // 
            tbox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbox2.BackColor = Color.White;
            tbox2.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbox2.ForeColor = Color.FromArgb(64, 64, 64);
            tbox2.Location = new Point(755, 618);
            tbox2.Name = "tbox2";
            tbox2.PasswordChar = '*';
            tbox2.Size = new Size(376, 36);
            tbox2.TabIndex = 26;
            tbox2.Click += textBox2_Click;
            tbox2.TextChanged += textBox2_TextChanged;
            tbox2.KeyDown += textBox2_KeyDown;
            // 
            // lbl4
            // 
            lbl4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl4.AutoSize = true;
            lbl4.BackColor = Color.White;
            lbl4.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl4.ForeColor = Color.Gray;
            lbl4.Location = new Point(758, 415);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(117, 27);
            lbl4.TabIndex = 25;
            lbl4.Text = "Username";
            lbl4.Click += label4_Click;
            // 
            // tbox4
            // 
            tbox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbox4.BackColor = Color.White;
            tbox4.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbox4.ForeColor = Color.FromArgb(64, 64, 64);
            tbox4.Location = new Point(755, 411);
            tbox4.Name = "tbox4";
            tbox4.Size = new Size(376, 36);
            tbox4.TabIndex = 24;
            tbox4.Click += textBox4_Click;
            tbox4.TextChanged += textBox4_TextChanged;
            tbox4.KeyDown += textBox4_KeyDown;
            // 
            // Forgot_Password_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(lbl3);
            Controls.Add(tbox3);
            Controls.Add(lbl2);
            Controls.Add(tbox2);
            Controls.Add(lbl4);
            Controls.Add(tbox4);
            Controls.Add(btn1);
            Controls.Add(dtpick1);
            Controls.Add(pcbox1);
            Controls.Add(lbl1);
            Controls.Add(tbox1);
            Cursor = Cursors.IBeam;
            DoubleBuffered = true;
            Name = "Forgot_Password_1";
            Text = "Forgot_Password_1";
            Load += Forgot_Password_1_Load;
            Resize += Forgot_Password_1_Resize;
            ((System.ComponentModel.ISupportInitialize)pcbox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox tbox1;
        private PictureBox pcbox1;
        private DateTimePicker dtpick1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn1;
        private Label lbl3;
        private TextBox tbox3;
        private Label lbl2;
        private TextBox tbox2;
        private Label lbl4;
        private TextBox tbox4;
    }
}