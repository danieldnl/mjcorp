using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJCorp.Negocio
{
    public class PedidoDto
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataPedido { get; set; }

        public List<ItemPedidoDto> Itens { get; set; }

        public int IdPedido { get; set; }

        public Endereco EnderecoDeEntrega { get; set; }
    }
}
