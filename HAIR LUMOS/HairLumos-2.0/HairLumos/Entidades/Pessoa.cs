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

        //public PessoaFisica PessoaFisica { get; set; }
        //public PessoaJuridica PessoaJuridica { get; set; }

        private List<Endereco> _listaEndreco;
        private List<Contato> _listaContato;

        private string _erro;

        //public Pessoa(int cod, string nome, DateTime dataCadastro, string tipoPes, bool status, string obs, bool fiado, 
        //    string email, PessoaFisica pessoafisica, PessoaJuridica pessoajuridica)
        //{
        //    this.carregaPessoa(cod, nome, dataCadastro, tipoPes, status, obs, fiado, email, pessoafisica, pessoajuridica);
        //}

        //public Pessoa()
        //{
        //    this.carregaPessoa(0, string.Empty, DateTime.Now, string.Empty, false, string.Empty, false, string.Empty, null, null);
        //}

        public Pessoa(int cod, string nome, DateTime dataCadastro, string tipoPes, bool status, string obs, bool fiado,
        string email)
        {
            this.carregaPessoa(cod, nome, dataCadastro, tipoPes, status, obs, fiado, email);
        }

        public Pessoa()
        {
            this.carregaPessoa(0, string.Empty, DateTime.Now, string.Empty, false, string.Empty, false, string.Empty);
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



        


        public List<Endereco> ListaEndereco
        {
            get { return _listaEndreco; }
            set
            {
                _listaEndreco = value;
            }
        }

        public List<Contato> ListaContato
        {
            get { return _listaContato; }
            set
            {
                _listaContato = value;
            }
        }



        public void carregaPessoa(int cod, string nome, DateTime dataCadastro, string tipoPes, bool status,
            string obs, bool fiado, string email)//, PessoaFisica pessoaFisica, PessoaJuridica pessoajuridica)
        {
            this.Codigo = cod;
            this.Nome = nome;
            this.DataCadastro = dataCadastro;
            this.TipoPessoa = tipoPes;
            this.StatusPessoa = status;
            this.Observacao = obs;
            this.Fiado = fiado;
            this.Email = email;
            //this.PessoaFisica = pessoaFisica;
            //this.PessoaJuridica = pessoajuridica;
        }

        public void carregaPessoaTable(int cod, string nome, DateTime dataCadastro, string tipoPes, bool status,
            string obs, bool fiado, string email)
        {
            this.Codigo = cod;
            this.Nome = nome;
            this.DataCadastro = dataCadastro;
            this.TipoPessoa = tipoPes;
            this.StatusPessoa = status;
            this.Observacao = obs;
            this.Fiado = fiado;
            this.Email = email;
            
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

    public class Contato
    {
        public Contato()
        {

        }

        public Contato(string strfone, string strCel, string strEmail)
        {
            _cod = 0;
            _telefone = strfone;
            _celular = strCel;
            _email = strEmail;
            
        }

        public int _cod { get; set; }
        public string _telefone { get; set; }
        public string _celular { get; set; }
        public string _email { get; set; }
        
    }
}
