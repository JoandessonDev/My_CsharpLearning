using System;
using ex01oop;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Nome da primeira Pessoa:    ");
            a.Name = Console.ReadLine();

            Console.WriteLine("Digite a Idade da Primeira Pessoa:    ");
            a.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da Segunda Pessoa:   ");
            b.Name = Console.ReadLine();

            Console.WriteLine("Digite a idade da segunda Pessoa:   ");
            b.Age = int.Parse(Console.ReadLine());

            if (a.Age > b.Age)
            {
                Console.WriteLine($"{a.Name} e o(a) mais velho(a)");
            }
            else
            {
                Console.WriteLine($"{b.Name} e o(a) mais velho(a)");
            }

        }
    }
    
}

