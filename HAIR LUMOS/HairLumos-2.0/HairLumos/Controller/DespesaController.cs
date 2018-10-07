using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class DespesaController
    {
        private Models.DespesaModels _MdlDespesa = new Models.DespesaModels();

        public int gravaDespesa(int cod, string descricao, string status)
        {
            return _MdlDespesa.gravaDespesa(cod, descricao, status);
        }

        public DataTable retronaDespesa()
        {
            return _MdlDespesa.retronadespesa();
        }

        public DataTable retornaObjDespesa(int cod)
        {
            return _MdlDespesa.retornaObjDespesa(cod);
        }

        public DataTable retornaObjDespesa(string despesa)
        {
            return _MdlDespesa.retornaObjDespesa(despesa);
        }

        public bool excluirDespesa(int intCod)
        {
            return _MdlDespesa.excluirDespesa(intCod);
        }

    }
}
