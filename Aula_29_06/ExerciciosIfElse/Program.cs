namespace ExerciciosIfElse;

class Program
{
    static void Main(string[] args)
    {
        ex16();
        
        static void ex11()
        {
            /*
            As Organizações Tabajara resolveram dar um aumento de salário aos seus
            colaboradores e lhe contrataram para desenvolver o programa que calculará os
            reajustes.
            Faça um programa que recebe o salário de um colaborador e o reajuste
            segundo o seguinte critério, baseado no salário atual:
            salários até R$ 280,00 (incluindo) : de 20%
            salários entre R$ 280,00 e R$ 700,00 : aumento de 15%
            salários entre R$ 700,00 e R$ 1500,00 : aumento de 10%
            salários de R$ 1500,00 em diante : aumento de 5%
            Após o aumento ser realizado, informe na tela:
            o salário antes do reajuste;
            o percentual de aumento aplicado;
            o valor do aumento;
            o novo salário, após o aumento.
            */

            double salario = 0;
            double aumentoPercentual = 0;

            Console.WriteLine("Digite o valor do salario: ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario <= 280)
            {
                aumentoPercentual = 20;
            } else if  (salario > 280 && salario < 700)
            {
                aumentoPercentual = 15;
            } else if (salario > 700 && salario < 1500)
            {
                aumentoPercentual = 10;
            }
            else
            {
                aumentoPercentual = 5;
            }
            
            double salarioAumento = salario * (aumentoPercentual / 100);
            double salarioPosAumento = salario + salarioAumento;

            Console.WriteLine("\nSalario antes do reajuste: R$" +  salario.ToString("N2"));
            Console.WriteLine("Percentual de aumento aplicado: " + aumentoPercentual + "%") ;
            Console.WriteLine("Valor do aumento: R$" + salarioAumento.ToString("N2")) ;
            Console.WriteLine("Novo salario apos o aumento: R$" +  salarioAumento.ToString("N2"));
        }

        static void ex16()
        {
            Console.WriteLine("*** CALCULADORA DE BHASKARA ***");

            double coeficienteA;
            while (true)
            {
                Console.Write("Informe o valor do coeficiente a: ");
                string entrada = Console.ReadLine();
                if (double.TryParse(entrada, out coeficienteA)) break;
                Console.WriteLine("Entrada inválida. Digite um número.");
            }

            if (coeficienteA == 0)
            {
                Console.WriteLine("Coeficiente a é igual a zero. Não é uma equação de segundo grau.");
                return;
            }

            double coeficienteB;
            while (true)
            {
                Console.Write("Informe o valor do coeficiente b: ");
                string entrada = Console.ReadLine();
                if (double.TryParse(entrada, out coeficienteB)) break;
                Console.WriteLine("Entrada inválida. Digite um número.");
            }

            double coeficienteC;
            while (true)
            {
                Console.Write("Informe o valor do coeficiente c: ");
                string entrada = Console.ReadLine();
                if (double.TryParse(entrada, out coeficienteC)) break;
                Console.WriteLine("Entrada inválida. Digite um número.");
            }

            double delta = coeficienteB * coeficienteB - 4 * coeficienteA * coeficienteC;
            if (delta < 0)
            {
                Console.WriteLine("A equação não possui raízes reais (delta negativo).");
                return;
            }

            if (delta == 0)
            {
                double raizUnica = -coeficienteB / (2 * coeficienteA);
                Console.WriteLine($"Raiz única: {raizUnica:F2}");
                return;
            }

            double raiz1 = (-coeficienteB + Math.Sqrt(delta)) / (2 * coeficienteA);
            double raiz2 = (-coeficienteB - Math.Sqrt(delta)) / (2 * coeficienteA);
            Console.WriteLine($"Raiz 1: {raiz1:F2}");
            Console.WriteLine($"Raiz 2: {raiz2:F2}");
        }
        
        static void ex25()
        {
            /*
            Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As
            perguntas são:
            "Telefonou para a vítima?"
            "Esteve no local do crime?"
            "Mora perto da vítima?"
            "Devia para a vítima?"
            "Já trabalhou com a vítima?" O programa deve no final emitir uma
            classificação sobre a participação da pessoa no crime. Se a pessoa
            responder positivamente a 2 questões ela deve ser classificada como
            "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como "Assassino". Caso
            contrário, ele será classificado como "Inocente".
            */
            
            int contadorSim = 0;
            string classificacao = "";

            Console.WriteLine("Telefonou para a vitima?");
            if (PerguntaSimNao() == "s") contadorSim++;

            Console.WriteLine("Esteve no local do crime?");
            if (PerguntaSimNao() == "s") contadorSim++;

            Console.WriteLine("Mora perto da vitima?");
            if (PerguntaSimNao() == "s") contadorSim++;

            Console.WriteLine("Devia para a vitima?");
            if (PerguntaSimNao() == "s") contadorSim++;

            Console.WriteLine("Ja trabalhou com a vitima?");
            if (PerguntaSimNao() == "s") contadorSim++;

            if (contadorSim == 2)
            {
                classificacao = "Suspeito(a)";
            }
            else if (contadorSim == 3 || contadorSim == 4)
            {
                classificacao = "Cumplice";
            }
            else if (contadorSim == 5)
            {
                classificacao = "Assassino(a)";
            }
            else
            {
                classificacao = "Inocente";
            }

            Console.WriteLine("Classificacao: " + classificacao);
        }

        static string PerguntaSimNao()
        {
            string resposta = "";
            bool respostaValida = false;

            while (!respostaValida)
            {
                Console.WriteLine("Digite 's' (sim) ou 'n' (nao):");
                resposta = Console.ReadLine()?.ToLower().Trim();

                if (resposta == "s" || resposta == "n")
                {
                    respostaValida = true;
                }
                else
                {
                    Console.WriteLine("Resposta invalida. Tente novamente.\n");
                }
            }

            Console.WriteLine();
            return resposta;
        }

        static void ex26()
        {
            /* Um posto está vendendo combustíveis com a seguinte tabela de descontos:
             * Álcool: até 20 litros, desconto de 3% por litro
             * acima de 20 litros, desconto de 5% por litro
             * Gasolina: até 20 litros, desconto de 4% por litro
             * acima de 20 litros, desconto de 6% por litro
             * Escreva um algoritmo que leia o número de litros vendidos,
             * o tipo de combustível (codificado da seguinte forma: A-álcool, G-gasolina),
             * calcule e imprima o valor a ser pago pelo cliente
             * sabendo-se que o preço do litro da gasolina é R$ 2,50
             * o preço do litro do álcool é R$ 1,90.
             */
            
            int candidato1 = 0;
            int candidato2 = 0;
            int candidato3 = 0;
            int eleitores = 0;
            int candidatos;

            Console.WriteLine("*** ELEICAO ***");
            Console.WriteLine("Candidato 1: Luan");
            Console.WriteLine("Candidato 2: Marcos");
            Console.WriteLine("Candidato 3: Emerson\n");
            Console.WriteLine("Qual o numero total de eleitores? ");
            eleitores = int.Parse(Console.ReadLine());
            
            for (var i = 1; i <= eleitores; i++)
            {
                do
                {
                    Console.WriteLine($"{i} Eleitor: Escolha um candidato para votar (1, 2, 3): ");
                    candidatos = int.Parse(Console.ReadLine());

                    switch (candidatos)
                    {
                        case 1: candidato1++; break;
                        case 2: candidato2++; break;
                        case 3: candidato3++; break;
                        default:
                            Console.WriteLine("Candidato invalido. Tente novamente.\n");
                            break;
                    }
                } while (candidatos != 1 && candidatos != 2 && candidatos != 3);
            }
            Console.WriteLine("*** VOTOS ***");
            Console.WriteLine($"Luan: {candidato1}");
            Console.WriteLine($"Marcos: {candidato2}");
            Console.WriteLine($"Emerson: {candidato3}");
        }
    }
}