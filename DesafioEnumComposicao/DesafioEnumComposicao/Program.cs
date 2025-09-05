using System;
using DesafioEnumComposicao.Entites;
using DesafioEnumComposicao.Entites.Enum;
using System.Globalization;
namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {

            //Coletando os Dados para instanciar um Cliente
            Console.WriteLine("Enter Client Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("BirthDate (DD/MM/YYYY) : ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            //Instanciando um novo cliente
            Client client = new Client(name, email, birthDate);

            Console.WriteLine("\nEnter Order Data:");
            Console.Write("Status: ");
            string status = Console.ReadLine();

            Console.Write("How Many items to this Order? ");
            int orderItems = int.Parse(Console.ReadLine());

            //Instaniando uma nova ordem
            Order order = new Order(
                DateTime.Now,
                Enum.Parse<OrderStatus>(status),
                client
                );

            for (int i = 0; i < orderItems; i++)
            {
                Console.WriteLine($"Enter #{i+1} Item data:");
                Console.Write("Product Name:");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem Item = new OrderItem(quantity);
                Item.AddProduct(product);
                order.AddItem(Item);
            }

            Console.WriteLine(order);
            





        }
    }
}