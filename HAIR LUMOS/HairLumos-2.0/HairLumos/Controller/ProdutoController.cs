using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class ProdutoController
    {
        private Models.ProdutoModels _MdlProd = new Models.ProdutoModels();


        /*
         * ********** C A T E G O R I A  *********************************** 
         */
        public int gravaCategoria (int cod, string categoria, string obs)
        {
            return _MdlProd.gravarCategoria(cod, categoria, obs);
        }

        public DataTable retornaCategoria()
        {
            return _MdlProd.retornaCategoria();
        }

        public DataTable retornaObjCategoria(int cod)
        {
            return _MdlProd.retornaObjCategoria(cod);
        }

        public bool excluirCategoria(int intCod)
        {
            return _MdlProd.excluirCategoria(intCod);
        }

        /*
         * ********** M A R C A  *********************************** 
         */

        public int gravarMarca(int cod, string marca)
        {
            return _MdlProd.gravarMarca(cod, marca);
        }

        public DataTable retornaMarca()
        {
            return _MdlProd.retornaMarca();
        }

        public DataTable retornaObjMarca(int cod)
        {
            return _MdlProd.retornaObjMarca(cod);
        }

        public bool excluirMarca(int intCod)
        {
            return _MdlProd.excluirMarca(intCod);
        }

        /*
         * ********** P R O D U T O *********************************** 
         */
        public int gravaProduto (int codProd, int codCategoria , int codMarca, string nomeProd,
            double custo, double venda, int qtde, string obs)
        {
            return _MdlProd.gravaProduto(codProd, codCategoria, codMarca, nomeProd, custo, venda,  qtde, obs);
        }

        public DataTable retornaProduto()
        {
            return _MdlProd.retornaProduto();
        }

        public bool excluirProduto(int intCod)
        {
            return _MdlProd.excluirProduto(intCod);
        }
    }
}
