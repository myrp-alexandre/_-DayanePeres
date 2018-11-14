using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class ContasPagarModels
    {
        //------------------------ LANÇAR DESPESA ---------------------------

        DAO.ContasPagarDAO ContasPagarDAO = new DAO.ContasPagarDAO();
        DAO.DespesaDAO DespesaDAO = new DAO.DespesaDAO();

        public int gravarLancamentoConta(Entidades.ContasPagar contasPagar)
        {
            Entidades.Compra _compra = new Entidades.Compra();
            Entidades.Despesa _despesa = new Entidades.Despesa();
            Entidades.Caixa _caixa = new Entidades.Caixa();
            Entidades.FormaPagamento _formaPagamento = new Entidades.FormaPagamento();
            Entidades.Comissao _comissao = new Entidades.Comissao();
            Entidades.ContasPagar _contas = new Entidades.ContasPagar();


            DataTable dtDespesa = DespesaDAO.RetornaObjServico(contasPagar.Despesa.Codigo);
            if(dtDespesa!=null && dtDespesa.Rows.Count > 0)
            {
                DataRow dr = dtDespesa.Rows[0];
                _despesa.Codigo = Convert.ToInt32(dr["coddespesa"].ToString());
                _despesa.Descricao = dr["desp_descricao"].ToString();
                _despesa.Status = dr["desp_status"].ToString();
                _contas.Despesa = _despesa;
            }

            return ContasPagarDAO.GravaLancamentoDespesa(_contas);

            //DataTable dtCategoria = _DAOProd.retornaObjCateria(codCategoria);
            //if (dtCategoria != null && dtCategoria.Rows.Count > 0)
            //{
            //    DataRow dr = dtCategoria.Rows[0];

            //    _entCategoria.Codigo = Convert.ToInt32(dr["codcategoria"].ToString());
            //    _entCategoria.CategoriaNome = dr["cat_categoria"].ToString();
            //    _entCategoria.Observacao = dr["cat_obscategoria"].ToString();
            //}
        }

    }
}
