using System;
using System.Globalization;
using System.Security.Cryptography;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 1; i < 5;  i++)
            {
                Console.Write($"Digite sua {i} nota: ");
                double nota = Convert.ToDouble(Console.ReadLine());

                while (nota > 10)
                {
                    Console.WriteLine("Nota Invalida!.\n Try Again");
                    Console.Write($"Digite sua {i} nota: ");
                    nota = Convert.ToDouble(Console.ReadLine());
                }
                    
                sum += nota;          
                
            }

            double media = sum / 4;

            Console.WriteLine($"Media = {media.ToString(CultureInfo.InvariantCulture)}");

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!\n");
            }
            else
            {
                Console.WriteLine("Reprovado\n");
            }

        }
    }
}