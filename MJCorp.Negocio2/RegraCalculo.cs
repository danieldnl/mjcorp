using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJCorp.Negocio
{
    public abstract class RegraCalculo
    {
        public abstract TipoPedido TipoPedido { get; }

        public abstract decimal CalcularValor(ItemPedido item);
    }

    public class RegraPadrao : RegraCalculo
    {
        public override TipoPedido TipoPedido
        {
            get
            {
                return TipoPedido.Padrao;
            }
        }

        public override decimal CalcularValor(ItemPedido item)
        {
            return item.Total;
        }
    }

    public class RegraCallCenter : RegraCalculo
    {
        public override TipoPedido TipoPedido
        {
            get
            {
                return TipoPedido.CallCenter;
            }
        }

        public override decimal CalcularValor(ItemPedido item)
        {
            return item.Total - (item.Total * 0.05M);
        }
    }

    public class RegraOnline : RegraCalculo
    {
        public override TipoPedido TipoPedido
        {
            get
            {
                return TipoPedido.Online;
            }
        }

        public override decimal CalcularValor(ItemPedido item)
        {
            return item.Total - (item.Total * 0.15M);
        }
    }

    public class RegraBalcao : RegraCalculo
    {
        public override TipoPedido TipoPedido
        {
            get
            {
                return TipoPedido.Balcao;
            }
        }

        public override decimal CalcularValor(ItemPedido item)
        {
            return item.Total - (item.Total * 0.20M);
        }
    }

    public class CalculadoraItemPedido
    {
        private List<RegraCalculo> _regras;

        public CalculadoraItemPedido()
        {
            _regras = new List<RegraCalculo>();
            _regras.Add(new RegraPadrao());
            _regras.Add(new RegraCallCenter());
            _regras.Add(new RegraOnline());
            _regras.Add(new RegraBalcao());
        }

        public decimal calcularValor(TipoPedido tipoPedido, ItemPedido item)
        {
            var regraEscolhida = _regras.Single(regra => regra.TipoPedido == tipoPedido);

            return regraEscolhida.CalcularValor(item);
        }
    }
}
