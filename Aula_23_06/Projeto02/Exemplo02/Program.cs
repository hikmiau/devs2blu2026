namespace Exemplo02;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Qual o lado do quadrado? ");
        //Console.WriteLine(calcularAreaQuadrado(lado: double.Parse(Console.ReadLine())));
        //Console.WriteLine("Qual o raio do circulo?");
        //double raio = double.Parse(Console.ReadLine());
        //Console.WriteLine(calcularAreaCirculo(raio));
        //double lado = double.Parse(Console.ReadLine());
        //Console.WriteLine(calcularAreaQuadrado(lado));
        Console.WriteLine("Qual a area da base da piramide?");
        double areaBase = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual a altura da piramide?");
        double altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Volume: \n" + calcularVolumePiramide(areaBase, altura));
    }

    static double somar(double num1, double num2)
    {
        return num1 + num2;
    }

    static double calcularAreaQuadrado(double lado)
    {
        return lado * lado;
    }

    static double calcularAreaCirculo(double raio)
    {
        return MathF.PI * Math.Pow(raio, 2);
    }

    static double calcularVolumePiramide(double areaBase, double altura)
    {
        return (areaBase * altura)/3;
    }
}