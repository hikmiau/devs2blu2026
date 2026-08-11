using DesignPatterns03.Exercicios;

namespace DesignPatterns03;

public class FreteTransportadorStrategy : ICalculoFreteStrategy
{
    public ResultadoFrete Calcular(decimal pesoKg, string cepDestino)
    {
        var resultado = new ResultadoFrete();
        resultado.Valor = pesoKg * 20;
        resultado.DiasPrazo = 5; 
        return resultado;
    }
}