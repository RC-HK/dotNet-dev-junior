namespace Inheritance;

public class Personel
{
    private int _id;
    private String _ad;
    private String _soyad;
    private double _maas;

    public int Id
    {
        get { return _id;}
        set { _id = value; }
    }

    public String Ad
    {
        get { return _ad; }
        set { _ad = value; }
    }

    public String Soyad
    {
        get
        {
            return _soyad;
        }
        set
        {
            _soyad = value;
        }
    }

    public double Maas
    {
        get { return _maas; }
        set { _maas = value; }
    }
    

    public Personel(int id,String ad, String soyad, double maas)
    {
        Id = id;
        Ad = ad;
        Soyad = soyad;
        Maas = maas;
    }

    public Personel()
    {
        
    }

    //destructor
    ~Personel()
    {
        
    }
}