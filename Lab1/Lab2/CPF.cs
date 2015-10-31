using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Lab2
{
    class CPF
    {
        private const int tamanhoPadraoDoCPF = 11;

        public bool valida(string cpfParaSerValidado)
        {

            var numerosDoCPF = removeCaracteresNaoNumericos(cpfParaSerValidado);

            if (numerosDoCPF.Length != tamanhoPadraoDoCPF)
                return false;

            var cpfSemDigitosVerificadores = numerosDoCPF.Substring(0, 9);
            
            var primeiroDigito = calculaDigitoVerificador(cpfSemDigitosVerificadores);

            var segundoDigitoVerificador = calculaDigitoVerificador(cpfSemDigitosVerificadores + primeiroDigito);

            return numerosDoCPF.EndsWith(primeiroDigito + segundoDigitoVerificador);
        }

        private String calculaDigitoVerificador(string cpfParcial)
        {
            var soma = 0;

            for (int i = 0; i < cpfParcial.Length; i++)
                soma += int.Parse(cpfParcial[i].ToString()) * ((cpfParcial.Length - i) + 1);

            var resto = soma % tamanhoPadraoDoCPF;
            return resto < 2 ? "0" : (tamanhoPadraoDoCPF - resto).ToString();

        }

        private string removeCaracteresNaoNumericos(string cpf)
        {
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            return cpf;
        }
    }
}
