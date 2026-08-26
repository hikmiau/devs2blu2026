namespace MinhaSegundaAPI.Services;

using MinhaSegundaAPI.Models;
using MinhaSegundaAPI.Repositories;

public class LivroService : ILivroService
{
    private readonly ILivroRepository _livroRepository;

    public LivroService(ILivroRepository livroRepository)
    {
        _livroRepository = livroRepository;
    }

    public async Task<List<Livro>> ObterTodosAsync()
    {
        return await _livroRepository.ObterTodosAsync();
    }

    public async Task<Livro?> ObterPorIdAsync(int id)
    {
        return await _livroRepository.ObterPorIdAsync(id);
    }

    public async Task<Livro> CriarAsync(Livro livro)
    {
        await _livroRepository.AdicionarAsync(livro);
        return livro;
    }

    public Task AtualizarAsync(Livro livro)
    {
        throw new NotImplementedException();
    }

    public Task RemoverAsync(Livro livro)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> AtualizarAsync(int id, Livro livro)
    {
        var existente = await _livroRepository.ObterPorIdAsync(id);
        if (existente is null) return false;

        existente.Titulo = livro.Titulo;
        existente.Autor = livro.Autor;
        existente.AnoPublicacao = livro.AnoPublicacao;
        existente.Preco = livro.Preco;

        await _livroRepository.AtualizarAsync(existente);
        return true;
    }

    public async Task<bool> RemoverAsync(int id)
    {
        var livro = await _livroRepository.ObterPorIdAsync(id);
        if (livro is null) return false;

        await _livroRepository.RemoverAsync(livro);
        return true;
    }
}