using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class CompraController
    {

        private Models.CompraModels _MdlComp = new Models.CompraModels();

        public int geravaCompra(int cod, int despesa, DateTime data, string situacao, bool consignado, double valor, string obs, int pessoa, List<Entidades.CompraProduto> lista)
        {
            return _MdlComp.gravarCompra(cod, despesa, data, situacao, consignado, valor, obs, pessoa, lista);
        }

        public DataTable retornaCompra()
        {
            return _MdlComp.retornaCompra();
        }

        public DataTable retornaCompra(int codigo)
        {
            return _MdlComp.retornaCompra(codigo);
        }

        public List<Entidades.CompraProduto> retornaLista(int codigo)
        {
            return _MdlComp.retornaLista(codigo);
        }

        public int excluirCompra(int codigo)
        {
            return _MdlComp.excluirCompra(codigo);
        }
    }
}
