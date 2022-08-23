using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardSampleProject_OOP
{
    public class Kart
    {
        public int BankaAdi { get; set; }
        public int KartAdi { get; set; }
        public KartTuru KartTuru { get; set; }
        public int CVCKodu { get; set; }
        public void ParaCek(decimal tutar)
        {
            throw new NotImplementedException();
        }
        public void ParaYatirma(decimal tutar)
        {
            throw new NotImplementedException();
        }

    }
}
