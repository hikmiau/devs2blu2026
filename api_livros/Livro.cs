using System.ComponentModel;

namespace LivrosApi;

[Description("Livro do acervo")]
public class Livro
{
    [Description("ISBN-10 ou ISBN-13 (com ou sem hifens). Identificador único do livro.")]
    public string Isbn { get; set; } = "";

    [Description("Título do livro")]
    public string Titulo { get; set; } = "";

    [Description("Subtítulo (opcional)")]
    public string? Subtitulo { get; set; }

    [Description("Lista de autores")]
    public List<string> Autores { get; set; } = new();

    [Description("Editora")]
    public string Editora { get; set; } = "";

    [Description("Ano de publicação")]
    public int AnoPublicacao { get; set; }

    [Description("Número da edição")]
    public int Edicao { get; set; } = 1;

    [Description("Número de páginas")]
    public int NumeroPaginas { get; set; }

    [Description("Idioma, ex.: Português, Inglês")]
    public string Idioma { get; set; } = "Português";

    [Description("Gênero ou categoria, ex.: Programação, Ficção")]
    public string Genero { get; set; } = "";

    [Description("Sinopse (opcional)")]
    public string? Sinopse { get; set; }

    [Description("Preço em reais (BRL)")]
    public decimal Preco { get; set; }

    [Description("Quantidade em estoque")]
    public int Estoque { get; set; }

    [Description("Indica se há exemplares disponíveis (calculado a partir do estoque)")]
    public bool Disponivel { get; set; }

    [Description("Data de cadastro (preenchida pela API)")]
    public DateTime DataCadastro { get; set; }
}

public record ErroResposta(string Erro);
