using HairLumos.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class ProdutoModels
    {
        // validar informações para enviar/receber do Banco 

        DAO.ProdutoDAO _DAOProd = new DAO.ProdutoDAO();


        /*  
         *************** CATEGORIA *************************************  
         *  
         */
        public bool validaCadastro()
        {
            Entidades.Categoria _entCategoria = new Entidades.Categoria();
            if (string.IsNullOrEmpty(_entCategoria.CategoriaNome))
                _entCategoria.Erro += "Informa a Categoria.";

            return string.IsNullOrEmpty(_entCategoria.Erro);
        }

        public int gravarCategoria(int cod, string categoria, string obs)
        {
            Entidades.Categoria _entCategoria = new Entidades.Categoria();
            _entCategoria.carregaCategoria(cod, categoria, obs);
            
            return _DAOProd.GravarCategoria(_entCategoria);
        }

        public DataTable retornaCategoria()
        {
            Entidades.Categoria _entCategoria = new Entidades.Categoria();
            return _DAOProd.retornaCategoria();
        }

        public DataTable retornaObjCategoria(int cod)
        {
            Entidades.Categoria _entCategoria = new Entidades.Categoria();
            return _DAOProd.retornaObjCateria(cod);
        }

        public bool excluirCategoria(int intCod)
        {
            Entidades.Categoria _entCategoria = new Entidades.Categoria();
            return _DAOProd.excluirCategoria(intCod);
        }

        /*  
         *************** M A R C A *************************************  
         *  
         */

        public bool validaCadastroMarca()
        {
            Entidades.Marca _entMarca = new Entidades.Marca();
            if (string.IsNullOrEmpty(_entMarca.MarcaProduto))
                _entMarca.Erro += "Informe a Marca.";

            return string.IsNullOrEmpty(_entMarca.Erro);
        }

        public int gravarMarca(int cod, string marca)
        {
            Entidades.Marca _entMarca = new Entidades.Marca();
            _entMarca.carregaMarca(cod, marca);

            return _DAOProd.GravarMarca(_entMarca);
        }

        public DataTable retornaMarca()
        {
            Entidades.Marca _entMarca = new Entidades.Marca();
            return _DAOProd.RetornaMarca();
        }

        public DataTable retornaObjMarca(int cod)
        {
            Entidades.Marca _entMarca = new Entidades.Marca();
            return _DAOProd.retornaObjMarca(cod);
        }

        public bool excluirMarca(int intCod)
        {
            Entidades.Marca _entMarca = new Entidades.Marca();
            return _DAOProd.ExcluirMarca(intCod);
        }

        /*  
         *************** P R O D U T O *************************************  
         *  
         */

        public int gravaProduto(int codProd, int codCategoria, int codMarca, string nomeProd, 
            double custo, double venda,  int qtde, string obs)
        {
            Entidades.Produto _entProduto = new Entidades.Produto();
            Entidades.Categoria _entCategoria = new Entidades.Categoria();
            Entidades.Marca _entMarca = new Entidades.Marca();

            DataTable dtCategoria = _DAOProd.retornaObjCateria(codCategoria);            
            if (dtCategoria != null && dtCategoria.Rows.Count > 0)
            {
                DataRow dr = dtCategoria.Rows[0];

                _entCategoria.Codigo = Convert.ToInt32(dr["codcategoria"].ToString());
                _entCategoria.CategoriaNome = dr["cat_categoria"].ToString();
                _entCategoria.Observacao = dr["cat_obscategoria"].ToString();
            }

            DataTable dtMarca = _DAOProd.retornaObjMarca(codMarca);
            if (dtMarca != null && dtMarca.Rows.Count > 0)
            {
                DataRow dr = dtMarca.Rows[0];

                _entMarca.Codigo = Convert.ToInt32(dr["codmarca"].ToString());
                _entMarca.MarcaProduto = dr["marc_nome"].ToString();
            }


            _entProduto.carregaProduto(codProd, _entCategoria, _entMarca, nomeProd, custo, venda, qtde, obs); // 

            return _DAOProd.GravarProduto(_entProduto);
        }
  
        public DataTable retornaProduto()
        {
            Entidades.Produto _entProduto = new Entidades.Produto();
            return _DAOProd.RetornaProduto();
        }
            
        public bool excluirProduto(int intCod)
        {
            Entidades.Produto _entProd = new Entidades.Produto();
            return _DAOProd.ExcluirProduto(intCod);
        }

        public DataTable retornaProduto(string texto)
        {
            return _DAOProd.RetornaProduto(texto);
        }

        public DataTable retornaProduto(int cod)
        {
            return _DAOProd.RetornaProduto(cod);
        }

        public int atualizaEstoque(Entidades.Produto obj)
        {
            return _DAOProd.atualizaEstoque(obj);
        }

        //------------------------------------- Baixa manual no estoque--------------------------

        public int gravaBaixa(Entidades.BaixaManual obj)
        {
            return _DAOProd.gravaBaixaManual(obj);
        }

        public int excluiBaixa(Entidades.BaixaManual obj)
        {
            return _DAOProd.excluiBaixa(obj);
        }

        public DataTable retornaBaixaManual(int cod)
        {
            return _DAOProd.RetornaBaixas(cod);
        }

    }




}
