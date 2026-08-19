using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.DB;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Produto> Produtos => Set<Produto>();

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Produto>(e =>
        {
            e.Property(p => p.Nome).HasMaxLength(200).IsRequired();
            e.Property(p => p.Preco).HasPrecision(10, 2).IsRequired();
        });
    }
}