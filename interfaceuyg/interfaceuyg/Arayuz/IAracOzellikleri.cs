using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceuyg.Arayuz
{
    public interface IAracOzellikleri
    {
        string Marka { get; }
        string Model { get; }
        int Hız { get; set; }
        int Fiyat { get; set; }
        int Gosterge(int deger);
        string Bilgiler();
    }
}
