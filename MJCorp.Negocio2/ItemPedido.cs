using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJCorp.Negocio
{
    public class ItemPedido
    {
        public ItemPedido(){}

        public ItemPedido(int idItemPedido, int idProduto, int quantidade, decimal precoCompra)
        {
            IdItemPedido = idItemPedido;
            IdProduto = idProduto;
            Quantidade = quantidade;
            PrecoCompra = precoCompra;
        }

        public int IdItemPedido { get; private set; }

        public int Quantidade { get; set; }

        public int IdProduto { get; set; }

        public decimal? PrecoCompra { get; set; }

        public decimal Total
        {
            get
            {
                return Quantidade * PrecoCompra.Value;
            }
        }


        public ItemPedido Obter(int idItemPedido)
        {
            return new ItemPedido();
        }

        public bool Salvar()
        {
            return true;
        }

        public bool Validar()
        {
            var ehValido = true;

            if (Quantidade <= 0)
                ehValido = false;

            if (IdProduto <= 0)
                ehValido = false;

            if (PrecoCompra == null)
                ehValido = false;

            return ehValido;
        }
    }
}
