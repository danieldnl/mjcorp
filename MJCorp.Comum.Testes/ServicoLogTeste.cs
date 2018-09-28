using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MJCorp.Negocio;

namespace MJCorp.Comum.Testes
{
 
    [TestClass]
    public class ServicoLogTeste
    {
          
        [TestMethod]
        public void EscreverArquivo_QuandoChamarMetodo_DeveEscreverArquivoLog()
        {
            //Arrange
            var itensModificados = new List<ILog>();

            var cliente = new Cliente(1, "Wayne", "bruce@batman.com");
            cliente.Nome = "Bruce";

            itensModificados.Add(cliente);

            var produto = new Produto(1, "Playstation4", 2000);
            produto.Descricao = "Console 500GB - Sony";

            itensModificados.Add(produto);

            //Act
            ServicoLog.EscreverArquivo(itensModificados);
        }
    }
}
