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

        public DataTable retornaDespesa()
        {
            return _MdlCont.retornaDespesas();
        }

        public DataTable retornaDespesaL()
        {
            return _MdlCont.retornaDespesasL();
        }

        public DataTable retornaDespesaCod(int cod)
        {
            return _MdlCont.retornaDespesasCod (cod);
        }

        public DataTable retornaDespesaCodData(int cod, DateTime data)
        {
            return _MdlCont.retornaDespesasCodData(cod, data);
        }

    }
}