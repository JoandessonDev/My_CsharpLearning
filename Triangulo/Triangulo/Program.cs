using System.Globalization;
using Triangulo;

namespace name
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTriangulo x, y;

            x = new MyTriangulo();
            y = new MyTriangulo();


            Console.WriteLine("Entre com as medidas do Triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do Triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Area de X: {y.Area().ToString("f4", CultureInfo.InvariantCulture)}\n" +
                $"Area de Y:  {x.Area().ToString("f4", CultureInfo.InvariantCulture)}");

            if (x.Area() > y.Area())
            {
                Console.WriteLine("Maior Area: X");
            }
            else
            {
                Console.WriteLine("Maior Area: Y");
            }


        }

    }
}