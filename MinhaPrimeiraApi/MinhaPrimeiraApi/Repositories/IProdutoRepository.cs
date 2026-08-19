using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Repositories;

public interface IProdutoRepository {
  Task<List<Produto>> GetAllAsync();
  Task<Produto> GetByIdAsync(int id);
  Task  AdicionarAsync
