using System.Text.Json;
using System.Text.Json.Serialization;
using ArdenaSolucoes.Models;

namespace ArdenaSolucoes.Services.Cep;

public sealed class BrasilApiService : ICepService
{
    private readonly HttpClient _httpClient;

    public BrasilApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<EnderecoCepDto> BuscarEnderecoPorCepAsync(string cepNumerico)
    {
        string cepLimpo = LimparCep(cepNumerico);

        if (cepLimpo.Length != 8)
        {
            throw new ArgumentException("O CEP precisa conter exatamente 8 dígitos.", nameof(cepNumerico));
        }

        string urlDaRequisicao = $"https://brasilapi.com.br/api/cep/v1/{cepLimpo}";

        try
        {
            using HttpResponseMessage respostaHttp = await _httpClient.GetAsync(urlDaRequisicao);
            string conteudoJson = await respostaHttp.Content.ReadAsStringAsync();

            if (respostaHttp.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return CriarEnderecoNaoEncontrado(cepLimpo);
            }

            if (!respostaHttp.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"A consulta ao BrasilAPI falhou com o código {(int)respostaHttp.StatusCode}.");
            }

            BrasilApiResposta? respostaSerializada = JsonSerializer.Deserialize<BrasilApiResposta>(conteudoJson, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            if (respostaSerializada is null)
            {
                return CriarEnderecoNaoEncontrado(cepLimpo);
            }

            return new EnderecoCepDto
            {
                Cep = respostaSerializada.Cep ?? cepLimpo,
                Logradouro = respostaSerializada.Street ?? string.Empty,
                Bairro = respostaSerializada.Neighborhood ?? string.Empty,
                Cidade = respostaSerializada.City ?? string.Empty,
                Estado = respostaSerializada.State ?? string.Empty,
                EnderecoEncontrado = true
            };
        }
        catch (TaskCanceledException excecao)
        {
            throw new HttpRequestException("O tempo de resposta do BrasilAPI expirou.", excecao);
        }
        catch (JsonException excecao)
        {
            throw new InvalidOperationException("Não foi possível interpretar a resposta do BrasilAPI.", excecao);
        }
    }

    private static EnderecoCepDto CriarEnderecoNaoEncontrado(string cepLimpo)
    {
        return new EnderecoCepDto
        {
            Cep = cepLimpo,
            EnderecoEncontrado = false
        };
    }

    private static string LimparCep(string cepNumerico)
    {
        return new string(cepNumerico.Where(char.IsDigit).ToArray());
    }

    private sealed class BrasilApiResposta
    {
        [JsonPropertyName("cep")]
        public string? Cep { get; set; }

        [JsonPropertyName("street")]
        public string? Street { get; set; }

        [JsonPropertyName("neighborhood")]
        public string? Neighborhood { get; set; }

        [JsonPropertyName("city")]
        public string? City { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }
    }
}


