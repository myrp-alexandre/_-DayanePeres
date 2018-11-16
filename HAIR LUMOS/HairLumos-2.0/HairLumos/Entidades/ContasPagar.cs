using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class ContasPagar
    {
        public int _codContaPagar;
        public DateTime _dtVencimento;
        public DateTime _dtPagamento;
        public double _valorTotal;
        public double _valorPago;
        public string _obs;
        public int _numParcela;
        public bool _status;
        public double _valorParcela;
        public int _codParcela;

        public Compra _Compra;
        public Despesa _Despesa;
        public Caixa _Caixa;
        public FormaPagamento _FormaPagamento;
        public Comissao _Comissao;

        public string _erro;

        public ContasPagar(int codContaPagar, DateTime dtvencimento, DateTime dtpagamento, double valortotal, double valorpago, 
            string obs, int numparcela, bool status, Compra compra, Despesa despesa, Caixa caixa, FormaPagamento formpagamento, Comissao comissao, int codParcela, int valorParc)
        {
            this.carregaDespesa(codContaPagar, dtvencimento, dtpagamento, valortotal, valorpago, obs, numparcela, status, compra, despesa, caixa, formpagamento, comissao, codParcela, valorParc);
        }

        public ContasPagar()
        {
            this.carregaDespesa(0, DateTime.Now, DateTime.Now, 0, 0, string.Empty, 0, false, null, null, null, null, null, 0, 0);
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }
        public int CodigoContasaPagar
        {
            get { return _codContaPagar; }
            set { _codContaPagar = value; }
        }
        public DateTime DataVencimento
        {
            get { return _dtVencimento; }
            set { _dtVencimento = value; }
        }
        public DateTime DataPagamento
        {
            get { return _dtPagamento; }
            set { _dtPagamento = value; }
        }
        public double ValorTotal
        {
            get { return _valorTotal; }
            set { _valorTotal = value; }
        }
        public double ValorPago
        {
            get { return _valorPago; }
            set { _valorPago = value; }
        }
        public string Observacao
        {
            get { return _obs; }
            set { _obs = value; }
        }

        public int Parcela
        {
            get { return _numParcela; }
            set { _numParcela = value; }
        }

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public Compra Compra
        {
            get { return _Compra; }
            set { _Compra = value; }
        }
        public Despesa Despesa
        {
            get { return _Despesa; }
            set { _Despesa = value; }
        }
        public Caixa Caixa
        {
            get { return _Caixa; }
            set { _Caixa = value; }
        }
        public FormaPagamento FormaPagamento
        {
            get { return _FormaPagamento; }
            set { _FormaPagamento = value; }
        }
        public Comissao Comissao
        {
            get { return _Comissao; }
            set { _Comissao = value; }
        }

        public int CodParcela
        {
            get { return _codParcela; }
            set { _codParcela = value; }
        }

        public double ValorParcela
        {
            get { return _valorParcela; }
            set { _valorParcela = value; }
        }

        public void carregaDespesa(int codContaPagar, DateTime dtvencimento, DateTime dtpagamento, double valortotal, double valorpago,
            string obs, int numparcela, bool status, Compra compra, Despesa despesa, Caixa caixa, FormaPagamento formpagamento, Comissao comissao, int codParcela, int valorParc)
        {
            this.CodigoContasaPagar = codContaPagar;
            this.DataVencimento = dtvencimento;
            this.DataPagamento = dtpagamento;
            this.ValorTotal = valortotal;
            this.ValorPago = valorpago;
            this.Observacao = obs;
            this.Parcela = numparcela;
            this.Status = status;
            this.Compra = compra;
            this.Despesa = despesa;
            this.Caixa = caixa;
            this.FormaPagamento = formpagamento;
            this.Comissao = comissao;
            this.CodigoContasaPagar = codParcela;
            this.ValorParcela = valorParc;
        }

    }
}
