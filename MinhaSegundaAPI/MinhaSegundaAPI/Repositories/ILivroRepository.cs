using MinhaSegundaAPI.Models;

namespace MinhaSegundaAPI.Repositories;

public interface ILivroRepository
{
    Task<List<Livro>> ObterTodosAsync();
    Task<Livro?> ObterPorIdAsync(int id);
    Task AdicionarAsync(Livro livro);
    Task AtualizarAsync(Livro livro);
    Task RemoverAsync(Livro livro);
}