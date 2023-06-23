namespace pbo_desain
{
    partial class Update_Status_Kamar_MawarII
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
            this.mawarII = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.Label();
            this.pilihstatus = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.pilihkamar = new System.Windows.Forms.ComboBox();
            this.Insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mawarII
            // 
            this.mawarII.AutoSize = true;
            this.mawarII.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mawarII.Location = new System.Drawing.Point(382, 26);
            this.mawarII.Name = "mawarII";
            this.mawarII.Size = new System.Drawing.Size(94, 25);
            this.mawarII.TabIndex = 6;
            this.mawarII.Text = "Mawar II";
            this.mawarII.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 125);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pilihkamar);
            this.panel1.Controls.Add(this.pilihstatus);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(284, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 252);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(124, 191);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(42, 16);
            this.status.TabIndex = 12;
            this.status.Text = "status";
            this.status.Click += new System.EventHandler(this.label2_Click);
            // 
            // pilihstatus
            // 
            this.pilihstatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Free",
            "Booked"});
            this.pilihstatus.FormattingEnabled = true;
            this.pilihstatus.Items.AddRange(new object[] {
            "Free",
            "Booked"});
            this.pilihstatus.Location = new System.Drawing.Point(27, 212);
            this.pilihstatus.Name = "pilihstatus";
            this.pilihstatus.Size = new System.Drawing.Size(236, 24);
            this.pilihstatus.TabIndex = 12;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(468, 403);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(175, 75);
            this.update.TabIndex = 15;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.button1_Click);
            // 
            // pilihkamar
            // 
            this.pilihkamar.AutoCompleteCustomSource.AddRange(new string[] {
            "Free",
            "Booked"});
            this.pilihkamar.FormattingEnabled = true;
            this.pilihkamar.Items.AddRange(new object[] {
            "Kamar no 12B",
            "Kamar no 14",
            "Kamar no 15",
            "Kamar no 16"});
            this.pilihkamar.Location = new System.Drawing.Point(27, 21);
            this.pilihkamar.Name = "pilihkamar";
            this.pilihkamar.Size = new System.Drawing.Size(236, 24);
            this.pilihkamar.TabIndex = 16;
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(227, 403);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(175, 75);
            this.Insert.TabIndex = 16;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 505);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.update);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mawarII);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mawarII;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ComboBox pilihstatus;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ComboBox pilihkamar;
        private System.Windows.Forms.Button Insert;
    }
}

