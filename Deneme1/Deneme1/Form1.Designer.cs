namespace Deneme1
{
    partial class frmDeneme
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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Öğrenci Ekle");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Öğrenci Sil");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Öğrencileri Görüntile");
            this.gbIslemMenusu = new System.Windows.Forms.GroupBox();
            this.trvIslemler = new System.Windows.Forms.TreeView();
            this.pblAna = new System.Windows.Forms.Panel();
            this.gbIslemMenusu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIslemMenusu
            // 
            this.gbIslemMenusu.Controls.Add(this.trvIslemler);
            this.gbIslemMenusu.Location = new System.Drawing.Point(12, 12);
            this.gbIslemMenusu.Name = "gbIslemMenusu";
            this.gbIslemMenusu.Size = new System.Drawing.Size(161, 98);
            this.gbIslemMenusu.TabIndex = 2;
            this.gbIslemMenusu.TabStop = false;
            this.gbIslemMenusu.Text = "İşlem Menüsü";
            // 
            // trvIslemler
            // 
            this.trvIslemler.Location = new System.Drawing.Point(6, 19);
            this.trvIslemler.Name = "trvIslemler";
            treeNode4.Name = "Node0";
            treeNode4.Tag = "0";
            treeNode4.Text = "Öğrenci Ekle";
            treeNode4.ToolTipText = "asdasdas";
            treeNode5.Name = "Node1";
            treeNode5.Tag = "1";
            treeNode5.Text = "Öğrenci Sil";
            treeNode6.Name = "Node2";
            treeNode6.Tag = "3";
            treeNode6.Text = "Öğrencileri Görüntile";
            this.trvIslemler.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.trvIslemler.Size = new System.Drawing.Size(143, 74);
            this.trvIslemler.TabIndex = 2;
            this.trvIslemler.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvIslemler_NodeMouseClick);
            // 
            // pblAna
            // 
            this.pblAna.Location = new System.Drawing.Point(179, 12);
            this.pblAna.Name = "pblAna";
            this.pblAna.Size = new System.Drawing.Size(447, 266);
            this.pblAna.TabIndex = 3;
            // 
            // frmDeneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 290);
            this.Controls.Add(this.pblAna);
            this.Controls.Add(this.gbIslemMenusu);
            this.Name = "frmDeneme";
            this.Text = "Deneme Formu";
         
            this.gbIslemMenusu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIslemMenusu;
        private System.Windows.Forms.TreeView trvIslemler;
        private System.Windows.Forms.Panel pblAna;

    }
}

