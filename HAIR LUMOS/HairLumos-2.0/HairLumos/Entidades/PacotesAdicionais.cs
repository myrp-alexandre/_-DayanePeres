using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class PacotesAdicionais
    {
        //private Contrato _codContrato;
        private Servico _servico;
        private int _qtdeServico;
        private PessoaFisica _pessoa;
        private double _valor;
        private string _observacao;
        private bool _realizado;

        public PacotesAdicionais(Servico servico, int qtdeServico, PessoaFisica pessoa, double valor, string observacao, bool realizado)
        {
            this.carregaPacotesAdicionais(servico, qtdeServico, pessoa, valor, observacao, realizado);
        }

        public PacotesAdicionais()
        {
            _servico = new Servico();
            _pessoa = new PessoaFisica();

            this.carregaPacotesAdicionais(null, 0, null, 0, "",false);
        }

        public Servico Servico
        {
            get { return _servico; }
            set { _servico = value; }
        }

        public int QtdeServico
        {
            get { return _qtdeServico; }
            set { _qtdeServico = value; }
        }

        public PessoaFisica Pessoa
        {
            get { return _pessoa; }
            set { _pessoa = value; }
        }

        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public string Observacao
        {
            get { return _observacao; }
            set { _observacao = value; }
        }

        public bool Realizado
        {
            get { return _realizado; }
            set { _realizado = value; }
        }

        public void carregaPacotesAdicionais(Servico servico, int qtdeServico, PessoaFisica pessoa, double valor, string observacao, bool realizado)
        {
            this.Servico = servico;
            this.QtdeServico = qtdeServico;
            this.Pessoa = pessoa;
            this.Valor = valor;
            this.Observacao = observacao;
            this.Realizado = realizado;
        }
    }
}
