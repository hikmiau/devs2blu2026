using System.Collections.Concurrent;

namespace LivrosApi;

/// <summary>Armazenamento em memória (some ao reiniciar a aplicação).</summary>
public class LivroStore
{
    private readonly ConcurrentDictionary<string, Livro> _livros = new();

    public LivroStore()
    {
        // Dados de exemplo para facilitar os testes do agente
        Adicionar(new Livro
        {
            Isbn = "9780132350884", Titulo = "Clean Code", Subtitulo = "A Handbook of Agile Software Craftsmanship",
            Autores = { "Robert C. Martin" }, Editora = "Prentice Hall", AnoPublicacao = 2008, Edicao = 1,
            NumeroPaginas = 464, Idioma = "Inglês", Genero = "Programação",
            Sinopse = "Boas práticas para escrever código limpo.", Preco = 189.90m, Estoque = 5
        });
        Adicionar(new Livro
        {
            Isbn = "9780201633610", Titulo = "Design Patterns", Subtitulo = "Elements of Reusable Object-Oriented Software",
            Autores = { "Erich Gamma", "Richard Helm", "Ralph Johnson", "John Vlissides" }, Editora = "Addison-Wesley",
            AnoPublicacao = 1994, Edicao = 1, NumeroPaginas = 416, Idioma = "Inglês", Genero = "Programação",
            Sinopse = "Catálogo clássico de padrões de projeto orientados a objetos.", Preco = 210.00m, Estoque = 0
        });
    }

    public IEnumerable<Livro> Listar(string? titulo, string? autor, string? genero, string? editora, bool? disponivel)
    {
        var q = _livros.Values.AsEnumerable();
        if (!string.IsNullOrWhiteSpace(titulo))
            q = q.Where(l => l.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase));
        if (!string.IsNullOrWhiteSpace(autor))
            q = q.Where(l => l.Autores.Any(a => a.Contains(autor, StringComparison.OrdinalIgnoreCase)));
        if (!string.IsNullOrWhiteSpace(genero))
            q = q.Where(l => l.Genero.Contains(genero, StringComparison.OrdinalIgnoreCase));
        if (!string.IsNullOrWhiteSpace(editora))
            q = q.Where(l => l.Editora.Contains(editora, StringComparison.OrdinalIgnoreCase));
        if (disponivel.HasValue)
            q = q.Where(l => l.Disponivel == disponivel.Value);
        return q.OrderBy(l => l.Titulo).ToList();
    }

    public Livro? Obter(string isbn) => _livros.GetValueOrDefault(isbn);

    public bool Adicionar(Livro livro)
    {
        livro.DataCadastro = DateTime.UtcNow;
        livro.Disponivel = livro.Estoque > 0;
        return _livros.TryAdd(livro.Isbn, livro);
    }

    public bool Atualizar(string isbn, Livro novo)
    {
        if (!_livros.TryGetValue(isbn, out var atual)) return false;
        novo.Isbn = isbn;
        novo.DataCadastro = atual.DataCadastro;
        novo.Disponivel = novo.Estoque > 0;
        _livros[isbn] = novo;
        return true;
    }

    public bool Remover(string isbn) => _livros.TryRemove(isbn, out _);
}
