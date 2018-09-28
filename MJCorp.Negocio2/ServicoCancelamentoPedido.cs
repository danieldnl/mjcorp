using MJCorp.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJCorp.Negocio
{
    public class ServicoCancelamentoPedido
    {
        private IMensagemEmail _mensagem;

        public ServicoCancelamentoPedido(IMensagemEmail mensagem)
        {
            _mensagem = mensagem;
        }

        public void CancelarPedido(Pedido pedido)
        {
            pedido.Cancelar();

            var corpo = "Pedido " + pedido.ToString() + " Cancelado.";

            _mensagem.Assunto = "Pedido Cancelado";
            _mensagem.Remetente = "admin@mjcorp.com.br";
            _mensagem.Destinatario = "financeiro@mjcorp.com.br";
            _mensagem.Corpo = corpo;
            _mensagem.Enviar();
        }
    }
}
