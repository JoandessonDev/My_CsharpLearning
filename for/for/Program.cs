using System;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros voce vai somar?   ");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Digite o {i}º Numero:   ");
                int numero = int.Parse(Console.ReadLine());
                sum += numero;
                Console.WriteLine(sum);
            }
        }
    }
}
