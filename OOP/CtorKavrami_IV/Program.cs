// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//var a1 = new A();

/*
var m1 = new Masa();
m1.Ad = "Metal Masa";
*/

var s1 = new Sandalye(4);
s1.Ad = "Ahşap Sandalye";

public class Esya
{
    public string Ad { get; set; }
    
    public Esya(bool durum)
    {
       Console.WriteLine("public Esya(bool durum)"); 
    }
}

public class Masa : Esya
{
    public Masa():base(true)
    {
        
    }
}

public class Sandalye : Esya
{
    public Sandalye():base(false)
    {
        Console.WriteLine("public Sandalye():base(false)");
    }

    public Sandalye(int ayakSayisi) : this()
    {
        Console.WriteLine("public Sandalye(int ayakSayisi) : this");
    }
}