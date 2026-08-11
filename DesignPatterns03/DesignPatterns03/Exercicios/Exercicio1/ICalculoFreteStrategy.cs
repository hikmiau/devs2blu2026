namespace DesignPatterns03.Exercicios;

public interface ICalculoFreteStrategy
{
    ResultadoFrete Calcular(decimal pesoKg, string cepDestino);
}