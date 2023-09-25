namespace ArabaKiralama
{
    partial class frmAraçKayıt
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
            Plakatxt = new TextBox();
            Markacombo = new ComboBox();
            Sericombo = new ComboBox();
            Kmtxt = new TextBox();
            Renktxt = new TextBox();
            Yiltxt = new TextBox();
            Yakıtcombo = new ComboBox();
            Ücrettxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Plakatxt
            // 
            Plakatxt.BackColor = SystemColors.HighlightText;
            Plakatxt.Location = new Point(75, 29);
            Plakatxt.Name = "Plakatxt";
            Plakatxt.Size = new Size(137, 23);
            Plakatxt.TabIndex = 0;
            // 
            // Markacombo
            // 
            Markacombo.BackColor = SystemColors.HighlightText;
            Markacombo.FormattingEnabled = true;
            Markacombo.Items.AddRange(new object[] { "Opel", "Renault", "Fiat", "Ford" });
            Markacombo.Location = new Point(75, 58);
            Markacombo.Name = "Markacombo";
            Markacombo.Size = new Size(137, 23);
            Markacombo.TabIndex = 1;
            Markacombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Sericombo
            // 
            Sericombo.BackColor = SystemColors.HighlightText;
            Sericombo.FormattingEnabled = true;
            Sericombo.Location = new Point(75, 87);
            Sericombo.Name = "Sericombo";
            Sericombo.Size = new Size(137, 23);
            Sericombo.TabIndex = 2;
            // 
            // Kmtxt
            // 
            Kmtxt.BackColor = SystemColors.HighlightText;
            Kmtxt.Location = new Point(75, 174);
            Kmtxt.Name = "Kmtxt";
            Kmtxt.Size = new Size(137, 23);
            Kmtxt.TabIndex = 3;
            // 
            // Renktxt
            // 
            Renktxt.BackColor = SystemColors.HighlightText;
            Renktxt.Location = new Point(75, 145);
            Renktxt.Name = "Renktxt";
            Renktxt.Size = new Size(137, 23);
            Renktxt.TabIndex = 4;
            // 
            // Yiltxt
            // 
            Yiltxt.BackColor = SystemColors.HighlightText;
            Yiltxt.Location = new Point(75, 116);
            Yiltxt.Name = "Yiltxt";
            Yiltxt.Size = new Size(137, 23);
            Yiltxt.TabIndex = 5;
            // 
            // Yakıtcombo
            // 
            Yakıtcombo.BackColor = SystemColors.HighlightText;
            Yakıtcombo.FormattingEnabled = true;
            Yakıtcombo.Items.AddRange(new object[] { "Dizel", "Benzin", "Benzin+Lpg" });
            Yakıtcombo.Location = new Point(75, 203);
            Yakıtcombo.Name = "Yakıtcombo";
            Yakıtcombo.Size = new Size(137, 23);
            Yakıtcombo.TabIndex = 7;
            // 
            // Ücrettxt
            // 
            Ücrettxt.BackColor = SystemColors.HighlightText;
            Ücrettxt.Location = new Point(75, 232);
            Ücrettxt.Name = "Ücrettxt";
            Ücrettxt.Size = new Size(137, 23);
            Ücrettxt.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 37);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 9;
            label1.Text = "Plaka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 66);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 10;
            label2.Text = "Marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 95);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 11;
            label3.Text = "Seri";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 124);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 12;
            label4.Text = "Model(YIL)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 153);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 13;
            label5.Text = "Renk";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 182);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 14;
            label6.Text = "Km";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 211);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 15;
            label7.Text = "Yakıt";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 240);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 16;
            label8.Text = "Kira Ücreti";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(44, 270);
            button1.Name = "button1";
            button1.Size = new Size(92, 41);
            button1.TabIndex = 17;
            button1.Text = "Kayıt";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(142, 270);
            button2.Name = "button2";
            button2.Size = new Size(92, 41);
            button2.TabIndex = 18;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(324, 203);
            button3.Name = "button3";
            button3.Size = new Size(88, 32);
            button3.TabIndex = 19;
            button3.Text = "Resim Ekle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(263, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAraçKayıt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 329);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Ücrettxt);
            Controls.Add(Yakıtcombo);
            Controls.Add(Yiltxt);
            Controls.Add(Renktxt);
            Controls.Add(Kmtxt);
            Controls.Add(Sericombo);
            Controls.Add(Markacombo);
            Controls.Add(Plakatxt);
            Name = "frmAraçKayıt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Kayıt Sayfası";
            Load += frmAraçKayıt_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Plakatxt;
        private ComboBox Markacombo;
        private ComboBox Sericombo;
        private TextBox Kmtxt;
        private TextBox Renktxt;
        private TextBox Yiltxt;
        private ComboBox Yakıtcombo;
        private TextBox Ücrettxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}