using DesignPatterns03.Exercicios;

namespace DesignPatterns03;

public class CalculadoraFreteService
{
    public ResultadoFrete CalcularFrete(decimal pesoKg, string cepDestino, ICalculoFreteStrategy strategy)
    {
        return strategy.Calcular(pesoKg, cepDestino);
    }
}