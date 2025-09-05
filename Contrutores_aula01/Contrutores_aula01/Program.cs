using Desafio_OOP;
using System.Globalization;
using System;

namespace Myprogram
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre com os dados do produto:   ");
            Console.Write("Name:    ");
            string name = Console.ReadLine();

            Console.Write("Preco:    ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em Estoque:   ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto coca = new Produto(name, preco, quantidade);

            Console.WriteLine(coca);

            Console.WriteLine("Quantos Produtos deseja adcionar?   ");
            int add = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            coca.AdicionarProdutos(add);

            Console.WriteLine(coca);

            Produto tv = new Produto("Tv", 900.00);
            Console.WriteLine(tv);

            Produto cama = new Produto {
                Name = "Cama",
                Preco = 2000.0,
                Quantidade = 7
            };
            Console.WriteLine(cama);




            Console.WriteLine("Quantos produtos deja Remover?    ");
            int remove = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            coca.RemoverProdutos(remove);

            Console.WriteLine("Dados Atualizados: " + coca);
            
        }
    }
}