# Integração MySQL - ArdenaSolucoes

## ✓ Status: Pronto para Usar

A aplicação está **completamente integrada** com o banco MySQL `ardena_solucoes`.

---

## Como Executar

No terminal PowerShell, na pasta do projeto:

```powershell
$env:MYSQL_CONNECTION_STRING = "Server=localhost;Database=ardena_solucoes;Uid=root;Pwd=admin;"
dotnet run --project .\ArdenaSolucoes\ArdenaSolucoes.csproj
```

---

## Fluxo de Cadastro

1. **Escolha do Provedor de CEP**
   - 1 = ViaCEP
   - 2 = BrasilAPI

2. **Dados Pessoais**
   - Nome completo (obrigatório)
   - CPF (obrigatório e validado)

3. **Endereço**
   - CEP (obrigatório)
   - Consulta automática na API escolhida
   - Exibe: Logradouro, Bairro, Cidade, Estado

4. **Complemento do Endereço**
   - Número (obrigatório)
   - Complemento (opcional)

5. **Confirmação**
   - Resumo com todos os dados
   - Confirmação final (S/N)
   - Gravação no banco

---

## Consultar Dados no DataGrip

No DataGrip, conecte ao banco e execute:

```sql
SELECT cpf, nome_completo, cep, logradouro, numero, complemento, bairro, cidade, estado
FROM cliente
ORDER BY nome_completo;
```

---

## Validações Implementadas

| Regra | Validação |
|-------|-----------|
| RN01  | Nome obrigatório |
| RN02  | CPF obrigatório |
| RN03  | CPF validado (dígitos verificadores) |
| RN04  | CPF único (não permite duplicar) |
| RN05  | CEP obrigatório (8 dígitos) |
| RN06  | CEP inexistente bloqueia cadastro |
| RN07  | Falhas de API tratadas sem quebra |
| RN08  | Número obrigatório |
| RN09  | Gravação apenas após confirmação |
| RN10  | Escolha de provedor em execução |
| RN11  | Lógica independente de provedor |
| RN12  | Novo provedor extensível |

---

## Arquitetura

```
Program.cs                    → UI/Fluxo principal
├── Models/
│   ├── Cliente              → Entidade de domínio
│   └── EnderecoCepDto       → DTO de endereço
├── Services/
│   ├── Cep/
│   │   ├── ICepService      → Interface Strategy
│   │   ├── ViaCepService    → Implementação ViaCEP
│   │   └── BrasilApiService → Implementação BrasilAPI
│   └── Validacao/
│       └── CpfValidator     → Validação de CPF
└── Repositories/
    └── ClienteRepository    → Acesso ao MySQL
```

---

## Testado com Sucesso

✓ Cadastro completo de cliente
✓ Validação de CPF
✓ Consulta de CEP via ViaCEP
✓ Gravação no banco MySQL
✓ Tratamento de erros e falhas de conexão

