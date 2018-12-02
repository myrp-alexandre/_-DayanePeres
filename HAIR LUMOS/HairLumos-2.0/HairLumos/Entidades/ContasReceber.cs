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
        private double valortotal;
        private string obs;
        private Venda venda;
        private Contrato contrato;
        private Comissao comissao;
        private int codfechamento;
        private Pessoa pessoaf;

        private List<Entidades.Parcela> listaParcelas;

        public ContasReceber()
        {
            comissao = new Comissao();
            pessoaf = new Pessoa();
            venda = new Venda();
            contrato = new Contrato();
            listaParcelas = new List<Parcela>();
        }

        public int Codigo { get; set; }
        public DateTime DtVencimento { get; set; }
        public double ValorTotal { get; set; }
        public string Obs { get; set; }
        public Comissao Comissao { get; set; }
        public int CodigoFechamento { get; set; }
        public Pessoa Pessoaf { get; set; }
        public Venda Venda { get; set; }
        public Contrato Contrato { get; set; }
        public List<Entidades.Parcela> Lista { get; set; }

    }
}
