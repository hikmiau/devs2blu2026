using MinhaPrimeiraApi.DTOs;
using MinhaPrimeiraApi.Models;
using MinhaPrimeiraApi.Repositories;

namespace MinhaPrimeiraApi.Services;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _repository;

    public ProdutoService(IProdutoRepository repository)
    {
        _repository = repository;
    }

    public async Task<PagedResult<ProdutoResponse>> ListarAsync(ProdutoFiltro filtro, CancellationToken ct = default)
    {
        var pagina = await _repository.ListarAsync(filtro.Page, filtro.PageSize, ct);

        return new PagedResult<ProdutoResponse>
        {
            Items = pagina.Items.Select(Mapear).ToList(),
            Page = pagina.Page,
            PageSize = pagina.PageSize,
            TotalItems = pagina.TotalItems
        };
    }

    public async Task<ProdutoResponse?> ObterPorIdAsync(int id, CancellationToken ct = default)
    {
        var produto = await _repository.ObterPorIdAsync(id, ct);
        return produto is null ? null : Mapear(produto);
    }

    public async Task<ProdutoResponse> CriarAsync(ProdutoRequest request, CancellationToken ct = default)
    {
        var produto = new Produto
        {
            Nome = request.Nome.Trim(),
            Descricao = request.Descricao?.Trim(),
            Preco = request.Preco,
            Estoque = request.Estoque,
            CriadoEm = DateTime.UtcNow
        };

        await _repository.AdicionarAsync(produto, ct);
        await _repository.SalvarAsync(ct);

        return Mapear(produto);
    }

    public async Task<ProdutoResponse?> AtualizarAsync(int id, ProdutoRequest request, CancellationToken ct = default)
    {
        var produto = await _repository.ObterPorIdAsync(id, ct);

        if (produto is null)
            return null;

        produto.Nome = request.Nome.Trim();
        produto.Descricao = request.Descricao?.Trim();
        produto.Preco = request.Preco;
        produto.Estoque = request.Estoque;

        await _repository.SalvarAsync(ct);

        return Mapear(produto);
    }

    public async Task<bool> RemoverAsync(int id, CancellationToken ct = default)
    {
        var produto = await _repository.ObterPorIdAsync(id, ct);

        if (produto is null)
            return false;

        _repository.Remover(produto);
        await _repository.SalvarAsync(ct);

        return true;
    }

    private static ProdutoResponse Mapear(Produto produto) =>
        new(produto.Id, produto.Nome, produto.Descricao, produto.Preco, produto.Estoque, produto.CriadoEm);
}
