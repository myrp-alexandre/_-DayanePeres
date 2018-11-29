using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class Venda
    {
        private int _codigo;
        private DateTime _data;
        private string _situacao;
        private double _valorTotal;
        private string _observacao;
        private Entidades.Pessoa _pessoa;

        private List<VendaProduto> listVendaProduto;

        public Venda(int codigo, DateTime data, string situacao, 
            double valorTotal, string observacao, Pessoa pessoa, List<VendaProduto> listVendaProduto)
        {
            _codigo = codigo;
            _data = data;
            _situacao = situacao;
            _valorTotal = valorTotal;
            _observacao = observacao;
            _pessoa = pessoa;
            this.listVendaProduto = listVendaProduto;
        }

        public Venda()
        {
            _pessoa = new Pessoa();
            listVendaProduto = new List<VendaProduto>();
        }

        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public string Situacao { get; set; }
        public double ValorTotal { get; set; }
        public string Observacao { get; set; }
        public Pessoa Pessoa { get; set; }
        public List<VendaProduto> ListavendaProdutos { get; set; }
    }
}
