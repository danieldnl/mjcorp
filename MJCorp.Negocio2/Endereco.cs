namespace MJCorp.Negocio
{
    public class Endereco
    {
        public Endereco(){}

        public Endereco(int idEndereco)
        {
            IdEndereco = idEndereco;
        }

        public int IdEndereco { get; set; }

        public TipoEndereco TipoEndereco { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string CEP { get; set; }

        public string Pais { get; set; }

    }
}
