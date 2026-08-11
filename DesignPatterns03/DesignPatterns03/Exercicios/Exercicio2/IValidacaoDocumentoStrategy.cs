namespace DesignPatterns03.Exercicios.Exercicio2;

public class IValidacaoDocumentoStrategy
{
    public bool EhValido(string numeroDocumento)
    {
        return !string.IsNullOrEmpty(numeroDocumento);
    }
}