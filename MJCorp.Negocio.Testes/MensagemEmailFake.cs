using MJCorp.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MJCorp.Negocio.Testes
{
    public class MensagemEmailFake : IMensagemEmail
    {
        public string Remetente { get; set; }

        public string Destinatario { get; set; }

        public string Assunto { get; set; }

        public string Corpo { get; set; }

        public bool Enviar()
        {
            Console.WriteLine("Email enviado para " + Destinatario + " Assunto " + Assunto);

            return true;
        }

        public bool EnviarEmailComAnexo()
        {
            return true;
        }

        public bool ValidarEmailDestinatario()
        {
            return true;
        }
    }
}
