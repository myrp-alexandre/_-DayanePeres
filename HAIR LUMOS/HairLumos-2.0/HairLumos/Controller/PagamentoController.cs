using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class PagamentoController
    {
        private Models.PagamentoModels _MdlPagam= new Models.PagamentoModels();


        /*
         * ********** C A T E G O R I A  *********************************** 
         */
        public int gravaFormaPagamento(int cod, string forma)
        {
            return _MdlPagam.gravarFormaPagamento(cod, forma);
        }

        public DataTable retornaFormaPagamento()
        {
            return _MdlPagam.retornoFormaPagamento();
        }

        public DataTable retornaObjFormaPagamento(int cod)
        {
            return _MdlPagam.retornaObjFormaPagamento(cod);
        }

        public bool excluirFormaPagamento(int intCod)
        {
            return _MdlPagam.excluirFormaPagamento(intCod);
        }
    }
}
