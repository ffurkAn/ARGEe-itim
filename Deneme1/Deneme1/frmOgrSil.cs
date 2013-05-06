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
           
            lvOgrSil.CheckBoxes = true;
            
            //Ogrenci ogr = new Ogrenci();
            //List<Ogrenci> ogrenciler = new List<Ogrenci>();


            //ogrenciler = ogr.tumOgrenciler();

            //foreach (Ogrenci o in ogrenciler)
            //{
            //    ListViewItem item = new ListViewItem(ogr.OgrNo);
            //    item.SubItems.Add(ogr.OgrAdi);
            //    item.SubItems.Add(ogr.OgrSoyadi);
            //    item.SubItems.Add(ogr.OgrHarfNotu);
            //    item.SubItems.Add(ogr.OgrCinsiyet);
            //    if(ogr.SinifTekrari == true)
            //        item.SubItems.Add("Evet");
            //    else
            //        item.SubItems.Add("Hayır");
               

            //    lvOgrSil.Items.Add(item);
            //}

            ListViewItem item = new ListViewItem("051654");
            item.SubItems.Add("furkan");
            item.SubItems.Add("asfdsafd");
            item.SubItems.Add("AA");
            item.SubItems.Add("erkek");
            item.SubItems.Add("Hayır");


            lvOgrSil.Items.Add(item);
            
        }

      
      

    }
}
