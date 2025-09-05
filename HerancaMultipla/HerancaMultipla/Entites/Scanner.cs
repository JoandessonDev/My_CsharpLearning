using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerancaMultipla.Interfaces;

namespace HerancaMultipla.Entites
{
    internal class Scanner : Device, IScanner
    {
        public void Scan()
        {
            Console.WriteLine("Scaneadno documento");
        }
    }
}
