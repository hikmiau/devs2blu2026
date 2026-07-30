namespace Exercicios;

public class Retangulo : IFormaGeometrica
{
    public decimal Largura { get; set; }
    public decimal Altura { get; set; }

    public Retangulo(decimal largura, decimal altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public decimal CalcularArea()
    {
        return Largura * Altura;
    }

    public decimal CalcularPerimetro()
    {
        return (Largura * 2) + (Altura * 2);
    }
}
