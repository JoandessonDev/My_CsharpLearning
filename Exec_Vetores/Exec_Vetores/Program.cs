using System;
using System.Globalization;
using Exec_Vetores;
namespace Mynamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            string[]rooms = new string[9];
            Pessoa[] pessoas = new Pessoa[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i+1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                pessoas[i] = new Pessoa(name, email, room);

                rooms[room] = ("Nome: " + pessoas[i].Name + " Email: " + pessoas[i].Email);
                

            }
            for (int i = 0;i < 9; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine("Busy Rooms: ");
                    Console.WriteLine($"{i}: {rooms[i]}");

                }
                
            }
        }
    }
}