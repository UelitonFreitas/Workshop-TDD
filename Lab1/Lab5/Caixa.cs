using System;
using System.Collections.Generic;

namespace Lab1.Lab5
{
    internal class Caixa
    {
        private List<int> notasDisponiveisEmCaixa;

        public Caixa()
        {
            notasDisponiveisEmCaixa = new List<int>() { 100, 50, 20, 10 };
        }

        internal List<int> Saque(int valorDoSaque)
        {
            return CaixaPodePagarOhValor(valorDoSaque) ? ObtemQuantidadeDeNotas(valorDoSaque) : new List<int>();
        }

        private List<int> ObtemQuantidadeDeNotas(int valorDoSaque)
        {
            var valorAtualParaSerPago = valorDoSaque;
            var notasAhSeremPagas = new List<int>();

            foreach (int nota in notasDisponiveisEmCaixa)
            {
                var quantidadeMaximaDeNotas = CalculaQuantidadeMaximoDeNotas(valorAtualParaSerPago, nota);
           
                if (quantidadeMaximaDeNotas > 0)
                {
                    AdicionaQuantidadeDeNotas(notasAhSeremPagas, nota, quantidadeMaximaDeNotas);
                }

                valorAtualParaSerPago = valorAtualParaSerPago % (nota * quantidadeMaximaDeNotas);
                if (valorAtualParaSerPago == 0)
                {
                    break;
                }
            }

            return notasAhSeremPagas;
        }

        private int CalculaQuantidadeMaximoDeNotas(int valorParcial, int nota)
        {
            return valorParcial / nota;
        }

        private bool CaixaPodePagarOhValor(int valorDoSaque)
        {
            foreach (int nota in notasDisponiveisEmCaixa)
            {
                if (valorDoSaque % nota == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private void AdicionaQuantidadeDeNotas(List<int> notas, int valor, int quantidadeDeNotas)
        {
            for (int i = 0; i < quantidadeDeNotas; i++)
            {
                notas.Add(valor);
            }
        }

    }
}