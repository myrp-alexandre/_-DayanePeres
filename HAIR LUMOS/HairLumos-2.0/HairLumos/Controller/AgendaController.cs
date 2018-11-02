using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class AgendaController
    {
        private Models.AgendaModels _MdlAgenda = new Models.AgendaModels();

        public DataTable buscaAgenda(int codigo, string data)
        {
            return _MdlAgenda.buscaData(codigo, data);
        }


    }
}
