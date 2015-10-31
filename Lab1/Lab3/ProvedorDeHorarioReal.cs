using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Lab3
{
    class ProvedorDeHorarioReal : ProvedorDeHorario
    {
        public DateTime DataEhHoraAtual
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
