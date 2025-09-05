using HerancaMultipla.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaMultipla.Entites
{
    internal class Printer : Device, IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Imprimindo Documento...");
        }
    }
}
