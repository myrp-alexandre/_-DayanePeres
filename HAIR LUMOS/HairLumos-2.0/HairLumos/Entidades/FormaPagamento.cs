using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class FormaPagamento
    {
        private int _cod;
        private string _forma;

        private string _erro;

        public FormaPagamento (int cod, string marca)
        {
            this.carregaMarca(cod, marca);
        }

        public FormaPagamento()
        {
            this.carregaMarca(0, string.Empty);
        }

        public int Codigo
        {
            get { return _cod; }
            set { _cod = value; }
        }


        public string Forma
        {
            get { return _forma; }
            set { _forma = value; }
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        public void carregaMarca(int cod, string forma)
        {
            this.Codigo = cod;
            this.Forma = forma;
        }

        public override string ToString()
        {
            return Forma;
        }

    }
}

