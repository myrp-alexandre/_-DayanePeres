using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class Pacote
    {
        private int _cod;
        private string _pacote;
        private double _valor;
        private string _obs;
        private string _periodicidadde;
        private DateTime _dataInicio;
        private DateTime _dataFim;
        
        List<Entidades.PacoteServico> _listaServicos;

        public string _erro;

        public Pacote(int cod, string pacote, double valor, string obs, string periodo, List <Entidades.PacoteServico> servicos, DateTime dtIni, DateTime dtFim)
        {
            this.carregaPacote(cod, pacote, valor, obs, periodo, servicos, dtIni, dtFim);
        }

        public Pacote()
        {
            this.carregaPacote(0, string.Empty, 0, string.Empty, string.Empty, null, DateTime.Now, DateTime.Now);
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        public int Codigo
        {
            get { return _cod; }
            set { _cod = value; }
        }

        public string PaccoteNome
        {
            get { return _pacote; }
            set { _pacote= value; }
        }

        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }


        public string Observacao
        {
            get { return _obs; }
            set { _obs = value; }
        }

        public string Periodo
        {
            get { return _periodicidadde; }
            set { _periodicidadde = value; }
        }

        public List<Entidades.PacoteServico> ListaServico
        {
            get { return _listaServicos; }
            set { _listaServicos = value; }
        }

        public DateTime DataInicio
        {
            get { return _dataInicio; }
            set { _dataInicio = value; }
        }

        public DateTime DataFim
        {
            get { return _dataFim; }
            set { _dataFim = value; }
        }

        public void carregaPacote(int cod, string pacote, double valor, string obs, string periodo, List<Entidades.PacoteServico> servicos, DateTime dtIni, DateTime dtFim)
        {
            this.Codigo = cod;
            this.PaccoteNome = pacote;
            this.Valor = valor;
            this.Observacao = obs;
            this.Periodo = periodo;
            this.ListaServico = servicos;
            this.DataInicio = dtIni;
            this.DataFim = dtFim;
            
        }
    }
}

