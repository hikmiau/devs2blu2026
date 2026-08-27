using Api02.Models;
using Api02.Repoositories;

namespace Api02.Services;

public class GeneroService : IGeneroService
{
    private readonly IGeneroRepository _repository;

    public GeneroService(IGeneroRepository repository)
    {
        this._repository = repository;
    }

    public async Task<bool> AtualizarAsync(int id, Genero genero)
    {
        var existente = await _repository.ObterPorIdAsync(id);
        if (existente is null)
            return false;

        existente.Nome = genero.Nome;
        await _repository.AtualizarAsync(existente);
        return true;
    }

    public async Task<Genero> CriarAsync(Genero genero)
    {
        await _repository.AdicionarAsync(genero);
        return genero;
    }

    public Task<List<Genero>> ListarAsync()
    {
        return _repository.ObterTodosAsync();
    }

    public Task<Genero?> ObterPorIdAsync(int id)
    {
        return _repository.ObterPorIdAsync(id);
    }

    public async Task<bool> RemoverAsync(int id)
    {
        var genero = await _repository.ObterPorIdAsync(id);
        if (genero is null)
            return false;

        await _repository.RemoverAsync(genero);
        return true;
    }
}
