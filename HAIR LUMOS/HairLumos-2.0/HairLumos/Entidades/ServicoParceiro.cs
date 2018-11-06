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

        public string _erro;

        public ServicoParceiro (PessoaJuridica pes, Servico serv, double valor, double percentual, string recebido)
        {
            this.CarregaServicoParceiro(pes, serv, valor, percentual, recebido);
        }

        public ServicoParceiro()
        {
            this.CarregaServicoParceiro(null, null, 0, 0, string.Empty);
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

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        public void CarregaServicoParceiro(PessoaJuridica strPessoa, Servico strServico, double strValor, double strPercentual, string strRecebido)
        {
            this.PessoaJuridica = strPessoa;
            this.Servico = strServico;
            this.Valor = strValor;
            this.Percentual = strPercentual;
            this.PagamentoRecebido = strRecebido;
        }
        
    }
}
