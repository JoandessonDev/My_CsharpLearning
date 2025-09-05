using System;

namespace DependencyInjectionExample
{
    // Interface que define o contrato
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }

    // Implementação concreta da interface
    public class EmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Enviando email para: {to}");
            Console.WriteLine($"Assunto: {subject}");
            Console.WriteLine($"Corpo: {body}");
        }
    }

    // Classe que depende da interface IEmailService
    public class NotificationService
    {
        private readonly IEmailService _emailService;

        // Injeção de dependência através do construtor
        public NotificationService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void Notify(string message)
        {
            // Usando o serviço de email injetado
            _emailService.SendEmail("user@example.com", "Notificação", message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Configuração manual da dependência
            IEmailService emailService = new EmailService();

            // Injetando a dependência na classe NotificationService
            NotificationService notificationService = new NotificationService(emailService);

            // Usando a classe que tem a dependência injetada
            notificationService.Notify("Olá! Esta é uma notificação de teste.");

            Console.ReadLine();
        }
    }
}
