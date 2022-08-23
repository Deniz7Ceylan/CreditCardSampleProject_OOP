using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardSampleProject_OOP
{
    public class BankamatikKarti : Kart,IHavale
    {
        public HesapTuru HesapTuru { get; set; }
        public decimal Bakiye { get; set; }

        public void HavaleGonder(string iban, decimal tutar)
        {
            throw new NotImplementedException();
        }

        public void LimitTanimla(decimal tutar)
        {

        }

    }
}
