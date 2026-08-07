namespace DesignPatterns02.FactoryExercicios.Exercicio2;

public class TransportadoraMaritima : ITransportadora
{
    public void CalcularPrazoEntrega(decimal distanciaKm)
    {
        decimal prazo = distanciaKm / 100; // Exemplo de cálculo de prazo para transporte marítimo
        Console.WriteLine($"Prazo de entrega por transporte marítimo: {prazo} dias");
    }
}