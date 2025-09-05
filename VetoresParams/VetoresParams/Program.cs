using System;
using System.Runtime.Serialization;
using System.Xml.Schema;
using VetoresParams;
namespace Mynamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];

            int soma = Calculator.Sum(3, 5, 6, 7, 8, 9, 10, 11, 12);
            Console.WriteLine(soma);
            /*
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            for (int i = 0;i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }*/
            
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
        
    }
}