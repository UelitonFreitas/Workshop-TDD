using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Lab4
{
    public class InteressadoMock : Interessado
    {

        public Produto UltimoProdutoNotificado { get; set; }

        public void ReceberNotificao(Produto produto)
        {
            UltimoProdutoNotificado = produto;
        }
    }
}
