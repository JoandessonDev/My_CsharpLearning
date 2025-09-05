using System;
using System.Globalization;
using ex_membros_estaticos;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do Dolar:    ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos Dolares deseja Comprar?    ");
            double compra = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em Reais:   {ConversorMoeda.ConverterMoeda(cot, compra).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}