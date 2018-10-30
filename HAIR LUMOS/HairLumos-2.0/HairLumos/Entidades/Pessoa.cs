using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    public class Pessoa
    {
        // tbPessoa
        protected int _cod;
        protected string _nome;
        protected DateTime _dataCadastro;
        protected string _tipoPessoa;
        protected bool _statusPessoa;
        protected string _obsPessoa;
        protected bool _fiado;
        protected string _email;
        protected string _fone;
        protected string _cel;

        protected Endereco _endereco;
        //public PessoaFisica PessoaFisica { get; set; }
        //public PessoaJuridica PessoaJuridica { get; set; }

       

        private string _erro;


        public Pessoa(int cod, string nome, DateTime dataCadastro, string tipoPes, bool status, string obs, bool fiado,
        string email, string fone, string cel, Endereco endereco)
        {
           
            this.Codigo = cod;
            this.Nome = nome;
            this.DataCadastro = dataCadastro;
            this.TipoPessoa = tipoPes;
            this.StatusPessoa = status;
            this.Observacao = obs;
            this.Fiado = fiado;
            this.Email = email;
            this.Telefone = fone;
            this.Celular = cel;
            this.Endereco = endereco;
            
        }

        public Pessoa()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.DataCadastro = DateTime.Now;
            this.TipoPessoa = "";
            this.StatusPessoa = false;
            this.Observacao = "";
            this.Fiado = false;
            this.Email = "";
            this.Telefone = "";
            this.Celular = "";

        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        public int Codigo
        {
            get { return _cod; }
            set { _cod = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public DateTime DataCadastro
        {
            get { return _dataCadastro; }
            set { _dataCadastro = value; }
        }

        public string TipoPessoa
        {
            get { return _tipoPessoa; }
            set { _tipoPessoa = value; }
        }

        public bool StatusPessoa
        {
            get { return _statusPessoa; }
            set { _statusPessoa = value; }
        }

        public string Observacao
        {
            get { return _obsPessoa; }
            set { _obsPessoa = value; }
        }

        public bool Fiado
        {
            get { return _fiado; }
            set { _fiado = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Telefone
        {
            get {
                return _fone;
                    ; }
            set { _fone = value; }
        }

        public string Celular
        {
            get { return _cel; }
            set { _cel = value; }
        }

        public Endereco Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }


        public void carregaPessoa(int cod, string nome, DateTime dataCadastro, string tipoPes, bool status,
            string obs, bool fiado, string email, string fone, string cel)//, PessoaFisica pessoaFisica, PessoaJuridica pessoajuridica)
        {
            this.Codigo = cod;
            this.Nome = nome;
            this.DataCadastro = dataCadastro;
            this.TipoPessoa = tipoPes;
            this.StatusPessoa = status;
            this.Observacao = obs;
            this.Fiado = fiado;
            this.Email = email;
            this.Telefone = fone;
            this.Celular = cel; 

            //this.PessoaFisica = pessoaFisica;
            //this.PessoaJuridica = pessoajuridica;
        }

        public void carregaPessoaTable(int cod, string nome, DateTime dataCadastro, string tipoPes, bool status,
            string obs, bool fiado, string email, string fone, string cel, Endereco endereco)
        {
            this.Codigo = cod;
            this.Nome = nome;
            this.DataCadastro = dataCadastro;
            this.TipoPessoa = tipoPes;
            this.StatusPessoa = status;
            this.Observacao = obs;
            this.Fiado = fiado;
            this.Email = email;
            this.Telefone = fone;
            this.Celular = cel;
        }

    }

    public class Endereco
    {
        public Endereco()
        {

        }

        public Endereco(string strCep, string strLogradouro, string strNumero, string strBairro, string strComplemento, int uf, int cidade)
        {
            _cod = 0;
            _cep = strCep;
            _logradouro = strLogradouro;
            _numero = strNumero;
            _bairro = strBairro;
            _complemento = strComplemento;
            _codUf = uf;
            _codCidade = cidade;
        }

        public int _cod { get; set; }
        public string _cep { get; set; }
        public string _logradouro { get; set; }
        public string _numero { get; set; }
        public string _bairro { get; set; }
        public string _complemento { get; set; }
        public int _codUf { get; set; }
        public int _codCidade { get; set; }
    }
    
}
