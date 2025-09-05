using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TryContaBancaria.Entites.Exceptions;

namespace TryContaBancaria.Entites
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }


        public Account() { }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double value)
        {
            if (value < 0)
            {
                throw new DomainException("Não é possivel depositar um valor Negativo.");
            }

            Balance += value;
        }

        public void WithDraw(double value)
        {
            if (value > WithDrawLimit)
            {
                throw new DomainException($"Valor superior ao Limite de Saque de R$ {WithDrawLimit.ToString("f2")}.");
            }
            else if (value > Balance)
            {
                throw new DomainException("Saldo insuficiente para o saque.");
            }


            Balance -= value;
        }


    }
}
