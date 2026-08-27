using Api02.Models;
using Microsoft.EntityFrameworkCore;

namespace Api02.Infra
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Livro> Livros => Set<Livro>();
    }
}
