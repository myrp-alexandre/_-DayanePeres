using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class Contrato
    {
        private int _codContrato;
        private DateTime _dataContrato;
        private string _observacao;

        private Pacote _pacote;
        private Pessoa _pessoa;

        private List<PacotesAdicionais> _listPacotesAdicionais;

        private string _erro;

        public Contrato(int codContrato, DateTime dataContrato, string observacao, Pacote pacote, Pessoa pessoa, List<PacotesAdicionais> listPacotesAdicionais)
        {
            this.carregaContrato(codContrato,  dataContrato,  observacao,  pacote,  pessoa, listPacotesAdicionais);
        }

        public Contrato()
        {
            this.carregaContrato(0, DateTime.Now, "", null, null, null);
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        public int CodigoContrato
        {
            get { return _codContrato; }
            set { _codContrato = value; }
        }

        public DateTime DataContrato
        {
            get { return _dataContrato; }
            set { _dataContrato = value; }
        }

        public string Observacao
        {
            get { return _observacao; }
            set { _observacao = value; }
        }

        public Pacote Pacote
        {
            get { return _pacote; }
            set { _pacote = value; }
        }

        public Pessoa Pessoa
        {
            get { return _pessoa; }
            set { _pessoa = value; }
        }

        public List<PacotesAdicionais> PacotesAdicionais
        {
            get { return _listPacotesAdicionais; }
            set { _listPacotesAdicionais = value; }
        }

        public void carregaContrato(int codContrato, DateTime dataContrato, string observacao, Pacote pacote, Pessoa pessoa, List<PacotesAdicionais> listPacotesAdicionais)
        {
            this.CodigoContrato = codContrato;
            this.DataContrato = dataContrato;
            this.Observacao = observacao;
            this.Pacote = pacote;
            this.Pessoa = pessoa;
            this.PacotesAdicionais = listPacotesAdicionais;
        }

        public override string ToString()
        {
            return ToString();
        }
    }
}
