using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPoo01.Exercicios
{
    internal class ContaBancaria
    {
        public string titular;
        public double saldo;
        public string agencia;

        public ContaBancaria(string titular, double saldo, string agencia)
        {
            this.titular = titular;
            this.saldo = saldo;
            this.agencia = agencia;
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && this.saldo >= valor)
            {
                this.saldo -= valor;
                Console.WriteLine($"Saque de R${valor:F2} realizado.");
            }
            else
            {
                Console.WriteLine("Saque invalido. Valor incorreto ou saldo insuficiente.");
            }
        }
    }
}
