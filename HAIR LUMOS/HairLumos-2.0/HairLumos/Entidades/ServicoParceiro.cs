using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class ServicoParceiro
    {

        public PessoaJuridica _pessoaJuridica;
        public Servico _servico;
        public double _valor;
        public double _percentual;
        public string _pagRecebido;
        public Agenda _Agenda;

        public string _erro;

        public ServicoParceiro (PessoaJuridica pes, Servico serv, double valor, double percentual, string recebido, Agenda agenda)
        {
            this.CarregaServicoParceiro(pes, serv, valor, percentual, recebido, agenda);
        }

        public ServicoParceiro()
        {
            this.CarregaServicoParceiro(null, null, 0, 0, string.Empty, null);
        }

        public PessoaJuridica PessoaJuridica
        {
            get { return _pessoaJuridica; }
            set { _pessoaJuridica = value; }
        }

        public Servico Servico
        {
            get { return _servico; }
            set { _servico = value; }
        }

        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public double Percentual
        {
            get { return _percentual; }
            set { _percentual = value; }
        }

        public string PagamentoRecebido
        {
            get { return _pagRecebido; }
            set { _pagRecebido = value; }
        }

        public Agenda Agenda
        {
            get { return _Agenda; }
            set { _Agenda = value; }
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        public void CarregaServicoParceiro(PessoaJuridica strPessoa, Servico strServico, double strValor, double strPercentual, string strRecebido, Agenda agenda)
        {
            this.PessoaJuridica = strPessoa;
            this.Servico = strServico;
            this.Valor = strValor;
            this.Percentual = strPercentual;
            this.PagamentoRecebido = strRecebido;
            this.Agenda = agenda;
        }
        
    }
}
