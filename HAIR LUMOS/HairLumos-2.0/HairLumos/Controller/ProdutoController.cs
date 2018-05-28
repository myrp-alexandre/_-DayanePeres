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
    }
}
