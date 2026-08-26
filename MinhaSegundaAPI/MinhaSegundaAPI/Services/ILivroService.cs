using MinhaSegundaAPI.Models;

namespace MinhaSegundaAPI.Services;

public interface ILivroService
{
    Task<List<Livro>> ObterTodosAsync();
    Task<Livro?> ObterPorIdAsync(int id);
    Task<Livro> CriarAsync(Livro livro);
    Task AtualizarAsync(Livro livro);
    Task RemoverAsync(Livro livro);
}