using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MJCorp.Negocio;

namespace MJCorp.Negocio.Testes
{
    [TestClass]
    public class ProdutoTeste
    {
        [TestMethod]
        public void Validar_QuandoObjetoForValido_DeveRetornarVerdadeiro()
        {
            //Arrange
            Produto produto = new Produto();
            produto.Nome = "PS4";
            produto.Preco = 1000;

            Console.WriteLine(produto.ToString());

            var resultadoEsperado = true;

            //Act
            var resultadoAtual = produto.Validar();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void Validar_QuandoNomeVazio_DeveRetornarFalso()
        {
            //Arrange
            Produto produto = new Produto();
            produto.Preco = 1000;

            var resultadoEsperado = false;

            //Act
            var resultadoAtual = produto.Validar();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void Validar_QuandoPrecoNaoInformado_DeveRetornarFalso()
        {
            //Arrange
            Produto produto = new Produto();
            produto.Nome = "PS4";

            var resultadoEsperado = false;

            //Act
            var resultadoAtual = produto.Validar();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
    }
}
