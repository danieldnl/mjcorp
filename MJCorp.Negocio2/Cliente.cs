using MJCorp.Comum;
using System;
using System.Collections.Generic;

namespace MJCorp.Negocio
{
    public class Cliente : EntidadeBase, ILog
    {
        public Cliente()
        {
            Enderecos = new List<Endereco>();
        }

        public Cliente(int idCliente, string sobrenome, string email):this()
        {
            IdCliente = idCliente;
            Sobrenome = sobrenome;
            Email = email;

            Enderecos = new List<Endereco>();
        }

        public int IdCliente { get; private set; }

        private string _sobrenome;

        public string Sobrenome
        {
            get
            {
                return _sobrenome;
            }
            set
            {
                _sobrenome = value;
            }
        }

        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime? DataNascimento { get; set; }

        public Telefone Telefone { get; set; }

        public List<Endereco> Enderecos { get; set; }

        public TipoCliente TipoCliente { get; set; }

        public string NomeCompleto
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Nome))
                    return Sobrenome;

                if (string.IsNullOrWhiteSpace(Sobrenome))
                    return Nome;

                return Sobrenome + ", " + Nome;
            }
        }

        public override bool Validar()
        {
            var ehValido = true;

            if (string.IsNullOrWhiteSpace(Sobrenome))
                ehValido = false;

            if (string.IsNullOrWhiteSpace(Email))
                ehValido = false;

            return ehValido;
        }

        public override string ToString()
        {
            return NomeCompleto;
        }

        public string Log()
        {
            var informacao = IdCliente + ": " +
                             NomeCompleto + " " +
                             "Email: " + Email + " " +
                             "Status: " + EstadoEntidade.ToString();

            return informacao;
        }
    }

}
