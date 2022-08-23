namespace CreditCardSampleProject_OOP
{
    public interface IEkstra
    {
        bool EkKartMi { get; set; }
        DateTime SonKullanımTarihi { get; set; }
        void BorcOde(decimal tutar);
    }
}
