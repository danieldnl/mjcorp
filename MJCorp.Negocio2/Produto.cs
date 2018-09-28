using MJCorp.Comum;
using System.Collections.Generic;

namespace MJCorp.Negocio
{
    public class Produto : EntidadeBase, ILog
    {
        public Produto()
        {

        }

        public Produto(int idProduto, string nome, decimal preco)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
        }

        public int IdProduto { get; private set; }

        private string _nome;

        public string Nome
        {
            get
            {
                return _nome.InserirEspacos();
            }
            set { _nome = value; }
        }

        public decimal? Preco { get; set; }

        public string Descricao { get; set; }


        public override bool Validar()
        {
            var ehValido = true;

            if (string.IsNullOrWhiteSpace(Nome))
                ehValido = false;

            if (Preco == null)
                ehValido = false;

            return ehValido;
        }

        public override string ToString()
        {
            return Nome;
        }

        public string Log()
        {
            var informacao = IdProduto + ": " +
                             Nome + " " +
                             "Detalhe: " + Descricao + " " +
                             "Status: " + EstadoEntidade.ToString();

            return informacao;
        }
    }
}
