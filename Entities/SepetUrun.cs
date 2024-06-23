using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvanterYönetimSistemi.Entities
{
    public class SepetUrun
    {
        public string UrunAd { get; set; }
        public int Adet { get; set; }
        public decimal ToplamFiyat { get; set; }
        public int MusteriID { get; set; }
    }
}
