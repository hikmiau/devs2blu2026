using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO04.Exercicios
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public decimal Saldo { get; private set; }

        public ContaBancaria(int numero)
        {
            Numero = numero;
            Saldo = 0;
        }

        public bool Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                return false;
            }
            this.Saldo += valor;
            return true;
        }

        public bool Sacar(decimal valor)
        {
            if (valor <= 0)
                return false;
            if (valor > Saldo)
                return false;
            this.Saldo -= valor;
            return true;
        }
    }
}
