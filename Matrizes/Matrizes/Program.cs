using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual tamanho da sua matriz");
            int tamanho = int.Parse(Console.ReadLine());

            int[,] mat = new int[tamanho, tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < tamanho; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine();
            }

        }

        static void Trasversal(int[,] mat)
        {

        }
    }
}