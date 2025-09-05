using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Sec10.Entites
{
    internal class PessoaJuridica : Contribuente
    {
        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica() { }

        public PessoaJuridica(string nome, double rendaAnual, int numeroDeFuncionarios)
            : base(nome, rendaAnual)
        {
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }

        public override double CalcularImposto()
        {
            if(NumeroDeFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }

    }
    
}
