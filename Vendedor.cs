using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho1509
{
    class Vendedor
    {
        private int id;
        private string nome;
        private double percComissao;
        private Venda[] asVendas;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Comissao
        {
            get { return percComissao; }
            set { percComissao = value; }
        }

        public Venda[] AsVendas
            {
                get { return asVendas; }
            }

        public Vendedor(int id, string nome, double percComissao)
        {
            this.id = id;
            this.nome = nome;
            this.percComissao = percComissao;
            this.asVendas = new Venda[31];

            for (int i=0; i<31; i++)
            {
                this.asVendas[i] = new Venda();
            }
        }

        public Vendedor()
            : this(0, "", 0.0)
        { }

        public void registrarVenda(int dia, Venda venda)
        {

        }


      public double valorVendas()
        {
            double total = 0;
            foreach (Venda v in this.asVendas)
            {
                total += v.Valor;
            }
            return total;
        } 

        public double valorComissao()
        {
            return this.valorVendas() * (this.percComissao / 100);
        }

        public override bool Equals(object obj)
        {
            return this.id.Equals(((Vendedor)obj).id);
        }
    }



}
