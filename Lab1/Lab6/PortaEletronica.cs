using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1.Lab6
{
    internal class PortaEletronica
    {
        public List<DateTime> entradas;

        private static TimeSpan horarioDeEntrada = new TimeSpan(10, 00, 00);
        private static TimeSpan horarioDeSainda = new TimeSpan(16, 00, 00);
        private ProvedorDeHorario provedorDeHorario;

        public PortaEletronica(ProvedorDeHorario provedorDeHorario)
        {
            this.entradas = new List<DateTime>();
            this.provedorDeHorario = provedorDeHorario;
        }

        public void RegistraEntrada()
        {
            DateTime entrada = provedorDeHorario.DataEhHoraAtual;
            entradas.Add(entrada);
        }

        public List<DateTime> EntradasForaDoHorarioDeExpediente()
        {
            return entradas.Where(entrada => entrada.TimeOfDay < horarioDeEntrada || entrada.TimeOfDay > horarioDeSainda).ToList();
        }
    }
}