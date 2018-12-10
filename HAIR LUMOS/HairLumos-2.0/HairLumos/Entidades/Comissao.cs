using System;

namespace HairLumos.Entidades
{
    public class Comissao
    {

        public int _codComissao;
        public DateTime _dtPagamento;
        public double _valorTotal;
        public double _valorPago;
        public double _valorDevolver;
        public string _statusComissao;
        public string _statusPagamento;

        public string _erro;

        public Comissao (int strCod, DateTime strPagamento, double strTotal, double strPago, double strDevolver, string strStatusComissao, string strStatusPagamento)
        {
            this.carregaComissao(strCod, strPagamento, strTotal, strPago, strDevolver, strStatusComissao, strStatusPagamento);
        }

        public Comissao()
        {
            //this.carregaComissao(0, DateTime.Now, 0, 0, 0, string.Empty, string.Empty);
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }
        public int CodigoComissao
        {
            get { return _codComissao; }
            set { _codComissao = value; }
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
        public double ValorDevolver
        {
            get { return _valorDevolver; }
            set { _valorDevolver = value; }
        }
        public string StatusComissao
        {
            get { return _statusComissao; }
            set { _statusComissao = value; }
        }
        public string StatusPagamento
        {
            get { return _statusPagamento; }
            set { _statusPagamento = value; }
        }

        public void carregaComissao(int strCod, DateTime strPagamento, double strTotal, double strPago, double strDevolver, 
            string strStatusComissao, string strStatusPagamento)
        {
            this.CodigoComissao = strCod;
            this.DataPagamento = strPagamento;
            this.ValorTotal = strTotal;
            this.ValorPago = strPago;
            this.ValorDevolver = strDevolver;
            this.StatusComissao = strStatusComissao;
            this.StatusPagamento = strStatusPagamento;
        }

    }
}