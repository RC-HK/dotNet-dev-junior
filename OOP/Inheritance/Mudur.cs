namespace Inheritance;

public class Mudur: Personel
{
    private String _bolge;

    public string Bolge
    {
        get => _bolge;
        set => _bolge = value;
    }
    
    public Mudur(string bolge, int id, String ad, String soyad, double maas):this(id,ad,soyad,maas)
    {
        _bolge = bolge;
    }

    public Mudur(int id, String ad, String soyad, double maas):base(id,ad,soyad,maas)
    {
        
    }
}