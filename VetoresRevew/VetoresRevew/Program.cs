using System;
using System.Globalization;
using VetoresRevew;

namespace Mynamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão ocupados? ");
            int n = int.Parse(Console.ReadLine());

            string[] rooms = new string[9];
            Aluno[] alunos = new Aluno[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.WriteLine("Email: ");
                string email = Console.ReadLine();

                Console.WriteLine("Numero do quarto");
                int quarto = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno { Nome = name, Email = email};

                rooms[quarto] = alunos[i].Nome + alunos[i].Email;

            }


        }
    }
}