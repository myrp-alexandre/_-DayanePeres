using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    public class PessoaJuridica : Pessoa
    {
        //private Pessoa _Pessoa;
        private string _cnpj;
        private string _razaoSocial;
        

        private string _erro;

        public PessoaJuridica(int cod, string nome, DateTime dataCadastro, string tipoPes, bool status, string obs, bool fiado,
        string email, Endereco endereco, string telefone, string celular, string cnpj, string razao) : base(cod, nome, dataCadastro, tipoPes, status, obs, fiado, email, telefone, celular, endereco)
        {
            this.CNPJ = cnpj;
            this.RazaoSocial = razao;
        }
        
        public PessoaJuridica()
        {
            this.CNPJ = "";
            this.RazaoSocial = "";
        }

        private Pessoa pessoa;
        public Pessoa Pessoa
        {
            get { return pessoa; }
            set { pessoa = value; }
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }
        
        public string CNPJ
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        public string RazaoSocial
        {
            get { return _razaoSocial; }
            set { _razaoSocial = value; }
        }

       
    }
}
