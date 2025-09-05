
using System;
using Newtonsoft.Json;
namespace Serialização
{
    class Programa
    {
        static void Main(string[] args)
        {


            List<Venda> list = new List<Venda> {
                new Venda(1, "Materia de Escritorio", 25.00M),
                new Venda(1, "Books", 45.00M),
                new Venda(3, "Electronics", 430M)
                };

            string serializado = JsonConvert.SerializeObject(list, Formatting.Indented);
            foreach (Venda v in list)
            {
                var temp = JsonConvert.SerializeObject(v, Formatting.Indented);
                Console.WriteLine(temp);

            }

            File.WriteAllText(@"C:\Users\JOANDESSON\Desktop\vendas.json", serializado);

        }
    }
}
