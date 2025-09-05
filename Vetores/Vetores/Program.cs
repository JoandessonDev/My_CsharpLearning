using System;
using System.Globalization;

namespace Mynamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Numero de pessoas a cadastrar a altura:");
            int x = int.Parse(Console.ReadLine());

            double[] vec = new double[x];
            double sum = 0;
            for (int i = 0; i < x; i++)
            {
                Console.Write($"Digite a altura da {i+1} Pessoa:");
                vec[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                sum += vec[i];
            }

            double media = sum / x;
            Console.WriteLine($"Media = {media.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}