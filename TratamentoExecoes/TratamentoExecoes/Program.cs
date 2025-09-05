using System;
using System.Globalization;
using TratamentoExecoes.Entites;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Check-In date (dd/mm/yyyy)");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Check-Out date (dd/mm/yyyy)");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());




        }
    }
}