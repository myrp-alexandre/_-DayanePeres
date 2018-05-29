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

        public bool excluirMarca(int intCod)
        {
            return _MdlProd.excluirMarca(intCod);
        }
    }
}
