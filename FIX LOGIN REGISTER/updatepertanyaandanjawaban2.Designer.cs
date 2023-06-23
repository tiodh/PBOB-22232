namespace updatepertanyaandanjawaban
{
    partial class updatepertanyaandanjawaban2
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
            btnupdatefaq = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btnupdatefaq
            // 
            btnupdatefaq.Location = new Point(694, 409);
            btnupdatefaq.Name = "btnupdatefaq";
            btnupdatefaq.Size = new Size(94, 29);
            btnupdatefaq.TabIndex = 2;
            btnupdatefaq.Text = "update";
            btnupdatefaq.UseVisualStyleBackColor = true;
            btnupdatefaq.Click += btnupdatefaq_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 3;
            label1.Text = "Pertanyaan";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 245);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "Jawaban";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 96);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 129);
            textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(637, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(607, 25);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 8;
            label3.Text = "ID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 268);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(776, 129);
            textBox2.TabIndex = 9;
            // 
            // updatepertanyaandanjawaban2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnupdatefaq);
            Name = "updatepertanyaandanjawaban2";
            Text = "updatepertanyaandanjawaban2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnupdatefaq;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox2;
    }
}