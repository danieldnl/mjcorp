using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MJCorp.Negocio;

namespace MJCorp.Negocio.Testes
{
    [TestClass]
    public class PedidoTeste
    {
        [TestMethod]
        public void Validar_QuandoObjetoForValido_DeveRetornarVerdadeiro()
        {
            //Arrange
            Pedido pedido = new Pedido();
            pedido.Data = DateTime.Today;

            var resultadoEsperado = true;

            //Act
            var resultadoAtual = pedido.Validar();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void Validar_QuandoDataNaoInformada_DeveRetornarFalso()
        {
            //Arrange
            Pedido pedido = new Pedido();

            var resultadoEsperado = false;

            //Act
            var resultadoAtual = pedido.Validar();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void Entregar_QuandoChamarEntregar_DeveAtribuirEntregue()
        {
            //Arrange
            Pedido pedido = new Pedido(5, DateTime.Now);

            //Act
            pedido.Entregar();

            //Assert
            Assert.IsTrue(pedido.Entregue);
            Assert.IsTrue(pedido.DataEntrega.HasValue);
        }

        [TestMethod]
        public void Cancelar_QuandoChamarCancelar_DeveAtribuirCancelado()
        {
            //Arrange
            Pedido pedido = new Pedido(5, DateTime.Now);

            //Act
            pedido.Cancelar();

            //Assert
            Assert.IsTrue(pedido.Cancelado);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Cancelar_QuandoPedidoEntregue_NaoDeveAtribuirCancelado()
        {
            //Arrange
            Pedido pedido = new Pedido(5, DateTime.Now);
            pedido.Entregar();

            //Act
            pedido.Cancelar();
        }

        [TestMethod]
        public void CalcularValorTotal_QuandoChamarMetodo_DeveRetornarValorPedido()
        {
            //Arrange
            Pedido pedido = new Pedido(1, DateTime.Now);
            pedido.Itens.Add(new ItemPedido(1, 1, 1, 50));
            pedido.Itens.Add(new ItemPedido(2, 2, 2, 25));

            var resultadoEsperado = 100;

            //Act
            var resultadoAtual = pedido.CalcularValorTotal();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void CalcularValorTotal_QuandoPedidoCallCenter_DeveRetornarPedidoComCincoPorCentoDesconto()
        {
            //Arrange
            Pedido pedido = new Pedido(1, DateTime.Now);
            pedido.Itens.Add(new ItemPedido(1, 1, 1, 50));
            pedido.Itens.Add(new ItemPedido(2, 2, 2, 25));
            pedido.TipoPedido = TipoPedido.CallCenter;

            var resultadoEsperado = 95;

            //Act
            var resultadoAtual = pedido.CalcularValorTotal();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void CalcularValorTotal_QuandoPedidoOnline_DeveRetornarPedidoComQuinzePorCentoDesconto()
        {
            //Arrange
            Pedido pedido = new Pedido(1, DateTime.Now);
            pedido.Itens.Add(new ItemPedido(1, 1, 1, 50));
            pedido.Itens.Add(new ItemPedido(2, 2, 2, 25));
            pedido.TipoPedido = TipoPedido.Online;

            var resultadoEsperado = 85;

            //Act
            var resultadoAtual = pedido.CalcularValorTotal();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void CalcularValorTotal_QuandoPedidoBalcao_DeveRetornarPedidoComVintePorCentoDesconto()
        {
            //Arrange
            Pedido pedido = new Pedido(1, DateTime.Now);
            pedido.Itens.Add(new ItemPedido(1, 1, 1, 50));
            pedido.Itens.Add(new ItemPedido(2, 2, 2, 25));
            pedido.TipoPedido = TipoPedido.Balcao;

            var resultadoEsperado = 80;

            //Act
            var resultadoAtual = pedido.CalcularValorTotal();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
    }
}