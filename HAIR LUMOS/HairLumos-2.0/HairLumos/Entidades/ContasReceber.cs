using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class ContasReceber
    {
        private int codigo;
        private DateTime dtvencimento;
        private DateTime dtpagamento;
        private double valortotal;
        private string obs;
        private Comissao comissao;
        private Caixa caixa;
        private int codfechamento;
        private FormaPagamento forma;
        private int pf;

        public ContasReceber()
        {
            comissao = new Comissao();
            caixa = new Caixa();
            forma = new FormaPagamento();
        }

        public int Codigo { get; set; }
        public DateTime DtVencimento { get; set; }
        public DateTime DtPagamento { get; set; }
        public double ValorTotal { get; set; }
        public string Obs { get; set; }
        public Comissao Comissao { get; set; }
        public Caixa Caixa { get; set; }
        public int CodigoFechamento { get; set; }
        public FormaPagamento Forma { get; set; }
        public int CodigoPf { get; set; }

    }
}
