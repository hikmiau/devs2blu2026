namespace DesignPatterns03.Exercicios.Exercicio2;

public class ValidacaoCnpjStrategy : IValidacaoDocumentoStrategy
{
    public bool EhValido(string numeroDocumento)
    {
        return !string.IsNullOrEmpty(numeroDocumento) && numeroDocumento.Length == 14;
    }
}