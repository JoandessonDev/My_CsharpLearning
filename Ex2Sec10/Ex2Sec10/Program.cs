using System;
using System.Globalization;
using Ex2Sec10.Entites;

namespace Sesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuente> contribuientes = new List<Contribuente>();

            Console.Write("Enter of the number of tax payers: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data:");

                Console.Write("Individual or Company (i/c): ");
                char c = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual Income:");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (c == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double gastosComSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Contribuente Pf = new PessoaFisica(name, rendaAnual, gastosComSaude);
                    contribuientes.Add(Pf);
                }
                else
                {
                    Console.Write("Number of Employee: ");
                    int numeroDeFuncionarios = int.Parse(Console.ReadLine());

                    Contribuente Pj = new PessoaJuridica(name, rendaAnual, numeroDeFuncionarios);
                    contribuientes.Add(Pj);
                }
                
            }

            Console.WriteLine("\nTAXES PAID:");
            foreach (Contribuente contribuente in contribuientes)
            {
                Console.WriteLine($"{contribuente.Nome}: $ {contribuente.CalcularImposto().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            double totalTaxes = 0;
            foreach(Contribuente contribuente in contribuientes )
            {
                totalTaxes += contribuente.CalcularImposto();
            }
            
            Console.WriteLine($"\nTOTAL TAXES: {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
