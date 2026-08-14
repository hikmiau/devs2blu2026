using System.Text;
using ArdenaSolucoes.Models;
using ArdenaSolucoes.Repositories;
using ArdenaSolucoes.Services.Cep;
using ArdenaSolucoes.Services.Validacao;

namespace ArdenaSolucoes;

internal enum ProvedorCepEscolhido
{
    ViaCep = 1,
    BrasilApi = 2
}

class Program
{
    static async Task Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        bool sair = false;

        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine("       SISTEMA ARDENA SOLUÇÕES        ");
            Console.WriteLine("======================================");
            Console.WriteLine("1) Cadastrar Cliente");
            Console.WriteLine("2) Consultar Clientes já existentes");
            Console.WriteLine("3) Informar dados pessoais do cliente");
            Console.WriteLine("4) Informar CEP de um cliente");
            Console.WriteLine("5) Consultar o CEP utilizando um sistema externo");
            Console.WriteLine("6) Obter os dados de endereço do cliente");
            Console.WriteLine("0) Sair do Sistema");
            Console.WriteLine("======================================");
            Console.Write("Escolha uma opção: ");

            string opcao = (Console.ReadLine() ?? string.Empty).Trim();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    await CadastrarClienteAsync();
                    break;
                case "2":
                    Console.Clear();
                    await ConsultarClientesAsync();
                    break;
                case "3":
                    Console.Clear();
                    await InformarDadosPessoaisAsync();
                    break;
                case "4":
                    Console.Clear();
                    await InformarCepAsync();
                    break;
                case "5":
                    Console.Clear();
                    await ConsultarCepExternoAsync();
                    break;
                case "6":
                    Console.Clear();
                    await ObterDadosEnderecoAsync();
                    break;
                case "0":
                    sair = true;
                    Console.WriteLine("Encerrando o sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // =================================================================================
    // LÓGICA DO MENU
    // =================================================================================

    private static async Task CadastrarClienteAsync()
    {
        Console.WriteLine("--- 1. CADASTRO DE CLIENTE ---");
        try
        {
            ProvedorCepEscolhido provedorCepEscolhido = SolicitarProvedorCep();
            using HttpClient clienteHttp = new HttpClient();
            ICepService servicoCep = CriarServicoCep(provedorCepEscolhido, clienteHttp);
            ClienteRepository clienteRepository = new ClienteRepository();
            
            Console.WriteLine();
            string nomeCompleto = SolicitarTextoObrigatorio("Digite o nome completo:");
            string cpfInformado = SolicitarCpfValido();
            string cpfSomenteNumeros = CpfValidator.ObterApenasNumeros(cpfInformado);

            Console.WriteLine();
            string cepInformado = SolicitarCepObrigatorio();

            EnderecoCepDto enderecoConsultado;

            try
            {
                enderecoConsultado = await servicoCep.BuscarEnderecoPorCepAsync(cepInformado);
            }
            catch (Exception excecao)
            {
                Console.WriteLine($"Falha na consulta do CEP: {excecao.Message}");
                PausarParaLeitura();
                return;
            }

            if (!enderecoConsultado.EnderecoEncontrado)
            {
                Console.WriteLine("O CEP informado não foi encontrado no provedor escolhido.");
                PausarParaLeitura();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Endereço encontrado:");
            Console.WriteLine($"Logradouro: {enderecoConsultado.Logradouro}");
            Console.WriteLine($"Bairro: {enderecoConsultado.Bairro}");
            Console.WriteLine($"Cidade: {enderecoConsultado.Cidade}");
            Console.WriteLine($"Estado: {enderecoConsultado.Estado}");

            Console.WriteLine();
            string numeroEndereco = SolicitarTextoObrigatorio("Digite o número do endereço:");
            string complementoEndereco = SolicitarTextoOpcional("Digite o complemento do endereço (opcional):");

            Console.WriteLine();
            Console.WriteLine("Resumo do cadastro:");
            Console.WriteLine($"Nome completo: {nomeCompleto}");
            Console.WriteLine($"CPF: {CpfValidator.FormatarCpf(cpfSomenteNumeros)}");
            Console.WriteLine($"CEP: {enderecoConsultado.Cep}");
            Console.WriteLine($"Logradouro: {enderecoConsultado.Logradouro}");
            Console.WriteLine($"Número: {numeroEndereco}");
            Console.WriteLine($"Complemento: {(string.IsNullOrWhiteSpace(complementoEndereco) ? "Não informado" : complementoEndereco)}");
            Console.WriteLine($"Bairro: {enderecoConsultado.Bairro}");
            Console.WriteLine($"Cidade: {enderecoConsultado.Cidade}");
            Console.WriteLine($"Estado: {enderecoConsultado.Estado}");

            Console.WriteLine();
            if (!SolicitarConfirmacaoFinal())
            {
                Console.WriteLine("Cadastro cancelado pelo usuário.");
                PausarParaLeitura();
                return;
            }

            try
            {
                Cliente clienteParaCadastro = new Cliente
                {
                    Cpf = cpfSomenteNumeros,
                    NomeCompleto = nomeCompleto,
                    Cep = cepInformado,
                    Logradouro = enderecoConsultado.Logradouro,
                    Numero = numeroEndereco,
                    Complemento = complementoEndereco,
                    Bairro = enderecoConsultado.Bairro,
                    Cidade = enderecoConsultado.Cidade,
                    Estado = enderecoConsultado.Estado
                };

                bool cpfJaCadastrado = await clienteRepository.ExisteCpfCadastradoAsync(clienteParaCadastro.Cpf);

                if (cpfJaCadastrado)
                {
                    Console.WriteLine("Já existe um cliente cadastrado com este CPF. Cadastro bloqueado.");
                    PausarParaLeitura();
                    return;
                }

                await clienteRepository.Inserir(clienteParaCadastro);

                Console.WriteLine();
                Console.WriteLine("Cliente cadastrado com sucesso.");
            }
            catch (InvalidOperationException excecao)
            {
                Console.WriteLine($"Não foi possível concluir o cadastro: {excecao.Message}");
            }
            catch (Exception excecao)
            {
                Console.WriteLine($"Falha ao gravar o cliente no banco de dados: {excecao.Message}");
            }
        }
        catch (Exception excecao)
        {
            Console.WriteLine($"Não foi possível iniciar o cadastro: {excecao.Message}");
        }

        PausarParaLeitura();
    }

    private static async Task ConsultarClientesAsync()
    {
        Console.WriteLine("--- 2. CONSULTAR CLIENTES EXISTENTES ---");
        try
        {
            var repositorio = new ClienteRepository();
            var clientes = await repositorio.ObterTodosAsync();

            if (clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado no banco de dados.");
            }
            else
            {
                Console.WriteLine($"Foram encontrados {clientes.Count} cliente(s):\n");
                foreach (var c in clientes)
                {
                    Console.WriteLine($"- CPF: {CpfValidator.FormatarCpf(c.Cpf)} | Nome: {c.NomeCompleto} | Cidade: {c.Cidade}/{c.Estado}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao consultar o banco de dados: {ex.Message}");
        }
        PausarParaLeitura();
    }

    private static async Task InformarDadosPessoaisAsync()
    {
        Console.WriteLine("--- 3. INFORMAR DADOS PESSOAIS DO CLIENTE ---");
        string cpf = SolicitarCpfValido();
        string cpfLimpo = CpfValidator.ObterApenasNumeros(cpf);

        try
        {
            var repositorio = new ClienteRepository();
            var cliente = await repositorio.ObterPorCpfAsync(cpfLimpo);

            if (cliente == null)
            {
                Console.WriteLine("\nCliente não encontrado no banco de dados.");
            }
            else
            {
                Console.WriteLine("\nDados Pessoais Encontrados:");
                Console.WriteLine($"Nome: {cliente.NomeCompleto}");
                Console.WriteLine($"CPF: {CpfValidator.FormatarCpf(cliente.Cpf)}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao consultar o banco de dados: {ex.Message}");
        }
        PausarParaLeitura();
    }

    private static async Task InformarCepAsync()
    {
        Console.WriteLine("--- 4. INFORMAR CEP DE UM CLIENTE ---");
        string cpf = SolicitarCpfValido();
        string cpfLimpo = CpfValidator.ObterApenasNumeros(cpf);

        try
        {
            var repositorio = new ClienteRepository();
            var cliente = await repositorio.ObterPorCpfAsync(cpfLimpo);

            if (cliente == null)
            {
                Console.WriteLine("\nCliente não encontrado no banco de dados.");
            }
            else
            {
                Console.WriteLine($"\nO CEP cadastrado para {cliente.NomeCompleto} é: {cliente.Cep}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao consultar o banco de dados: {ex.Message}");
        }
        PausarParaLeitura();
    }

    private static async Task ConsultarCepExternoAsync()
    {
        Console.WriteLine("--- 5. CONSULTAR CEP EM SISTEMA EXTERNO ---");
        try
        {
            ProvedorCepEscolhido provedor = SolicitarProvedorCep();
            using HttpClient clienteHttp = new HttpClient();
            ICepService servicoCep = CriarServicoCep(provedor, clienteHttp);
            
            Console.WriteLine();
            string cepInformado = SolicitarCepObrigatorio();

            Console.WriteLine("\nBuscando na API externa...");
            var endereco = await servicoCep.BuscarEnderecoPorCepAsync(cepInformado);

            if (!endereco.EnderecoEncontrado)
            {
                Console.WriteLine("O CEP não foi encontrado no provedor externo.");
            }
            else
            {
                Console.WriteLine("Resultado da busca:");
                Console.WriteLine($"Logradouro: {endereco.Logradouro}");
                Console.WriteLine($"Bairro: {endereco.Bairro}");
                Console.WriteLine($"Cidade: {endereco.Cidade}");
                Console.WriteLine($"Estado: {endereco.Estado}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao consultar a API externa: {ex.Message}");
        }
        PausarParaLeitura();
    }

    private static async Task ObterDadosEnderecoAsync()
    {
        Console.WriteLine("--- 6. OBTER DADOS DE ENDEREÇO DO CLIENTE ---");
        string cpf = SolicitarCpfValido();
        string cpfLimpo = CpfValidator.ObterApenasNumeros(cpf);

        try
        {
            var repositorio = new ClienteRepository();
            var cliente = await repositorio.ObterPorCpfAsync(cpfLimpo);

            if (cliente == null)
            {
                Console.WriteLine("\nCliente não encontrado no banco de dados.");
            }
            else
            {
                Console.WriteLine("\nEndereço Completo Cadastrado:");
                Console.WriteLine($"CEP: {cliente.Cep}");
                Console.WriteLine($"Logradouro: {cliente.Logradouro}");
                Console.WriteLine($"Número: {cliente.Numero}");
                Console.WriteLine($"Complemento: {(string.IsNullOrWhiteSpace(cliente.Complemento) ? "N/A" : cliente.Complemento)}");
                Console.WriteLine($"Bairro: {cliente.Bairro}");
                Console.WriteLine($"Cidade: {cliente.Cidade}");
                Console.WriteLine($"Estado: {cliente.Estado}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao consultar o banco de dados: {ex.Message}");
        }
        PausarParaLeitura();
    }

    private static void PausarParaLeitura()
    {
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    // =================================================================================
    // MÉTODOS AUXILIARES (Mesmos de antes)
    // =================================================================================

    private static ICepService CriarServicoCep(ProvedorCepEscolhido provedorCepEscolhido, HttpClient clienteHttp)
    {
        return provedorCepEscolhido switch
        {
            ProvedorCepEscolhido.ViaCep => new ViaCepService(clienteHttp),
            ProvedorCepEscolhido.BrasilApi => new BrasilApiService(clienteHttp),
            _ => throw new InvalidOperationException("Provedor de CEP inválido.")
        };
    }

    private static ProvedorCepEscolhido SolicitarProvedorCep()
    {
        while (true)
        {
            Console.WriteLine("Escolha o provedor de CEP:");
            Console.WriteLine("1 - ViaCEP");
            Console.WriteLine("2 - BrasilAPI");
            Console.Write("Opção: ");

            string opcaoInformada = (Console.ReadLine() ?? string.Empty).Trim();

            if (opcaoInformada == "1") return ProvedorCepEscolhido.ViaCep;
            if (opcaoInformada == "2") return ProvedorCepEscolhido.BrasilApi;

            Console.WriteLine("Opção inválida. Tente novamente.\n");
        }
    }

    private static string SolicitarTextoObrigatorio(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem + " ");
            string textoInformado = (Console.ReadLine() ?? string.Empty).Trim();

            if (!string.IsNullOrWhiteSpace(textoInformado)) return textoInformado;
            Console.WriteLine("Este campo é obrigatório.");
        }
    }

    private static string SolicitarTextoOpcional(string mensagem)
    {
        Console.Write(mensagem + " ");
        return (Console.ReadLine() ?? string.Empty).Trim();
    }

    private static string SolicitarCpfValido()
    {
        while (true)
        {
            Console.Write("Digite o CPF: ");
            string cpfInformado = (Console.ReadLine() ?? string.Empty).Trim();

            if (string.IsNullOrWhiteSpace(cpfInformado))
            {
                Console.WriteLine("O CPF é obrigatório.");
                continue;
            }

            if (!CpfValidator.EhCpfValido(cpfInformado))
            {
                Console.WriteLine("CPF inválido. Tente novamente.");
                continue;
            }

            return cpfInformado;
        }
    }

    private static string SolicitarCepObrigatorio()
    {
        while (true)
        {
            Console.Write("Digite o CEP: ");
            string cepInformado = (Console.ReadLine() ?? string.Empty).Trim();
            string cepSomenteNumeros = new string(cepInformado.Where(char.IsDigit).ToArray());

            if (string.IsNullOrWhiteSpace(cepInformado))
            {
                Console.WriteLine("O CEP é obrigatório.");
                continue;
            }

            if (cepSomenteNumeros.Length != 8)
            {
                Console.WriteLine("O CEP precisa conter exatamente 8 dígitos.");
                continue;
            }

            return cepSomenteNumeros;
        }
    }

    private static bool SolicitarConfirmacaoFinal()
    {
        while (true)
        {
            Console.Write("Confirma o cadastro? (S/N): ");
            string respostaInformada = (Console.ReadLine() ?? string.Empty).Trim().ToUpperInvariant();

            if (respostaInformada == "S") return true;
            if (respostaInformada == "N") return false;

            Console.WriteLine("Resposta inválida. Digite S para confirmar ou N para cancelar.");
        }
    }
}