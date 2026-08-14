using MySqlConnector;

string? stringDeConexao = Environment.GetEnvironmentVariable("MYSQL_CONNECTION_STRING");

if (string.IsNullOrWhiteSpace(stringDeConexao))
{
    Console.WriteLine("Defina a variavel MYSQL_CONNECTION_STRING antes de executar o setup.");
    Environment.Exit(1);
}

try
{
    await using MySqlConnection conexao = new MySqlConnection(stringDeConexao);
    await conexao.OpenAsync();

    Console.WriteLine("✓ Conectado ao banco de dados MySQL com sucesso!");

    string scriptSql = @"
CREATE SCHEMA IF NOT EXISTS `ardena_solucoes` DEFAULT CHARACTER SET utf8;
USE `ardena_solucoes`;

CREATE TABLE IF NOT EXISTS cliente (
    cpf VARCHAR(11) NOT NULL,
    nome_completo VARCHAR(255) NOT NULL,
    cep VARCHAR(8) NOT NULL,
    logradouro VARCHAR(255) NOT NULL,
    numero VARCHAR(20) NOT NULL,
    complemento VARCHAR(100) NOT NULL,
    bairro VARCHAR(100) NOT NULL,
    cidade VARCHAR(100) NOT NULL,
    estado VARCHAR(2) NOT NULL,
    PRIMARY KEY (cpf),
    UNIQUE KEY cpf_UNIQUE (cpf)
) ENGINE=InnoDB;
";

    await using MySqlCommand comando = new MySqlCommand(scriptSql, conexao);
    await comando.ExecuteNonQueryAsync();

    Console.WriteLine("✓ Tabela 'cliente' criada com sucesso!");
    Console.WriteLine();
    Console.WriteLine("Agora você pode executar a aplicação com os comandos abaixo:");
    Console.WriteLine();
    Console.WriteLine("PowerShell:");
    Console.WriteLine("  $env:MYSQL_CONNECTION_STRING = \"Server=localhost;Port=3306;Database=ardena_solucoes;Uid=root;Pwd=sua_senha;\"");
    Console.WriteLine("  dotnet run --project .\\ArdenaSolucoes\\ArdenaSolucoes.csproj");
    Console.WriteLine();
}
catch (Exception excecao)
{
    Console.WriteLine($"✗ Erro ao conectar ou criar a tabela: {excecao.Message}");
    Environment.Exit(1);
}


