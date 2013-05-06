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
            Ogrenci y = new Ogrenci();

            //List<Ogrenci> c = y.tumOgrenciler();
            //BindingListView<Customer> view = new BindingListView<Customer>(customers);
            gvGoruntule.DataSource = y.tumOgrenciler();


           gvGoruntule.Refresh();
        }

        private void gvGoruntule_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult sonuc;
              String tekrar;

            Ogrenci o = new Ogrenci();
            o.OgrAdi = gvGoruntule.SelectedRows[0].Cells[0].ToString();
            o.OgrSoyadi = gvGoruntule.SelectedRows[0].Cells[1].ToString();
            o.OgrNo = gvGoruntule.SelectedRows[0].Cells[2].ToString();
            o.OgrHarfNotu = gvGoruntule.SelectedRows[0].Cells[3].ToString();
            o.OgrCinsiyet = gvGoruntule.SelectedRows[0].Cells[4].ToString();

            if (gvGoruntule.SelectedRows[0].Cells[5].ToString() == "Evet")
                tekrar = "evet";
            else
                tekrar = "hayır";


            sonuc = MessageBox.Show(o.OgrAdi + " " + o.OgrSoyadi + "\n" + o.OgrNo + "\n" + o.OgrHarfNotu + "\n" + o.OgrCinsiyet + "\n"+tekrar, "Öğrenci Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }

            
        }

        
    }
}
