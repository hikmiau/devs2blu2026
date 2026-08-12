namespace DesignPatterns05.Exercicios.Exercicio3;

public class CaixaAltaDecorator : IFormatadorTexto
{
    private IFormatadorTexto _formatador;

    public CaixaAltaDecorator(IFormatadorTexto formatador)
    {
        _formatador = formatador;
    }

    public string Formatar(string texto)
    {
        return _formatador.Formatar(texto).ToUpper();
    }
}