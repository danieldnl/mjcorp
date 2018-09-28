using System;

namespace MJCorp.Negocio
{
    public class Telefone
    {
        public Telefone(string ddd, string numero)
        {
            if (string.IsNullOrWhiteSpace(ddd))
                throw new ArgumentNullException("ddd");

            if (string.IsNullOrWhiteSpace(numero))
                throw new ArgumentNullException("numero");

            Ddd = ddd;
            Numero = numero;
        }

        public string  Ddd { get; private set; }

        public string Numero { get; private set; }
    }
}
