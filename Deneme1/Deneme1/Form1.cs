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
            Ogrenci yeni = new Ogrenci();

                pblAna.Controls.Clear();
                switch (trvIslemler.SelectedNode.Name)
                {
                    case "Node0" :

                        frmOgrEkle f = new frmOgrEkle();
                        f.TopLevel = false;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                        pblAna.Controls.Add(f);

                        break;

                    case "Node1":                      
                        
                        frmOgrSil fSil = new frmOgrSil();
                        fSil.TopLevel = false;
                        fSil.Dock = DockStyle.Fill;
                        fSil.Show();
                        pblAna.Controls.Add(fSil);
                        break;

                    case "Node2":

                        frmOgrGoruntule fg = new frmOgrGoruntule();
                        fg.TopLevel = false;
                        fg.Dock = DockStyle.Fill;
                        fg.Show();
                        pblAna.Controls.Add(fg);

                        break;



                }
                pblAna.Refresh();
            }
        }

       
         
        

    }
