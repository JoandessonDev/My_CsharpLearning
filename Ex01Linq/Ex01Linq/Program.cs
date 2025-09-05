using System;
using System.IO;
using System.Threading.Channels;
using System.Globalization;
using Ex01Linq.Entites;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\JOANDESSON\Desktop\C#\Course_Nelio\Logic_with_C#\Ex01Linq\.vs\Ex01Linq\in.txt";
            try
            {
                List<Product> products = new List<Product>();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] line = sr.ReadLine().Split(',');
                        
                        string name = line[0];
                        double price = double.Parse(line[1].ToString(CultureInfo.InvariantCulture));

                        products.Add(new Product(name, price));
                    }
                }

                var query1 = products.Average(p => p.Price);
                var query2 = products.Where(p => p.Price < query1).Select(p => p.Name);

                Console.WriteLine("Mean product Prices: " + query1);
                foreach (string product in query2)
                {
                    Console.WriteLine(product);
                }
            }
            catch(IOException e) 
            {
                Console.WriteLine("OCORRUED AN ERROR!");
                Console.WriteLine(e.Message);
            }
            


            
        }
    }
}