using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Lab5
{
    [TestFixture]
    class TestaCaixaEletronico
    {
        [Test]
        public void Deve_retornar_a_nota_da_quantidade_pedida()
        {

            var valorDoSaque = 100;

            var caixa = new Caixa();

            var notasRecebidas = caixa.Saque(valorDoSaque);

            var notasEsperadas = new List<int>() { 100};
            Assert.AreEqual(notasEsperadas, notasRecebidas);
        }

        [Test]
        public void Deve_retornar_duas_notas_iguais_para_um_valor()
        {
            var valorDoSaque = 200;

            var caixa = new Caixa();

            var notasRecebidas = caixa.Saque(valorDoSaque);

            List<int> notasEsperadas = new List<int>() { 100, 100};

            Assert.AreEqual(notasEsperadas, notasRecebidas);
        }

        [Test]
        public void Deve_retornar_tres_notas_diferentes_para_um_valor()
        {
            var valorDoSaque = 170;

            var caixa = new Caixa();

            var notasRecebidas = caixa.Saque(valorDoSaque);

            List<int> notasEsperadas = new List<int>() { 100, 50, 20 };

            Assert.AreEqual(notasEsperadas, notasRecebidas);
        }
        
        [Test]
        public void Deve_retornar_uma_lista_vazia_para_um_valor_que_nao_pode_ser_pago()
        {
            var valorDoSaque = 153;

            var caixa = new Caixa();

            var notasRecebidas = caixa.Saque(valorDoSaque);

            List<int> notasEsperadas = new List<int>() { };

            Assert.AreEqual(notasEsperadas, notasRecebidas);

        }
    }
}
