using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class BaixaManual
    {
        private int codigo;
        private int qtde;
        private DateTime data;
        private Produto prod;
        private string obs;

        public BaixaManual(int codigo, int qtde, DateTime data, Produto prod, string obs)
        {
            this.codigo = codigo;
            this.qtde = qtde;
            this.data = data;
            this.prod = prod;
            this.obs = obs;
        }

        public BaixaManual()
        {
            prod = new Produto();
        }

        public int Codigo { get; set;}

        public int Qtde { get; set; }

        public DateTime Data { get; set; }

        public Produto Prod { get; set; }

        public string Obs { get; set; }
    }
}
