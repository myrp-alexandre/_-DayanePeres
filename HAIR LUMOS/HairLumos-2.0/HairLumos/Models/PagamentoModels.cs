using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class PagamentoModels
    {
        /// <summary>
        /// CADASTRO DE FORMA DE PAGAMENTO
        /// </summary>
        /// 
        DAO.PagamentoDAO _DAOFormaPag = new DAO.PagamentoDAO();

        public int gravarFormaPagamento(int cod, string forma)
        {
            Entidades.FormaPagamento _entFormaPag = new Entidades.FormaPagamento();
            _entFormaPag.carregaMarca(cod, forma);

            return _DAOFormaPag.GravarFormaPagamento(_entFormaPag);
        }

        public DataTable retornoFormaPagamento()
        {
            Entidades.Marca _entMarca = new Entidades.Marca();
            return _DAOFormaPag.retornaFormaPagamento();
        }

        public DataTable retornaObjFormaPagamento(int cod)
        {
            Entidades.Marca _entMarca = new Entidades.Marca();
            return _DAOFormaPag.retornaObjFormaPagamento(cod);
        }

        public bool excluirFormaPagamento(int intCod)
        {
            Entidades.Marca _entMarca = new Entidades.Marca();
            return _DAOFormaPag.excluirFormaPagamento(intCod);
        }
    }
}
