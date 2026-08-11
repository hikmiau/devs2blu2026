namespace DesignPatterns03;

public class PizzaBuilder
{
    private string _massa;
    private string _molho;
    private string _queijo;
    private List<string> _coberturas = new List<string>();
    private bool _bordaRecheada;

    public PizzaBuilder ComMassa(string massa)
    {
        _massa = massa;
        return this;
    }

    public PizzaBuilder ComMolho(string molho)
    {
        _molho = molho;
        return this;
    }

    public PizzaBuilder ComQueijo(string queijo)
    {
        _queijo = queijo;
        return this;
    }

    public PizzaBuilder AdicionarCobertura(string cobertura)
    {
        _coberturas.Add(cobertura);
        return this;
    }

    public PizzaBuilder ComBordaRecheada(bool bordaRecheada)
    {
        _bordaRecheada = bordaRecheada;
        return this;
    }

    public Pizza Build()
    {
        if (string.IsNullOrEmpty(_massa))
        {
            throw new ArgumentException("PizzaBuilder: No massa");
        }
        return new Pizza(_massa, _molho, _queijo, _coberturas, _bordaRecheada);
    }
}    
