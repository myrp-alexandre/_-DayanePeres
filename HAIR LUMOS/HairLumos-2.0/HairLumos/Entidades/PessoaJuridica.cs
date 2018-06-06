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
        private string _razaoSocial;
        private string _fantasia;
        

        private string _erro;

        public PessoaJuridica (string razao, string fantasia, int codP, string nome, DateTime dataCadastro, string tipoPes, bool status,
            string obs, bool fiado) : base(codP, nome, dataCadastro, tipoPes, status, obs, fiado)
        {

            this.carregaPessoaJuridica(razao, fantasia);
        }

        public PessoaJuridica(string razao, string fantasia)
        {
            this.carregaPessoaJuridica(razao, fantasia);
        }

        public PessoaJuridica()
        {
            this.carregaPessoaJuridica(string.Empty, string.Empty);
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

        public void carregaPessoaJuridica(string razao, string fantasia)
        {
            //this.Pessoa = pes;
            this.RazaoSocial = razao;
            this.NomeFantasia = fantasia;
            
        }
    }
}
