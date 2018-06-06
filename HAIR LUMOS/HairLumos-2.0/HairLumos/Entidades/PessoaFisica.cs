using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
   public  class PessoaFisica : Pessoa
    {
        private string _cpf;
        private string _rg;
        private DateTime _nascimento;

        private string _erro;

        public PessoaFisica(string cpf, string rg, DateTime nascimento,  int codP, string nome, DateTime dataCadastro, string tipoPes, bool status,
            string obs, bool fiado) //:base(codP, nome, dataCadastro, tipoPes, status, obs, fiado)
        {

            this.carregaPessoaFisica(cpf, rg, nascimento, codP, nome, dataCadastro, tipoPes, status, obs, fiado);
            //this.CPF = cpf;
            //this.RG = rg;
            //this.Nascimento = nascimento;
        }

        //public PessoaFisica(int cod, string nome, DateTime dataCadastro, string tipoPes, string obs, bool fiado,
        //    string cpf, string rg, DateTime nascimento)
        //{
        //    this.carregaPessoaFisica(cpf, rg, nascimento);
        //}

        //public PessoaFisica(string cpf, string rg, DateTime nascimento)
        //{
        //    this.carregaPessoaFisica(cpf, rg, nascimento);
        //}

        //public PessoaFisica()
        //{
        //    this.carregaPessoaFisica(string.Empty, string.Empty, DateTime.Now);
        //}

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }


        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public string RG
        {
            get { return _rg; }
            set { _rg = value; }
        }

        public DateTime Nascimento
        {
            get { return _nascimento; }
            set { _nascimento = value; }
        }
        
        public void carregaPessoaFisica(string cpf, string rg, DateTime nascimento, int codP, string nome, DateTime dataCadastro, string tipoPes, bool status,
            string obs, bool fiado)
        {
            this.CPF = cpf;
            this.RG = rg;
            this.Nascimento = nascimento;
            this.Codigo = codP;
            this.Nome = nome;
            this.DataCadastro = dataCadastro;
            this.TipoPessoa = tipoPes;
            this.StatusPessoa = status;
            this.Observacao = obs;
            this.Fiado = fiado;
            
        }
    }
}
