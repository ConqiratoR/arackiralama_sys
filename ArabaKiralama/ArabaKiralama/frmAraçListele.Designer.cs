namespace ArabaKiralama
{
    partial class frmAraçListele
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
            dataGridView1 = new DataGridView();
            comboAraçlar = new ComboBox();
            button3 = new Button();
            btnİptal = new Button();
            btnGüncelle = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Ücrettxt = new TextBox();
            Yakıtcombo = new ComboBox();
            Yiltxt = new TextBox();
            Renktxt = new TextBox();
            Kmtxt = new TextBox();
            Sericombo = new ComboBox();
            Markacombo = new ComboBox();
            Plakatxt = new TextBox();
            btnSil = new Button();
            pictureBox2 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(293, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(905, 477);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // comboAraçlar
            // 
            comboAraçlar.FormattingEnabled = true;
            comboAraçlar.Items.AddRange(new object[] { "Tüm Araçlar", "Boş Araçlar", "Dolu Araçlar" });
            comboAraçlar.Location = new Point(986, 10);
            comboAraçlar.Name = "comboAraçlar";
            comboAraçlar.Size = new Size(121, 23);
            comboAraçlar.TabIndex = 1;
            comboAraçlar.SelectedIndexChanged += comboAraçlar_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(194, 472);
            button3.Name = "button3";
            button3.Size = new Size(85, 46);
            button3.TabIndex = 39;
            button3.Text = "Resim Ekle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnİptal
            // 
            btnİptal.BackColor = SystemColors.ActiveCaption;
            btnİptal.Location = new Point(103, 472);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(85, 46);
            btnİptal.TabIndex = 38;
            btnİptal.Text = "İptal";
            btnİptal.UseVisualStyleBackColor = false;
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = SystemColors.ActiveCaption;
            btnGüncelle.Location = new Point(12, 472);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(85, 46);
            btnGüncelle.TabIndex = 37;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 263);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 36;
            label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 234);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 35;
            label7.Text = "Yakıt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 205);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 34;
            label6.Text = "Km";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 176);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 33;
            label5.Text = "Renk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 147);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 32;
            label4.Text = "Model(YIL)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 118);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 31;
            label3.Text = "Seri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 89);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 30;
            label2.Text = "Marka";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 60);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 29;
            label1.Text = "Plaka";
            // 
            // Ücrettxt
            // 
            Ücrettxt.BackColor = SystemColors.HighlightText;
            Ücrettxt.Location = new Point(79, 255);
            Ücrettxt.Name = "Ücrettxt";
            Ücrettxt.Size = new Size(187, 23);
            Ücrettxt.TabIndex = 28;
            // 
            // Yakıtcombo
            // 
            Yakıtcombo.BackColor = SystemColors.HighlightText;
            Yakıtcombo.FormattingEnabled = true;
            Yakıtcombo.Items.AddRange(new object[] { "Dizel", "Benzin", "Benzin+Lpg" });
            Yakıtcombo.Location = new Point(79, 226);
            Yakıtcombo.Name = "Yakıtcombo";
            Yakıtcombo.Size = new Size(187, 23);
            Yakıtcombo.TabIndex = 27;
            // 
            // Yiltxt
            // 
            Yiltxt.BackColor = SystemColors.HighlightText;
            Yiltxt.Location = new Point(79, 139);
            Yiltxt.Name = "Yiltxt";
            Yiltxt.Size = new Size(187, 23);
            Yiltxt.TabIndex = 26;
            // 
            // Renktxt
            // 
            Renktxt.BackColor = SystemColors.HighlightText;
            Renktxt.Location = new Point(79, 168);
            Renktxt.Name = "Renktxt";
            Renktxt.Size = new Size(187, 23);
            Renktxt.TabIndex = 25;
            // 
            // Kmtxt
            // 
            Kmtxt.BackColor = SystemColors.HighlightText;
            Kmtxt.Location = new Point(79, 197);
            Kmtxt.Name = "Kmtxt";
            Kmtxt.Size = new Size(187, 23);
            Kmtxt.TabIndex = 24;
            // 
            // Sericombo
            // 
            Sericombo.BackColor = SystemColors.HighlightText;
            Sericombo.FormattingEnabled = true;
            Sericombo.Location = new Point(79, 110);
            Sericombo.Name = "Sericombo";
            Sericombo.Size = new Size(187, 23);
            Sericombo.TabIndex = 23;
            Sericombo.SelectedIndexChanged += Sericombo_SelectedIndexChanged;
            // 
            // Markacombo
            // 
            Markacombo.BackColor = SystemColors.HighlightText;
            Markacombo.FormattingEnabled = true;
            Markacombo.Items.AddRange(new object[] { "Opel", "Renault", "Fiat", "Ford" });
            Markacombo.Location = new Point(79, 81);
            Markacombo.Name = "Markacombo";
            Markacombo.Size = new Size(187, 23);
            Markacombo.TabIndex = 22;
            Markacombo.SelectedIndexChanged += Markacombo_SelectedIndexChanged;
            // 
            // Plakatxt
            // 
            Plakatxt.BackColor = SystemColors.HighlightText;
            Plakatxt.Location = new Point(79, 52);
            Plakatxt.Name = "Plakatxt";
            Plakatxt.Size = new Size(187, 23);
            Plakatxt.TabIndex = 21;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ActiveCaption;
            btnSil.Location = new Point(1113, 6);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(85, 28);
            btnSil.TabIndex = 41;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Location = new Point(12, 298);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(254, 153);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAraçListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 532);
            Controls.Add(pictureBox2);
            Controls.Add(btnSil);
            Controls.Add(button3);
            Controls.Add(btnİptal);
            Controls.Add(btnGüncelle);
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
            Controls.Add(comboAraçlar);
            Controls.Add(dataGridView1);
            Name = "frmAraçListele";
            Text = "Araç Listeleme Sayfası";
            Load += frmAraçListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboAraçlar;
        private Button button3;
        private Button btnİptal;
        private Button btnGüncelle;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Ücrettxt;
        private ComboBox Yakıtcombo;
        private TextBox Yiltxt;
        private TextBox Renktxt;
        private TextBox Kmtxt;
        private ComboBox Sericombo;
        private ComboBox Markacombo;
        private TextBox Plakatxt;
        private Button btnSil;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
    }
}