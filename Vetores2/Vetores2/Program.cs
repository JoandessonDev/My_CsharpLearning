using System;
using System.Globalization;
using Vetores2;

namespace Mynamespace
{
    class Program_vect
    {
        static void Main(string[] args)
        {
            Console.Write("Produtos a cadastrar: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];
            double sum = 0.00;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };

                sum += vect[i].Price;

            }
            Console.WriteLine($"Media de preços: {(sum / n).ToString("F2", CultureInfo.InvariantCulture)}");

            


        }
    }
}