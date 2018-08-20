using System;

namespace HairLumos.Entidades
{
    public class Caixa
    {
        public int _codCaixa;
        public string _periodo;
        public DateTime _dtAbertura;
        public DateTime _dtFecha;
        public double _saldoInicial;
        public double _troco;
        public double _totalEntrada;
        public double _totalSaida;

        public Usuario _Usuario;
        public Pessoa _Pessoa;

        public string _erro;

        public Caixa(int codCaixa, string strPeriodo, DateTime strAbertura, DateTime strFecha, double strSaldoInicial, double strTroco,
            double strEntrada, double strSaida)
        {
            this.carregaCaixa(codCaixa, strPeriodo, strAbertura, strFecha, strSaldoInicial, strTroco, strEntrada, strSaida);
        }

        public Caixa()
        {
            this.carregaCaixa(0, string.Empty, DateTime.Now, DateTime.Now, 0, 0, 0, 0); //Convert.ToDateTime("dd/MM/yyyy")
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        public int CodCaixa
        {
            get { return _codCaixa; }
            set { _codCaixa = value; }
        }
        public string Periodo
        {
            get { return _periodo; }
            set { _periodo = value; }
        }
        public DateTime DataAbertura
        {
            get { return _dtAbertura; }
            set { _dtAbertura = value; }
        }
        public DateTime DataFechamento
        {
            get { return _dtFecha; }
            set { _dtFecha = value; }
        }
        public double SaldoInicial
        {
            get { return _saldoInicial; }
            set { _saldoInicial = value; }
        }
        public double Troco
        {
            get { return _troco; }
            set { _troco = value; }
        }
        public double TotalEntrada
        {
            get { return _totalEntrada; }
            set { _totalEntrada = value; }
        }
        public double TotalSaida
        {
            get { return _totalSaida; }
            set { _totalSaida = value; }
        }
        public Usuario Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public Pessoa Pessoa
        {
            get { return _Pessoa; }
            set { _Pessoa = value; }
        }

        public void carregaCaixa(int codCaixa, string strPeriodo, DateTime strAbertura, DateTime strFecha, double strSaldoInicial, 
            double strTroco, double strEntrada, double strSaida)
        {
            this.CodCaixa = codCaixa;
            this.Periodo = strPeriodo;
            this.DataAbertura = strAbertura;
            this.DataFechamento = strFecha;
            this.SaldoInicial = strSaldoInicial;
            this.Troco = strTroco;
            this.TotalEntrada = strEntrada;
            this.TotalSaida = strSaida;

        }

    }
}