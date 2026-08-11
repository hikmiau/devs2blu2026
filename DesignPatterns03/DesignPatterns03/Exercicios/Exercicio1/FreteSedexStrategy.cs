namespace DesignPatterns03.Exercicios;

public class FreteSedexStrategy : ICalculoFreteStrategy
{
    public ResultadoFrete Calcular(decimal pesoKg, string cepDestino)
    {
        var resultado = new ResultadoFrete();
        resultado.Valor = pesoKg * 10; 
        resultado.DiasPrazo = 3; 
        return resultado;
    }
}