using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class PacoteServico
    {
        private Pacote _pacote;
        private Servico _servico;
        private int _qtde;
        private string _periodicidade;

        private string _erro;

        public PacoteServico()
        {

        }

        public PacoteServico(Pacote pacote, Servico servico, int qtd, string periodicidade)
        {
            this.carregaPacoteServico(pacote, servico, qtd, periodicidade);
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        public Pacote Pacote
        {
            get { return _pacote; }
            set { _pacote = value; }
        }
        public Servico Servico
        {
            get { return _servico; }
            set { _servico = value; }
        }
        public int Quantidade
        {
            get { return _qtde; }
            set { _qtde = value; }
        }
        public string Periodicidade
        {
            get { return _periodicidade; }
            set { _periodicidade = value; }
        }

        public void carregaPacoteServico(Pacote pacote, Servico servico, int qtd, string periodicidade)
        {
            this.Pacote = pacote;
            this.Servico = servico;
            this.Quantidade = qtd;
            this.Periodicidade = periodicidade;
        }
    }
}
