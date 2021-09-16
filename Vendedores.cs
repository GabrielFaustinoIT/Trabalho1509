using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho1509
{
    class Vendedores
    {
        private Vendedor[] osVendedores;
        private int max;
        private int qtde;

        public int Max
        {
            get { return max; }
        }

        public int Qtde
        {
            get { return qtde; }
        }

        public Vendedor[] OsVendedores
        {
            get { return OsVendedores; }
        }

        public Vendedores(int max)
        {
            this.max = 10;
            this.qtde = 0;
            this.osVendedores = new Vendedor[this.max];
            for (int i = 0; i < this.max; i++)
            {
                this.osVendedores[i] = new Vendedor(1, "Gabriel", 0.0);
            }
        }

        /*   public string listaVendedores()
           {
               string ret = "";

               foreach(Vendedor v in this.osVendedores)
               {
                   ret += v.dados();
               }

               return ret;
           }*/

        public bool addVendedor(Vendedor vendedor)
        {
            bool podeAdicionar = (this.qtde < this.max);

            if (podeAdicionar)
            {
                this.osVendedores[this.qtde] = vendedor;
                this.qtde++;

            }

            return podeAdicionar;

        }

      /*  public override string ToString()
        {
            string dados = "";
            foreach{
                dados 
            }
        }*/

        public bool delVendedor(Vendedor vendedor)
        {
            bool temVend = false;

            foreach(Vendedor v in this.osVendedores)
            {
                if (v.Nome == vendedor.Nome)
                {
                    v.Id = -1;
                    v.Nome = "...";
                    temVend = true;
                }
            }

            return temVend;
        }

        public double valorVendas()
        {
            double totalV = 0;
            foreach(Vendedor v in this.osVendedores)
            {
                totalV += v.valorVendas();
            }
            return totalV;
        }

        public double valorComissao()
        {
            double totalC = 0;
            foreach (Vendedor v in this.osVendedores)
            {
                totalC += v.valorComissao();
            }
            return totalC;
        }

        
        
        }
    }


