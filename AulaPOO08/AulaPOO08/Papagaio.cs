namespace AulaPOO08;

public class Papagaio : Animal, IVoador
    
{
    public override void Comer()
    {
        Console.WriteLine("Comeu castanha");
    }

    public void LevantarVoo()
    {
        throw new NotImplementedException();
    }
}