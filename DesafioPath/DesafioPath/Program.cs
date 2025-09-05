using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Globalization;
using DesafioPath;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\JOANDESSON\Desktop\testedoc";

            try
            {
                string directory = path + @"\out";
                Directory.CreateDirectory(directory);

                string[] lines = File.ReadAllLines(@"C:\Users\JOANDESSON\Desktop\testedoc\filetest.csv");

                using (StreamWriter sw = File.AppendText(@"C:\Users\JOANDESSON\Desktop\testedoc\out\summary.csv"))
                {
                    
                    foreach (string line in lines)
                    {

                        string[] novalista = line.Split(',');

                        string nome = novalista[0];
                        double price = double.Parse(novalista[1], CultureInfo.InvariantCulture);
                        
                        Product product = new Product(nome, price);

                        string newLine = ($"{product.Name},{product.Price}");
                        sw.WriteLine(newLine);


                    }
                }
               
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}