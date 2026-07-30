namespace Exercicios;

public class Circulo : IFormaGeometrica
{
    public decimal Raio { get; set; }

    public Circulo(decimal raio)
    {
        Raio = raio;
    }

    public decimal CalcularArea()
    {
        return 3.14m * Raio * Raio;
    }

    public decimal CalcularPerimetro()
    {
        return 2 * 3.14m * Raio;
    }
}
