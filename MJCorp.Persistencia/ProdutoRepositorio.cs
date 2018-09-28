using MJCorp.Negocio;
using System.Collections.Generic;

namespace MJCorp.Persistencia
{
    public class ProdutoRepositorio
    {
        public Produto Obter(int idProduto)
        {
            return new Produto();
        }

        public List<Produto> Obter()
        {
            return new List<Produto>();
        }

        public bool Salvar()
        {
            return true;
        }
    }
}
