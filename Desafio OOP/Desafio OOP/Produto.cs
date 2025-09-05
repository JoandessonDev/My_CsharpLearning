using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_OOP
{
    internal class Produto
    {
        public string Name;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) 
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            string dados = ($"Dados do produto:\n{Name}, {Preco.ToString(CultureInfo.InvariantCulture)}," +
                            $" {Quantidade.ToString(CultureInfo.InvariantCulture)}" +
                            $" unidades, Total: $ {ValorTotalEmEstoque().ToString(CultureInfo.InvariantCulture)}");
            return dados;

        }

    }
}
