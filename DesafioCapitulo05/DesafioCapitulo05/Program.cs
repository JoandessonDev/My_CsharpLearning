using System;
using System.Globalization;
using DesafioCapitulo05;

namespace DefaioFinal05
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Entre com o Numero da Conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular da Conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Haverá deposito incial? [s/n]");
            char escolha = char.Parse(Console.ReadLine());

            double saldo = 0.00;

            if (escolha == 's')
            {
                Console.Write("Entre com o valor do Deposito Incial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            Conta conta1 = new Conta(numeroDaConta, titular, saldo);

            Console.WriteLine($"Dados da Conta:\n {conta1}\n");

            Console.Write("Entre com um valor para deposito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.RealizarDeposito(valorDeposito);
            Console.WriteLine();
            Console.WriteLine(conta1);

            Console.Write("Entre com o Valor do Saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.RealizarSaque(valorSaque);
            Console.WriteLine();
            Console.WriteLine(conta1);



        }
    }
}