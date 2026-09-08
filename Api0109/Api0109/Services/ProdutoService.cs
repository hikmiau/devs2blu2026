using Api0109.Models;
using Api0109.DTOs;
using Api0109.Repositories;

namespace Api0109.Services;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _repository;

    public ProdutoService(IProdutoRepository repository)
    {
        _repository = repository;
    }

    public Task<List<Produto>> ListarProdutosAsync(ProdutoFilterDto filtro)
    {
        return _repository.ObterComFiltrosAsync(filtro);
    }
}
