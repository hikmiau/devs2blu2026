using MinhaPrimeiraApi.Models;
using MinhaPrimeiraApi.DTOs;

namespace MinhaPrimeiraApi.Repositories;

public interface IProdutoRepository
{
    Task<PagedResult<Produto>> ListarAsync(int page, int pageSize, CancellationToken ct = default);
    Task<Produto?> ObterPorIdAsync(int id, CancellationToken ct = default);
    Task AdicionarAsync(Produto produto, CancellationToken ct = default);
    Task SalvarAsync(CancellationToken ct = default);
    void Remover(Produto produto);
}