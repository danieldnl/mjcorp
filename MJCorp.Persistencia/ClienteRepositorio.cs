using MJCorp.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MJCorp.Persistencia
{
    public class ClienteRepositorio
    {
        private EnderecoRepositorio _enderecoRepositorio;

        public ClienteRepositorio()
        {
            _enderecoRepositorio = new EnderecoRepositorio();
        }

        public Cliente Obter(int idCliente)
        {
            var cliente = new Cliente(idCliente, "Wayne", "wayne@batman.com");
            cliente.Nome = "Bruce";
            cliente.DataNascimento = new DateTime(1980, 2, 6);
            cliente.Telefone = new Telefone("98", "99999999");
            cliente.Enderecos = _enderecoRepositorio.ObterPeloIdCliente(idCliente).ToList();

            return cliente;
        }

        public List<Cliente> Obter()
        {
            return new List<Cliente>();
        }

        public bool Salvar(Cliente cliente)
        {
            var sucesso = true;
            if(cliente.TemMudancas && cliente.EhValido)
            {
                if(cliente.EhNovo)
                {
                    //Inserir no Bd
                }
                else
                {
                    //Alterar no Bd
                }
            }

            return sucesso;
        }
    }
}
