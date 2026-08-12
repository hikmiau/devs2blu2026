namespace DesignPatterns05.Exercicios.Exercicio3;

public class CensurarPalavrasDecorator : IFormatadorTexto
{
    private IFormatadorTexto _formatador;
    public List<string>  _palavrasCensuradas;

    public CensurarPalavrasDecorator(IFormatadorTexto formatador, string[] palavrasCensuradas)
    {
        _formatador = formatador;
        _palavrasCensuradas = new List<string>(palavrasCensuradas);
        AdicionarCensura("ruim");
    }

    public string Formatar(string texto)
    {
        var textoFormatado = _formatador.Formatar(texto);

        foreach (var palavra in _palavrasCensuradas)
        {
            textoFormatado = textoFormatado.Replace(palavra, new string('*', palavra.Length));
        }

        return textoFormatado;
    }
    
    public void AdicionarCensura(string palavra)
    {
        _palavrasCensuradas.Add(palavra);
    }
}