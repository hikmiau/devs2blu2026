using System;
using System.Threading.Tasks;
using ArdenaSolucoes.Models;
using MySqlConnector;

namespace ArdenaSolucoes.Repositories;

public sealed class ClienteRepository
{
    // A string de conexão fixa
    private readonly string _stringDeConexao = "Server=localhost;Database=ardena_solucoes;Uid=root;Pwd=admin;";

    // Construtor vazio (ou você pode simplesmente apagá-lo)
    public ClienteRepository()
    {
    }

    public async Task<bool> ExisteCpfCadastradoAsync(string cpf)
    {
        const string comandoSql = "SELECT COUNT(1) FROM cliente WHERE cpf = @cpf;";

        await using MySqlConnection conexao = new MySqlConnection(_stringDeConexao);
        await conexao.OpenAsync();

        await using MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
        comando.Parameters.AddWithValue("@cpf", cpf);

        object? resultado = await comando.ExecuteScalarAsync();

        return Convert.ToInt32(resultado) > 0;
    }

    public async Task Inserir(Cliente cliente)
    {
        const string comandoSql = @"
INSERT INTO cliente
    (cpf, nome_completo, cep, logradouro, numero, complemento, bairro, cidade, estado)
VALUES
    (@cpf, @nomeCompleto, @cep, @logradouro, @numero, @complemento, @bairro, @cidade, @estado);";

        try
        {
            await using MySqlConnection conexao = new MySqlConnection(_stringDeConexao);
            await conexao.OpenAsync();

            await using MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
            comando.Parameters.AddWithValue("@nomeCompleto", cliente.NomeCompleto);
            comando.Parameters.AddWithValue("@cep", cliente.Cep);
            comando.Parameters.AddWithValue("@logradouro", cliente.Logradouro);
            comando.Parameters.AddWithValue("@numero", cliente.Numero);
            comando.Parameters.AddWithValue("@complemento", cliente.Complemento);
            comando.Parameters.AddWithValue("@bairro", cliente.Bairro);
            comando.Parameters.AddWithValue("@cidade", cliente.Cidade);
            comando.Parameters.AddWithValue("@estado", cliente.Estado);

            await comando.ExecuteNonQueryAsync();
        }
        catch (MySqlException excecao) when (excecao.Number == 1062)
        {
            throw new InvalidOperationException("Já existe um cliente cadastrado com este CPF.", excecao);
        }
    }
    
   public async Task<List<Cliente>> ObterTodosAsync()
    {
        var clientes = new List<Cliente>();
        const string comandoSql = "SELECT * FROM cliente;";

        await using MySqlConnection conexao = new MySqlConnection(_stringDeConexao);
        await conexao.OpenAsync();

        await using MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
        await using var reader = await comando.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            clientes.Add(new Cliente
            {
                Cpf = reader["cpf"].ToString(),
                NomeCompleto = reader["nome_completo"].ToString(),
                Cep = reader["cep"].ToString(),
                Logradouro = reader["logradouro"].ToString(),
                Numero = reader["numero"].ToString(),
                Complemento = reader["complemento"].ToString(),
                Bairro = reader["bairro"].ToString(),
                Cidade = reader["cidade"].ToString(),
                Estado = reader["estado"].ToString()
            });
        }

        return clientes;
    }

    public async Task<Cliente?> ObterPorCpfAsync(string cpf)
    {
        const string comandoSql = "SELECT * FROM cliente WHERE cpf = @cpf;";

        await using MySqlConnection conexao = new MySqlConnection(_stringDeConexao);
        await conexao.OpenAsync();

        await using MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
        comando.Parameters.AddWithValue("@cpf", cpf);
        
        await using var reader = await comando.ExecuteReaderAsync();

        if (await reader.ReadAsync())
        {
            return new Cliente
            {
                Cpf = reader["cpf"].ToString(),
                NomeCompleto = reader["nome_completo"].ToString(),
                Cep = reader["cep"].ToString(),
                Logradouro = reader["logradouro"].ToString(),
                Numero = reader["numero"].ToString(),
                Complemento = reader["complemento"].ToString(),
                Bairro = reader["bairro"].ToString(),
                Cidade = reader["cidade"].ToString(),
                Estado = reader["estado"].ToString()
            };
        }

        return null; // Retorna nulo se não encontrar o cliente
    } 
}