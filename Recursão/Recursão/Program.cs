using System;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Recursao
{
    class Algoritimo
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Regressiva:");
            Regressiva(5);
            Console.WriteLine("\nFatorial = " + Fat(5));
            */
            int[] list = { 1, 2, 3, 4, 5 };
            Console.WriteLine(Sum(list)); 
        }
        static void Regressiva(long i)
        {
            Console.WriteLine("n = " + i);
            if (i <= 1)
            {
                return;
            }
            else
            {
                Regressiva(i - 1);
            }
            
        }

        static int Fat(int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else
            {
                return i * Fat(i - 1);
            }
        }

        static int Sum(int[] list)
        {
            int soma = 0;
            
            if (list.Length == 0)
            {
                return 0;
            }
            else
            {
                soma = list[0] + Sum(list);
                return soma;
            }

        }
    }
}