using Api02.DTOs;
using Api02.Infra;
using Api02.Models;
using Microsoft.EntityFrameworkCore;

namespace Api02.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Cliente dto)
        {
            _context.Clientes.Add(dto);
            await _context.SaveChangesAsync();
        }

        public async Task<Cliente?> ObterPorIdAsync(Guid id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task<List<Cliente>> ObterTodosAsyn()
        {
            return await _context.Clientes.ToListAsync();
        }
    }
}
