using System;
using System.Collections.Concurrent;

namespace mynamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Maior = " + Maior(n1, n2, n3));


        }

        static int Maior(int a, int b, int c)
        {
            int M;

            if (a >= b && a >= c)
            {
                M = a;
            }
            else if (b >= c) 
            { 
                M = b;
            }
            else
            {
                M = c;
            }
            return M;
        }
    }
}