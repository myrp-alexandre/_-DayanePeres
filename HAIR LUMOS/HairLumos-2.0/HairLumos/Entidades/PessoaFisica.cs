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

        

        public PessoaFisica(int cod, string nome, DateTime dataCadastro, string tipoPes, bool status, string obs, bool fiado,
        string email, List<Endereco> ListaEndereco, List<Contato> ListaContato, string cpf, string rg, DateTime nascimento) : base(cod, nome, dataCadastro, tipoPes, status, obs, fiado, email, ListaEndereco, ListaContato)
        {
            
            this.CPF = cpf;
            this.RG = rg;
            this.Nascimento = nascimento;
        }

        private Pessoa pessoa;
        public Pessoa Pessoa
        {
            get { return pessoa; }
            set { pessoa = value; }
        }

        public PessoaFisica() : base()
        {
            
            this.CPF = "";
            this.RG = "";
            this.Nascimento = _nascimento;
        }
        
        
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
        
       
    }
}
