namespace MJCorp.Negocio
{
    public abstract class EntidadeBase
    {
        public bool EhNovo { get; set; }

        public bool TemMudancas { get; set; }

        public EstadoEntidade EstadoEntidade { get; set; }

        public bool EhValido
        {
            get { return Validar(); }
        }

        public abstract bool Validar();
    }
}
