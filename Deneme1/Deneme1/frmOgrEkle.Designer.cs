namespace Deneme1
{
    partial class frmOgrEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOgrEkle = new System.Windows.Forms.Button();
            this.cmbHarfNotu = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbOgrNo = new System.Windows.Forms.TextBox();
            this.lblOgrNo = new System.Windows.Forms.Label();
            this.tbOgrAdi = new System.Windows.Forms.TextBox();
            this.tbOgrSoyadi = new System.Windows.Forms.TextBox();
            this.lblOgrSoyadi = new System.Windows.Forms.Label();
            this.lblOgrAdi = new System.Windows.Forms.Label();
            this.gbCinsiyet = new System.Windows.Forms.GroupBox();
            this.rbKız = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.lblHarfNotu = new System.Windows.Forms.Label();
            this.cbSinifTekrar = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOgrEkle);
            this.groupBox1.Controls.Add(this.cmbHarfNotu);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.gbCinsiyet);
            this.groupBox1.Controls.Add(this.lblHarfNotu);
            this.groupBox1.Controls.Add(this.cbSinifTekrar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekleme";
            // 
            // btnOgrEkle
            // 
            this.btnOgrEkle.Location = new System.Drawing.Point(313, 180);
            this.btnOgrEkle.Name = "btnOgrEkle";
            this.btnOgrEkle.Size = new System.Drawing.Size(75, 23);
            this.btnOgrEkle.TabIndex = 15;
            this.btnOgrEkle.Text = "Ekle";
            this.btnOgrEkle.UseVisualStyleBackColor = true;
            this.btnOgrEkle.Click += new System.EventHandler(this.btnOgrEkle_Click);
            // 
            // cmbHarfNotu
            // 
            this.cmbHarfNotu.FormattingEnabled = true;
            this.cmbHarfNotu.Items.AddRange(new object[] {
            "AA",
            "BA",
            "BB",
            "CB",
            "CC"});
            this.cmbHarfNotu.Location = new System.Drawing.Point(221, 103);
            this.cmbHarfNotu.Name = "cmbHarfNotu";
            this.cmbHarfNotu.Size = new System.Drawing.Size(121, 21);
            this.cmbHarfNotu.TabIndex = 14;
            this.cmbHarfNotu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbHarfNotu_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbOgrNo);
            this.groupBox2.Controls.Add(this.lblOgrNo);
            this.groupBox2.Controls.Add(this.tbOgrAdi);
            this.groupBox2.Controls.Add(this.tbOgrSoyadi);
            this.groupBox2.Controls.Add(this.lblOgrSoyadi);
            this.groupBox2.Controls.Add(this.lblOgrAdi);
            this.groupBox2.Location = new System.Drawing.Point(20, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 77);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci";
            // 
            // tbOgrNo
            // 
            this.tbOgrNo.Location = new System.Drawing.Point(82, 45);
            this.tbOgrNo.Name = "tbOgrNo";
            this.tbOgrNo.Size = new System.Drawing.Size(100, 20);
            this.tbOgrNo.TabIndex = 19;
            this.tbOgrNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOgrNo_KeyPress);
            // 
            // lblOgrNo
            // 
            this.lblOgrNo.AutoSize = true;
            this.lblOgrNo.Location = new System.Drawing.Point(25, 48);
            this.lblOgrNo.Name = "lblOgrNo";
            this.lblOgrNo.Size = new System.Drawing.Size(51, 13);
            this.lblOgrNo.TabIndex = 18;
            this.lblOgrNo.Text = "Numarası";
            // 
            // tbOgrAdi
            // 
            this.tbOgrAdi.Location = new System.Drawing.Point(82, 12);
            this.tbOgrAdi.Name = "tbOgrAdi";
            this.tbOgrAdi.Size = new System.Drawing.Size(100, 20);
            this.tbOgrAdi.TabIndex = 17;
            this.tbOgrAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOgrAdi_KeyPress);
            // 
            // tbOgrSoyadi
            // 
            this.tbOgrSoyadi.Location = new System.Drawing.Point(243, 16);
            this.tbOgrSoyadi.Name = "tbOgrSoyadi";
            this.tbOgrSoyadi.Size = new System.Drawing.Size(100, 20);
            this.tbOgrSoyadi.TabIndex = 16;
            this.tbOgrSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOgrSoyadi_KeyPress);
            // 
            // lblOgrSoyadi
            // 
            this.lblOgrSoyadi.AutoSize = true;
            this.lblOgrSoyadi.Location = new System.Drawing.Point(198, 19);
            this.lblOgrSoyadi.Name = "lblOgrSoyadi";
            this.lblOgrSoyadi.Size = new System.Drawing.Size(39, 13);
            this.lblOgrSoyadi.TabIndex = 15;
            this.lblOgrSoyadi.Text = "Soyadı";
            // 
            // lblOgrAdi
            // 
            this.lblOgrAdi.AutoSize = true;
            this.lblOgrAdi.Location = new System.Drawing.Point(25, 19);
            this.lblOgrAdi.Name = "lblOgrAdi";
            this.lblOgrAdi.Size = new System.Drawing.Size(22, 13);
            this.lblOgrAdi.TabIndex = 14;
            this.lblOgrAdi.Text = "Adı";
            // 
            // gbCinsiyet
            // 
            this.gbCinsiyet.Controls.Add(this.rbKız);
            this.gbCinsiyet.Controls.Add(this.rbErkek);
            this.gbCinsiyet.Location = new System.Drawing.Point(20, 103);
            this.gbCinsiyet.Name = "gbCinsiyet";
            this.gbCinsiyet.Size = new System.Drawing.Size(76, 75);
            this.gbCinsiyet.TabIndex = 10;
            this.gbCinsiyet.TabStop = false;
            this.gbCinsiyet.Text = "Cinsiyet";
            // 
            // rbKız
            // 
            this.rbKız.AutoSize = true;
            this.rbKız.Location = new System.Drawing.Point(6, 51);
            this.rbKız.Name = "rbKız";
            this.rbKız.Size = new System.Drawing.Size(39, 17);
            this.rbKız.TabIndex = 14;
            this.rbKız.TabStop = true;
            this.rbKız.Text = "Kız";
            this.rbKız.UseVisualStyleBackColor = true;
            this.rbKız.Click += new System.EventHandler(this.rbKız_Click);
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(6, 28);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 13;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            this.rbErkek.Click += new System.EventHandler(this.rbErkek_Click);
            // 
            // lblHarfNotu
            // 
            this.lblHarfNotu.AutoSize = true;
            this.lblHarfNotu.Location = new System.Drawing.Point(117, 106);
            this.lblHarfNotu.Name = "lblHarfNotu";
            this.lblHarfNotu.Size = new System.Drawing.Size(85, 13);
            this.lblHarfNotu.TabIndex = 8;
            this.lblHarfNotu.Text = "Başarı Harf Notu";
            // 
            // cbSinifTekrar
            // 
            this.cbSinifTekrar.AutoSize = true;
            this.cbSinifTekrar.Location = new System.Drawing.Point(120, 132);
            this.cbSinifTekrar.Name = "cbSinifTekrar";
            this.cbSinifTekrar.Size = new System.Drawing.Size(91, 17);
            this.cbSinifTekrar.TabIndex = 5;
            this.cbSinifTekrar.Text = "Sınıf Tekrarı ?";
            this.cbSinifTekrar.UseVisualStyleBackColor = true;
            // 
            // frmOgrEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(430, 240);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmOgrEkle";
            this.ShowIcon = false;
            this.Text = "frmOgrEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbCinsiyet.ResumeLayout(false);
            this.gbCinsiyet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHarfNotu;
        private System.Windows.Forms.CheckBox cbSinifTekrar;
        private System.Windows.Forms.GroupBox gbCinsiyet;
        private System.Windows.Forms.RadioButton rbKız;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbOgrAdi;
        private System.Windows.Forms.TextBox tbOgrSoyadi;
        private System.Windows.Forms.Label lblOgrSoyadi;
        private System.Windows.Forms.Label lblOgrAdi;
        private System.Windows.Forms.TextBox tbOgrNo;
        private System.Windows.Forms.Label lblOgrNo;
        private System.Windows.Forms.ComboBox cmbHarfNotu;
        private System.Windows.Forms.Button btnOgrEkle;

    }
}