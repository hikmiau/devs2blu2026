namespace AulaPOO08;

public class Pinguim : Animal, ICacador, INadador
{
    public override void Comer()
    {
        Console.WriteLine("Comeu Peixe");
    }

    public void Caçar()
    {
        Console.WriteLine("Pinguim correu atras do bicho");
    }

    public void Nadar()
    {
        Console.WriteLine("Pinguim mergulhou");
    }
}