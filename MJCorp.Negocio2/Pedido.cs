using MJCorp.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJCorp.Negocio
{
    public class Pedido : EntidadeBase, ILog
    {
        public Pedido()
        {
            Itens = new List<ItemPedido>();
            _calculadoraItemPedido = new CalculadoraItemPedido();
        }

        public Pedido(int idPedido, DateTime data):this()
        {
            IdPedido = idPedido;
            Data = data;
        }

        private CalculadoraItemPedido _calculadoraItemPedido;

        public int IdPedido { get; private set; }

        public int IdCliente { get; set; }

        public DateTime? Data { get; set; }

        public bool Entregue { get; private set; }

        public DateTime? DataEntrega { get; private set; }

        public bool Cancelado { get; set; }

        public List<ItemPedido> Itens { get; set; }

        public TipoPedido TipoPedido { get; set; }


        public decimal CalcularValorTotal()
        {
            decimal valorTotal = 0;

            foreach(var item in Itens)
            {
                valorTotal += _calculadoraItemPedido.calcularValor(TipoPedido, item);
            }

            return valorTotal;
        }

        public void Cancelar()
        {
            if (Entregue)
                throw new ArgumentException("Pedido entregue não pode ser cancelado!");

            Cancelado = true;
        }

        public void Entregar()
        {
            DataEntrega = DateTime.Now;
            Entregue = true;
        }

        public override bool Validar()
        {
            var ehValido = true;

            if (Data == null)
                ehValido = false;

            return ehValido;
        }

        public override string ToString()
        {
            return Data + "(" + IdPedido + ")";
        }

        public string Log()
        {
            var informacao = IdPedido + ": " +
                             "Data: " + Data.Value.Date + " " +
                             "Status: " + EstadoEntidade.ToString();

            return informacao;
        }
    }
}
