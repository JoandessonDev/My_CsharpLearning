using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaMultipla.Entites
{
     class Device
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public void ProcessDocument(string document)
        {
            Console.WriteLine(Name + $" Processing document {document}");
        }
    }
}
