namespace ArdenaSolucoes.Models;

public class Cliente
{
    public required string Cpf { get; set; }

    public required string NomeCompleto { get; set; }

    public required string Cep { get; set; }

    public required string Logradouro { get; set; }

    public required string Numero { get; set; }

    public string Complemento { get; set; } = string.Empty;

    public required string Bairro { get; set; }

    public required string Cidade { get; set; }

    public required string Estado { get; set; }
}
