using System.Text.Json;
using System.Text.Json.Serialization;
using ArdenaSolucoes.Models;

namespace ArdenaSolucoes.Services.Cep;

public sealed class ViaCepService : ICepService
{
    private readonly HttpClient _httpClient;

    public ViaCepService(HttpClient httpClient)
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

        string urlDaRequisicao = $"https://viacep.com.br/ws/{cepLimpo}/json/";

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
                throw new HttpRequestException($"A consulta ao ViaCEP falhou com o código {(int)respostaHttp.StatusCode}.");
            }

            ViaCepResposta? respostaSerializada = JsonSerializer.Deserialize<ViaCepResposta>(conteudoJson, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            if (respostaSerializada is null || respostaSerializada.Erro)
            {
                return CriarEnderecoNaoEncontrado(cepLimpo);
            }

            return new EnderecoCepDto
            {
                Cep = respostaSerializada.Cep ?? cepLimpo,
                Logradouro = respostaSerializada.Logradouro ?? string.Empty,
                Bairro = respostaSerializada.Bairro ?? string.Empty,
                Cidade = respostaSerializada.Localidade ?? string.Empty,
                Estado = respostaSerializada.Uf ?? string.Empty,
                EnderecoEncontrado = true
            };
        }
        catch (TaskCanceledException excecao)
        {
            throw new HttpRequestException("O tempo de resposta do ViaCEP expirou.", excecao);
        }
        catch (JsonException excecao)
        {
            throw new InvalidOperationException("Não foi possível interpretar a resposta do ViaCEP.", excecao);
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

    private sealed class ViaCepResposta
    {
        [JsonPropertyName("cep")]
        public string? Cep { get; set; }

        [JsonPropertyName("logradouro")]
        public string? Logradouro { get; set; }

        [JsonPropertyName("bairro")]
        public string? Bairro { get; set; }

        [JsonPropertyName("localidade")]
        public string? Localidade { get; set; }

        [JsonPropertyName("uf")]
        public string? Uf { get; set; }

        [JsonPropertyName("erro")]
        public bool Erro { get; set; }
    }
}


