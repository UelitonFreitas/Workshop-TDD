using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Lab3
{
    [TestFixture]
    class ProtaEletronicaTeste
    {
        [Test]
        public void deve_registrar_uma_uma_entrada()
        {

            var provedorDeHorario = new ProvedorDeHorarioStub() {
                dataEhHoraConfiguravel = new DateTime(2015, 10, 31, 18, 17, 00)
            };

            PortaEletronica portaEletronica = new PortaEletronica(provedorDeHorario);

            portaEletronica.RegistraEntrada();

            var listaDeEntradas = portaEletronica.entradas;

            Assert.AreEqual(1, listaDeEntradas.Count());
        }

        [Test]
        public void deve_retornar_todas_as_entradas_fora_do_horario_de_expediente()
        {

            var provedorDeHorario = new ProvedorDeHorarioStub()
            {
                dataEhHoraConfiguravel = new DateTime(2015, 10, 31, 18, 17, 00)
            };

            PortaEletronica portaEletronica = new PortaEletronica(provedorDeHorario);

            portaEletronica.RegistraEntrada();

            var listaEsperada = new List<DateTime> { new DateTime(2015, 10, 31, 18, 17, 00)  };

            var listaDeEntradasForaDoHorarioDeExpediente = portaEletronica.EntradasForaDoHorarioDeExpediente();

            CollectionAssert.AreEqual(listaEsperada, listaDeEntradasForaDoHorarioDeExpediente);
        }
    }
}
