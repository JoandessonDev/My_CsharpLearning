using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Biblioteca
{
    internal class User
    {
        public string Name { private set; get; }
        public string Major { private set; get; }
        public string Email { private set; get; }
        public int Number {  private set; get; }
        public string Sin{  private set; get; }
        public int Age {  private set; get; }

        private string Status;


        public User(string name, int age, string major, string email, string sin)
        {
            Name = name;
            Age = age;
            Major = major;
            Email = email;
            Sin = sin;
        }
        
        public void ManageUser()
        {
            
            Console.WriteLine("Entre com os dados atualizados");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string sin = Console.ReadLine();
            if (name != null && email != null && sin != null)
            {
                Name = name;
                Age = age;
                Email = email;
                Sin = sin;
            }
            else
            {
                Console.WriteLine("Falha ao Atualizar dados");
            }

        }

        public bool ValidarUsuario(string email, string sin)
        {
            if (email == Email && sin == Sin)
            {
                return true;

            }
            else
            {
                return false;
            }


        }
        public void AplicarAdvertencia(string name, int tempo)
        {
            int Tempo = tempo;

            if (Tempo > 0 && Name == name)
            {
                Status = "bloqueado";
            }
            
        }

        public bool VerificarStatus(string name)
        {
            if (Name == name && Status != "bloqueado")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            string user_dados = ($"Name: {Name}\nAge: {Age}\nUcupation: {Major}\nEmail: {Email}");
            return user_dados;
        }

    }
}
