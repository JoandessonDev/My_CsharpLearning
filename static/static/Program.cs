using System;
using System.Globalization;
using Calcu;

namespace Mynamespace
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Calculadora Cal = new Calculadora();

            Console.Write("Write the value Raio:    ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);   

            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine($"\nCircunferencia:    {circ.ToString("F2", CultureInfo.InvariantCulture)}");

            double volume  = Calculadora.Volume(raio);
            Console.WriteLine($"Volume:    {volume.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Pi:   {Calculadora.Pi}");

        }
        



    }
}
