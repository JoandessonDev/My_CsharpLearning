using Desafio_OOP;
using System.Globalization;
using System;

namespace Myprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto coca = new Produto();

            Console.WriteLine("Entre com os dados do produto:   ");
            Console.Write("Name:    ");
            coca.Nome = Console.ReadLine();

            Console.Write("Preco:    ");
            coca.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em Estoque:   ");
            coca.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(coca);

            Console.WriteLine("Quantos Produtos deseja adcionar?   ");
            int add = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            coca.AdicionarProdutos(add);

            Console.WriteLine(coca);

            Console.WriteLine("Quantos produtos deja Remover?    ");
            int remove = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            coca.RemoverProdutos(remove);

            Console.WriteLine("Dados Atualizados: " + coca);
        }
    }
}
