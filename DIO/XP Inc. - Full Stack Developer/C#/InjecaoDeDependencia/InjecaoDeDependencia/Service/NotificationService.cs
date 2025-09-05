

namespace InjecaoDeDependencia.Service
{
    public class NotificationService
    {
       private IEmailService _emailService;

       public NotificationService(IEmailService emailService)
       {
            _emailService = emailService;
       }

        public void Notify(string assunto, string message)
        {
            // Usando o serviço de email injetado
            _emailService.SendEmail(assunto, message);
        }
    }
}
