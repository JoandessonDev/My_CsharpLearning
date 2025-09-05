using Iterfaces.Entites;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato contrato = new Contrato(320, 3, 600.00);
            contrato.CalcularContrato();
            Console.WriteLine(contrato.TotalValue);
            contrato.ImprimirParcelas();

        }
    }
}