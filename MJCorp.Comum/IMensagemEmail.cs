namespace MJCorp.Comum
{
    public interface IMensagemEmail : IMensagem
    {
        string Assunto { get; set; }

        bool ValidarEmailDestinatario();

        bool EnviarEmailComAnexo();

    }
}
