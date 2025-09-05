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
        private string _nome;
        public double Preco {  get ; private set; }
        public int Quantidade { get; private set; }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != null && value.Length > 0)
                {
                    _nome = value;
                }
                else
                {
                    _nome = "Indefinido";
                }
            }
        }



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
            string dados = ($"Dados do produto:\n{Nome}, {Preco.ToString(CultureInfo.InvariantCulture)}," +
                            $" {Quantidade.ToString(CultureInfo.InvariantCulture)}" +
                            $" unidades, Total: $ {ValorTotalEmEstoque().ToString(CultureInfo.InvariantCulture)}");
            return dados;

        }

    }
}