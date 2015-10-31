using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Lab2
{
    [TestFixture]
    class ValidaCPFTeste
    {

        [TestCase("03221874197", true, TestName = "CPF válido é valido")]
        [TestCase("03221874198", false, TestName = "CPF não válido é não valido")]
        [TestCase("032.218.741-97", true, TestName = "CPF válido com máscara")]
        [TestCase("abcd", false, TestName = "CPF com letrar aleatórias não valido")]
        [TestCase("", false, TestName = "CPF com letrar aleatórias não valido")]
        public void testa_cpf(String numeroDoCPF, bool resultadoEsperado)
        {
            var CPFEhValido = ValidaCpf.EhValido(numeroDoCPF);
            Assert.AreEqual(resultadoEsperado, CPFEhValido);
        }

    }
}
