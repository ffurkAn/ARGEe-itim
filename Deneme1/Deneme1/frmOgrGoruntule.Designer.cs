namespace Deneme1
{
    partial class frmOgrGoruntule
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
            this.gbOgrGoruntule = new System.Windows.Forms.GroupBox();
            this.gvGoruntule = new System.Windows.Forms.DataGridView();
            this.clmNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHarf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTekrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbOgrGoruntule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGoruntule)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOgrGoruntule
            // 
            this.gbOgrGoruntule.Controls.Add(this.gvGoruntule);
            this.gbOgrGoruntule.Location = new System.Drawing.Point(12, 12);
            this.gbOgrGoruntule.Name = "gbOgrGoruntule";
            this.gbOgrGoruntule.Size = new System.Drawing.Size(406, 216);
            this.gbOgrGoruntule.TabIndex = 0;
            this.gbOgrGoruntule.TabStop = false;
            this.gbOgrGoruntule.Text = "Görüntüle";
            // 
            // gvGoruntule
            // 
            this.gvGoruntule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGoruntule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNo,
            this.clmAd,
            this.clmSoyad,
            this.clmHarf,
            this.clmCinsiyet,
            this.clmTekrar});
            this.gvGoruntule.Location = new System.Drawing.Point(6, 19);
            this.gvGoruntule.Name = "gvGoruntule";
            this.gvGoruntule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvGoruntule.Size = new System.Drawing.Size(394, 191);
            this.gvGoruntule.TabIndex = 0;
            this.gvGoruntule.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvGoruntule_MouseClick);
            // 
            // clmNo
            // 
            this.clmNo.HeaderText = "Öğr. No";
            this.clmNo.Name = "clmNo";
            this.clmNo.ReadOnly = true;
            // 
            // clmAd
            // 
            this.clmAd.HeaderText = "Öğr. Adi";
            this.clmAd.Name = "clmAd";
            this.clmAd.ReadOnly = true;
            // 
            // clmSoyad
            // 
            this.clmSoyad.HeaderText = "Öğr. Soyadı";
            this.clmSoyad.Name = "clmSoyad";
            // 
            // clmHarf
            // 
            this.clmHarf.HeaderText = "Öğr. Harf Notu";
            this.clmHarf.Name = "clmHarf";
            this.clmHarf.ReadOnly = true;
            // 
            // clmCinsiyet
            // 
            this.clmCinsiyet.HeaderText = "Öğr. Cinsiyet";
            this.clmCinsiyet.Name = "clmCinsiyet";
            this.clmCinsiyet.ReadOnly = true;
            // 
            // clmTekrar
            // 
            this.clmTekrar.HeaderText = "Sınıf Tekrarı";
            this.clmTekrar.Name = "clmTekrar";
            this.clmTekrar.ReadOnly = true;
            // 
            // frmOgrGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 240);
            this.Controls.Add(this.gbOgrGoruntule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOgrGoruntule";
            this.Text = "frmOgrGoruntule";
            this.Load += new System.EventHandler(this.frmOgrGoruntule_Load);
            this.gbOgrGoruntule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGoruntule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOgrGoruntule;
        private System.Windows.Forms.DataGridView gvGoruntule;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHarf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTekrar;
    }
}