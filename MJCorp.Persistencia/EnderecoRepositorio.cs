using MJCorp.Negocio;
using System.Collections.Generic;

namespace MJCorp.Persistencia
{
    public class EnderecoRepositorio
    {
        public Endereco Obter(int idEndereco)
        {
            Endereco endereco = new Endereco();

            endereco.Rua = "Rua do sol";
            endereco.Numero = "10";
            endereco.Bairro = "Centro";
            endereco.Cidade = "São Luis";
            endereco.Estado = "MA";
            endereco.CEP = "31000-000";
            endereco.Pais = "Brasil";

            return endereco;
        }

        public IEnumerable<Endereco> ObterPeloIdCliente(int idCliente)
        {
            var enderecos = new List<Endereco>();

            var endereco1 = new Endereco(1)
            {
                TipoEndereco = TipoEndereco.Casa,
                Rua = "Rua Grande",
                Numero = "20",
                Bairro = "Centro",
                Cidade = "São Luís",
                Estado = "MA",
                CEP = "41052-520",
                Pais = "Brasil"
            };
            enderecos.Add(endereco1);

            var endereco2 = new Endereco(2)
            {
                TipoEndereco = TipoEndereco.Trabalho,
                Rua = "Rua do passeio",
                Numero = "34",
                Bairro = "Centro",
                Cidade = "São Luís",
                Estado = "MA",
                CEP = "41600-521",
                Pais = "Brasil"
            };
            enderecos.Add(endereco2);

            return enderecos;
        }

        public bool Salvar(Endereco endereco)
        {
            return true;
        }
    }
}
