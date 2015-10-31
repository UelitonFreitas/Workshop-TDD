using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Lab2
{
    public static class ValidaCpf
    {
        public static bool EhValido(string cpf)
        {
            //É necessário criar o cpf passando o cpf como parâmetro.
            //Dispara exceção caso o cpf não seja válido.
            return new CPF().valida(cpf);
        }
    }
}
