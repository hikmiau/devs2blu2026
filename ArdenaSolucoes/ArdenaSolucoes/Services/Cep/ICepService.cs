using ArdenaSolucoes.Models;

namespace ArdenaSolucoes.Services.Cep;

public interface ICepService
{
    Task<EnderecoCepDto> BuscarEnderecoPorCepAsync(string cepNumerico);
}

