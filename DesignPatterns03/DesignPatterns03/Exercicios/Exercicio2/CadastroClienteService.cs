namespace DesignPatterns03.Exercicios.Exercicio2;

public class CadastroClienteService
{
    private readonly IValidacaoDocumentoStrategy _validacaoDocumentoStrategy;

    public CadastroClienteService(IValidacaoDocumentoStrategy validacaoDocumentoStrategy)
    {
        _validacaoDocumentoStrategy = validacaoDocumentoStrategy;
    }

    public bool CadastrarCliente(string numeroDocumento)
    {
        return _validacaoDocumentoStrategy.EhValido(numeroDocumento);
    }
}