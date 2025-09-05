using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritorio";

            byte idade = 30;
            int codigo = 5325;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:f2}");
            Console.WriteLine($"{produto2} cujo preço é  ${preco2:f2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e gênero {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com 8 casa decimais: {medida}");
            Console.WriteLine($"Arredondado (3 casas decimais): {medida:f3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("f3", CultureInfo.InvariantCulture)}");

        }
    }
}