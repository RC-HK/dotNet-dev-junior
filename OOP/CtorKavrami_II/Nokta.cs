namespace CtorKavrami_II;

public class Nokta
{
    public int X;
    public int Y;

    //Programcı hiçbir ctor yazmazsa derleyici otomatik olarak bir ctor yazar. Programcının en az bir ctor yazması durumda artık otomatik olarak başka bir ctor YA-ZIL-MAZ!
    public Nokta()
    {
        Console.WriteLine("Ctor - 1. çalıştı..."); 
    }

    public Nokta(int x, int y)
    {
        X = x;
        Y = y;
        
        Console.WriteLine("Ctor - 2. çalıştı...");  
    }
}