using System;

namespace forex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero:    ");
            int n = int.Parse(Console.ReadLine());

            int input = 0;
            int output = 0;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Digite um numero:");
                int numero = int.Parse(Console.ReadLine());

                if (numero >= 10 && numero <= 20)
                {
                    input += 1;
                }
                else
                {
                    output += 1;
                }
                Console.WriteLine($"{input} input\n{output} output");

            }
        }
    }
}