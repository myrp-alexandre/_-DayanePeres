using System;
using System.Data;

namespace HairLumos.Controller
{
    internal class ContasPagarController
    {
        private Models.ContasPagarModels _MdlCont = new Models.ContasPagarModels();

        public int insereLancamento(Entidades.ContasPagar contasPagar)
        {
            return _MdlCont.gravarLancamentoConta(contasPagar);
        }

        public DataTable retornaPeriodo(DateTime datai, DateTime dataf)
        {
            return _MdlCont.retornaPeriodo(datai, dataf);
        }

        public int retornaMax()
        {
            return _MdlCont.retornaMax();
        }
        
    }
}