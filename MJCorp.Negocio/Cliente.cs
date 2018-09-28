using System;

namespace MJCorp.Negocio
{
    public class Cliente
    {
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

        public string Ddd { get; set; }

        public string Telefone { get; set; }

        public string NomeCompleto
        {
            get
            {
                return Sobrenome + ", " + Nome;
            }
        }
    }
}
