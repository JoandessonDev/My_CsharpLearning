using RevPolimorismo.Entites;
using System;

namespace RevPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa { Nome = "Joandesson", Email = "joandesson.rocha@gmail.com"};
            p1.Apresentar();

            Aluno aluno = new Aluno { Nome = "Magno", Nota = 9.5 };
            aluno.Apresentar();

            Professor professor = new Professor { Nome = "Carlos", Salario = 3450M };
            professor.Apresentar();
        }
    }
}