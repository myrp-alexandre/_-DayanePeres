using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class Parametrizacao
    {
        //ATRIBUTOS
        private int _cod;
        private string _razao;
        private string _nomeFantasia;
        private string _email;
        private string _endereco;
        private string _complemento;
        private string  _numero;
        private string _telefone;
        private string _celular;
        private byte[] _byteimg;

        //CONSTRUTORES
        public Parametrizacao()
        {
            this.carregaParametro(0, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, null);
        }

        public Parametrizacao(int cod, string razao, string nomeFantasia, string email, string endereco, 
            string complemento, string numero, string fone, string cel, byte[] logo)
        {
            carregaParametro(cod, razao, nomeFantasia, email, endereco, complemento, numero, fone, cel, logo);
        }

        public void carregaParametro(int cod, string razao, string nomeFantasia, string email, string endereco,
            string complemento, string numero, string fone, string cel, byte[] byteimg)
        {
            this.Codigo = cod;
            this.Razao = razao;
            this.NomeFantasia = nomeFantasia;
            this.Email = email;
            this.Endereco = endereco;
            this.Complemento = complemento;
            this.Numero = numero;
            this.Telefone = fone;
            this.Celular = cel;
            this.Byteimg = byteimg;
        }

        public int Codigo
        {
            get { return _cod; }
            set { _cod = value; }
        }

        public string Razao
        { get { return _razao; }
            set { _razao = value; }
        }

        public string NomeFantasia
        { get { return _nomeFantasia; }
            set { _nomeFantasia = value; }

        }
        public string Email
        { get { return _email; }
            set { _email = value; }
        }

        public string Endereco
        { get { return _endereco; }
            set { _endereco = value; }

        }
        public string Complemento
        { get { return _complemento; }
            set { _complemento = value; }
        }

        public string Numero
        { get { return _numero; }
            set { _numero = value; }
        }

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public string Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        public byte[] Byteimg
        { get { return _byteimg; }
            set { _byteimg = value; }
        }

    }
}
