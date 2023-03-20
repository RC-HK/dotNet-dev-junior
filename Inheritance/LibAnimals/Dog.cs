namespace LibAnimals;

public class Dog
{
    public string Name { get; set; }

    public string Age { get; set; }

    public void MakeSound()
    {   
        Console.WriteLine("Bark!"); 
    }
}