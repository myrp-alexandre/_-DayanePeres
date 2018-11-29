using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class TabelaVendaProduto
    {
        private int codVenda;
        private int codProuto;
        private string nomeProd;
        private double valorProd;
        private double valorTotalVenda;

        public TabelaVendaProduto()
        {
        }

        public int CodigoVenda { get; set; }
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public double ValorProduto{ get; set; }
        public double ValorVenda { get; set; }

        public static explicit operator TabelaVendaProduto(string v)
        {
            throw new NotImplementedException();
        }
    }
}
