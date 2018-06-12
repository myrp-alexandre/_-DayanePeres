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
        private string _fantasia;
        

        private string _erro;

        public PessoaJuridica (string cnpj, string razao, string fantasia)//, int codP, string nome, DateTime dataCadastro,
            //string tipoPes, bool status,string obs, bool fiado) 
        {

            this.carregaPessoaJuridica(cnpj, razao, fantasia);
        }

        //public PessoaJuridica(string cnpj, string razao, string fantasia)
        //{
        //    this.carregaPessoaJuridica(cnpj, razao, fantasia);
        //}

        public PessoaJuridica()
        {
            this.carregaPessoaJuridica(string.Empty, string.Empty, string.Empty);
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        //public Pessoa Pessoa
        //{
        //    get { return _Pessoa; }
        //    set { _Pessoa = value; }
        //}
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

        public string NomeFantasia
        {
            get { return _fantasia; }
            set { _fantasia = value; }
        }

        //public string InscricaoEstadual
        //{
        //    get { return _inscricaoEstadual; }
        //    set { _inscricaoEstadual = value; }
        //}

        public void carregaPessoaJuridica(string cnpj, string razao, string fantasia)
        {
            //this.Pessoa = pes;
            this.CNPJ = cnpj;
            this.RazaoSocial = razao;
            this.NomeFantasia = fantasia;
            
        }
    }
}
