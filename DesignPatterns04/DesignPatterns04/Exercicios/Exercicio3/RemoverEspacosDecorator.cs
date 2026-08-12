namespace DesignPatterns05.Exercicios.Exercicio3;

public class RemoverEspacosDecorator : IFormatadorTexto
{
    private IFormatadorTexto _formatador;

    public RemoverEspacosDecorator(IFormatadorTexto formatador)
    {
        _formatador = formatador;
    }

    public string Formatar(string texto)
    {
        return _formatador.Formatar(texto).Replace(" ", "");
    }
}