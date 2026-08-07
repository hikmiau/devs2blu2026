namespace DesignPatterns02.FactoryExercicios.Exercicio2;

public class FabricaDeTransportadora
{
    public ITransportadora CriarTransportadora(string tipo)
    {
        return tipo switch
        {
            "aereo" => new TransportadoraAerea(),
            "rodoviario" => new TransportadoraRodoviaria(),
            "maritimo" => new TransportadoraMaritima(),
            _ => throw new ArgumentException("Tipo de transportadora não suportado")
        };
    }
}