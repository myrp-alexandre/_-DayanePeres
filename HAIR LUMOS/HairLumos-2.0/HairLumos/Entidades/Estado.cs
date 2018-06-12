using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class Estado
    {
        private int _codUf;
        private string _uf;
        private string _nome;

        private string _erro;

        public Estado(int cod, string uf, string nome)
        {
            this.carregaEstado(cod, uf, nome);
        }

        public Estado()
        {
            this.carregaEstado(0, string.Empty, string.Empty);
        }

        public int CodigoUF
        {
            get { return _codUf; }
            set { _codUf = value; }
        }

        public string UF
        {
            get { return _uf; }
            set { _uf = value; }
        }

        public string NomeEstado
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        public void carregaEstado(int cod, string uf, string nome)
        {
            this.CodigoUF = cod;
            this.UF = uf;
            this.NomeEstado = nome;
        }
    }
}
