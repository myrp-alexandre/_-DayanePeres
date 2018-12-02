using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HairLumos.Entidades
{
    class Parcela
    {
        private int codigo;
        private double valorpago;
        private double valorparcela;
        private DateTime datapagamento;
        private DateTime datavencimento;
        private FormaPagamento forma;
        private Caixa caixa;

        public Parcela()
        {
        }

        public int Codigo { get; set; }
        public double ValorPago { get; set; }
        public double ValorReceber { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public FormaPagamento Forma { get; set; }
        public Caixa Caixa { get; set; }

    }
}