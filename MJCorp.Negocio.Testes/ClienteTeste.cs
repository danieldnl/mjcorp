using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MJCorp.Negocio;

namespace MJCorp.Negocio.Testes
{
    [TestClass]
    public class ClienteTeste
    {
        //[metodo]_[condicao]_[resultadoEsperado]

        [TestMethod]
        public void NomeCompleto_QuandoObterNomeCompleto_DeveRetornarNomeSobrenome()
        {
            //Arrange
            Cliente cliente = new Cliente();
            cliente.Nome = "Bruce";
            cliente.Sobrenome = "Wayne";

            var resultadoEsperado = "Wayne, Bruce";

            //Act
            var resultadoAtual = cliente.NomeCompleto;

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void NomeCompleto_QuandoPrimeiroNomeVazio_DeveRetornarSobrenome()
        {
            //Arrange
            Cliente cliente = new Cliente();
            cliente.Sobrenome = "Wayne";

            var resultadoEsperado = "Wayne";

            //Act
            var resultadoAtual = cliente.NomeCompleto;

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void NomeCompleto_QuandoSobrenomeVazio_DeveRetornarVerdadeiro()
        {
            //Arrange
            Cliente cliente = new Cliente();
            cliente.Nome = "Bruce";

            var resultadoEsperado = "Bruce";

            //Act
            var resultadoAtual = cliente.NomeCompleto;

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void Validar_QuandoClienteForValido_DeveRetornarVerdadeiro()
        {
            //Arrange
            Cliente cliente = new Cliente();
            cliente.Sobrenome = "Wayne";
            cliente.Email = "wayne@batman.com";

            var resultadoEsperado = true;

            //Act
            var resultadoAtual = cliente.Validar();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void Validar_QuandoSobrenomeVazio_DeveRetornarFalso()
        {
            //Arrange
            Cliente cliente = new Cliente();
            cliente.Email = "wayne@batman.com";

            var resultadoEsperado = false;

            //Act
            var resultadoAtual = cliente.Validar();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void Validar_QuandoEmailVazio_DeveRetornarFalso()
        {
            //Arrange
            Cliente cliente = new Cliente();
            cliente.Sobrenome = "Wayne";

            var resultadoEsperado = false;

            //Act
            var resultadoAtual = cliente.Validar();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
    }
}
