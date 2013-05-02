using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Deneme1
{
    public partial class frmDeneme : Form
    {
        public frmDeneme()
        {
            InitializeComponent();
        }

        private void trvIslemler_AfterSelect(object sender, TreeViewEventArgs e)
        {

              //TreeNode newNode = new TreeNode("Windows");
              //trvIslemler.Nodes.Add(treeNode);

            switch (trvIslemler.SelectedNode.Index)
            {
                case 0 :
                    frmOgrEkle f = new frmOgrEkle();
                     f.TopLevel = false;
                     f.Dock = DockStyle.Fill;    
                     f.Show();                   
                     pblAna.Controls.Add(f);

                    break;

                case 1 :
                    break;

                case 2 :
                    break;



            }
        }
    }
}
