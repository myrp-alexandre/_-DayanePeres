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

        public DataTable retornaPeriodo(DateTime datai, DateTime dataf, bool estado, string tipo)
        {
            return _MdlCont.retornaPeriodo(datai, dataf, estado, tipo);
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

        public bool verificaDespesaPaga(int cod)
        {
            return _MdlCont.verificaDespesaPaga(cod);
        }

        public int excluirDespesa(int cod)
        {
            return _MdlCont.excluirDespesa(cod);
        }

        public DataTable retornaContaCod(int cod)
        {
            return _MdlCont.retornaContaCod(cod);
        }

        public DataTable retornaContaCodParc(int cod, int parc)
        {
            return _MdlCont.retornaContaCodParc(cod,parc);
        }

        public int pagaConta(Entidades.ContasPagar cp)
        {
            return _MdlCont.pagaConta(cp);
        }

        public bool verificaConta(int cod)
        {
            return _MdlCont.verificaConta(cod);
        }

        public DataTable retornaDespesaNome(string nome)
        {
            return _MdlCont.retornaDespesaNome(nome);
        }
    }
}