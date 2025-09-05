using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DesafioCapitulo05
{
    internal class Conta
    {
        private int _numeroDaConta;
        public string Titular;
        public double Saldo { get; private set; }

        public Conta(int numeroDaConta, string titular)
        {
            NumeroDaconta = numeroDaConta;
            Titular = titular;
        }

        public Conta(int numeroDaConta, string titular, double depositar) : this(numeroDaConta, titular)
        {
            RealizarDeposito(depositar);
        }

        public int NumeroDaconta
        {
            get
            {
                return _numeroDaConta;
            }
            set
            {
                if (value > 1000)
                {
                    _numeroDaConta = value;
                }
                else
                {
                    Console.WriteLine("Numero de Conta não pode ser cadastrado.");
                }
            }
        }
        public void RealizarDeposito(double valorDeposito)
        {
            if (valorDeposito > 0)
            {
                Saldo += valorDeposito;
                Console.WriteLine("Deposito Realizado com Sucesso!");
            }
            else
            {
                Console.WriteLine("Valor minimo de 0.01");
            }
        }

        public void RealizarSaque(double valorSaque)
        {
            if (valorSaque <= Saldo && valorSaque != 0.00)
            {
                Saldo = (Saldo - valorSaque - 5.00);

            }
            else if (valorSaque > Saldo)
            {
                Console.WriteLine("Saldo Insuficiente");
            }
            else
            {
                Console.WriteLine("Valor Invalido!");
            }

        }
        public void Teste()
        {
            var a = 10;
        }
        public override string ToString()
        {

            string dados = ($"Conta: {_numeroDaConta}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            return dados;

        }
    }
}
