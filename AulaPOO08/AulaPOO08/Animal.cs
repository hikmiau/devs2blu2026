namespace AulaPOO08;

public abstract class Animal
{
    public string Nome { get; set; }
    public string Especie { get; set; }
    
    public abstract void Comer();
}