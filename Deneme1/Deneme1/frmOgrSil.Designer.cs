namespace Deneme1
{
    partial class frmOgrSil
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
            this.gbOgrSil = new System.Windows.Forms.GroupBox();
            this.lvOgrSil = new System.Windows.Forms.ListView();
            this.clm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOgrNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOgrAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOgrSoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOgrHarf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOgrCinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOgrTekrar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brnSil = new System.Windows.Forms.Button();
            this.lnkSil = new System.Windows.Forms.LinkLabel();
            this.gbOgrSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOgrSil
            // 
            this.gbOgrSil.Controls.Add(this.lvOgrSil);
            this.gbOgrSil.Location = new System.Drawing.Point(5, 12);
            this.gbOgrSil.Name = "gbOgrSil";
            this.gbOgrSil.Size = new System.Drawing.Size(421, 186);
            this.gbOgrSil.TabIndex = 0;
            this.gbOgrSil.TabStop = false;
            this.gbOgrSil.Text = "Silme";
            this.gbOgrSil.Enter += new System.EventHandler(this.gbOgrSil_Enter);
            // 
            // lvOgrSil
            // 
            this.lvOgrSil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clm,
            this.clmOgrNo,
            this.clmOgrAdi,
            this.clmOgrSoyadi,
            this.clmOgrHarf,
            this.clmOgrCinsiyet,
            this.clmOgrTekrar});
            this.lvOgrSil.Location = new System.Drawing.Point(4, 19);
            this.lvOgrSil.Name = "lvOgrSil";
            this.lvOgrSil.Size = new System.Drawing.Size(409, 161);
            this.lvOgrSil.TabIndex = 1;
            this.lvOgrSil.UseCompatibleStateImageBehavior = false;
            this.lvOgrSil.View = System.Windows.Forms.View.Details;
            // 
            // clm
            // 
            this.clm.Text = "";
            this.clm.Width = 20;
            // 
            // clmOgrNo
            // 
            this.clmOgrNo.Text = "Öğr. No";
            // 
            // clmOgrAdi
            // 
            this.clmOgrAdi.Text = "Öğr. Adı";
            // 
            // clmOgrSoyadi
            // 
            this.clmOgrSoyadi.Text = "Öğr. Soyadı";
            this.clmOgrSoyadi.Width = 68;
            // 
            // clmOgrHarf
            // 
            this.clmOgrHarf.Text = "Harf Notu";
            // 
            // clmOgrCinsiyet
            // 
            this.clmOgrCinsiyet.Text = "Cinsiyeti";
            this.clmOgrCinsiyet.Width = 58;
            // 
            // clmOgrTekrar
            // 
            this.clmOgrTekrar.Text = "Sınıf Tekrarı ?";
            this.clmOgrTekrar.Width = 80;
            // 
            // brnSil
            // 
            this.brnSil.Location = new System.Drawing.Point(343, 205);
            this.brnSil.Name = "brnSil";
            this.brnSil.Size = new System.Drawing.Size(75, 23);
            this.brnSil.TabIndex = 1;
            this.brnSil.Text = "Sil";
            this.brnSil.UseVisualStyleBackColor = true;
            // 
            // lnkSil
            // 
            this.lnkSil.AutoSize = true;
            this.lnkSil.Location = new System.Drawing.Point(12, 210);
            this.lnkSil.Name = "lnkSil";
            this.lnkSil.Size = new System.Drawing.Size(68, 13);
            this.lnkSil.TabIndex = 2;
            this.lnkSil.TabStop = true;
            this.lnkSil.Text = "Tümünü Seç";
            this.lnkSil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSil_LinkClicked);
            // 
            // frmOgrSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 240);
            this.Controls.Add(this.lnkSil);
            this.Controls.Add(this.brnSil);
            this.Controls.Add(this.gbOgrSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOgrSil";
            this.ShowIcon = false;
            this.Text = "frmOgrSil";
            this.Load += new System.EventHandler(this.frmOgrSil_Load);
            this.gbOgrSil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOgrSil;
        private System.Windows.Forms.ListView lvOgrSil;
        private System.Windows.Forms.ColumnHeader clmOgrNo;
        private System.Windows.Forms.ColumnHeader clmOgrAdi;
        private System.Windows.Forms.ColumnHeader clmOgrSoyadi;
        private System.Windows.Forms.ColumnHeader clmOgrHarf;
        private System.Windows.Forms.ColumnHeader clmOgrCinsiyet;
        private System.Windows.Forms.ColumnHeader clmOgrTekrar;
        private System.Windows.Forms.ColumnHeader clm;
        private System.Windows.Forms.Button brnSil;
        private System.Windows.Forms.LinkLabel lnkSil;

    }
}