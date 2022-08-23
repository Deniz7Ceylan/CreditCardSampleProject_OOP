using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardSampleProject_OOP
{
    public class KKPlatin : Kart, IHavale, IPuan, IEkstra, IEft
    {
        public bool ClubUyeligiVarMİ { get; set; }
        public DateTime UyelikBaslangicTarihi { get; set; }
        public DateTime UyelikBitisTarihi { get; set; }
        public decimal KazanilanPuan { get; set; }
        public bool EkKartMi { get; set; }
        public DateTime SonKullanımTarihi { get; set; }

        public void BorcOde(decimal tutar)
        {
            throw new NotImplementedException();
        }

        public void HavaleGonder(string iban, decimal tutar)
        {
            throw new NotImplementedException();
        }

        public void UyeligiYenile()
        {
            throw new NotImplementedException();
        }
        public void UyeligiBitir()
        {
            throw new NotImplementedException();
        }

        public void EftGonder(string iban, decimal tutar)
        {
            throw new NotImplementedException();
        }
    }
}
