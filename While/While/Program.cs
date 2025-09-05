using System;

namespace couse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("DIGITE UM NUMERO:");
            double num = double.Parse(Console.ReadLine());

            while (num >= 0.0 )
            {
                double square = Math.Sqrt(num);
                Console.WriteLine(square);

                Console.Write("Digite outro numero");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Numero NEGATIVO!");
        }
    }
}
