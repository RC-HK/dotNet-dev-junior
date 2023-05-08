namespace Inheritance;

public class Asistant:Personel
{
    private int _mudurId;

    public int MudurId
    {
        get => _mudurId;
        set => _mudurId = value;
    }

    public Asistant(int mudurId):base()
    {
        MudurId = mudurId;
    }
}