
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Trabalho1509
{
    class Venda
    {

    private double valor;
        private int qtd;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }

        public Venda(int qtd, double valor)
        {
            this.qtd = qtd;
            this.valor = valor;
        }

        public Venda()
            : this(0, 0.0)
        { }

        public double valorMedio()
        {
            double res;

            res = (this.valor == 0 ? 0: this.valor / this.qtd);

            return res;
        }

    }

}
