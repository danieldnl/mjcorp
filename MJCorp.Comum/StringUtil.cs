namespace MJCorp.Comum
{
    public static class StringUtil
    {
        public static string InserirEspacos(this string nome)
        {
            var resultado = string.Empty;

            if(!string.IsNullOrWhiteSpace(nome))
            {
                foreach(char caractere in nome)
                {
                    if (char.IsUpper(caractere) || char.IsNumber(caractere))
                    {
                        resultado = resultado.Trim();
                        resultado += " ";
                    }
                        
                    resultado += caractere;
                }

                resultado = resultado.Trim();
            }

            return resultado;
        }
    }
}
