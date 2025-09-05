using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    struct Tipo
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return ($"{X}, {Y}");
        }
        
    }
}
