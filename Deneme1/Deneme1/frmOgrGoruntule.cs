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
    }
}
