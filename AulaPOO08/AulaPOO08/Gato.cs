namespace AulaPOO08;

public class Gato : Animal, ICacador, INadador
{
    public override void Comer()
    {
        Console.WriteLine("Comeu peixe");
    }

    public void Caçar()
    {
        Console.WriteLine("Gato correu atras do bicho");
    }

    public void Nadar()
    {
        Console.WriteLine("Gato nadou");
    }
}