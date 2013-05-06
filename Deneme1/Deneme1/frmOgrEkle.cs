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
        private Ogrenci o;  

        public frmOgrEkle()
        {
            InitializeComponent();
        }

        public frmOgrEkle(Ogrenci o)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.o = o;
            btnOgrEkle.Text = "Kapat";

            //bos alanların doldurulması

            btnOgrEkle.Click -= new EventHandler(btnOgrEkle_Click);
            btnOgrEkle.Click += new EventHandler(formKapat);

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
            yeniOgrenci.OgrNo = tbOgrNo.Text.ToString();
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

            yeniOgrenci.ogrEkle(yeniOgrenci);

            MessageBox.Show("Başarıyla Eklendi !", "!!!11!111", MessageBoxButtons.OK);

            foreach (Control c in Controls)
            {
                ResetControl(c);
            }
            
        }

        private void ResetControl(Control control)
        {
            if (control.HasChildren)
                foreach (var ctl in control.Controls)
                    ResetControl((Control)ctl);

            if (control is TextBox)
                control.ResetText();

            if (control is ComboBox)
                control.ResetText();

            if (control is CheckBox)
                ((CheckBox)control).Checked = false;

            if (control is RadioButton)
                ((RadioButton)control).Checked = false;
            
           
        }

        private void cmbHarfNotu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void formKapat(object sender, EventArgs e)
        { 
        
        }
      
    }
}
