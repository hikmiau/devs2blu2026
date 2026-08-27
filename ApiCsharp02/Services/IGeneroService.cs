using Api02.Models;

namespace Api02.Services;

public interface IGeneroService
{
    Task<List<Genero>> ListarAsync();

    Task<Genero?> ObterPorIdAsync(int id);
    Task<Genero> CriarAsync(Genero genero);
    Task<bool> AtualizarAsync(int id, Genero genero);
    Task<bool> RemoverAsync(int id);
}
