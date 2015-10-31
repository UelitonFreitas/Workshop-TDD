using System;

namespace Lab1.Lab4
{
    public class Produto
    {
        private Interessado _interessado;
        private double _preco;

        public Produto(Interessado interessado)
        {
            _interessado = interessado;
        }

        internal void AlterarPreco(double novoPreco)
        {
            _preco = novoPreco;
            _interessado.ReceberNotificao(this);
        }
    }
}