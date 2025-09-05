using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Sec10.Entites
{
    internal class PessoaFisica : Contribuente
    {
        public double GastosComSaude { get; set; }

        public PessoaFisica() { }

        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude)
            : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public override double CalcularImposto()
        {
            if (RendaAnual < 20000.00)
            {
                return (RendaAnual * 0.15) - (GastosComSaude * 0.5);
            }
            else
            {
                return RendaAnual * 0.25 - (GastosComSaude * 0.5);
            }
        }
    }
}
