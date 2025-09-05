using System;
using System.Globalization;
using System.Collections.Generic;
using ListasExercicio;

namespace Mynamespace
{
    class Program
    {
        static void Main(string[] args) { 
        
            Console.Write("Quantos funcionarios serão cadastrados? ");
            int nFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            

            for (int i = 0; i < nFuncionarios; i++)
            {
                Console.WriteLine($"\n#Funcionario {i+1}");
                Console.Write("\nNome: ");
                string nome = Console.ReadLine();

                Console.Write("Matricula: ");
                int matricula = int.Parse(Console.ReadLine());
                

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(nome, matricula, salario));
            }
            Console.Write("Digite a Matricula do Funcionario que recebera o aumento: ");
            int id = int.Parse(Console.ReadLine());

            Funcionario funcionario = funcionarios.FirstOrDefault(x => x.Matricula == id);

            Console.WriteLine("Qual porcentagem de aumento: ");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.AtualizarSalario(percent);

            Console.WriteLine(funcionario);


            foreach ( Funcionario func in funcionarios )
            {
                Console.WriteLine();
                Console.WriteLine(func.ToString());
            }
            
        }
    }
}