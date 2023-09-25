namespace ArabaKiralama
{
    partial class frmMüşteriListele
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMüşteriListele));
            dataGridView1 = new DataGridView();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTc = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnİptal = new Button();
            ımageList1 = new ImageList(components);
            btnGüncelle = new Button();
            btnSil = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(266, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(647, 386);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = SystemColors.ActiveCaption;
            txtTelefon.Location = new Point(139, 245);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(121, 23);
            txtTelefon.TabIndex = 15;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BackColor = SystemColors.ActiveCaption;
            txtAdSoyad.Location = new Point(139, 179);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(121, 23);
            txtAdSoyad.TabIndex = 14;
            // 
            // txtTc
            // 
            txtTc.BackColor = SystemColors.ActiveCaption;
            txtTc.Location = new Point(139, 120);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(121, 23);
            txtTc.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(65, 249);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 12;
            label3.Text = "TELEFON";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(52, 183);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 11;
            label2.Text = "AD SOYAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(104, 121);
            label1.Name = "label1";
            label1.Size = new Size(23, 17);
            label1.TabIndex = 10;
            label1.Text = "TC";
            // 
            // btnİptal
            // 
            btnİptal.BackColor = SystemColors.ActiveCaption;
            btnİptal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnİptal.ImageAlign = ContentAlignment.MiddleLeft;
            btnİptal.ImageIndex = 1;
            btnİptal.ImageList = ımageList1;
            btnİptal.Location = new Point(139, 314);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(121, 59);
            btnİptal.TabIndex = 9;
            btnİptal.Text = "İptal";
            btnİptal.TextAlign = ContentAlignment.MiddleRight;
            btnİptal.UseVisualStyleBackColor = false;
            btnİptal.Click += btnİptal_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "sa.png");
            ımageList1.Images.SetKeyName(1, "download.png");
            ımageList1.Images.SetKeyName(2, "download.png");
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = SystemColors.ActiveCaption;
            btnGüncelle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGüncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGüncelle.ImageIndex = 0;
            btnGüncelle.ImageList = ımageList1;
            btnGüncelle.Location = new Point(8, 314);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(125, 59);
            btnGüncelle.TabIndex = 8;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.TextAlign = ContentAlignment.MiddleRight;
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += BtnGüncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ActiveCaption;
            btnSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageIndex = 2;
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(820, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(93, 62);
            btnSil.TabIndex = 16;
            btnSil.Text = "Sil";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(590, 26);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 17;
            label4.Text = "TC Arama";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(662, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // frmMüşteriListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 480);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(btnSil);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnİptal);
            Controls.Add(btnGüncelle);
            Controls.Add(dataGridView1);
            Name = "frmMüşteriListele";
            Text = "Müşteri Listeleme Sayfası";
            Load += frmMüşteriListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTc;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnİptal;
        private Button btnGüncelle;
        private ImageList ımageList1;
        private Button btnSil;
        private Label label4;
        private TextBox textBox1;
    }
}