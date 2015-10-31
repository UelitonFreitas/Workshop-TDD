using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Lab4
{
    [TestFixture]
    class ProdutoTeste
    {

        [Test]
        public void Deve_Notificar_Os_Interessador_Sobre_Mudanca_De_Preco()
        {

            var interessadoMock = new InteressadoMock();

            var produto = new Produto(interessadoMock);

            produto.AlterarPreco(50.0);
            
            Assert.AreEqual(produto, interessadoMock.UltimoProdutoNotificado);
        }
    }
}
