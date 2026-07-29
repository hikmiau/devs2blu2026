namespace AulaPOO08;

public class Tubarão : Animal, ICacador, INadador
{
    public override void Comer()
    {
        Console.WriteLine("Comeu peixe");
    }

    public void Caçar()
    {
        Console.WriteLine("Cacou o peixe");
    }

    public void Nadar()
    {
        Console.WriteLine("Nadou pra sempre");
    }
}