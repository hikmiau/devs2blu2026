using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaPOO05.Exercicios;
using AulaPOO05.TrabalhoCafeteria;

namespace AulaPOO05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrabalhoCafeteria();
        }

        static void Ex01()
        {
            Produto p1 = new Produto("Casaco", 10, 20);
            p1.PrecoBase = 900;
        }

        static void Ex02()
        {
            Termometro tm = new Termometro();
            tm.Celsius = 80;
        }

        static void Ex03()
        {
            TanqueCombustivel t1 = new TanqueCombustivel(50.0, 10.0);
            t1.Abastecer(25.0);
        }

        public static void TrabalhoCafeteria()
        {
            List<ItemCardapio> listaCardapio = new List<ItemCardapio>();
            int proximoId = 1;
            bool rodando = true;

            while (rodando)
            {
                Console.WriteLine("\n--- MENU CAFETERIA ---");
                Console.WriteLine("1. Cadastrar Item");
                Console.WriteLine("2. Listar Cardápio");
                Console.WriteLine("3. Aplicar Desconto");
                Console.WriteLine("4. Pausar/Reativar Vendas");
                Console.WriteLine("5. Remover Item");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Categoria: ");
                    string categoria = Console.ReadLine();
                    Console.Write("Preço Base: ");
                    decimal preco = Convert.ToDecimal(Console.ReadLine());

                    ItemCardapio novo = new ItemCardapio(proximoId, nome, categoria, preco, true);
                    listaCardapio.Add(novo);

                    Console.WriteLine("Item adicionado com ID " + proximoId);
                    proximoId++;
                }
                else if (opcao == "2")
                {
                    Console.WriteLine("\n--- ITENS ---");
                    foreach (ItemCardapio item in listaCardapio)
                    {
                        Console.WriteLine(
                            "ID: "
                                + item.Id
                                + " | "
                                + item.Nome
                                + " | R$ "
                                + item.PrecoBase
                                + " | Disponível: "
                                + item.EstaDisponivel
                        );
                    }
                }
                else if (opcao == "3")
                {
                    Console.Write("Digite o ID do item: ");
                    int idAlvo = Convert.ToInt32(Console.ReadLine());

                    foreach (ItemCardapio item in listaCardapio)
                    {
                        if (item.Id == idAlvo)
                        {
                            Console.Write("Porcentagem de desconto: ");
                            decimal porcentagemDeDesconto = Convert.ToDecimal(Console.ReadLine());
                            item.AplicarDesconto(porcentagemDeDesconto);
                        }
                    }
                }
                else if (opcao == "4")
                {
                    Console.Write("Digite o ID do item: ");
                    int idAlvo = Convert.ToInt32(Console.ReadLine());

                    foreach (ItemCardapio item in listaCardapio)
                    {
                        if (item.Id == idAlvo)
                        {
                            Console.WriteLine("1. Pausar Vendas | 2. Reativar Vendas");
                            string escolha = Console.ReadLine();
                            if (escolha == "1")
                                item.PausarVendas();
                            if (escolha == "2")
                                item.ReativarVendas();
                            Console.WriteLine("Disponibilidade alterada.");
                        }
                    }
                }
                else if (opcao == "5")
                {
                    Console.Write("Digite o ID do item para remover: ");
                    int idAlvo = Convert.ToInt32(Console.ReadLine());

                    ItemCardapio itemParaRemover = null;

                    foreach (ItemCardapio item in listaCardapio)
                    {
                        if (item.Id == idAlvo)
                        {
                            itemParaRemover = item;
                        }
                    }

                    if (itemParaRemover != null)
                    {
                        listaCardapio.Remove(itemParaRemover);
                        Console.WriteLine("Item removido com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Item não encontrado.");
                    }
                }
                else if (opcao == "6")
                {
                    rodando = false;
                    Console.WriteLine("Saindo do sistema...");
                }
            }
        }
    }
}
