using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class DespesaModels
    {
        // validar informações para enviar/receber do Banco 

        DAO.DespesaDAO _DAODespesa = new DAO.DespesaDAO();


        public int gravaDespesa(int cod, string descricao, string status)
        {
            Entidades.Despesa _entDespesa = new Entidades.Despesa();

            _entDespesa.carregaDespesa(cod, descricao, status);

            return _DAODespesa.GravaDespesa(_entDespesa);
        }

        public DataTable retronadespesa()
        {
            Entidades.Despesa _entDespesa = new Entidades.Despesa();
            return _DAODespesa.RetornaDespesa();
        }

        public DataTable retornaObjDespesa(int cod)
        {
            Entidades.Despesa _entDespesa = new Entidades.Despesa();
            return _DAODespesa.RetornaObjServico(cod);
        }

        public bool excluirDespesa(int intCod)
        {
            Entidades.Despesa _entDespesa = new Entidades.Despesa();
            return _DAODespesa.ExcluirServico(intCod);
        }
    }
}
