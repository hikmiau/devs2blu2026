using DesignPatterns03.Exercicios;

namespace DesignPatterns03;

public class FreteMotoboyStrategy : ICalculoFreteStrategy
{
    public ResultadoFrete Calcular(decimal pesoKg, string cepDestino)
    {
        var resultado = new ResultadoFrete();
        resultado.Valor = pesoKg * 15; 
        resultado.DiasPrazo = 1; 
        return resultado;
    }
}