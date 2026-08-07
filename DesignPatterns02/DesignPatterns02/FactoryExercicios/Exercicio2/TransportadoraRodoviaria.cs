namespace DesignPatterns02.FactoryExercicios.Exercicio2;

public class TransportadoraRodoviaria : ITransportadora
{
    public void CalcularPrazoEntrega(decimal distanciaKm)
    {
        decimal prazoEntrega = distanciaKm / 500; // Supondo que a transportadora percorre 500 km por dia
        Console.WriteLine($"Prazo de entrega rodoviária: {prazoEntrega} dias");
    }
}