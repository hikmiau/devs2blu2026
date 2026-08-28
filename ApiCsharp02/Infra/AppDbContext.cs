using Api02.Models;
using Microsoft.EntityFrameworkCore;

namespace Api02.Infra
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Livro> Livros => Set<Livro>();
        public DbSet<Genero> Generos => Set<Genero>();
        public DbSet<Cliente> Clientes => Set<Cliente>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>()
                .HasOne(l => l.Genero)
                .WithMany(g => g.livros)
                .HasForeignKey(l => l.GeneroId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Cliente>(e =>
            {
                e.Property(c => c.Id).ValueGeneratedNever();
                e.Property(c => c.Nome).IsRequired().HasMaxLength(150);
                e.Property(c => c.Email).IsRequired().HasMaxLength(200);
                e.HasIndex(c => c.Email).IsUnique();
            });
        }



      
    }
}
