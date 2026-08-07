namespace DesignPatterns02.FactoryExercicios.Exercicio1;

public class FabricaDePagamento
{
    public IFormaPagamento CriarFormaPagamento(string tipo)
    {
        return tipo switch
        {
            "boleto" => new Boleto(),
            "cartao" => new Cartao(),
            "pix" => new Pix(),
            _ => throw new ArgumentException("Tipo de pagamento não suportado")
        };
    }
}