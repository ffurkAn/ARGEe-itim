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

                        //frmOgrSil fSil = new frmOgrSil();
                        //fSil.TopLevel = false;
                        //fSil.Dock = DockStyle.Fill;
                        //fSil.Show();
                        //pblAna.Controls.Add(fSil);
                        break;

                    case "Node1":
                        //pblAna.Controls.Clear();
                        frmOgrSil fSil = new frmOgrSil();
                        fSil.TopLevel = false;
                        fSil.Dock = DockStyle.Fill;
                        fSil.Show();
                        pblAna.Controls.Add(fSil);
                        break;

                    case "Node2":
                        break;



                }
                pblAna.Refresh();
            }
        }

       
        //private void trvIslemler_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        //{

        //    Ogrenci yeni = new Ogrenci();

        //    pblAna.Controls.Clear();
        //    switch (trvIslemler.SelectedNode.Name)
        //    {
        //        case "Node0" :

                   
        //            frmOgrEkle f = new frmOgrEkle();
        //            f.TopLevel = false;
        //            f.Dock = DockStyle.Fill;
        //            f.Show();
        //            pblAna.Controls.Add(f);

        //            //frmOgrSil fSil = new frmOgrSil();
        //            //fSil.TopLevel = false;
        //            //fSil.Dock = DockStyle.Fill;
        //            //fSil.Show();
        //            //pblAna.Controls.Add(fSil);
        //            break;

        //        case "Node1":
        //            //pblAna.Controls.Clear();
        //            frmOgrSil fSil = new frmOgrSil();
        //            fSil.TopLevel = false;
        //            fSil.Dock = DockStyle.Fill;
        //            fSil.Show();
        //            pblAna.Controls.Add(fSil);
        //            break;

        //        case "Node2":
        //            break;



        //    }
        //    pblAna.Refresh();
        //}

       
        

    }
