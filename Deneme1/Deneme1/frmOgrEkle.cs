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
    public partial class frmOgrEkle : Form
    {
        public frmOgrEkle()
        {
            InitializeComponent();
        }

        private void tbOgrAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
          
                
        }

        private void tbOgrNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
            
        }

        private void tbOgrSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void rbKız_Click(object sender, EventArgs e)
        {
            rbErkek.Checked = false;
        }

        private void rbErkek_Click(object sender, EventArgs e)
        {
            rbKız.Checked = false;
        }

        private void btnOgrEkle_Click(object sender, EventArgs e)
        {
            Ogrenci yeniOgrenci = new Ogrenci();
            yeniOgrenci.OgrAdi = tbOgrAdi.Text.ToString();
            yeniOgrenci.OgrSoyadi = tbOgrSoyadi.Text.ToString();
            yeniOgrenci.OgrNo = Convert.ToInt32(tbOgrNo.Text);
            yeniOgrenci.OgrHarfNotu = cmbHarfNotu.SelectedItem.ToString();

            if (cbSinifTekrar.Checked)
                yeniOgrenci.SinifTekrari = true;
            else
                yeniOgrenci.SinifTekrari = false;

            if (rbKız.Checked)
            {
                yeniOgrenci.OgrCinsiyet = "Kız";
            }

            else if(rbErkek.Checked)
            {
                yeniOgrenci.OgrCinsiyet = "Erkek";
            }
        }

        private void cmbHarfNotu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


      

      
    }
}
