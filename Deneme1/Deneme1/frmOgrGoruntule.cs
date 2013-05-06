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
    public partial class frmOgrGoruntule : Form
    {
        public frmOgrGoruntule()
        {
            InitializeComponent();
        }

        private void frmOgrGoruntule_Load(object sender, EventArgs e)
        {           
            gvGoruntule.DataSource = Program.ogrenciler;
            gvGoruntule.Refresh();

            gvGoruntule.Columns["ogrAdi"].DisplayIndex = 0;
            gvGoruntule.Columns["ogrSoyadi"].DisplayIndex = 1;
            gvGoruntule.Columns["ogrNo"].DisplayIndex = 2;
            gvGoruntule.Columns["ogrHarfNotu"].DisplayIndex = 3;
            gvGoruntule.Columns["ogrCinsiyet"].DisplayIndex = 4;
            gvGoruntule.Columns["sinifTekrari"].DisplayIndex = 5;
        }

        private void gvGoruntule_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult sonuc;
              String tekrar;

            Ogrenci o = new Ogrenci();
            o.OgrAdi = gvGoruntule.SelectedRows[0].Cells[0].Value.ToString();
            o.OgrSoyadi = gvGoruntule.SelectedRows[0].Cells[1].Value.ToString();
            o.OgrNo = gvGoruntule.SelectedRows[0].Cells[2].Value.ToString();
            o.OgrHarfNotu = gvGoruntule.SelectedRows[0].Cells[3].Value.ToString();
            o.OgrCinsiyet = gvGoruntule.SelectedRows[0].Cells[4].Value.ToString();

            if (gvGoruntule.SelectedRows[0].Cells[5].ToString() == "Evet")
                tekrar = "evet";
            else
                tekrar = "hayır";


            frmOgrEkle fg = new frmOgrEkle(o);
            
            sonuc = fg.ShowDialog();

            if (sonuc == DialogResult.Yes)
            {
                
            }
           

                
                
                //MessageBox.Show(o.OgrAdi.ToString() + " " 
                //+ o.OgrSoyadi.ToString() + "\n" + o.OgrNo.ToString() 
                //+ "\n" + o.OgrHarfNotu.ToString() + "\n" + o.OgrCinsiyet.ToString() 
                //+ "\n" + tekrar, "Öğrenci Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        
    }
}
