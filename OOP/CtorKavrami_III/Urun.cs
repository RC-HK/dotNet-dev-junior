public class Urun
{
    public string UrunAdi { get; set; }

    #region Nesne üretimini engellemek

    //Bir nesnenin üretilmesini engellemek için ctor'ın erişim belirleyicisi belirlenebilir! Örneğin private yapıldığı taktirde yalnızca tanımlandığı tip tarafından örneklenir.
    /*private Urun()
    {
        
    }*/

    #endregion
   

    public Urun()
    {
        //Aşağıda, ctor'ın çalıştıracağı kodları simüle etmeye çalıştık..Ctor benzer şekilde, başka işler de yapabilirdi. Örneğin veritabanına bağlantı açmak, sunucuya bağlanmak, dosya oluşturmak vs...
        Console.WriteLine("İşler");
        Console.WriteLine("İşler");
        Console.WriteLine("İşler");
        Console.WriteLine("İşler"); 
    }

    public Urun(string urunAd):this()
    {
        #region Kötü Programcı yaklaşımı

        /*Console.WriteLine("İşler");
        Console.WriteLine("İşler");
        Console.WriteLine("İşler");
        Console.WriteLine("İşler"); */

        #endregion 
        
        UrunAdi = urunAd;
        
        Console.WriteLine(UrunAdi);
    }
}