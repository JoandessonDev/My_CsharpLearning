using System;
using System.Timers;

namespace Mynamespace
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static int[] QuickSort(int[] lista)
        {
            int pivo = lista[0];
            int[] menorValor = new int[lista.Length];
            int[] maiorValor = new int[lista.Length];

            if (lista.Length > 2)
            {
                foreach (int i in lista)
                {
                    if (lista[i] > pivo)
                    {
                        menorValor[0] = i;
                    }
                    else
                    {
                        maiorValor[0] = i;
                    }
                }
                return (QuickSort(menorValor) + [pivo] + QuickSort(maiorValor));


            }else return lista; 
        }
    }
}