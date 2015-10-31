using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Lab3
{
    class ProvedorDeHorarioStub : ProvedorDeHorario
    {

        public DateTime dataEhHoraConfiguravel { get; set; }

        public DateTime DataEhHoraAtual
        {
            get
            {
                return this.dataEhHoraConfiguravel;
            }
        }
    }
}
