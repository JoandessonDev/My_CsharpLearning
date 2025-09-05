using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Sec10.Entites
{
    internal abstract  class Contribuente
    {
        public string Nome {  get; set; }
        public double RendaAnual { get; set; }

        public Contribuente() { }

        public Contribuente(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalcularImposto();
    }
}
