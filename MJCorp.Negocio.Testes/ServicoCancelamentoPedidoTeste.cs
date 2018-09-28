using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MJCorp.Negocio.Testes
{
    [TestClass]
    public class ServicoCancelamentoPedidoTeste
    {
        [TestMethod]
        public void CancelarPedido_QuandoChamarMetodo_DeveCancelarEEnviarEmail()
        {
            //Arrange
            var pedido = new Pedido(1, DateTime.Now);
            var servico = new ServicoCancelamentoPedido(new MensagemEmailFake());

            //Act
            servico.CancelarPedido(pedido);

            //Assert
            Assert.IsTrue(pedido.Cancelado);
        }
    }
}
