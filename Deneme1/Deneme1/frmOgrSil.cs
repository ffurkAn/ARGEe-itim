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
    public partial class frmOgrSil : Form
    {
        public frmOgrSil()
        {
            InitializeComponent();
        }

        private void frmOgrSil_Load(object sender, EventArgs e)
        {
            lvOgrSil_Refresh();
        }

        private void lvOgrSil_Refresh()
        {
            

            lvOgrSil.CheckBoxes = true;


            foreach (Ogrenci o in Program.ogrenciler)
            {
                ListViewItem item = new ListViewItem(o.OgrNo);
                item.SubItems.Add(o.OgrNo);
                item.SubItems.Add(o.OgrAdi);
                item.SubItems.Add(o.OgrSoyadi);
                item.SubItems.Add(o.OgrHarfNotu);
                item.SubItems.Add(o.OgrCinsiyet);
                if (o.SinifTekrari == true)
                    item.SubItems.Add("Evet");
                else
                    item.SubItems.Add("Hayır");


                lvOgrSil.Items.Add(item);
            }
        }

        private void lnkSil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach ( ListViewItem lvit in lvOgrSil.Items)
            {
                lvit.Checked = true;
            }
        }

        private void brnSil_Click(object sender, EventArgs e)
        {
            List<Ogrenci> silinecekler = new List<Ogrenci>();

            foreach (ListViewItem item in lvOgrSil.CheckedItems)
            {
                
                foreach (Ogrenci ogr in Program.ogrenciler)
                {
                    if (ogr.OgrNo == item.Text.ToString())
                    {
                       silinecekler.Add(ogr);
                       lvOgrSil.Items.Remove(item); 
                    }
                }
            }

           
             
                foreach (Ogrenci del in silinecekler)
                {
                    Program.ogrenciler.Remove(del);
                    
                }


            if (silinecekler.Count!=0)
                MessageBox.Show("Öğrenci kaydı silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            silinecekler.Clear();

           
        }


      

    }
}
