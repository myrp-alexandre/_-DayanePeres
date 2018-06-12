using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class UsuarioController
    {
        private Models.UsuarioModels _MdlUsu = new Models.UsuarioModels();

        //public int gravaDespesa(int cod, string descricao, string status)
        //{
        //    return _MdlDespesa.gravaDespesa(cod, descricao, status);
        //}

        public DataTable retronaDespesa(string texto)
        {
            return _MdlUsu.retornaPessoa(texto);
        }
        

        //public DataTable retornaObjDespesa(int cod)
        //{
        //    return _MdlDespesa.retornaObjDespesa(cod);
        //}

        //public bool excluirDespesa(int intCod)
        //{
        //    return _MdlDespesa.excluirDespesa(intCod);
        //}
    }
}
