using System;
using System.Globalization;

namespace Mynamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();  
            string z = Console.ReadLine();

            string[] vetor = Console.ReadLine().Split(' ');

            string name = vetor[0];
            string lastname = vetor[1];

            Console.WriteLine("\nVocê Digitou:\n");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine($"{name} seu sobrenome é : {lastname}");
        }
    }
}