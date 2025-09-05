using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Vetores
{
    internal class Pessoa
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room {get; set; }


        public Pessoa(string name, string email, int room)
        {
            Name = name;
            Email = email;
            Room = room;

        }

        public override string ToString()
        {
            return ($"Nome:{Name}\n Email: {Email}\n Quarto: {Room}\n");
        }
    }
}
