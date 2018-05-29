using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class Marca
    {
        private int _cod;
        private string _marca;

        private string _erro;

        public Marca(int cod, string marca)
        {
            this.carregaMarca(cod, marca);
        }

        public Marca()
        {
            this.carregaMarca(0, string.Empty);
        }

        public int Codigo
        {
            get { return _cod;  }
            set { _cod = value;  }
        }


        public string MarcaProduto
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        public void carregaMarca(int cod, string marca)
        {
            this.Codigo = cod;
            this.MarcaProduto = marca;
        }
    }
}
