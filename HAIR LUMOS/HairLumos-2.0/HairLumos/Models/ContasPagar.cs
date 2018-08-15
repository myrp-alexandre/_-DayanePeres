using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class ContasPagar
    {
        //------------------------ LANÇAR DESPESA ---------------------------

        DAO.ContasPagarDAO ContasPagarDAO = new DAO.ContasPagarDAO();

        public int gravarLancamentoConta(int codContaPagar, DateTime dtvencimento, DateTime dtpagamento, double valortotal, double valorpago,
            string obs, int numparcela, bool status, int compra, int despesa, int caixa, int formpagamento, int comissao)
        {
            Entidades.Compra _compra = new Entidades.Compra();
            Entidades.Despesa _despesa = new Entidades.Despesa();
            Entidades.Caixa _caixa = new Entidades.Caixa();
            Entidades.FormaPagamento _formaPagamento = new Entidades.FormaPagamento();
            Entidades.Comissao _comissao = new Entidades.Comissao();


            return 1;
        }

    }
}
