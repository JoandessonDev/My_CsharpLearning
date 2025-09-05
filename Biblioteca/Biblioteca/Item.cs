using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Biblioteca
{
    internal class Item
    {
        public string Title { get; private set; }
        public string Autor {  get; private set; }
        public string Editora {  get; private set; }

        public int Quantidade;

        public Item(string title, string autor, string editora, int quantidade)
        {
            Title = title;
            Autor = autor;
            Editora = editora;
            Quantidade = quantidade;

        }
        public bool SolicitarEmprestimo(string title)
        {

            if (Title == title && Quantidade > 0)
            {
                Quantidade = Quantidade - 1;
                return true;
            }
            else
            {
                return false;
            }

        }
        public override string ToString()
        {
            return ($"Title: {Title}\nAutor: {Autor}\nEditora: {Editora}\nQuantidadel: {Quantidade}");

        }
    }
}
