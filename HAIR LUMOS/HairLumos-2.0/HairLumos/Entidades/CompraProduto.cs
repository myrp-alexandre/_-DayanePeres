using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class CompraProduto
    {
        public Produto _produto;
        public int _qtde;
        public double _valor;
        public int _qtdeDevolvida;

        public CompraProduto()
        {
            _produto = new Produto();
        }

        public Produto Produto
        {
            get { return _produto; }
            set { _produto = value; }
        }

        public int Qtde
        {
            get { return _qtde; }
            set { _qtde = value; }
        }

        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public int QtdeDevolvida
        {
            get { return _qtdeDevolvida; }
            set { _qtdeDevolvida = value; }
        }

    }
}
