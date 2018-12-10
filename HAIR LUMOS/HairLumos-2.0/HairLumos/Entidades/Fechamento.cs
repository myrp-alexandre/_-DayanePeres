using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class Fechamento
    {
        private int codigo;
        private Pessoa pes;
        private DateTime dtAbertura;
        private DateTime dtPagamento;
        private double valorTotal;
        private string status;

        public Fechamento()
        {
            pes = new Pessoa();
        }

        public int Codigo { get; set; }
        public Pessoa Pes { get; set; }
        public DateTime DtAbertura { get; set; }
        public DateTime DtPagamento { get; set; }
        public double Valor { get; set; }
        public string Status { get; set; }

    }
}
