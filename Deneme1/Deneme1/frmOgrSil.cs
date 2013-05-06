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
            foreach (ListViewItem item in lvOgrSil.CheckedItems)
            {
                foreach (Ogrenci ogr in Program.ogrenciler)
                {
                    if (ogr.OgrAdi == item.Text)
                        Program.ogrenciler.Remove(ogr);
                }
            }
        }

      

    }
}
