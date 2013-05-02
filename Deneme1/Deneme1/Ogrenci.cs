using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deneme1
{
    class Ogrenci
    {
        private String ogrAdi, ogrSoyadi, ogrCinsiyet, ogrHarfNotu;

        public String OgrHarfNotu
        {
            get { return ogrHarfNotu; }
            set { ogrHarfNotu = value; }
        }

      
        private Int32 ogrNo;
        private bool sinifTekrari = false;

        public bool SinifTekrari
        {
            get { return sinifTekrari; }
            set { sinifTekrari = value; }
        }


        public String OgrSoyadi
        {
            get { return ogrSoyadi; }
            set { ogrSoyadi = value; }
        }

        public String OgrAdi
        {
            get { return ogrAdi; }
            set { ogrAdi = value; }
        }
        
        public Int32 OgrNo
        {
            get { return ogrNo; }
            set { ogrNo = value; }
        }

     

        public String OgrCinsiyet
        {
            get { return ogrCinsiyet; }
            set { ogrCinsiyet = value; }
        }
    }
}
