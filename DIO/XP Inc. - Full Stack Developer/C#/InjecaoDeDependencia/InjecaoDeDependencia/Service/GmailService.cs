using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InjecaoDeDependencia.Service
{

    // Implementação concreta da interface
    public class GmailService : IEmailService
    {
        public  string Email { get; set; }

        public GmailService(string email)
        {
            Email = email;
        }

        public void SendEmail(string assunto, string body)
        {
            Console.WriteLine($"Enviando email para: {Email}");
            Console.WriteLine("Assunto: " + assunto);
            Console.WriteLine($"Corpo: {body}");
        }
    }

   
}
