namespace GantiPassword
{
    partial class GantiPassword2
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
            btnresetpassword = new Button();
            lbl = new Label();
            label2 = new Label();
            label1 = new Label();
            KonfirPass = new TextBox();
            PassBaru = new TextBox();
            PassLama = new TextBox();
            SuspendLayout();
            // 
            // btnresetpassword
            // 
            btnresetpassword.BackColor = SystemColors.ActiveCaption;
            btnresetpassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnresetpassword.Location = new Point(394, 312);
            btnresetpassword.Name = "btnresetpassword";
            btnresetpassword.Size = new Size(140, 30);
            btnresetpassword.TabIndex = 13;
            btnresetpassword.Text = "Reset Password";
            btnresetpassword.UseVisualStyleBackColor = false;
            btnresetpassword.Click += btnresetpassword_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(267, 232);
            lbl.Name = "lbl";
            lbl.Size = new Size(145, 20);
            lbl.TabIndex = 12;
            lbl.Text = "Konfirmasi Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 172);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 11;
            label2.Text = "Password Baru";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 109);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 10;
            label1.Text = "Password Lama";
            // 
            // KonfirPass
            // 
            KonfirPass.Location = new Point(267, 255);
            KonfirPass.Name = "KonfirPass";
            KonfirPass.Size = new Size(267, 27);
            KonfirPass.TabIndex = 9;
            // 
            // PassBaru
            // 
            PassBaru.Location = new Point(267, 195);
            PassBaru.Name = "PassBaru";
            PassBaru.Size = new Size(267, 27);
            PassBaru.TabIndex = 8;
            // 
            // PassLama
            // 
            PassLama.Location = new Point(267, 132);
            PassLama.Name = "PassLama";
            PassLama.Size = new Size(267, 27);
            PassLama.TabIndex = 7;
            // 
            // GantiPassword2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnresetpassword);
            Controls.Add(lbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(KonfirPass);
            Controls.Add(PassBaru);
            Controls.Add(PassLama);
            Name = "GantiPassword2";
            Text = "GantiPassword2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnresetpassword;
        private Label lbl;
        private Label label2;
        private Label label1;
        private TextBox KonfirPass;
        private TextBox PassBaru;
        private TextBox PassLama;
    }
}