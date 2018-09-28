using MJCorp.Negocio;
using System;
using System.Collections.Generic;

namespace MJCorp.Persistencia
{
    public class PedidoRepositorio
    {
        public Pedido Obter(int idPedido)
        {
            return new Pedido();
        }

        public PedidoDto ObterPedidoParaExibicao(int idPedido)
        {
            var pedidoDto = new PedidoDto()
            {
                IdPedido = idPedido,
                Nome = "Bruce",
                Sobrenome = "Wayne",
                DataPedido = DateTime.Today,
                EnderecoDeEntrega = new Endereco(1)
                {
                    TipoEndereco = TipoEndereco.Casa,
                    Rua = "Rua Grande",
                    Numero = "20",
                    Bairro = "Centro",
                    Cidade = "São Luís",
                    Estado = "MA",
                    CEP = "41052-520",
                    Pais = "Brasil"
                }
            };

            pedidoDto.Itens = new List<ItemPedidoDto>();
            var itemPedidoDto = new ItemPedidoDto()
            {
                NomeProduto = "XBOX One",
                PrecoDeCompra = 1500,
                Quantidade = 1
            };

            pedidoDto.Itens.Add(itemPedidoDto);

            itemPedidoDto = new ItemPedidoDto()
            {
                NomeProduto = "Playstation 4",
                PrecoDeCompra = 2000,
                Quantidade = 1
            };

            pedidoDto.Itens.Add(itemPedidoDto);

            return pedidoDto;
        }

        public bool Salvar()
        {
            return true;
        }
    }
}
