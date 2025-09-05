using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDeDependencia.Service
{
    public interface IEmailService
    {
        void SendEmail( string assunto, string body);
    }
}
