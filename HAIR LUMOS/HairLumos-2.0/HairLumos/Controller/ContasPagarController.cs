using System;

namespace HairLumos.Controller
{
    internal class ContasPagarController
    {
        private Models.ContasPagarModels _MdlCont = new Models.ContasPagarModels();

        public int insereLancamento(Entidades.ContasPagar contasPagar)
        {
            return _MdlCont.gravarLancamentoConta(contasPagar);
        }

        
    }
}