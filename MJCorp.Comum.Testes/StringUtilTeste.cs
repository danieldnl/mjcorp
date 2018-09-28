using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MJCorp.Comum.Testes
{
    [TestClass]
    public class StringUtilTeste
    {
        [TestMethod]
        public void InserirEspacos_QuandoNomeSemEspaco_DeveInserirEspacos()
        {
            //Arrange
            var nome = "ConsolePlaystation4";
            var resultadoEsperado = "Console Playstation 4";

            //Act
            var resultadoAtual = nome.InserirEspacos();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void InserirEspacos_QuandoNomeJaTemEspaco_NaoDeveInserirEspacos()
        {
            //Arrange
            var nome = "Console Playstation 4";
            var resultadoEsperado = "Console Playstation 4";

            //Act
            var resultadoAtual = nome.InserirEspacos();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void InserirEspacos_QuandoNomeVazio_RetornarVazio()
        {
            //Arrange
            var nome = "";
            var resultadoEsperado = "";

            //Act
            var resultadoAtual = nome.InserirEspacos();
            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
    }
}
