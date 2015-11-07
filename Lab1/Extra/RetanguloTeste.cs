using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Extra
{
    [TestFixture]
    class RetanguloTeste
    {

        [Test]
        public void Deve_calcular_a_area_do_retangulo()
        {

            var p1 = new Ponto(0, 0);
            var p2 = new Ponto(1, 1);
            
            var retangulo = new Retangulo(p1, p2);

            double areaCalculada = retangulo.CalculaArea();

            int areaEsperada = 1;
            Assert.AreEqual(areaEsperada, areaCalculada);
        }

        [Test]
        public void Deve_calcular_o_perimetro_do_retangulo()
        {

            var p1 = new Ponto(0, 0);
            var p2 = new Ponto(1, 1);

            var retangulo = new Retangulo(p1, p2);

            double perimetroCalculado = retangulo.CalculaPerimetro();

            int areaEsperada = 2;
            Assert.AreEqual(areaEsperada, perimetroCalculado);
        }

        [Test]
        public void Deve_retornar_falso_para_dois_retangulos_nao_sobrepostos()
        {

            var p1 = new Ponto(0, 0);
            var p2 = new Ponto(1, 1);
            var retangulo1 = new Retangulo(p1, p2);

            var p3 = new Ponto(2, 2);
            var p4 = new Ponto(3, 3);
            var retangulo2 = new Retangulo(p3, p4);

            bool naoEhSobreposto = retangulo1.EhSobrepostoAo(retangulo2);

            Assert.AreEqual(false, naoEhSobreposto);
        }

        [Test]
        public void Deve_retornar_verdadeiro_para_dois_retangulos_sobrepostos()
        {

            var p1 = new Ponto(2, 2);
            var p2 = new Ponto(5, 4);
            var retangulo1 = new Retangulo(p1, p2);

            var p3 = new Ponto(1, 1);
            var p4 = new Ponto(4, 3);
            var retangulo2 = new Retangulo(p3, p4);

            bool ehSobreposto = retangulo1.EhSobrepostoAo(retangulo2);

            Assert.AreEqual(true, ehSobreposto);
        }


    }
}
