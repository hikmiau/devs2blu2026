namespace ArdenaSolucoes.Models;

public sealed class EnderecoCepDto
{
    public string Cep { get; init; } = string.Empty;

    public string Logradouro { get; init; } = string.Empty;

    public string Bairro { get; init; } = string.Empty;

    public string Cidade { get; init; } = string.Empty;

    public string Estado { get; init; } = string.Empty;

    public bool EnderecoEncontrado { get; init; }
}

