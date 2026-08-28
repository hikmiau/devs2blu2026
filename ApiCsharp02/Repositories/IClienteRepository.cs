using Api02.DTOs;
using Api02.Models;

namespace Api02.Repositories
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> ObterTodosAsyn();
        Task<Cliente?> ObterPorIdAsync(Guid id);
        Task AdicionarAsync(Cliente dto);
    }
}
