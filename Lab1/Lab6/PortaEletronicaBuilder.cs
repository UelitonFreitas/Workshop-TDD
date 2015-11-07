using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Lab6
{
    class PortaEletronicaBuilder
    {
        private DateTime dataDeEntrada;
        private ProvedorDeHorarioStub provedorDeHorario;

        private PortaEletronicaBuilder()
        {
            this.dataDeEntrada = new DateTime(2015, 10, 31, 18, 17, 00);
        }

        public static PortaEletronicaBuilder UmaPortaEletronica()
        {
            return new PortaEletronicaBuilder();
        }

        public PortaEletronicaBuilder ComDataDeEntrada(DateTime dataDeEntrada)
        {
            this.dataDeEntrada = dataDeEntrada;
            return this;
        }

        public PortaEletronica Criar()
        {
            var provedorDeHorario = new ProvedorDeHorarioStub()
            {
                dataEhHoraConfiguravel = dataDeEntrada
            };

            return new PortaEletronica(provedorDeHorario);
        }

    }
}
