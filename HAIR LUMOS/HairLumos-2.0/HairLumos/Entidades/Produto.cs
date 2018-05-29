using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class Produto
    {
        public int _codProduto;
        public Categoria _categoria;
        public Marca _marca;
        public String _nome;
        public double _custo;
        public double _venda;
        public String _descricao;
        public int _qtde;
        public String _obs;

        public String _erro;

        public Produto(int _codProduto, Categoria _categoria, Marca _marca, String _nome, double _custo,
            double _venda, String _descricao, int _qtde, String _obs)
        {
            this.carregaProduto(_codProduto, _categoria, _marca, _nome, _custo, _venda, _descricao, _qtde, _obs);
        }

        public Produto()
        {
            this.carregaProduto(0, null, null, string.Empty, 0, 0, string.Empty, 0, string.Empty);
        }

        public void carregaProduto(int strCodProd, Categoria strcategoria, Marca strMarca, string strNome,
            double strCusto, double strVenda, string strDescricao, int strQtde, string strObs)
        {
            this.CodigoProduto = strCodProd;
            this.Categoria = strcategoria;
            this.Marca = strMarca;
            this.NomeProduto = strNome;
            this.Custo = strCusto;
            this.Venda = strVenda;
            this.Descricao = strDescricao;
            this.Quantidade = strQtde;
            this.Observacao = strObs;
        }

        public int CodigoProduto
        {
            get { return _codProduto; }
            set { _codProduto = value; }
        }

        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public Marca Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string NomeProduto
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public double Custo
        {
            get { return _custo; }
            set { _custo = value; }
        }

        public double Venda
        {
            get { return _venda; }
            set { _venda = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public int Quantidade
        {
            get { return _qtde; }
            set { _qtde = value; }
        }

        public string Observacao
        {
            get { return _obs; }
            set { _obs = value; }
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }
    }
}
