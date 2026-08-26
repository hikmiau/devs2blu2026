using Microsoft.EntityFrameworkCore;
using MinhaSegundaAPI.Models;

namespace MinhaSegundaAPI.Infra
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Livro> Livros => Set<Livro>();
    }
}