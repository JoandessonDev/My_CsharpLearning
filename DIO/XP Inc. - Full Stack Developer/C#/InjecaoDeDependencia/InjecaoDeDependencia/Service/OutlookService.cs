namespace InjecaoDeDependencia.Service
{
    public class OutlookService : IEmailService
    {
        public string Email { get; set; }

        public OutlookService(string email)
        {
            Email = email;
        }

        public void SendEmail(string assunto, string body)
        {
            Console.WriteLine($"Enviando email para: {Email}");
            Console.WriteLine($"Assunto: {assunto}");
            Console.WriteLine($"Corpo: {body}");

        }
    }
}
