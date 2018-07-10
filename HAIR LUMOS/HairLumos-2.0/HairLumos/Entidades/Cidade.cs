using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    public class Cidade
    {
        private int _codCidade;
        private string _nome;
        private Estado _estado;

        private string _erro;

        public Cidade(int cod, string nome, Estado estado)
        {
            this.carregaCidade(cod, nome, estado);
        }

        public Cidade()
        {
            this.carregaCidade(0, string.Empty, null);
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        public int CodigoCid
        {
            get { return _codCidade; }
            set { _codCidade = value; }
        }

        public string CidadeNome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public Estado Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public void carregaCidade(int cod, string nome, Estado estado)
        {
            this.CodigoCid = cod;
            this.CidadeNome = nome;
            this.Estado = estado;
        }
    }
}
