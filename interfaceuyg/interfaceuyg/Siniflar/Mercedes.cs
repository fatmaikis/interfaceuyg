using interfaceuyg.Arayuz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceuyg.Siniflar
{
    public class Mercedes : IAracOzellikleri
    {
        public string Marka
        {
            get { return "BMV"; }
        }

        public string Model
        {
            get { return "3.40"; }
        }

        private int hiz;

        public int Hız
        {
            get { return hiz; }
            set { hiz = value; }
        }

        private int fiyat;

        public int Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }


        public double AracPuanı(double puan)
        {
            return puan * 3.6;
        }

        public int Gosterge(int deger)
        {
            return deger;
        }

        private int ozelFiyat;

        public int OzelFiyat
        {
            get { return ozelFiyat; }
            set { ozelFiyat = value; }
        }
        public string Bilgiler()
        {
            return $"Marka : {Marka} Model : {Model} Hız :{Hız} Fiyat :{Fiyat}  Gosterge :{Gosterge(300)} Ozel Fiyat : {ozelFiyat}";
        }
    }
}
