namespace GantiPassword
{
    partial class GantiPassword1
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
            btnlupapassword = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnlupapassword
            // 
            btnlupapassword.BackColor = SystemColors.ActiveCaption;
            btnlupapassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnlupapassword.Location = new Point(85, 344);
            btnlupapassword.Name = "btnlupapassword";
            btnlupapassword.Size = new Size(140, 30);
            btnlupapassword.TabIndex = 3;
            btnlupapassword.Text = "Ganti Password";
            btnlupapassword.UseVisualStyleBackColor = false;
            btnlupapassword.Click += btnlupapassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 301);
            label1.Name = "label1";
            label1.Size = new Size(178, 31);
            label1.TabIndex = 2;
            label1.Text = "Ganti Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlupapassword);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlupapassword;
        private Label label1;
    }
}