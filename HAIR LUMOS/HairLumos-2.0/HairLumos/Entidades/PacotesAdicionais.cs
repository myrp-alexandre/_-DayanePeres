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
        private Pessoa _pessoa;

        public PacotesAdicionais(Servico servico, int qtdeServico, Pessoa pessoa)
        {
            this.carregaPacotesAdicionais(servico, qtdeServico, pessoa);
        }

        public PacotesAdicionais()
        {
            this.carregaPacotesAdicionais(null, 0, null);
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

        public Pessoa Pessoa
        {
            get { return _pessoa; }
            set { _pessoa = value; }
        }

        public void carregaPacotesAdicionais(Servico servico, int qtdeServico, Pessoa pessoa)
        {
            this.Servico = servico;
            this.QtdeServico = qtdeServico;
            this.Pessoa = pessoa;
        }
    }
}
