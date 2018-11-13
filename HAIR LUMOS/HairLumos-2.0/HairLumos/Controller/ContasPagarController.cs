using System;

namespace HairLumos.Controller
{
    internal class ContasPagarController
    {
        private Models.ContasPagarModels _MdlCont = new Models.ContasPagarModels();

        public int insereLancamento(int codigo, int despesa, DateTime data, double valor, string obs)
        {
            return _MdlCont.gravarLancamentoConta(codigo, data, DateTime.Now, valor, 0, obs, 0, false, 0, despesa, 0, 0, 0);
        }

        
    }
}