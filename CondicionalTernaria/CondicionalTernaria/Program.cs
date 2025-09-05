using System;

namespace Mynamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = 200;

            var desconto = (resultado < 100) ? resultado * 0.9 : resultado * 0.8;

            Console.WriteLine(Regressiva(desconto));
            
        }

        static double Regressiva(double x)
        {
            Console.WriteLine(x);

            if (x == 0)
            {
                return x;
            }
            else
            {
                return Regressiva(x-1);
            }
        }
    }
}
