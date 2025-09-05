using System;
using System.Linq;
using DemoLinq_.Entites;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Course
{
    class Program
    {
        static void Print<T>(string mensage, IEnumerable<T> colection)
        {
            Console.WriteLine(mensage);

            foreach (T obj in colection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };


            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var query0 = products.OrderBy(p => p.Name).ThenBy(p => p.Price);
            Print("", query0);

            //var query1 = products.Where(p => p.Category == c1 && p.Price < 900);
            var query1 = 
                from p in products
                where p.Category.Tier == 1 && p.Price < 900
                select p;

            Print("Category: C1 Price < 900:", query1);


            //var query2 = products.Where(p => p.Category == c1).Select(p => p.Name);
            var query2 = 
                from p in products
                where p.Category == c1
                select p.Name;

            Print("Name of Product from Tolls:", query2);



            //var query3 = products.Where(p => p.Name[0] == 'N').Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name});
            var query3 =
                from p in products
                where p.Name[0] == 'N'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                };
            Print("Product: ", query3);

            var query4 = products.FirstOrDefault();
            Console.WriteLine(query4);

            var query5 = products.Max(p => p.Price);
            Console.WriteLine("Max Value: " + query5);

            var query6 = products.Where(p => p.Category == c2).Sum(p => p.Price);
            Console.WriteLine("Sum values category 2: " + query6);

            var query7 = products.Where(p => p.Category == c2).Average(p => p.Price);
            Console.WriteLine("Average values category 2: " + query7);

            var query8 = products.GroupBy(p => p.Category);

            foreach ( var group in query8)
            {
                Console.WriteLine("Category" + group.Key.Name + ":");
                foreach( var produto in group)
                {
                    Console.WriteLine(produto);
                }
                Console.WriteLine();
            }

        }
    }
}