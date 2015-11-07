using System;
using System.Collections.Generic;

namespace Lab1.Extra
{
    internal class Retangulo
    {
        private Ponto _pontoInferiorEsquerdo;
        private Ponto _pontoSuperiorDireito;
        private Ponto _pontoSuperiorEsquerdo;
        private Ponto _pontoInferiorDireito;

        public Retangulo(Ponto p1, Ponto p2)
        {
       
            this._pontoInferiorEsquerdo = p1;
            this._pontoSuperiorDireito = p2;
            this._pontoSuperiorEsquerdo = new Ponto(p1.x, p2.y);
            this._pontoInferiorDireito = new Ponto(p2.x, p1.y);

        }

        internal double CalculaArea()
        {
            return PerimetroDaBase() * PerimetroDaAltura();
        }


        private double PerimetroDaBase()
        {
            return _pontoSuperiorDireito.x - _pontoInferiorEsquerdo.x;
        }

        private double PerimetroDaAltura()
        {
            return _pontoSuperiorDireito.y - _pontoInferiorEsquerdo.y;
        }

        internal double CalculaPerimetro()
        {
            return PerimetroDaBase() + PerimetroDaAltura();
        }

        internal bool EhSobrepostoAo(Retangulo retangulo)
        {
            var pontoAdjacenteSuperior = new Ponto(_pontoInferiorEsquerdo.x, retangulo._pontoSuperiorDireito.y);
            var pontoAdjacenteInferior = new Ponto(retangulo._pontoSuperiorDireito.x, _pontoInferiorEsquerdo.y);

            foreach (Ponto ponto in retangulo.Pontos())
            {
                if (ContemPonto(ponto))
                    return true;
            }
            return false;
        }

        private List<Ponto> Pontos()
        {
            return new List<Ponto>(){
                _pontoInferiorEsquerdo,
                _pontoSuperiorDireito,
                _pontoSuperiorEsquerdo,
                _pontoInferiorDireito
            };

        }

        private bool ContemPonto(Ponto ponto)
        {
            return (_pontoInferiorEsquerdo.x <= ponto.x && ponto.x <= _pontoSuperiorDireito.x) && (_pontoInferiorEsquerdo.y <= ponto.y && ponto.y <= _pontoSuperiorDireito.y); 
        }
    }
}