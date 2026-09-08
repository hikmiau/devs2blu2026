using Microsoft.EntityFrameworkCore;
using Api0109.Models;
using Api0109.DTOs;

namespace Api0109.Repositories;

public interface IProdutoRepository
{
    Task<List<Produto>> ObterComFiltrosAsync(ProdutoFilterDto filtro);
}
