using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJCorp.Comum
{
    public class ServicoLog
    {
        public static void EscreverArquivo(List<ILog> itensModificados)
        {
            foreach(var item in itensModificados)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
