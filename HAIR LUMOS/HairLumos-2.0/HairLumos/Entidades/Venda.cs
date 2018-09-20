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
        private Entidades.PessoaFisica _pessoaFisica;

        private List<VendaProduto> listVendaProduto;

        public Venda(int codigo, DateTime data, string situacao, double valorTotal, string observacao, PessoaFisica pessoaFisica, List<VendaProduto> listVendaProduto)
        {
            _codigo = codigo;
            _data = data;
            _situacao = situacao;
            _valorTotal = valorTotal;
            _observacao = observacao;
            _pessoaFisica = pessoaFisica;
            this.listVendaProduto = listVendaProduto;
        }

        public Venda()
        {
            _pessoaFisica = new PessoaFisica();
            listVendaProduto = new List<VendaProduto>();
        }

        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public string Situacao { get; set; }
        public double ValorTotal { get; set; }
        public string Observacao { get; set; }
        public PessoaFisica PessoaFisica { get; set; }
        public List<VendaProduto> ListavendaProdutos { get; set; }
    }
}
