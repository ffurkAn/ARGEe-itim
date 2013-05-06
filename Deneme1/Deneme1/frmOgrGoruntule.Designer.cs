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
            this.gvGoruntule.Location = new System.Drawing.Point(6, 19);
            this.gvGoruntule.Name = "gvGoruntule";
            this.gvGoruntule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvGoruntule.Size = new System.Drawing.Size(394, 191);
            this.gvGoruntule.TabIndex = 0;
            this.gvGoruntule.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvGoruntule_MouseClick);
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
    }
}