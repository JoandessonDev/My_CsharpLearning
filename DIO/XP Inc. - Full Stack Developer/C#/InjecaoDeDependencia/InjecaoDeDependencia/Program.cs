using InjecaoDeDependencia;
using InjecaoDeDependencia.Service;
using System;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuração manual da dependência
            GmailService emailService = new GmailService("joandesson@gmail.com");
            OutlookService outlookService = new OutlookService("joandesson@hotmail.com");

            // Injetando a dependência na classe NotificationService
            NotificationService notificationService = new NotificationService(outlookService);

            // Usando a classe que tem a dependência injetada
            notificationService.Notify("Test", "Olá! Esta é uma notificação de teste.");
            notificationService.Notify("Test2", "Olá! Esta é uma notificação de teste.");
        }
    }
}