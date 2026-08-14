# ArdenaSolucoes

Console Application em .NET 9 para cadastro de clientes com:

- Strategy para consulta de CEP
- Repository para MySQL com `MySqlConnector`
- Validação de CPF
- Integração com ViaCEP e BrasilAPI

## Configuração

Defina a variável de ambiente com a string de conexão do MySQL:

```powershell
$env:MYSQL_CONNECTION_STRING = "Server=localhost;Port=3306;Database=ardena_solucoes;Uid=root;Pwd=sua_senha;"
```

## DDL do banco

```sql
CREATE SCHEMA IF NOT EXISTS ardena_solucoes DEFAULT CHARACTER SET utf8;
USE ardena_solucoes;

CREATE TABLE cliente (
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
);
```

## Execução

```powershell
dotnet restore
dotnet run --project .\ArdenaSolucoes\ArdenaSolucoes.csproj
```

Durante a execução:

1. O usuário escolhe o provedor de CEP.
2. Informa nome e CPF.
3. Informa o CEP.
4. O sistema consulta a API escolhida.
5. O usuário informa número e complemento.
6. O sistema mostra o resumo e pede confirmação.
7. Se confirmado, o cliente é gravado no banco.

## Onde esta o manual

- `README.md`: setup rapido e execucao.
- `INTEGRACAO_MYSQL.md`: guia detalhado de integracao e consultas.

