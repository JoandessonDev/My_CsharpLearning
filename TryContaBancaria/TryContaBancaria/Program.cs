using System;
using System.Globalization;
using TryContaBancaria.Entites;
using TryContaBancaria.Entites.Exceptions;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Account data:");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.WriteLine("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("WithDraw Limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withDrawLimit);

                Console.WriteLine("[w] WithDraw \n[d] Deposit\nResponse: ");
                char response = char.Parse(Console.ReadLine());

                if (response == 'w')
                {
                    Console.WriteLine("Enter Amount WithDraw: ");
                    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    account.WithDraw(value);
                }
                else
                {
                    Console.WriteLine("Enter Amount Deposit: ");
                    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    account.Deposit(value);
                }

            }
            catch( DomainException e )
            {
                Console.WriteLine($"Falha na Operação: {e.Message}");
            }
            catch( FormatException e ) { Console.WriteLine("Format Error: " + e.Message); }
            
            catch ( Exception e ) { Console.WriteLine("Unexpected Error: " + e.Message); }

            finally { Console.WriteLine("Obrigado por ultilizar nossos serviços"); }
        }
    }
}