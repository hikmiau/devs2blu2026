using System;
using System.Collections.Generic;

namespace modulocontrole;

class Program
{
    static List<string> Insumos = new List<string>();
    static List<Double> CreditoVerde = new List<Double>();
    static List<int> QtdDisponivel = new List<int>();
    static List<int> QtdMinAceitavel = new List<int>();

    // Acumuladores do módulo 3 (Relatórios e Balanço Ecológico)
    static double _totalCreditosVerdesMovimentados;
    static int _totalOrdensFinalizadas;

    static void Main(string[] args)
    {
        GerarInventario();
        int opcao;
        do
        {
            // O Menu é Mostrado
            Console.WriteLine("=== Menu ===");
            Console.WriteLine("1) Digite o Codigo do Produto");
            Console.WriteLine("2) Reabastecer Produto");
            Console.WriteLine("3) Listar Produtos");
            Console.WriteLine("4) Requisição de Insumo");
            Console.WriteLine("5) Ver Relatório de Eficiência Geral");
            Console.WriteLine("0) Sair");
            Console.WriteLine("============");
            // Lê a entrada do usuário e tenta converter para inteiro
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                // Se o usuário digitar algo que não seja número, forçamos uma opção inválida
                opcao = -1; 
            }

            Console.WriteLine(); // Linha em branco para estética
           
            // Controle do fluxo com Switch-Case
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("-> Executando: Digite o Codigo do Produto...");
                    // OPÇÃO 1: Após o Utilizador(Cliente) digitar o codigo do material/produto, o Sistema exibe todos os seus detalhes
                    // Console.WriteLine("Codigo do Insumo: ");
                    // Console.WriteLine("Nome do Insumo: ");
                    // Console.WriteLine("Preço do Insumo: ");
                    // Console.WriteLine("Quantidade Disponivel do Insumo: ");
                    Consultar(Insumos, CreditoVerde, QtdDisponivel, QtdMinAceitavel);
                    break;

                case 2:
                    // OPÇÃO 2: O Utilizador(Cliente) procura reabastecer, o Sistema pede o Código do Produto para reabastecer.
                    Console.WriteLine("-> Executando: Reabastecer Produtos...");
                    Console.WriteLine("Digite o Codigo do Produto");
                    
                    if (!int.TryParse(Console.ReadLine(), out int codigoProduto))
                    {
                        Console.WriteLine("Código inválido. Use um número inteiro.");
                        break;
                    }
                    
                    Console.WriteLine("Digita a quantidade abastecida no silo");
                    if (!int.TryParse(Console.ReadLine(), out int quantidadeReabastecer))
                    {
                        Console.WriteLine("Quantidade inválida. Use um número inteiro.");
                        break;
                    }
                    
                    ReabastecerProduto(codigoProduto, quantidadeReabastecer);
                    break;

                case 3:
                    Console.WriteLine("-> Executando: Listando Produtos...");
                    // OPÇÃO 3: O Utilizador(cliente) pede para listar os produtos.
                    Console.WriteLine("Esses são os produtos:");
                    MostrarInventario();
                    break;

                case 4:
                    Console.WriteLine("\n=== Abrir Requisição de Insumo ===");
                    Console.WriteLine("Escolha o setor de cultivo:");
                    Console.WriteLine("1 - Hortaliças");
                    Console.WriteLine("2 - Frutos do Bosque");
                    Console.WriteLine("3 - Plantas Medicinais");
                    Console.Write("Opção: ");
                    
                    string nomeSetor = "";
                    if (int.TryParse(Console.ReadLine(), out int opcaoSetor))
                    {
                        nomeSetor = opcaoSetor switch
                        {
                            1 => "Hortaliças",
                            2 => "Frutos do Bosque",
                            3 => "Plantas Medicinais",
                            _ => ""
                        };
                    }

                    if (string.IsNullOrEmpty(nomeSetor))
                    {
                        Console.WriteLine("Setor inválido!");
                        break;
                    }

                    Console.WriteLine($"\n-> Iniciando requisição para: {nomeSetor}");
                    var (produtosRequisitados, quantidadesRequisitadas) = RequisitarProduto();

                    if (produtosRequisitados.Count > 0)
                    {
                        ProcessarOrdemDeDespacho(
                            nomeSetor,
                            produtosRequisitados,
                            quantidadesRequisitadas);
                    }
                    else
                    {
                        Console.WriteLine("Nenhum produto foi requisitado.");
                    }
                    break;

                case 5:
                    Console.WriteLine("-> Exibindo Relatório de Eficiência Geral...");
                    ExibirBalancoEcologico();
                    break;

                case 0:
                    Console.WriteLine("Saindo do sistema... Até logo!");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Por favor, escolha um número do menu.");
                    break;
            }
        if (opcao != 0)
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            try
            {
                Console.ReadKey();
            }
            catch
            {
                // Se houver erro ao ler a tecla (ex.: em modo pipe), apenas continua
            }
        }

    } while (opcao != 0);
       
        
        
    }



    static void GerarInventario()
    {
        //davidy
        Insumos.Add("Fertilizante");
        CreditoVerde.Add(10.0);
        QtdDisponivel.Add(15);
        QtdMinAceitavel.Add(2);

        Insumos.Add("Semente");
        CreditoVerde.Add(5.0);
        QtdDisponivel.Add(30);
        QtdMinAceitavel.Add(10);

        Insumos.Add("Pesticida");
        CreditoVerde.Add(15.0);
        QtdDisponivel.Add(20);
        QtdMinAceitavel.Add(1);

        Insumos.Add("Herbicida");
        CreditoVerde.Add(12.0);
        QtdDisponivel.Add(10);
        QtdMinAceitavel.Add(3);

        Insumos.Add("Adubo");
        CreditoVerde.Add(8.0);
        QtdDisponivel.Add(25);
        QtdMinAceitavel.Add(4);
    }


    static void MostrarInventario()
    {
      //davidy
        foreach (var insumo in Insumos)
        {
            int index = Insumos.IndexOf(insumo);
            Console.WriteLine($"Código: {Insumos.IndexOf(insumo)} Insumo: {insumo}, Custo(CV): {CreditoVerde[index]}, Quantidade: {QtdDisponivel[index]}");
        }
    }

    static void ReabastecerProduto(int codigo, int quantidade)
    {
        //davidy
        if (quantidade <= 0)
        {
            Console.WriteLine("Quantidade inválida. A quantidade deve ser maior que zero.");
            return;
        }
        if (codigo >= 0 && codigo < Insumos.Count)
        {
            // Calcula o custo da compra (preço unitário * quantidade)
            double custoDaCompra = CreditoVerde[codigo] * quantidade;
            
            QtdDisponivel[codigo] += quantidade;
            Console.WriteLine($"Produto {Insumos[codigo]} reabastecido com sucesso!\nNova quantidade: {QtdDisponivel[codigo]}");
            
            // Registra o custo da compra no acumulador de Créditos Verdes movimentados
            RegistarReabastecimentoNoBalanco(custoDaCompra);
            Console.WriteLine($"Custo de compra registado: {custoDaCompra:F2} CV");
        }
        else
        {
            Console.WriteLine("Código inválido. Não foi possível reabastecer o produto.");
        }
    }
    
    static void Consultar(List<string> insumos, List<double> CreditoVerde, List<int> QtdDisponivel, List<int> QtdMinAceitavel)
    {
        Console.Write("Digite ID do produto que deseja consultar: ");
        int id_produto = Convert.ToInt32(Console.ReadLine());
        
        for (var i = 0; i < insumos.Count; i++)
        {
            if (id_produto == insumos.IndexOf(insumos[i]))
            {
                Console.WriteLine($"ID: {insumos.IndexOf(insumos[i])}");
                Console.WriteLine($"Insumo: {insumos[i]}");
                Console.WriteLine($"Valor: {CreditoVerde[insumos.IndexOf(insumos[i])]}");
                Console.WriteLine($"Quantidade: {QtdDisponivel[i]}");

                if (QtdDisponivel[i] <= QtdMinAceitavel[i])
                {
                    Console.WriteLine("!!!!!A Quantidade disponivel do insumo esta abaixo do desejavel!!!!!");
                }
            }
            
        }
        
    }

    static (List<string>,List<int>) RequisitarProduto()
    {
        List<string> insumosRequisitados = new List<string>();
        List<int> qtdRequisitada = new List<int>();

        while (true)
        {
            Console.WriteLine("Digite o Código do Produto ou 0 para sair:");
            string? entradaCodigo = Console.ReadLine();
            if (!int.TryParse(entradaCodigo, out int codigo))
            {
                Console.WriteLine("Código inválido. Use um número inteiro.");
                continue;
            }

            if (codigo == 0) break;

            Console.WriteLine("Digite a quantidade desejada:");
            string? entradaQtd = Console.ReadLine();
            if (!int.TryParse(entradaQtd, out int qtd))
            {
                Console.WriteLine("Quantidade inválida. Use um número inteiro.");
                continue;
            }

            if (codigo >= 0 && codigo < Insumos.Count)
            {
                if (QtdDisponivel[codigo] < qtd)
                {
                    Console.WriteLine("Quantidade requisitada maior que a disponível.");
                    continue;
                }
                insumosRequisitados.Add(Insumos[codigo]);
                qtdRequisitada.Add(qtd);
            }
            else
            {
                Console.WriteLine("Código inválido. Tente novamente.");
            }
        }

        return (insumosRequisitados, qtdRequisitada);

    }

    // ==================== MÓDULO 3: BALANÇO ECOLÓGICO E RELATÓRIOS ====================

    // Processa uma ordem de cultivo recebida do módulo 2
    // Calcula custos, aplica ajustes, atualiza estoque e emite manifesto
    static double ProcessarOrdemDeDespacho(
        string nomeDoSetor,
        List<string> nomesDosProdutosRequisitados,
        List<int> quantidadesRequisitadas)
    {
        // Validações básicas
        if (nomesDosProdutosRequisitados == null || quantidadesRequisitadas == null)
        {
            Console.WriteLine("Erro: Dados da requisição não foram fornecidos corretamente.");
            return 0;
        }

        if (nomesDosProdutosRequisitados.Count == 0)
        {
            Console.WriteLine("Não há itens na ordem para processar.");
            return 0;
        }

        if (nomesDosProdutosRequisitados.Count != quantidadesRequisitadas.Count)
        {
            Console.WriteLine("Erro: listas de nomes e quantidades possuem tamanhos diferentes.");
            return 0;
        }

        // Verifica existência e calcula custo base
        double custoTotalBase = 0;
        List<double> custosUnitarios = new List<double>();
        List<string> nomesValidos = new List<string>();
        List<int> quantidadesValidas = new List<int>();

        for (int i = 0; i < nomesDosProdutosRequisitados.Count; i++)
        {
            string nomeProduto = nomesDosProdutosRequisitados[i];
            int quantidadePedida = quantidadesRequisitadas[i];

            if (quantidadePedida <= 0)
            {
                Console.WriteLine($"Aviso: quantidade inválida para {nomeProduto}. Valor ignorado.");
                continue;
            }

            // Busca o índice do produto na lista global de Insumos
            int indice = -1;
            for (int j = 0; j < Insumos.Count; j++)
            {
                if (Insumos[j] == nomeProduto)
                {
                    indice = j;
                    break;
                }
            }

            if (indice == -1)
            {
                Console.WriteLine($"Aviso: insumo '{nomeProduto}' não encontrado no inventário.");
                continue;
            }

            double precoUnitario = CreditoVerde[indice];
            double subtotal = precoUnitario * quantidadePedida;
            custoTotalBase += subtotal;

            custosUnitarios.Add(precoUnitario);
            nomesValidos.Add(nomeProduto);
            quantidadesValidas.Add(quantidadePedida);
        }

        if (nomesValidos.Count == 0)
        {
            Console.WriteLine("Nenhum item válido para processar após validações.");
            return 0;
        }

        // Mostra opções de ajuste
        Console.WriteLine();
        Console.WriteLine("====================================================");
        Console.WriteLine("Processamento da ordem de cultivo");
        Console.WriteLine("====================================================");
        Console.WriteLine($"Setor atendido: {nomeDoSetor}");
        Console.WriteLine($"Custo base dos insumos: {custoTotalBase:F2} CV");
        Console.WriteLine();
        Console.WriteLine("Escolha o tipo de processamento:");
        Console.WriteLine("1 - Tratamento de Urgência (acréscimo de 15%)");
        Console.WriteLine("2 - Plantio Sustentável Otimizado (desconto de 10%)");
        Console.WriteLine("3 - Sem ajuste");

        int opcao = LerOpcaoDeAjuste();

        double valorAjuste = 0;
        string nomeDoAjuste = "Sem ajuste";

        if (opcao == 1)
        {
            valorAjuste = custoTotalBase * 0.15;
            nomeDoAjuste = "Tratamento de Urgência";
        }
        else if (opcao == 2)
        {
            valorAjuste = -custoTotalBase * 0.10; // desconto
            nomeDoAjuste = "Plantio Sustentável Otimizado";
        }

        double custoFinal = custoTotalBase + valorAjuste;

        // Atualiza o estoque (remove as quantidades efetivamente liberadas)
        for (int i = 0; i < nomesValidos.Count; i++)
        {
            string nomeProduto = nomesValidos[i];
            int quantidadePedida = quantidadesValidas[i];

            // Busca o índice do produto
            int indice = -1;
            for (int j = 0; j < Insumos.Count; j++)
            {
                if (Insumos[j] == nomeProduto)
                {
                    indice = j;
                    break;
                }
            }

            if (indice != -1)
            {
                QtdDisponivel[indice] -= quantidadePedida;
            }
        }

        // Emite manifesto com os itens válidos processados
        EmitirManifestoDeDespacho(
            nomeDoSetor,
            nomesValidos,
            quantidadesValidas,
            custosUnitarios,
            nomeDoAjuste,
            custoTotalBase,
            valorAjuste,
            custoFinal);

        AtualizarBalancoEcologico(custoFinal);

        return custoFinal;
    }

    // Emite um comprovante simples de distribuição
    static void EmitirManifestoDeDespacho(
        string nomeDoSetor,
        List<string> itensRequisitados,
        List<int> quantidadesRequisitadas,
        List<double> custosUnitarios,
        string nomeDoAjuste,
        double custoBase,
        double valorAjuste,
        double custoFinal)
    {
        Console.WriteLine();
        Console.WriteLine("====================================================");
        Console.WriteLine("Manifesto de Distribuição");
        Console.WriteLine("====================================================");
        Console.WriteLine($"Setor agrícola assistido: {nomeDoSetor}");
        Console.WriteLine($"Tipo de ajuste aplicado: {nomeDoAjuste}");
        Console.WriteLine();
        Console.WriteLine("Itens liberados do inventário:");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("{0,-25}{1,8}{2,15}{3,15}", "Insumo", "Qtd", "Valor Unit.", "Subtotal");

        for (int indice = 0; indice < itensRequisitados.Count; indice++)
        {
            double subtotalDoItem = quantidadesRequisitadas[indice] * custosUnitarios[indice];
            Console.WriteLine($"{itensRequisitados[indice],-25}{quantidadesRequisitadas[indice],8}{custosUnitarios[indice],15:F2}{subtotalDoItem,15:F2}");
        }

        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($"Custo base: {custoBase:F2} CV");
        Console.WriteLine($"Ajuste aplicado: {valorAjuste:F2} CV");
        Console.WriteLine($"Custo final consolidado: {custoFinal:F2} CV");
        Console.WriteLine("====================================================");
    }

    // Atualiza acumuladores do balanço ecológico geral
    static void AtualizarBalancoEcologico(double custoFinalDaOrdem)
    {
        _totalCreditosVerdesMovimentados += custoFinalDaOrdem;
        _totalOrdensFinalizadas++;
    }

    // Exibe o relatório de eficiência geral da estufa
    static void ExibirBalancoEcologico()
    {
        Console.WriteLine();
        Console.WriteLine("====================================================");
        Console.WriteLine("Relatório de Eficiência Geral");
        Console.WriteLine("====================================================");
        Console.WriteLine($"Total de Créditos Verdes movimentados: {_totalCreditosVerdesMovimentados:F2} CV");
        Console.WriteLine($"Total de ordens finalizadas com sucesso: {_totalOrdensFinalizadas}");
        Console.WriteLine("====================================================");
    }

    // Obtém o total de créditos verdes movimentados
    static double ObterTotalCreditosVerdesMovimentados()
    {
        return _totalCreditosVerdesMovimentados;
    }

    // Obtém o total de ordens finalizadas
    static int ObterTotalOrdensFinalizadas()
    {
        return _totalOrdensFinalizadas;
    }

    // Registra um reabastecer de produtos (compra do fornecedor)
    // Adiciona o custo à movimentação de Créditos Verdes mas NÃO conta como ordem finalizada
    static void RegistarReabastecimentoNoBalanco(double custoDaCompra)
    {
        _totalCreditosVerdesMovimentados += custoDaCompra;
    }

    // Função auxiliar para ler a opção de ajuste com validação
    static int LerOpcaoDeAjuste()
    {
        while (true)
        {
            Console.Write("Digite a opção desejada: ");
            string? textoDigitado = Console.ReadLine();

            if (int.TryParse(textoDigitado, out int opcao) && opcao >= 1 && opcao <= 3)
            {
                return opcao;
            }

            Console.WriteLine("Opção inválida. Tente novamente usando 1, 2 ou 3.");
        }
    }
}