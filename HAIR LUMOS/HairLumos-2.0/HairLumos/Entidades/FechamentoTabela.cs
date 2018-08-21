using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class FechamentoTabela
    {
        private String forma;
        private double valor;

        public FechamentoTabela(string forma, double valor)
        {
            this.forma = forma;
            this.valor = valor;
        }

        public FechamentoTabela()
        {
        }

        public String Forma { get; set; }
        public double Valor { get; set; }
    }
}
