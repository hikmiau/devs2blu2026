namespace Exercicios;

public class Triangulo : IFormaGeometrica
{
    public decimal Base { get; set; }
    public decimal Altura { get; set; }
    public decimal Lado1 { get; set; }
    public decimal Lado2 { get; set; }
    public decimal Lado3 { get; set; }

    public Triangulo(decimal @base, decimal altura, decimal lado1, decimal lado2, decimal lado3)
    {
        Base = @base;
        Altura = altura;
        Lado1 = lado1;
        Lado2 = lado2;
        Lado3 = lado3;
    }

    public decimal CalcularArea()
    {
        return (Base * Altura) / 2;
    }

    public decimal CalcularPerimetro()
    {
        return Lado1 + Lado2 + Lado3;
    }
}
