namespace DesignPatterns02.FactoryExercicios.Exercicio2;

public class TransportadoraAerea : ITransportadora
{
    public void CalcularPrazoEntrega(decimal distanciaKm)
    {
        decimal prazoEntrega = distanciaKm / 800; // Supondo que a velocidade média de um avião seja de 800 km/h
        Console.WriteLine($"Prazo de entrega por transporte aéreo: {prazoEntrega} horas");
    }
}