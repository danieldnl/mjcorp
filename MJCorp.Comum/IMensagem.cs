namespace MJCorp.Comum
{
    public interface IMensagem
    {
        string Corpo { get; set; }
        string Destinatario { get; set; }
        string Remetente { get; set; }

        bool Enviar();
    }
}