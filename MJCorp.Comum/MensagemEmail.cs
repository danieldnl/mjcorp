using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MJCorp.Comum
{
    public class MensagemEmail : IMensagemEmail
    {
        public string Remetente { get; set; }

        public string Destinatario { get; set; }

        public string Assunto { get; set; }

        public string Corpo { get; set; }
       
        public bool Enviar()
        {
            var msg = new MailMessage(Remetente, Destinatario, Assunto, Corpo);

            SmtpClient client = new SmtpClient("localhost");
            client.Send(msg);

            return true;
        }

        public bool EnviarEmailComAnexo()
        {
            throw new NotImplementedException();
        }

        public bool ValidarEmailDestinatario()
        {
            throw new NotImplementedException();
        }
    }
}
