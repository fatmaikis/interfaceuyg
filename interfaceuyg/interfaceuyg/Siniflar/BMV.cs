using interfaceuyg.Arayuz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace interfaceuyg.Siniflar
{
    public class BMV : IAracOzellikleri, IAracPuan
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

       
        public  string Bilgiler()
        {
            return $"Marka : {Marka} Model : {Model} Fiyat :{Fiyat} Hız :{Hız} Gosterge :{Gosterge(300)} Arac Puanı :{AracPuanı(2000)}";
        }

      
    }
}
