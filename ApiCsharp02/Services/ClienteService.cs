using Api02.Models;
using Api02.Repositories;

namespace Api02.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public async Task<(Cliente? cliente, string? erro)> CriarAsync(Cliente cliente)
        {
            cliente.Id = Guid.NewGuid();
            await _repository.AdicionarAsync(cliente);
            return (cliente, null);

        }

        public Task<List<Cliente>> ListarAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente?> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
