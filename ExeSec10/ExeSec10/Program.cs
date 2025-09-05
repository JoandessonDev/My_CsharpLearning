using ExeSec10.Entites;
using System;
using System.Globalization;

namespace Section10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int nproduct = int.Parse(Console.ReadLine());

            for (int i = 0; i < nproduct; i++)
            {
                Console.Write("Common, used or Imported (c/u/i): ");
                char chooice = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (chooice)
                {
                    case 'c':
                        Product commumproduct = new Product(name, price);
                        products.Add(commumproduct);
                        break;

                    case 'i':
                        Console.Write("CustomsFee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Product importedProduct = new ImportedProduct(customsFee, name, price);
                        products.Add(importedProduct);
                        break;

                    case 'u':
                        Console.Write("Manufacture Date (dd/mm/yyyy): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        Product usedProduct = new UsedProduct(manufactureDate,name, price);
                        products.Add(usedProduct);
                        break;

                    default:
                        Console.WriteLine("Option Invalid");
                        break;
                }

            }
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}