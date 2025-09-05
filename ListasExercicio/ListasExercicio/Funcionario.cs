using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasExercicio
{
    internal class Funcionario
    {
        public string Nome { get; private set; }
        public int Matricula { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, int matricula, double salario) { 
            Nome = nome;
            Matricula = matricula;
            Salario = salario;
        }

        public void AtualizarSalario(double porcentagem)
        {
                porcentagem = porcentagem / 100;
                Salario += Salario * porcentagem;


        }

        public override string ToString()
        {
            return ($"{Nome}, {Matricula}, {Salario.ToString(CultureInfo.InvariantCulture)}");
        }
    }
}
