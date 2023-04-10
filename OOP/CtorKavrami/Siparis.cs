namespace CtorKavrami;

public class Siparis
{
    //Field : Tipin niteliklerini sakladığımız alanlardır
    public string UrunAdi;
    
    //Prop
    public int SiparisID { get; set; }
    public string Adres { get; set; }
    public short Adet{ get; set; }
    public DateTime Tarih { get; set; }
    
    //Ctor özel bir metottur!
    //Ctor üyesinin adı tiple aynı olmak zorundadır!
    //Ctor metodun (Yapıcı Metot) geri dönüş tipi bildirilemez! Otomatik olarak void olur...
    //Ctor metodu, nesne kullanıcısı istediği anda direkt olarak çağıramaz!
    //Ctor metot özel bir metottur! ve nesnenin üretilmesi sırasında otomatik olarak çağrısı yapılır!
    //Ctor, bir nesne örneği için yalnızca bir defa çalışabilir!
    //Bir nesnenin örneklenebilmesi için ctor çağrılmak ZORUNDADIR!
    public Siparis()
    {
        Adres = "Kadıköy";
        
        Console.WriteLine("Ctor metodu çalıştı");
    }
    
    //Metot
    public void Test()
    {
        Console.WriteLine("Test çalıştı...");
    }
}