using System.Globalization;

namespace RevPolimorismo.Entites
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}  e meu salario é : {Salario.ToString("f2", CultureInfo.InvariantCulture)}");

        }
    }
}
