using Microsoft.EntityFrameworkCore;
using Api0109.Models;
using Api0109.DTOs;
using Api0109.Infra;

namespace Api0109.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Produto>> ObterComFiltrosAsync(ProdutoFilterDto filtro)
    {
        var query = _context.Produtos.Include(p => p.Categoria).AsQueryable();

        // Filtro 1: Busca parcial por Nome
        if (!string.IsNullOrWhiteSpace(filtro.Nome))
            query = query.Where(p => p.Nome.Contains(filtro.Nome));

        // Filtro 2: Preco maximo
        if (filtro.PrecoMaximo.HasValue)
            query = query.Where(p => p.Preco <= filtro.PrecoMaximo.Value);

        // Filtro 3: Chave estrangeira CategoriaId
        if (filtro.CategoriaId.HasValue)
            query = query.Where(p => p.CategoriaId == filtro.CategoriaId.Value);

        return await query.ToListAsync();
    }
}
