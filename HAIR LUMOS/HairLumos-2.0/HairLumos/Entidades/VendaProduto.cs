using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class VendaProduto
    {
        private Produto _produto;
        private int _qtde;
        private double _valor;

        public VendaProduto(Produto produto, int qtde, double valor)
        {
            _produto = produto;
            _qtde = qtde;
            _valor = valor;
        }

        public VendaProduto()
        {
            _produto = new Produto();
        }

        public Produto Produto{ get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

    }
}
