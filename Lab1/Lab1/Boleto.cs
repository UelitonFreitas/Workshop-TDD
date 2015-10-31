using System;

namespace Lab1.Lab1
{
    class Boleto
    {
        private static double porcentagemDaMora = 0.01;
        private static double porcentagemDaMulta = 0.02;

        public double valor;
        private DateTime dataDeVencimento;

        public Boleto(double valor, DateTime dataDeVencimento)
        {
            this.valor = valor;
            this.dataDeVencimento = dataDeVencimento;
        }

        public double calculaMulta()
        {
            DateTime hoje = DateTime.Today;

            if (dataDeVencimento < hoje)
                return valor*porcentagemDaMulta;

            return 0.0;
        }

        public double calculaMora(DateTime dataDePagamento)
        {
             DateTime hoje = DateTime.Today;

             int quantidadeDeDiasEmAtraso = this.calculaQuantidadeDeDiasEmAtraso(dataDePagamento);
             return Math.Round(valor * Math.Pow(1 + porcentagemDaMora, quantidadeDeDiasEmAtraso) - valor, 2);
        }

        public int calculaQuantidadeDeDiasEmAtraso(DateTime dataDePagamento)
        {
            if (dataDePagamento < dataDeVencimento)
                return 0;
            return (dataDePagamento - dataDeVencimento).Days;
        }
    }
}