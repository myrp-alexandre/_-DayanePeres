using System;
using System.Collections.Generic;
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
    }
}
