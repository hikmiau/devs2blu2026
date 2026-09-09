using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraApi.db;
using MinhaPrimeiraApi.DTOs;
using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<PagedResult<Produto>> ListarAsync(int page, int pageSize, CancellationToken ct = default)
    {
        var paginaAtual = page <= 0 ? 1 : page;
        var tamanhoPagina = pageSize <= 0 ? 10 : pageSize;

        var query = _context.Produtos.AsNoTracking();
        var totalItems = await query.CountAsync(ct);

        var itens = await query
            .OrderBy(p => p.Id)
            .Skip((paginaAtual - 1) * tamanhoPagina)
            .Take(tamanhoPagina)
            .ToListAsync(ct);

        return new PagedResult<Produto>(itens, paginaAtual, tamanhoPagina, totalItems);
    }

    public async Task<Produto?> ObterPorIdAsync(int id, CancellationToken ct = default)
    {
        return await _context.Produtos.FirstOrDefaultAsync(p => p.Id == id, ct);
    }

    public async Task AdicionarAsync(Produto produto, CancellationToken ct = default)
    {
        await _context.Produtos.AddAsync(produto, ct);
    }

    public async Task SalvarAsync(CancellationToken ct = default)
    {
        await _context.SaveChangesAsync(ct);
    }

    public void Remover(Produto produto)
    {
        _context.Produtos.Remove(produto);
    }
}