using LINQ.Entites;
using System.Net.WebSockets;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Produtic> produtcs = new List<Produtic>()
            {
                new Produtic() { Id =  1, Name = "Computer",        Price = 2100.00, Category = c2 },
                new Produtic() { Id =  2, Name = "Hammer",          Price =   70.00, Category = c1 },
                new Produtic() { Id =  3, Name = "TV",              Price = 1800.00, Category = c3 },
                new Produtic() { Id =  4, Name = "Notebook",        Price = 3500.00, Category = c2 },
                new Produtic() { Id =  5, Name = "Saw",             Price =  150.00, Category = c1 },
                new Produtic() { Id =  6, Name = "Tablet",          Price = 1200.00, Category = c2 },
                new Produtic() { Id =  7, Name = "Camera",          Price =  700.00, Category = c3 },
                new Produtic() { Id =  8, Name = "Printer",         Price =  650.00, Category = c3 },
                new Produtic() { Id =  9, Name = "Drill",           Price =  300.00, Category = c1 },
                new Produtic() { Id = 10, Name = "Monitor",         Price =  950.00, Category = c2 },
                new Produtic() { Id = 11, Name = "Keyboard",        Price =  120.00, Category = c2 },
                new Produtic() { Id = 12, Name = "Mouse",           Price =   80.00, Category = c2 },
                new Produtic() { Id = 13, Name = "Smartphone",      Price = 2200.00, Category = c3 },
                new Produtic() { Id = 14, Name = "Backpack",        Price =  150.00, Category = c1 },
                new Produtic() { Id = 15, Name = "Desk Lamp",       Price =   60.00, Category = c3 },
                new Produtic() { Id = 16, Name = "Router",          Price =  200.00, Category = c3 },
                new Produtic() { Id = 17, Name = "Wrench",          Price =   50.00, Category = c1 },
                new Produtic() { Id = 18, Name = "Air Conditioner", Price = 3000.00, Category = c3 },
                new Produtic() { Id = 19, Name = "Refrigerator",    Price = 2500.00, Category = c3 },
                new Produtic() { Id = 20, Name = "Screwdriver Set", Price =  100.00, Category = c1 },
                new Produtic() { Id = 21, Name = "SSD 1TB",         Price =  400.00, Category = c2 },
                new Produtic() { Id = 22, Name = "External HDD",    Price =  150.00, Category = c2 },
                new Produtic() { Id = 23, Name = "Bluetooth Speaker", Price =  300.00, Category = c3 },
                new Produtic() { Id = 24, Name = "Graphic Card",    Price = 4500.00, Category = c2 },
                new Produtic() { Id = 25, Name = "Multimeter",      Price =  220.00, Category = c1 }
            };

            var r1 = produtcs.Where(p => p.Category.Tier == 1)
                .OrderByDescending(p => p.Price)
                .ThenBy(p => p.Name)
                .ToList();
            var product1 = produtcs.Where(p => p.Id == 1).SingleOrDefault();
            var average = produtcs.Average(p => p.Price);
            Console.WriteLine("Media: " + average);
            Console.WriteLine(product1);
            Console.WriteLine("Manjor Product price:" + produtcs.Max(p => p.Price));
            r1.ForEach(Console.WriteLine);

            produtcs.GroupBy(p => p.Category)
                .ToList()
                .ForEach( group =>
                {
                    Console.WriteLine($"Category: {group.Key.Name}");
                    group.ToList().ForEach(Console.WriteLine);
                    Console.WriteLine();
                });
   



        }

    }
}
