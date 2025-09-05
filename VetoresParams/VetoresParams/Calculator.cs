using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresParams
{
    internal class Calculator
    {
        public static int Sum(params int[] numbers)
        {
            int soma = 0;
            for (int i = 0; i < numbers.Length; i++)            
            {
                soma += numbers[i];
               
            }
            return soma;
        }
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

    }
}
