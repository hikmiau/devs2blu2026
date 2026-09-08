using Api0109.Models;
using Api0109.DTOs;

namespace Api0109.Services;

public interface IProdutoService
{
    Task<List<Produto>> ListarProdutosAsync(ProdutoFilterDto filtro);
}
