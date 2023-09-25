namespace ArabaKiralama
{
    partial class frmMüşteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMüşteriEkle));
            btnEkle = new Button();
            ımageList1 = new ImageList(components);
            btnİptal = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTc = new TextBox();
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveCaption;
            btnEkle.ImageAlign = ContentAlignment.TopCenter;
            btnEkle.ImageIndex = 0;
            btnEkle.ImageList = ımageList1;
            btnEkle.Location = new Point(64, 247);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 81);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.TextAlign = ContentAlignment.BottomCenter;
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "download.jpg");
            ımageList1.Images.SetKeyName(1, "download.png");
            // 
            // btnİptal
            // 
            btnİptal.BackColor = SystemColors.ActiveCaption;
            btnİptal.ImageAlign = ContentAlignment.TopCenter;
            btnİptal.ImageIndex = 1;
            btnİptal.ImageList = ımageList1;
            btnİptal.Location = new Point(206, 247);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(75, 81);
            btnİptal.TabIndex = 1;
            btnİptal.Text = "İptal";
            btnİptal.TextAlign = ContentAlignment.BottomCenter;
            btnİptal.UseVisualStyleBackColor = false;
            btnİptal.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(116, 42);
            label1.Name = "label1";
            label1.Size = new Size(23, 17);
            label1.TabIndex = 2;
            label1.Text = "TC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(64, 104);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 3;
            label2.Text = "AD SOYAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(77, 170);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 4;
            label3.Text = "TELEFON";
            // 
            // txtTc
            // 
            txtTc.BackColor = SystemColors.InactiveCaption;
            txtTc.Location = new Point(168, 44);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(100, 23);
            txtTc.TabIndex = 5;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BackColor = SystemColors.InactiveCaption;
            txtAdSoyad.Location = new Point(168, 103);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(100, 23);
            txtAdSoyad.TabIndex = 6;
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = SystemColors.InactiveCaption;
            txtTelefon.Location = new Point(168, 169);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 7;
            // 
            // frmMüşteriEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(340, 371);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnİptal);
            Controls.Add(btnEkle);
            Name = "frmMüşteriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Ekleme Sayfası";
            Load += frmMüşteriEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private Button btnİptal;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTc;
        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private ImageList ımageList1;
    }
}