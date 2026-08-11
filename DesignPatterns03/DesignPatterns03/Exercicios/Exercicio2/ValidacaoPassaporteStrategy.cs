namespace DesignPatterns03.Exercicios.Exercicio2;

public class ValidacaoPassaporteStrategy : IValidacaoDocumentoStrategy
{
    public bool EhValido(string numeroDocumento)
    {
        return !string.IsNullOrEmpty(numeroDocumento) && numeroDocumento.Length == 8;
    }
}