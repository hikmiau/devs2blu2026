using MinhaPrimeiraApi.models;

namespace MinhaPrimeiraApi.Repositories;

public interface IProdutoRepository
{
    Task<List<Produto>> GetAllAsync();
    Task<Produto> GetByIdAsync(int id);
    Task AdicionarAsync(Produto produto);
    Task SalvarAsync();
    void Remover(Produto produto);
    
}