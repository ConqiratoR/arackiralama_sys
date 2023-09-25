namespace ArabaKiralama
{
    partial class frmAnaSayfa
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            button1 = new Button();
            ımageList1 = new ImageList(components);
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ImageIndex = 1;
            button1.ImageList = ımageList1;
            button1.Location = new Point(12, 3);
            button1.Name = "button1";
            button1.Size = new Size(160, 112);
            button1.TabIndex = 0;
            button1.Text = "MÜŞTERİ EKLEME";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "sss.jpg");
            ımageList1.Images.SetKeyName(1, "");
            ımageList1.Images.SetKeyName(2, "");
            ımageList1.Images.SetKeyName(3, "");
            ımageList1.Images.SetKeyName(4, "");
            ımageList1.Images.SetKeyName(5, "");
            ımageList1.Images.SetKeyName(6, "");
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.ImageIndex = 2;
            button2.ImageList = ımageList1;
            button2.Location = new Point(228, 3);
            button2.Name = "button2";
            button2.Size = new Size(160, 112);
            button2.TabIndex = 1;
            button2.Text = "MÜŞTERİ LİSTELEME";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.ImageIndex = 3;
            button3.ImageList = ımageList1;
            button3.Location = new Point(441, 3);
            button3.Name = "button3";
            button3.Size = new Size(160, 112);
            button3.TabIndex = 2;
            button3.Text = "ARAÇ KAYIT";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.ImageIndex = 4;
            button4.ImageList = ımageList1;
            button4.Location = new Point(650, 3);
            button4.Name = "button4";
            button4.Size = new Size(160, 112);
            button4.TabIndex = 3;
            button4.Text = "ARAÇ LİSTELEME";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaption;
            button6.ImageIndex = 6;
            button6.ImageList = ımageList1;
            button6.Location = new Point(848, 3);
            button6.Name = "button6";
            button6.Size = new Size(160, 112);
            button6.TabIndex = 5;
            button6.Text = "ÇIKIŞ";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 119);
            panel1.TabIndex = 6;
            // 
            // frmAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._4_1_adana_arac_kiralama;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1020, 480);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "frmAnaSayfa";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private ImageList ımageList1;
        private Panel panel1;
    }
}