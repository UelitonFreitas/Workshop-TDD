using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Lab1
{
    [TestFixture]
    class TesteDeCalculoDeMultaEMora
    {

        [Test]
        public void deve_calcular_a_multa_quanto_o_boleto_esta_vencido()
        {

            double valor = 500;
            DateTime dataDeVencimento = new DateTime(2011, 09, 02);

            Boleto boleto = new Boleto(valor, dataDeVencimento);

            double valorDaMulta = boleto.calculaMulta();

            Assert.AreEqual(10.0, valorDaMulta);
        }

        [Test]
        public void deve_retornar_zero_quando_o_boleto_nao_esta_vencido()
        {
            double valor = 500;
            DateTime dataDeVencimento = new DateTime(2025, 09, 01);

            Boleto boleto = new Boleto(valor, dataDeVencimento);

            double valorDaMulta = boleto.calculaMulta();

            Assert.AreEqual(0, valorDaMulta);
        }

        [Test]
        public void deve_retornar_mora_quando_o_boleto_esta_vencido()
        {

            double valor = 500;

            DateTime dataDeVencimento = new DateTime(2014, 05, 10);
            DateTime dataDePagamento = new DateTime(2014, 09, 30);

            Boleto boleto = new Boleto(500, dataDeVencimento);

            double valorDaMora = boleto.calculaMora(dataDePagamento);

            Assert.AreEqual(1574.56, valorDaMora);
        }

        [Test]
        public void deve_retornar_zero_de_mora_quanto_o_boleto_nao_esta_vencido()
        {
            double valor = 500;

            DateTime dataDeVencimento = new DateTime(2015, 05, 10);
            DateTime dataDePagamento = new DateTime(2014, 09, 30);

            Boleto boleto = new Boleto(500, dataDeVencimento);

            double valorDaMora = boleto.calculaMora(dataDePagamento);

            Assert.AreEqual(0, valorDaMora);

        }
    }
}
