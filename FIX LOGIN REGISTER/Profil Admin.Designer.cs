using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace homepage_admin
{
    partial class profil
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
            pictureBox4 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            tb_nama_lengkap = new TextBox();
            label1 = new Label();
            tb_nik = new TextBox();
            label2 = new Label();
            tb_provinsi = new TextBox();
            tb_kabupaten = new TextBox();
            tb_kecamatan = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            value_poin = new Label();
            tb_tanggal_lahir = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new System.Drawing.Point(12, 50);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(75, 69);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(116, 54);
            label7.Name = "label7";
            label7.Size = new Size(112, 16);
            label7.TabIndex = 10;
            label7.Text = "Nama Lengkap";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(12, 18);
            label6.Name = "label6";
            label6.Size = new Size(75, 29);
            label6.TabIndex = 9;
            label6.Text = "Profil";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new System.Drawing.Point(217, 283);
            button1.Name = "button1";
            button1.Size = new Size(52, 25);
            button1.TabIndex = 16;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tb_nama_lengkap
            // 
            tb_nama_lengkap.Location = new System.Drawing.Point(243, 52);
            tb_nama_lengkap.Name = "tb_nama_lengkap";
            tb_nama_lengkap.ReadOnly = true;
            tb_nama_lengkap.Size = new Size(207, 23);
            tb_nama_lengkap.TabIndex = 17;
            tb_nama_lengkap.TextChanged += tb_nama_lengkap_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(116, 83);
            label1.Name = "label1";
            label1.Size = new Size(103, 16);
            label1.TabIndex = 18;
            label1.Text = "Tanggal Lahir";
            label1.Click += label1_Click;
            // 
            // tb_nik
            // 
            tb_nik.Location = new System.Drawing.Point(243, 81);
            tb_nik.Name = "tb_nik";
            tb_nik.ReadOnly = true;
            tb_nik.Size = new Size(207, 23);
            tb_nik.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(116, 112);
            label2.Name = "label2";
            label2.Size = new Size(31, 16);
            label2.TabIndex = 20;
            label2.Text = "NIK";
            // 
            // tb_provinsi
            // 
            tb_provinsi.Location = new System.Drawing.Point(243, 110);
            tb_provinsi.Name = "tb_provinsi";
            tb_provinsi.ReadOnly = true;
            tb_provinsi.Size = new Size(207, 23);
            tb_provinsi.TabIndex = 23;
            // 
            // tb_kabupaten
            // 
            tb_kabupaten.Location = new System.Drawing.Point(243, 139);
            tb_kabupaten.Name = "tb_kabupaten";
            tb_kabupaten.ReadOnly = true;
            tb_kabupaten.Size = new Size(207, 23);
            tb_kabupaten.TabIndex = 24;
            // 
            // tb_kecamatan
            // 
            tb_kecamatan.Location = new System.Drawing.Point(243, 168);
            tb_kecamatan.Name = "tb_kecamatan";
            tb_kecamatan.ReadOnly = true;
            tb_kecamatan.Size = new Size(207, 23);
            tb_kecamatan.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(116, 141);
            label3.Name = "label3";
            label3.Size = new Size(63, 16);
            label3.TabIndex = 26;
            label3.Text = "Provinsi";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(116, 170);
            label4.Name = "label4";
            label4.Size = new Size(81, 16);
            label4.TabIndex = 27;
            label4.Text = "Kabupaten";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(116, 199);
            label5.Name = "label5";
            label5.Size = new Size(84, 16);
            label5.TabIndex = 28;
            label5.Text = "Kecamatan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(133, 240);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 29;
            label8.Text = "POIN AKUN";
            // 
            // value_poin
            // 
            value_poin.AutoSize = true;
            value_poin.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            value_poin.Location = new System.Drawing.Point(243, 244);
            value_poin.Name = "value_poin";
            value_poin.Size = new Size(28, 16);
            value_poin.TabIndex = 30;
            value_poin.Text = "275";
            // 
            // tb_tanggal_lahir
            // 
            tb_tanggal_lahir.Location = new System.Drawing.Point(243, 197);
            tb_tanggal_lahir.Name = "tb_tanggal_lahir";
            tb_tanggal_lahir.ReadOnly = true;
            tb_tanggal_lahir.Size = new Size(207, 23);
            tb_tanggal_lahir.TabIndex = 31;
            // 
            // profil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(495, 347);
            Controls.Add(tb_tanggal_lahir);
            Controls.Add(value_poin);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tb_kecamatan);
            Controls.Add(tb_kabupaten);
            Controls.Add(tb_provinsi);
            Controls.Add(tb_nik);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_nama_lengkap);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "profil";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox4;
        private Label label7;
        private Label label6;
        private Button button1;
        private TextBox tb_nama_lengkap;
        private Label label1;
        private TextBox tb_nik;
        private Label label2;
        private TextBox tb_provinsi;
        private TextBox tb_kabupaten;
        private TextBox tb_kecamatan;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label value_poin;
        private TextBox tb_tanggal_lahir;
    }
}