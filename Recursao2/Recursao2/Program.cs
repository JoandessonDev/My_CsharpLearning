using System;

namespace Mynamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 2, 30, 4, 500, 289 };


            Console.WriteLine("List numbers:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n\nFunction MajorSize: " + MajorSize(numbers, 0, 0));
            Console.WriteLine("Function Pesquisa Binaria: " + SeachBin(numbers, 289, 0,0));


        }

        static int Sum(int[] Lista, int index, int somaElementos)
        {
            somaElementos += Lista[index];

            if (index < Lista.Length - 1)
            {
                return Sum(Lista, index + 1, somaElementos);
            }
            else
            {
                return somaElementos;
            }
        }
        static int Tamanho(int[] Lista, int tamanho)
        {

            if (Lista[tamanho] == 0)
            {
                return tamanho;

            }
            else
            {
                return Tamanho(Lista, tamanho + 1);
            }
        }

        static int MajorSize(int[] lista, int index, int maiorValor)
        {

            if (index < lista.Length)
            {
                if (maiorValor < lista[index])
                {
                    maiorValor = lista[index];
                }

                return MajorSize(lista, index + 1, maiorValor);
            }
            else
            {
                return maiorValor;
            }

        }
        /*
        static int SeachBin(int[] lista, int n, int metade, int value)
        {
            metade = lista.Length / 2;
            value = lista[metade];

            if (n == value)
            {
                return value;
            }
            else
            {
                if (n < value)
                {
                    return SeachBin(lista, n, metade, value);
                }
                else
                {
                    if(metade%2 == 0)
                    {
                        return SeachBin(lista, n, metade * 3, value);
                    }
                    else
                    {
                        return SeachBin(lista, n, (metade * 3)-1, value);
                    }
                }

            }

        }*/
    }
}