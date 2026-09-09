using MinhaPrimeiraApi.models;

namespace MinhaPrimeiraApi.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    public Task<List<Produto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Produto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task AdicionarAsync(Produto produto)
    {
        throw new NotImplementedException();
    }

    public Task SalvarAsync()
    {
        throw new NotImplementedException();
    }

    public void Remover(Produto produto)
    {
        throw new NotImplementedException();
    }
}