namespace DesignPatterns03.Exercicios.Exercicio2;

public class ValidacaoCpfStrategy : IValidacaoDocumentoStrategy
{
    public bool EhValido(string numeroDocumento)
    {
        return !string.IsNullOrEmpty(numeroDocumento) && numeroDocumento.Length == 11;
    }
}